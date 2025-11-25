using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace relatorio_espectrometro_gui.Forms
{
    internal class FileProcessor
    {
        private readonly Config config = new();
        private readonly Communications comm = new();
        private string[] _arquivos;
        private string _fileType;
        private string[] _outputArquivo;
        private string[] _cabecalho;
        private string[] _linhas;
        private string _arquivoFinal;
        private bool _isRunning;

        

        public FileProcessor() 
        {
            _fileType = "*.txt";
            _arquivos = Directory.GetFiles(config.RootFolder, _fileType, SearchOption.TopDirectoryOnly);
            _outputArquivo = OutputArquivo;
            _cabecalho = Cabecalho;
            _linhas = Linhas;
            _arquivoFinal = ArquivoFinal;
            _isRunning = false;
        }

        public string[] Arquivos { get => _arquivos; set => _arquivos = value; }
        public string FileType { get => _fileType; set => _fileType = value; }
        public string[] OutputArquivo { get => _outputArquivo; set => _outputArquivo = value; }
        public string[] Cabecalho { get => _cabecalho; set => _cabecalho = value; }
        public string[] Linhas { get => _linhas; set => _linhas = value; }
        public string ArquivoFinal { get => _arquivoFinal; set => _arquivoFinal = value; }
        public bool IsRunning {  get => _isRunning; set => _isRunning = value; }

        public void Start(Action<String> Log)
        {
            IsRunning = true;
            while (IsRunning)
            {
                if (!comm.HasAcessoPastaDestino) 
                {
                    Log($"Sem acesso a pasta {config.DestinationFolder}");
                    return;
                }
                if (comm.CountPendentes == 0)
                {
                    Log($"Sem arquivos pendentes para processar.");
                    continue;
                }
                foreach (var item in Arquivos)
                {
                    OutputArquivo = File.ReadAllLines(item);

                    Cabecalho = OutputArquivo[0].Split(';');
                    Linhas = OutputArquivo[1].Split(';');

                    // Cria um dicionário para usar cabecalho como chave
                    Dictionary<string, string> dados = new Dictionary<string, string>();

                    for (int i = 0; i < Cabecalho.Length; i++)
                    {
                        dados[Cabecalho[i]] = Linhas[i];
                    }

                    try
                    {
                        ArquivoFinal = (
                            $"Record: 1" +
                            $"Date:          {DateTime.Parse(dados["TimeStamp"]).ToString("HH,mm dd,MM,yyyy")}" +
                            $"Program:       {dados["Method"]}" +
                            $"Task:          Hydro" +
                            $"Quality:       {dados["Quality"]}" +
                            $"TypeStandard:  {dados["Standard"]}" +
                            $"Run Number:    Average of N/A    Runs Done: N/A" +
                            $"Sample:        {dados["Corrida"]},{dados["# dos tarugos"]},{dados["Operador"]},{dados["Liga"]},,,,," +
                            $"Elements: 22" +
                            $"Si: {dados["Si"].TrimStart('<')}, " +
                            $"Fe: {dados["Fe"].TrimStart('<')}, " +
                            $"Cu: {dados["Cu"].TrimStart('<')}, " +
                            $"Mn: {dados["Mn"].TrimStart('<')}, " +
                            $"Mg: {dados["Mg"].TrimStart('<')}, " +
                            $"Cr: {dados["Cr"].TrimStart('<')}, " +
                            $"Zn: {dados["Zn"].TrimStart('<')}, " +
                            $"Ti: {dados["Ti"].TrimStart('<')}, " +
                            $"V: {dados["V"].TrimStart('<')}, " +
                            $"Sn: {dados["Sn"].TrimStart('<')}, " +
                            $"Ni: {dados["Ni"].TrimStart('<')}, " +
                            $"Na: N/A, " +
                            $"Ca: {dados["Ca"].TrimStart('<')}, " +
                            $"B: {dados["B"].TrimStart('<')}, " +
                            $"Pb: {dados["Pb"].TrimStart('<')}, " +
                            $"Ga: N/A, " +
                            $"AL%: N/A, " +
                            $"Al: {dados["Al"].TrimStart('<')}, " +
                            $"Mg2Si: N/A, " +
                            $"SiEXC: N/A, " +
                            $"SiLivre: N/A");

                        var timestamp = DateTime.Now.ToString("ddMMyy_HHmmss");
                        var outFile = $@"{config.DestinationFolder}\Relatorio_{timestamp}.txt";
                        File.WriteAllText(outFile, ArquivoFinal);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível converter o arquivo. " + ex.Message);
                    }
                }
            }
        }
        public void Stop(Action<String> Log)
        {
            Log("Parando processamento...");
            IsRunning = false;
            Log("Processamento parado.");
        }

    }
}
