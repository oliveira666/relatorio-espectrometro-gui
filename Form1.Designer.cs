namespace relatorio_espectrometro_gui
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabComs = new TabPage();
            gbConfig = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtConfigTimer = new TextBox();
            lblPastaRelatorios = new Label();
            lblConfigPastaDestino = new Label();
            TxtConfigPastaDestino = new TextBox();
            TxtConfigPastaRelatorios = new TextBox();
            BtnSalvarConfig = new Button();
            lbConfigTimer = new Label();
            BtnEditarConfig = new Button();
            BtnAbrirConfig = new Button();
            gbComs = new GroupBox();
            tlpComs = new TableLayoutPanel();
            BtnTestarComunicacao = new Button();
            gbPastaDestino = new GroupBox();
            tlpPastaDestino = new TableLayoutPanel();
            lblAcessoPastaDestino = new Label();
            picAcessoPastaDestino = new PictureBox();
            pbComunicacao = new ProgressBar();
            gbArquivoPendente = new GroupBox();
            tlpArquivoPendente = new TableLayoutPanel();
            picArquivoPendente = new PictureBox();
            lblArquivoPendente = new Label();
            gbArquivoNaoProcessado = new GroupBox();
            tlpArquivoNaoProcessado = new TableLayoutPanel();
            picArquivoNaoProcessado = new PictureBox();
            lblArquivoNaoProcessado = new Label();
            tabMain = new TabPage();
            GbProcessamentoAuto = new GroupBox();
            tlpConsole = new TableLayoutPanel();
            ChkProcessaAuto = new CheckBox();
            BtnLimpar = new Button();
            tbConsole = new RichTextBox();
            lbTimer = new Label();
            lbAguardando = new Label();
            gbProcessarManual = new GroupBox();
            tlpArquivo = new TableLayoutPanel();
            BtnProcessarManual = new Button();
            lblArquivo = new Label();
            BtnEscolher = new Button();
            txtPath = new TextBox();
            tabControl = new TabControl();
            tabAbout = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            tabComs.SuspendLayout();
            gbConfig.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            gbComs.SuspendLayout();
            tlpComs.SuspendLayout();
            gbPastaDestino.SuspendLayout();
            tlpPastaDestino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAcessoPastaDestino).BeginInit();
            gbArquivoPendente.SuspendLayout();
            tlpArquivoPendente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picArquivoPendente).BeginInit();
            gbArquivoNaoProcessado.SuspendLayout();
            tlpArquivoNaoProcessado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picArquivoNaoProcessado).BeginInit();
            tabMain.SuspendLayout();
            GbProcessamentoAuto.SuspendLayout();
            tlpConsole.SuspendLayout();
            gbProcessarManual.SuspendLayout();
            tlpArquivo.SuspendLayout();
            tabControl.SuspendLayout();
            tabAbout.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabComs
            // 
            tabComs.Controls.Add(gbConfig);
            tabComs.Controls.Add(gbComs);
            tabComs.Location = new Point(4, 24);
            tabComs.Name = "tabComs";
            tabComs.Padding = new Padding(3);
            tabComs.Size = new Size(760, 299);
            tabComs.TabIndex = 1;
            tabComs.Text = "Comunicações";
            tabComs.UseVisualStyleBackColor = true;
            // 
            // gbConfig
            // 
            gbConfig.Controls.Add(tableLayoutPanel1);
            gbConfig.Dock = DockStyle.Right;
            gbConfig.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbConfig.Location = new Point(424, 3);
            gbConfig.Name = "gbConfig";
            gbConfig.Size = new Size(333, 293);
            gbConfig.TabIndex = 2;
            gbConfig.TabStop = false;
            gbConfig.Text = "Configurações";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(txtConfigTimer, 1, 2);
            tableLayoutPanel1.Controls.Add(lblPastaRelatorios, 0, 1);
            tableLayoutPanel1.Controls.Add(lblConfigPastaDestino, 0, 0);
            tableLayoutPanel1.Controls.Add(TxtConfigPastaDestino, 1, 0);
            tableLayoutPanel1.Controls.Add(TxtConfigPastaRelatorios, 1, 1);
            tableLayoutPanel1.Controls.Add(BtnSalvarConfig, 0, 4);
            tableLayoutPanel1.Controls.Add(lbConfigTimer, 0, 2);
            tableLayoutPanel1.Controls.Add(BtnEditarConfig, 0, 3);
            tableLayoutPanel1.Controls.Add(BtnAbrirConfig, 3, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(327, 271);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtConfigTimer
            // 
            txtConfigTimer.BackColor = Color.LightGray;
            tableLayoutPanel1.SetColumnSpan(txtConfigTimer, 3);
            txtConfigTimer.Cursor = Cursors.IBeam;
            txtConfigTimer.Font = new Font("Segoe UI", 9F);
            txtConfigTimer.Location = new Point(117, 111);
            txtConfigTimer.Name = "txtConfigTimer";
            txtConfigTimer.Size = new Size(207, 23);
            txtConfigTimer.TabIndex = 8;
            // 
            // lblPastaRelatorios
            // 
            lblPastaRelatorios.AutoSize = true;
            lblPastaRelatorios.Location = new Point(3, 54);
            lblPastaRelatorios.Name = "lblPastaRelatorios";
            lblPastaRelatorios.Padding = new Padding(3, 6, 3, 3);
            lblPastaRelatorios.Size = new Size(104, 24);
            lblPastaRelatorios.TabIndex = 5;
            lblPastaRelatorios.Text = "Pasta Relatorios:";
            lblPastaRelatorios.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblConfigPastaDestino
            // 
            lblConfigPastaDestino.AutoSize = true;
            lblConfigPastaDestino.Location = new Point(3, 0);
            lblConfigPastaDestino.Name = "lblConfigPastaDestino";
            lblConfigPastaDestino.Padding = new Padding(3, 6, 3, 3);
            lblConfigPastaDestino.Size = new Size(94, 24);
            lblConfigPastaDestino.TabIndex = 2;
            lblConfigPastaDestino.Text = "Pasta Destino: ";
            lblConfigPastaDestino.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtConfigPastaDestino
            // 
            TxtConfigPastaDestino.BackColor = Color.LightGray;
            tableLayoutPanel1.SetColumnSpan(TxtConfigPastaDestino, 3);
            TxtConfigPastaDestino.Cursor = Cursors.IBeam;
            TxtConfigPastaDestino.Font = new Font("Segoe UI", 9F);
            TxtConfigPastaDestino.Location = new Point(117, 3);
            TxtConfigPastaDestino.Name = "TxtConfigPastaDestino";
            TxtConfigPastaDestino.Size = new Size(207, 23);
            TxtConfigPastaDestino.TabIndex = 3;
            TxtConfigPastaDestino.Leave += TxtConfigPastaDestino_Leave;
            // 
            // TxtConfigPastaRelatorios
            // 
            TxtConfigPastaRelatorios.BackColor = Color.LightGray;
            tableLayoutPanel1.SetColumnSpan(TxtConfigPastaRelatorios, 3);
            TxtConfigPastaRelatorios.Cursor = Cursors.IBeam;
            TxtConfigPastaRelatorios.Font = new Font("Segoe UI", 9F);
            TxtConfigPastaRelatorios.Location = new Point(117, 57);
            TxtConfigPastaRelatorios.Name = "TxtConfigPastaRelatorios";
            TxtConfigPastaRelatorios.Size = new Size(207, 23);
            TxtConfigPastaRelatorios.TabIndex = 4;
            TxtConfigPastaRelatorios.Leave += TxtConfigPastaRelatorios_Leave;
            // 
            // BtnSalvarConfig
            // 
            BtnSalvarConfig.AutoSize = true;
            BtnSalvarConfig.Enabled = false;
            BtnSalvarConfig.Font = new Font("Segoe UI", 9F);
            BtnSalvarConfig.Location = new Point(3, 219);
            BtnSalvarConfig.Name = "BtnSalvarConfig";
            BtnSalvarConfig.Size = new Size(87, 25);
            BtnSalvarConfig.TabIndex = 0;
            BtnSalvarConfig.Text = "Salvar Config";
            BtnSalvarConfig.UseVisualStyleBackColor = true;
            BtnSalvarConfig.Click += BtnSalvarConfig_Click;
            // 
            // lbConfigTimer
            // 
            lbConfigTimer.AutoSize = true;
            lbConfigTimer.Location = new Point(3, 108);
            lbConfigTimer.Name = "lbConfigTimer";
            lbConfigTimer.Padding = new Padding(3, 6, 3, 3);
            lbConfigTimer.Size = new Size(97, 24);
            lbConfigTimer.TabIndex = 7;
            lbConfigTimer.Text = "Valor do Timer:";
            // 
            // BtnEditarConfig
            // 
            BtnEditarConfig.AutoSize = true;
            BtnEditarConfig.Font = new Font("Segoe UI", 9F);
            BtnEditarConfig.Location = new Point(3, 165);
            BtnEditarConfig.Name = "BtnEditarConfig";
            BtnEditarConfig.Size = new Size(86, 25);
            BtnEditarConfig.TabIndex = 6;
            BtnEditarConfig.Text = "Editar Config";
            BtnEditarConfig.UseVisualStyleBackColor = true;
            BtnEditarConfig.Click += BtnEditarConfig_Click;
            // 
            // BtnAbrirConfig
            // 
            BtnAbrirConfig.AutoSize = true;
            BtnAbrirConfig.Font = new Font("Segoe UI", 9F);
            BtnAbrirConfig.Location = new Point(226, 165);
            BtnAbrirConfig.Name = "BtnAbrirConfig";
            BtnAbrirConfig.Size = new Size(98, 25);
            BtnAbrirConfig.TabIndex = 1;
            BtnAbrirConfig.Text = "Abrir Config.ini";
            BtnAbrirConfig.UseVisualStyleBackColor = true;
            BtnAbrirConfig.Click += BtnAbrirConfig_Click;
            // 
            // gbComs
            // 
            gbComs.Controls.Add(tlpComs);
            gbComs.Dock = DockStyle.Left;
            gbComs.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbComs.Location = new Point(3, 3);
            gbComs.Name = "gbComs";
            gbComs.Size = new Size(415, 293);
            gbComs.TabIndex = 1;
            gbComs.TabStop = false;
            gbComs.Text = "Comunicações";
            // 
            // tlpComs
            // 
            tlpComs.ColumnCount = 1;
            tlpComs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpComs.Controls.Add(BtnTestarComunicacao, 0, 4);
            tlpComs.Controls.Add(gbPastaDestino, 0, 0);
            tlpComs.Controls.Add(pbComunicacao, 0, 3);
            tlpComs.Controls.Add(gbArquivoPendente, 0, 1);
            tlpComs.Controls.Add(gbArquivoNaoProcessado, 0, 2);
            tlpComs.Dock = DockStyle.Fill;
            tlpComs.Location = new Point(3, 19);
            tlpComs.Name = "tlpComs";
            tlpComs.RowCount = 5;
            tlpComs.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tlpComs.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tlpComs.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tlpComs.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpComs.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpComs.Size = new Size(409, 271);
            tlpComs.TabIndex = 0;
            // 
            // BtnTestarComunicacao
            // 
            BtnTestarComunicacao.Anchor = AnchorStyles.Top;
            BtnTestarComunicacao.AutoSize = true;
            BtnTestarComunicacao.Font = new Font("Segoe UI", 9F);
            BtnTestarComunicacao.Location = new Point(128, 238);
            BtnTestarComunicacao.Name = "BtnTestarComunicacao";
            BtnTestarComunicacao.Padding = new Padding(10, 5, 10, 5);
            BtnTestarComunicacao.Size = new Size(153, 30);
            BtnTestarComunicacao.TabIndex = 8;
            BtnTestarComunicacao.Text = "Testar Comunicações";
            BtnTestarComunicacao.UseVisualStyleBackColor = true;
            BtnTestarComunicacao.Click += BtnTestarComunicacao_Click;
            // 
            // gbPastaDestino
            // 
            gbPastaDestino.Controls.Add(tlpPastaDestino);
            gbPastaDestino.Dock = DockStyle.Fill;
            gbPastaDestino.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbPastaDestino.Location = new Point(3, 3);
            gbPastaDestino.Name = "gbPastaDestino";
            gbPastaDestino.Size = new Size(403, 64);
            gbPastaDestino.TabIndex = 0;
            gbPastaDestino.TabStop = false;
            gbPastaDestino.Text = "Pasta Destino";
            // 
            // tlpPastaDestino
            // 
            tlpPastaDestino.ColumnCount = 2;
            tlpPastaDestino.ColumnStyles.Add(new ColumnStyle());
            tlpPastaDestino.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPastaDestino.Controls.Add(lblAcessoPastaDestino, 1, 0);
            tlpPastaDestino.Controls.Add(picAcessoPastaDestino, 0, 0);
            tlpPastaDestino.Dock = DockStyle.Fill;
            tlpPastaDestino.Location = new Point(3, 19);
            tlpPastaDestino.Name = "tlpPastaDestino";
            tlpPastaDestino.RowCount = 1;
            tlpPastaDestino.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPastaDestino.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpPastaDestino.Size = new Size(397, 42);
            tlpPastaDestino.TabIndex = 0;
            // 
            // lblAcessoPastaDestino
            // 
            lblAcessoPastaDestino.Anchor = AnchorStyles.Left;
            lblAcessoPastaDestino.AutoSize = true;
            lblAcessoPastaDestino.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAcessoPastaDestino.Location = new Point(29, 13);
            lblAcessoPastaDestino.Name = "lblAcessoPastaDestino";
            lblAcessoPastaDestino.Size = new Size(57, 15);
            lblAcessoPastaDestino.TabIndex = 1;
            lblAcessoPastaDestino.Text = "Status: ...";
            // 
            // picAcessoPastaDestino
            // 
            picAcessoPastaDestino.Anchor = AnchorStyles.Left;
            picAcessoPastaDestino.Image = Properties.Resources.red;
            picAcessoPastaDestino.Location = new Point(3, 11);
            picAcessoPastaDestino.Name = "picAcessoPastaDestino";
            picAcessoPastaDestino.Size = new Size(20, 20);
            picAcessoPastaDestino.SizeMode = PictureBoxSizeMode.StretchImage;
            picAcessoPastaDestino.TabIndex = 0;
            picAcessoPastaDestino.TabStop = false;
            // 
            // pbComunicacao
            // 
            pbComunicacao.Anchor = AnchorStyles.None;
            pbComunicacao.ForeColor = SystemColors.Desktop;
            pbComunicacao.Location = new Point(52, 213);
            pbComunicacao.Name = "pbComunicacao";
            pbComunicacao.Size = new Size(305, 19);
            pbComunicacao.Step = 33;
            pbComunicacao.TabIndex = 7;
            // 
            // gbArquivoPendente
            // 
            gbArquivoPendente.Controls.Add(tlpArquivoPendente);
            gbArquivoPendente.Dock = DockStyle.Fill;
            gbArquivoPendente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbArquivoPendente.Location = new Point(3, 73);
            gbArquivoPendente.Name = "gbArquivoPendente";
            gbArquivoPendente.Size = new Size(403, 64);
            gbArquivoPendente.TabIndex = 1;
            gbArquivoPendente.TabStop = false;
            gbArquivoPendente.Text = "Arquivos Pendentes";
            // 
            // tlpArquivoPendente
            // 
            tlpArquivoPendente.ColumnCount = 2;
            tlpArquivoPendente.ColumnStyles.Add(new ColumnStyle());
            tlpArquivoPendente.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpArquivoPendente.Controls.Add(picArquivoPendente, 0, 0);
            tlpArquivoPendente.Controls.Add(lblArquivoPendente, 1, 0);
            tlpArquivoPendente.Dock = DockStyle.Fill;
            tlpArquivoPendente.Location = new Point(3, 19);
            tlpArquivoPendente.Name = "tlpArquivoPendente";
            tlpArquivoPendente.RowCount = 1;
            tlpArquivoPendente.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpArquivoPendente.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpArquivoPendente.Size = new Size(397, 42);
            tlpArquivoPendente.TabIndex = 1;
            // 
            // picArquivoPendente
            // 
            picArquivoPendente.Anchor = AnchorStyles.Left;
            picArquivoPendente.Image = Properties.Resources.red;
            picArquivoPendente.Location = new Point(3, 11);
            picArquivoPendente.Name = "picArquivoPendente";
            picArquivoPendente.Size = new Size(20, 20);
            picArquivoPendente.SizeMode = PictureBoxSizeMode.StretchImage;
            picArquivoPendente.TabIndex = 2;
            picArquivoPendente.TabStop = false;
            // 
            // lblArquivoPendente
            // 
            lblArquivoPendente.Anchor = AnchorStyles.Left;
            lblArquivoPendente.AutoSize = true;
            lblArquivoPendente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArquivoPendente.Location = new Point(29, 13);
            lblArquivoPendente.Name = "lblArquivoPendente";
            lblArquivoPendente.Size = new Size(57, 15);
            lblArquivoPendente.TabIndex = 3;
            lblArquivoPendente.Text = "Status: ...";
            // 
            // gbArquivoNaoProcessado
            // 
            gbArquivoNaoProcessado.Controls.Add(tlpArquivoNaoProcessado);
            gbArquivoNaoProcessado.Dock = DockStyle.Fill;
            gbArquivoNaoProcessado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbArquivoNaoProcessado.Location = new Point(3, 143);
            gbArquivoNaoProcessado.Name = "gbArquivoNaoProcessado";
            gbArquivoNaoProcessado.Size = new Size(403, 64);
            gbArquivoNaoProcessado.TabIndex = 2;
            gbArquivoNaoProcessado.TabStop = false;
            gbArquivoNaoProcessado.Text = "Arquivos Não Processados";
            // 
            // tlpArquivoNaoProcessado
            // 
            tlpArquivoNaoProcessado.ColumnCount = 2;
            tlpArquivoNaoProcessado.ColumnStyles.Add(new ColumnStyle());
            tlpArquivoNaoProcessado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpArquivoNaoProcessado.Controls.Add(picArquivoNaoProcessado, 0, 0);
            tlpArquivoNaoProcessado.Controls.Add(lblArquivoNaoProcessado, 1, 0);
            tlpArquivoNaoProcessado.Dock = DockStyle.Fill;
            tlpArquivoNaoProcessado.Location = new Point(3, 19);
            tlpArquivoNaoProcessado.Name = "tlpArquivoNaoProcessado";
            tlpArquivoNaoProcessado.RowCount = 1;
            tlpArquivoNaoProcessado.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpArquivoNaoProcessado.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpArquivoNaoProcessado.Size = new Size(397, 42);
            tlpArquivoNaoProcessado.TabIndex = 1;
            // 
            // picArquivoNaoProcessado
            // 
            picArquivoNaoProcessado.Anchor = AnchorStyles.Left;
            picArquivoNaoProcessado.Image = Properties.Resources.red;
            picArquivoNaoProcessado.Location = new Point(3, 11);
            picArquivoNaoProcessado.Name = "picArquivoNaoProcessado";
            picArquivoNaoProcessado.Size = new Size(20, 20);
            picArquivoNaoProcessado.SizeMode = PictureBoxSizeMode.StretchImage;
            picArquivoNaoProcessado.TabIndex = 4;
            picArquivoNaoProcessado.TabStop = false;
            // 
            // lblArquivoNaoProcessado
            // 
            lblArquivoNaoProcessado.Anchor = AnchorStyles.Left;
            lblArquivoNaoProcessado.AutoSize = true;
            lblArquivoNaoProcessado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArquivoNaoProcessado.Location = new Point(29, 13);
            lblArquivoNaoProcessado.Name = "lblArquivoNaoProcessado";
            lblArquivoNaoProcessado.Size = new Size(57, 15);
            lblArquivoNaoProcessado.TabIndex = 5;
            lblArquivoNaoProcessado.Text = "Status: ...";
            // 
            // tabMain
            // 
            tabMain.Controls.Add(GbProcessamentoAuto);
            tabMain.Location = new Point(4, 24);
            tabMain.Name = "tabMain";
            tabMain.Padding = new Padding(3);
            tabMain.Size = new Size(760, 299);
            tabMain.TabIndex = 0;
            tabMain.Text = "Processamento";
            tabMain.UseVisualStyleBackColor = true;
            // 
            // GbProcessamentoAuto
            // 
            GbProcessamentoAuto.Controls.Add(tlpConsole);
            GbProcessamentoAuto.Controls.Add(gbProcessarManual);
            GbProcessamentoAuto.Dock = DockStyle.Fill;
            GbProcessamentoAuto.Location = new Point(3, 3);
            GbProcessamentoAuto.Name = "GbProcessamentoAuto";
            GbProcessamentoAuto.Size = new Size(754, 293);
            GbProcessamentoAuto.TabIndex = 0;
            GbProcessamentoAuto.TabStop = false;
            GbProcessamentoAuto.Text = "Processamento Automático";
            // 
            // tlpConsole
            // 
            tlpConsole.ColumnCount = 4;
            tlpConsole.ColumnStyles.Add(new ColumnStyle());
            tlpConsole.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpConsole.ColumnStyles.Add(new ColumnStyle());
            tlpConsole.ColumnStyles.Add(new ColumnStyle());
            tlpConsole.Controls.Add(ChkProcessaAuto, 0, 1);
            tlpConsole.Controls.Add(BtnLimpar, 1, 1);
            tlpConsole.Controls.Add(tbConsole, 0, 0);
            tlpConsole.Controls.Add(lbTimer, 3, 1);
            tlpConsole.Controls.Add(lbAguardando, 2, 1);
            tlpConsole.Dock = DockStyle.Fill;
            tlpConsole.Location = new Point(3, 19);
            tlpConsole.Name = "tlpConsole";
            tlpConsole.RowCount = 2;
            tlpConsole.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tlpConsole.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpConsole.Size = new Size(748, 144);
            tlpConsole.TabIndex = 0;
            // 
            // ChkProcessaAuto
            // 
            ChkProcessaAuto.Anchor = AnchorStyles.Left;
            ChkProcessaAuto.Appearance = Appearance.Button;
            ChkProcessaAuto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChkProcessaAuto.Location = new Point(3, 113);
            ChkProcessaAuto.Name = "ChkProcessaAuto";
            ChkProcessaAuto.Size = new Size(49, 25);
            ChkProcessaAuto.TabIndex = 2;
            ChkProcessaAuto.Text = "Iniciar";
            ChkProcessaAuto.TextAlign = ContentAlignment.MiddleCenter;
            ChkProcessaAuto.UseVisualStyleBackColor = true;
            ChkProcessaAuto.CheckedChanged += ChkProcessaAuto_CheckedChanged;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Anchor = AnchorStyles.Left;
            BtnLimpar.Location = new Point(58, 113);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(52, 25);
            BtnLimpar.TabIndex = 1;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // tbConsole
            // 
            tbConsole.BackColor = Color.Gray;
            tlpConsole.SetColumnSpan(tbConsole, 4);
            tbConsole.Font = new Font("Consolas", 10F);
            tbConsole.ForeColor = Color.White;
            tbConsole.Location = new Point(3, 3);
            tbConsole.Name = "tbConsole";
            tbConsole.ReadOnly = true;
            tbConsole.Size = new Size(742, 102);
            tbConsole.TabIndex = 3;
            tbConsole.Text = "";
            // 
            // lbTimer
            // 
            lbTimer.AutoSize = true;
            lbTimer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTimer.Location = new Point(715, 108);
            lbTimer.Name = "lbTimer";
            lbTimer.Size = new Size(30, 15);
            lbTimer.TabIndex = 4;
            lbTimer.Text = "--:--";
            lbTimer.Visible = false;
            // 
            // lbAguardando
            // 
            lbAguardando.AutoSize = true;
            lbAguardando.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAguardando.Location = new Point(527, 108);
            lbAguardando.Name = "lbAguardando";
            lbAguardando.Size = new Size(182, 15);
            lbAguardando.TabIndex = 5;
            lbAguardando.Text = "Tempo até próxima verificação:";
            lbAguardando.Visible = false;
            // 
            // gbProcessarManual
            // 
            gbProcessarManual.Controls.Add(tlpArquivo);
            gbProcessarManual.Dock = DockStyle.Bottom;
            gbProcessarManual.Location = new Point(3, 163);
            gbProcessarManual.Name = "gbProcessarManual";
            gbProcessarManual.Padding = new Padding(8);
            gbProcessarManual.Size = new Size(748, 127);
            gbProcessarManual.TabIndex = 0;
            gbProcessarManual.TabStop = false;
            gbProcessarManual.Text = "Processar Manual";
            // 
            // tlpArquivo
            // 
            tlpArquivo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpArquivo.ColumnCount = 3;
            tlpArquivo.ColumnStyles.Add(new ColumnStyle());
            tlpArquivo.ColumnStyles.Add(new ColumnStyle());
            tlpArquivo.ColumnStyles.Add(new ColumnStyle());
            tlpArquivo.Controls.Add(BtnProcessarManual, 0, 1);
            tlpArquivo.Controls.Add(lblArquivo, 0, 0);
            tlpArquivo.Controls.Add(BtnEscolher, 2, 0);
            tlpArquivo.Controls.Add(txtPath, 1, 0);
            tlpArquivo.Location = new Point(8, 24);
            tlpArquivo.Name = "tlpArquivo";
            tlpArquivo.RowCount = 2;
            tlpArquivo.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpArquivo.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tlpArquivo.Size = new Size(738, 88);
            tlpArquivo.TabIndex = 0;
            // 
            // BtnProcessarManual
            // 
            BtnProcessarManual.Enabled = false;
            BtnProcessarManual.Location = new Point(0, 36);
            BtnProcessarManual.Margin = new Padding(0);
            BtnProcessarManual.Name = "BtnProcessarManual";
            BtnProcessarManual.Size = new Size(79, 25);
            BtnProcessarManual.TabIndex = 0;
            BtnProcessarManual.Text = "Processar";
            BtnProcessarManual.UseVisualStyleBackColor = true;
            BtnProcessarManual.Click += BtnProcessarManual_Click;
            // 
            // lblArquivo
            // 
            lblArquivo.AutoSize = true;
            lblArquivo.Dock = DockStyle.Left;
            lblArquivo.Location = new Point(0, 0);
            lblArquivo.Margin = new Padding(0);
            lblArquivo.Name = "lblArquivo";
            lblArquivo.Size = new Size(52, 36);
            lblArquivo.TabIndex = 0;
            lblArquivo.Text = "Arquivo:";
            lblArquivo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BtnEscolher
            // 
            BtnEscolher.Location = new Point(610, 3);
            BtnEscolher.Name = "BtnEscolher";
            BtnEscolher.Size = new Size(85, 25);
            BtnEscolher.TabIndex = 2;
            BtnEscolher.Text = "Escolher...";
            BtnEscolher.UseVisualStyleBackColor = true;
            BtnEscolher.Click += BtnEscolher_Click;
            // 
            // txtPath
            // 
            txtPath.BackColor = Color.WhiteSmoke;
            txtPath.Dock = DockStyle.Fill;
            txtPath.Location = new Point(82, 3);
            txtPath.Name = "txtPath";
            txtPath.ReadOnly = true;
            txtPath.Size = new Size(522, 23);
            txtPath.TabIndex = 1;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabMain);
            tabControl.Controls.Add(tabComs);
            tabControl.Controls.Add(tabAbout);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 9F);
            tabControl.Location = new Point(8, 26);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(768, 327);
            tabControl.TabIndex = 0;
            // 
            // tabAbout
            // 
            tabAbout.Controls.Add(tableLayoutPanel2);
            tabAbout.Location = new Point(4, 24);
            tabAbout.Name = "tabAbout";
            tabAbout.Padding = new Padding(3);
            tabAbout.Size = new Size(760, 299);
            tabAbout.TabIndex = 2;
            tabAbout.Text = "Sobre";
            tabAbout.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(754, 293);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.GripMargin = new Padding(6);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(8, 8);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(0);
            menuStrip1.Size = new Size(768, 18);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 18);
            arquivoToolStripMenuItem.Text = "&Arquivo";
            arquivoToolStripMenuItem.TextAlign = ContentAlignment.TopCenter;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "S&air";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator5, sobreToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 18);
            ajudaToolStripMenuItem.Text = "&Ajuda";
            ajudaToolStripMenuItem.TextAlign = ContentAlignment.TopCenter;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(110, 6);
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(113, 22);
            sobreToolStripMenuItem.Text = "&Sobre...";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(784, 361);
            Controls.Add(tabControl);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form";
            Padding = new Padding(8);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatorio Espectrometro";
            tabComs.ResumeLayout(false);
            gbConfig.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            gbComs.ResumeLayout(false);
            tlpComs.ResumeLayout(false);
            tlpComs.PerformLayout();
            gbPastaDestino.ResumeLayout(false);
            tlpPastaDestino.ResumeLayout(false);
            tlpPastaDestino.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAcessoPastaDestino).EndInit();
            gbArquivoPendente.ResumeLayout(false);
            tlpArquivoPendente.ResumeLayout(false);
            tlpArquivoPendente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picArquivoPendente).EndInit();
            gbArquivoNaoProcessado.ResumeLayout(false);
            tlpArquivoNaoProcessado.ResumeLayout(false);
            tlpArquivoNaoProcessado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picArquivoNaoProcessado).EndInit();
            tabMain.ResumeLayout(false);
            GbProcessamentoAuto.ResumeLayout(false);
            tlpConsole.ResumeLayout(false);
            tlpConsole.PerformLayout();
            gbProcessarManual.ResumeLayout(false);
            tlpArquivo.ResumeLayout(false);
            tlpArquivo.PerformLayout();
            tabControl.ResumeLayout(false);
            tabAbout.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabComs;
        private GroupBox gbConfig;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblPastaRelatorios;
        private Button BtnSalvarConfig;
        private Button BtnAbrirConfig;
        private Label lblConfigPastaDestino;
        private TextBox TxtConfigPastaDestino;
        private TextBox TxtConfigPastaRelatorios;
        private GroupBox gbComs;
        private TableLayoutPanel tlpComs;
        private Button BtnTestarComunicacao;
        private GroupBox gbPastaDestino;
        private TableLayoutPanel tlpPastaDestino;
        private Label lblAcessoPastaDestino;
        private PictureBox picAcessoPastaDestino;
        private ProgressBar pbComunicacao;
        private GroupBox gbArquivoPendente;
        private TableLayoutPanel tlpArquivoPendente;
        private PictureBox picArquivoPendente;
        private Label lblArquivoPendente;
        private GroupBox gbArquivoNaoProcessado;
        private TableLayoutPanel tlpArquivoNaoProcessado;
        private PictureBox picArquivoNaoProcessado;
        private Label lblArquivoNaoProcessado;
        private TabPage tabMain;
        private GroupBox GbProcessamentoAuto;
        private TableLayoutPanel tlpConsole;
        private CheckBox ChkProcessaAuto;
        private GroupBox gbProcessarManual;
        private TableLayoutPanel tlpArquivo;
        private Label lblArquivo;
        private Button BtnEscolher;
        private TextBox txtPath;
        private Button BtnProcessarManual;
        private Button BtnLimpar;
        private TabControl tabControl;
        private TabPage tabAbout;
        private TableLayoutPanel tableLayoutPanel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private Button BtnEditarConfig;
        private RichTextBox tbConsole;
        private Label lbTimer;
        private Label lbAguardando;
        private TextBox txtConfigTimer;
        private Label lbConfigTimer;
    }
}
