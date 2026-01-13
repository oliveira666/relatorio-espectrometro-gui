using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace relatorio_espectrometro_gui.Forms
{
    internal class FileProcessor
    {
        public event Action<int>? CooldownTick; 
        private readonly Config config;
        private readonly Communications comm = new();

        public bool IsRunning { get; private set; } = false;
        public string FileType { get; set; } = "*.txt";

        private const int DelayEntreArquivosMs = 1500;

        public FileProcessor(Config config)
        {
            this.config = config;
        }


        public async Task Start()
        {
            if (IsRunning)
            {
                LogHelper.Warn("Processamento automático já está em execução.");
                return;
            }

            IsRunning = true;
            LogHelper.Info("Processamento automático iniciado.");

            while (IsRunning)
            {
                await AutomaticLoop();
                await Task.Delay(500); // não trava CPU
            }
        }

        // STOP AUTOMÁTICO
        public void Stop()
        {
            LogHelper.Info("Parando processamento automático...");
            IsRunning = false;

        }

        // LOOP AUTOMÁTICO
        private async Task AutomaticLoop()
        {
            if (!comm.HasAcessoPastaDestino)
            {
                LogHelper.Error($"Sem acesso à pasta de destino: {config.DestinationFolder}");
                return;
            }

            var arquivos = Directory.GetFiles(config.RootFolder, FileType, SearchOption.TopDirectoryOnly);

            if (arquivos.Length == 0)
            {
                LogHelper.Info("Nenhum arquivo pendente.");
                return;
            }

            LogHelper.Info($"Encontrados {arquivos.Length} arquivo(s) pendente(s).");

            foreach (var arquivo in arquivos)
            {
                if (!IsRunning)
                    return;

                await ProcessFileInternal(arquivo);

                // Delay entre arquivos
                int steps = DelayEntreArquivosMs / 10;
                for (int i = 0; i < steps; i++)
                {
                    if (IsRunning) return;
                    await Task.Delay(100);
                }
            }
            if (IsRunning)
            {
                const int total = 300; // 5 min

                LogHelper.Info($"Aguardando {total} segundos até a próxima verificação...");
                for (int remaining = total; remaining >= 0; remaining--)
                {
                    if (IsRunning) return;

                    CooldownTick?.Invoke(remaining);
                    await Task.Delay(1000);
                }
            }

        }

        // PROCESSAMENTO MANUAL
        public async Task<bool> ProcessFile(string filePath)
        {
            if (IsRunning)
            {
                LogHelper.Warn("Pare o processamento automático antes de usar o processamento manual.");
                return false;
            }

            if (!File.Exists(filePath))
            {
                LogHelper.Error($"Arquivo não encontrado: {filePath}");
                return false;
            }

            return await ProcessFileInternal(filePath);
        }

        // PROCESSAMENTO DO ARQUIVO
        private async Task<bool> ProcessFileInternal(string filePath)
        {
            try
            {
                LogHelper.Info($"Processando: {Path.GetFileName(filePath)}");

                var linhas = File.ReadAllLines(filePath);
                var cabecalho = linhas[0].Split(';');
                var dadosLinha = linhas[1].Split(';');

                var dados = new Dictionary<string, string>();
                for (int i = 0; i < cabecalho.Length; i++)
                    dados[cabecalho[i]] = dadosLinha[i];

                // Monta o conteúdo final
                string conteudo = BuildOutputFile(dados);

                // Gera arquivo
                var timestamp = DateTime.Now.ToString("ddMMyy_HHmmss");
                var destino = $@"{config.DestinationFolder}\Relatorio_{timestamp}.txt";

                LogHelper.Info("Gerando relatório...");
                await File.WriteAllTextAsync(destino, conteudo);

                // Move arquivo processado
                var novoNome = Path.Combine(config.ProcessedFolder, Path.GetFileName(filePath));

                if (!Directory.Exists(config.ProcessedFolder))
                    Directory.CreateDirectory(config.ProcessedFolder);

                File.Move(filePath, novoNome, true);

                LogHelper.Ok($"✓ {Path.GetFileName(filePath)}: Arquivo processado com sucesso.");
                return true;
            }
            catch (KeyNotFoundException)
            {
                // Arquivo incompatível

                LogHelper.Error($"X {Path.GetFileName(filePath)}: Arquivo incompatível, verifique o arquivo.");
                return false;
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex, Path.GetFileName(filePath));
                return false;
            }

        }

        // CONSTROI O CONTEÚDO DO RELATÓRIO
        private string BuildOutputFile(Dictionary<string, string> dados)
        {
            return
                $"Record: 1\n" +
                $"Date:          {DateTime.Parse(dados["Timestamp"]).ToString("HH,mm dd,MM,yyyy")}\n" +
                $"Program:       {dados["Method"]}\n" +
                $"Task:          Hydro\n" +
                $"Quality:       {dados["Quality"]}\n" +
                $"TypeStandard:  {dados["Standard"]}\n" +
                $"Run Number:    Average of N/A    Runs Done: N/A\n" +
                $"Sample:        {dados["Corrida"]},{dados["# dos tarugos"]},{dados["Operador"]},{dados["Liga"]},,,,,,\n" +
                $"Elements: 22\n" +
                $"Si: {dados["Si"].TrimStart('<')}\n" +
                $"Fe: {dados["Fe"].TrimStart('<')}\n" +
                $"Cu: {dados["Cu"].TrimStart('<')}\n" +
                $"Mn: {dados["Mn"].TrimStart('<')}\n" +
                $"Mg: {dados["Mg"].TrimStart('<')}\n" +
                $"Cr: {dados["Cr"].TrimStart('<')}\n" +
                $"Zn: {dados["Zn"].TrimStart('<')}\n" +
                $"Ti: {dados["Ti"].TrimStart('<')}\n" +
                $"V: {dados["V"].TrimStart('<')}\n" +
                $"Sn: {dados["Sn"].TrimStart('<')}\n" +
                $"Ni: {dados["Ni"].TrimStart('<')}\n" +
                $"Na: N/A\n" +
                $"Ca: {dados["Ca"].TrimStart('<')}\n" +
                $"B: {dados["B"].TrimStart('<')}\n" +
                $"Pb: {dados["Pb"].TrimStart('<')}\n" +
                $"Ga: N/A\n" +
                $"AL%: N/A\n" +
                $"Al: {dados["Al"].TrimStart('<')}\n" +
                $"Mg2Si: N/A\n" +
                $"SiEXC: N/A\n" +
                $"SiLivre: N/A";
        }
    }
}
