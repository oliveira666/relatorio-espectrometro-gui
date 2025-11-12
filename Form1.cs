using relatorio_espectrometro_gui.Forms;
using System.Diagnostics;
using System.Runtime.Versioning;

namespace relatorio_espectrometro_gui
{
    [SupportedOSPlatform("windows")]
    public partial class Form : System.Windows.Forms.Form
    {
        private Config config = new();

        public Form()
        {
            InitializeComponent();

            try
            {
                config = new Config();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar a configuração:\n{ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TxtConfigPastaRelatorios.Text = config.RootFolder;
            TxtConfigPastaDestino.Text = config.DestinationFolder;
        }
        private void Form_Load(object sender, EventArgs e)
        {
            /* Atualiza o Textbox da configuração
            TxtConfigPastaRelatorios.Text = config.RootFolder;
            TxtConfigPastaDestino.Text = config.DestinationFolder; */


        }

        private void BtnTestarComunicacao_Click(object sender, EventArgs e)
        {
            // Simula teste de comunicação
            pbComunicacao.Value = 0;
            lblAcessoPastaDestino.Text = "Verificando pasta destino...";


            Task.Run(async () =>
            {
                await Task.Delay(500);
                this.Invoke(() =>
                {
                    lblAcessoPastaDestino.Text = "Pasta destino: OK";
                    picAcessoPastaDestino.Image = Properties.Resources.green;
                    pbComunicacao.Value = 30;
                });

                await Task.Delay(500);
                this.Invoke(() =>
                {
                    lblArquivoPendente.Text = "Arquivos Pendentes: Nenhum";
                    picArquivoPendente.Image = Properties.Resources.green;
                    pbComunicacao.Value = 60;
                });

                await Task.Delay(500);
                this.Invoke((Delegate)(() =>
                {
                    lblArquivoNaoProcessado.Text = "Arquivos Não Processados: 2";
                    picArquivoNaoProcessado.Image = Properties.Resources.red;
                    pbComunicacao.Value = 100;
                }));
            });
        }

        private void ChkProcessaAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkProcessaAuto.Checked)
            {
                ChkProcessaAuto.Text = "Parar";
            }
            else
            {
                ChkProcessaAuto.Text = "Iniciar";
            }
        }

        private void BtnAbrirConfig_Click(object sender, EventArgs e)
        {
            config = new();
            if (File.Exists(config.ConfigPath))
            {
                // Abre com o aplicativo padrão (geralmente o Bloco de Notas)
                ProcessStartInfo psi = new()
                {
                    FileName = config.ConfigPath,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            else
            {
                MessageBox.Show("O arquivo config.ini não foi encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }

        private void BtnEditarConfig_Click(object sender, EventArgs e)
        {
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
    }
}
