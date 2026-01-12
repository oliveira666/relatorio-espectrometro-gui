using relatorio_espectrometro_gui.Forms;
using System.Diagnostics;
using System.Runtime.Versioning;

namespace relatorio_espectrometro_gui
{
    [SupportedOSPlatform("windows")]
    public partial class Form : System.Windows.Forms.Form
    {
        private Config config = new();
        private FileProcessor _fp;
        private CancellationTokenSource _cts;

        private ConsoleLogger _logger; // NOVO LOGGER

        public Form()
        {
            InitializeComponent();

            try
            {
                config = new();
                _fp = new(_logger);
                _logger = new(tbConsole);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar a configuração:\n{ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Inicializar logger com o RichTextBox existente
            _logger = new ConsoleLogger(tbConsole);

            TxtConfigPastaRelatorios.Text = config.RootFolder;
            TxtConfigPastaDestino.Text = config.DestinationFolder;
        }

        private void BtnTestarComunicacao_Click(object sender, EventArgs e)
        {
            AtualizarComunicacoes();
        }

        private async void ChkProcessaAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkProcessaAuto.Checked)
            {
                // INICIAR
                ChkProcessaAuto.Text = "Parar";

                _cts = new CancellationTokenSource();

                await _fp.Start(msg => _logger.Log(msg));
            }
            else
            {
                // PARAR
                ChkProcessaAuto.Text = "Iniciar";

                _fp.Stop(msg => _logger.Log(msg));
                _cts?.Cancel();
            }
        }

        private void BtnAbrirConfig_Click(object sender, EventArgs e)
        {
            config = new();
            if (File.Exists(config.ConfigPath))
            {
                ProcessStartInfo psi = new()
                {
                    FileName = config.ConfigPath,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            else
            {
                MessageBox.Show("O arquivo config.ini não foi encontrado.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSalvarConfig_Click(object sender, EventArgs e)
        {
            config = new();

            if (!DirectoryHelper.ValidateDirectory(TxtConfigPastaRelatorios.Text))
                return;

            else if (!DirectoryHelper.ValidateDirectory(TxtConfigPastaDestino.Text))
                return;

            config.RootFolder = TxtConfigPastaRelatorios.Text;
            config.DestinationFolder = TxtConfigPastaDestino.Text;

            TxtConfigPastaRelatorios.Text = config.RootFolder;
            TxtConfigPastaDestino.Text = config.DestinationFolder;

            TxtConfigPastaDestino.ReadOnly = true;
            TxtConfigPastaRelatorios.ReadOnly = true;

            TxtConfigPastaRelatorios.BackColor = Color.LightGray;
            TxtConfigPastaDestino.BackColor = Color.LightGray;

            BtnEditarConfig.Enabled = true;
            BtnAbrirConfig.Enabled = true;
        }

        private void BtnEditarConfig_Click(object sender, EventArgs e)
        {
            BtnSalvarConfig.Enabled = true;
            BtnEditarConfig.Enabled = false;
            BtnAbrirConfig.Enabled = false;

            TxtConfigPastaDestino.ReadOnly = false;
            TxtConfigPastaDestino.BackColor = Color.WhiteSmoke;
            TxtConfigPastaRelatorios.ReadOnly = false;
            TxtConfigPastaRelatorios.BackColor = Color.WhiteSmoke;
        }

        private void TxtConfigPastaDestino_Leave(object sender, EventArgs e)
        {
            DirectoryHelper.ValidateDirectory(TxtConfigPastaDestino.Text);
        }

        private void TxtConfigPastaRelatorios_Leave(object sender, EventArgs e)
        {
            DirectoryHelper.ValidateDirectory(TxtConfigPastaRelatorios.Text);
        }

        private async void AtualizarComunicacoes()
        {
            Communications comm = new();
            var _delay = 1500;

            pbComunicacao.Value = 1;

            lblAcessoPastaDestino.Text = "Verificando acesso...";
            await Task.Delay(_delay);
            lblAcessoPastaDestino.Text = comm.HasAcessoPastaDestino ? "Status: OK" : "Status: Erro";
            picAcessoPastaDestino.Image = comm.HasAcessoPastaDestino ? Properties.Resources.green : Properties.Resources.red;
            pbComunicacao.PerformStep();

            lblArquivoPendente.Text = "Verificando...";
            await Task.Delay(_delay);
            lblArquivoPendente.Text = $"Arquivos Pendentes: {comm.CountPendentes}";
            picArquivoPendente.Image = comm.CountPendentes == 0 ? Properties.Resources.green : Properties.Resources.red;
            pbComunicacao.PerformStep();

            lblArquivoNaoProcessado.Text = "Verificando...";
            await Task.Delay(_delay);
            lblArquivoNaoProcessado.Text = $"Arquivos Não Processados: {comm.CountNaoProcessados}";
            picArquivoNaoProcessado.Image = comm.CountNaoProcessados == 0 ? Properties.Resources.green : Properties.Resources.red;
            pbComunicacao.PerformStep();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEscolher_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new()
            {
                InitialDirectory = config.RootFolder,
                Filter = "Arquivos de Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*",
                Title = "Selecione um arquivo de relatório"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = Path.GetFileName(ofd.FileName);
                txtPath.Tag = ofd.FileName;
                BtnProcessarManual.Enabled = true;
            }
        }

        private async void BtnProcessarManual_Click(object sender, EventArgs e)
        {
            if (txtPath.Tag == null)
            {
                MessageBox.Show("Por favor, selecione um arquivo primeiro.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string filePath = txtPath.Tag.ToString();
                await _fp.ProcessFile(filePath, msg => _logger.Log(msg));
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtPath.Text = "";
            txtPath.Tag = null;
            BtnProcessarManual.Enabled = false;
        }
    }
}
