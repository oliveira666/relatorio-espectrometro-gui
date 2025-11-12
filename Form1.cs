namespace relatorio_espectrometro_gui
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnTestarComunicacao_Click(object sender, EventArgs e)
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

        private void chkProcessaAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProcessaAuto.Checked)
            {
                chkProcessaAuto.Text = "Parar";
            }
            else
            {
                chkProcessaAuto.Text = "Iniciar";
            }
        }
    }
}
