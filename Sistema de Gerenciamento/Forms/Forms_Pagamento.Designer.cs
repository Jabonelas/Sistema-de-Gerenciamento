namespace Sistema_de_Gerenciamento.Forms
{
    partial class Forms_Pagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forms_Pagamento));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuPanel13 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblNumeroNotaFiscalSaida = new System.Windows.Forms.Label();
            this.lblDescricaoItem = new System.Windows.Forms.Label();
            this.pnlDesconto = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblValorDesconto = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.pnlFormaPagamento = new Bunifu.UI.WinForms.BunifuPanel();
            this.cmbFormaPagamento = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblFormaPamento = new System.Windows.Forms.Label();
            this.pnlCarne = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblValorDebito = new System.Windows.Forms.Label();
            this.lblValorParcela = new System.Windows.Forms.Label();
            this.txtValorDinheiro = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblValorJuros = new System.Windows.Forms.Label();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.lblTituloJuros = new System.Windows.Forms.Label();
            this.cmbParcelas = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTituloValorParcela = new System.Windows.Forms.Label();
            this.lblTituloFormaPagamento = new System.Windows.Forms.Label();
            this.pnlTotalRecebido = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblTotalRecebido = new System.Windows.Forms.Label();
            this.lblValores = new System.Windows.Forms.Label();
            this.pnlValorTotal = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTroco = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblTroco = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFechar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnConfirmar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlQRCode = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlChavePix = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblChavePix = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gdvPagamento = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ns_codigo_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ns_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ns_quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ns_valor_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ns_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuPanel13.SuspendLayout();
            this.pnlDesconto.SuspendLayout();
            this.pnlFormaPagamento.SuspendLayout();
            this.pnlCarne.SuspendLayout();
            this.pnlTotalRecebido.SuspendLayout();
            this.pnlValorTotal.SuspendLayout();
            this.pnlTroco.SuspendLayout();
            this.pnlChavePix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel13
            // 
            this.bunifuPanel13.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.bunifuPanel13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel13.BackgroundImage")));
            this.bunifuPanel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel13.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel13.BorderRadius = 20;
            this.bunifuPanel13.BorderThickness = 1;
            this.bunifuPanel13.Controls.Add(this.lblNumeroNotaFiscalSaida);
            this.bunifuPanel13.Controls.Add(this.lblDescricaoItem);
            this.bunifuPanel13.Location = new System.Drawing.Point(7, 10);
            this.bunifuPanel13.Name = "bunifuPanel13";
            this.bunifuPanel13.ShowBorders = true;
            this.bunifuPanel13.Size = new System.Drawing.Size(435, 66);
            this.bunifuPanel13.TabIndex = 181;
            // 
            // lblNumeroNotaFiscalSaida
            // 
            this.lblNumeroNotaFiscalSaida.AutoSize = true;
            this.lblNumeroNotaFiscalSaida.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroNotaFiscalSaida.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroNotaFiscalSaida.ForeColor = System.Drawing.Color.White;
            this.lblNumeroNotaFiscalSaida.Location = new System.Drawing.Point(204, 11);
            this.lblNumeroNotaFiscalSaida.Name = "lblNumeroNotaFiscalSaida";
            this.lblNumeroNotaFiscalSaida.Size = new System.Drawing.Size(95, 39);
            this.lblNumeroNotaFiscalSaida.TabIndex = 180;
            this.lblNumeroNotaFiscalSaida.Text = "Nº NF";
            this.lblNumeroNotaFiscalSaida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescricaoItem
            // 
            this.lblDescricaoItem.AutoSize = true;
            this.lblDescricaoItem.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricaoItem.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoItem.ForeColor = System.Drawing.Color.White;
            this.lblDescricaoItem.Location = new System.Drawing.Point(7, 11);
            this.lblDescricaoItem.Name = "lblDescricaoItem";
            this.lblDescricaoItem.Size = new System.Drawing.Size(201, 39);
            this.lblDescricaoItem.TabIndex = 179;
            this.lblDescricaoItem.Text = "PAGAMENTO:";
            this.lblDescricaoItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlDesconto
            // 
            this.pnlDesconto.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.pnlDesconto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDesconto.BackgroundImage")));
            this.pnlDesconto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDesconto.BorderColor = System.Drawing.Color.Transparent;
            this.pnlDesconto.BorderRadius = 50;
            this.pnlDesconto.BorderThickness = 1;
            this.pnlDesconto.Controls.Add(this.lblValorDesconto);
            this.pnlDesconto.Controls.Add(this.lblDesconto);
            this.pnlDesconto.Location = new System.Drawing.Point(7, 89);
            this.pnlDesconto.Name = "pnlDesconto";
            this.pnlDesconto.ShowBorders = true;
            this.pnlDesconto.Size = new System.Drawing.Size(193, 80);
            this.pnlDesconto.TabIndex = 184;
            // 
            // lblValorDesconto
            // 
            this.lblValorDesconto.AutoSize = true;
            this.lblValorDesconto.BackColor = System.Drawing.Color.Transparent;
            this.lblValorDesconto.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDesconto.ForeColor = System.Drawing.Color.White;
            this.lblValorDesconto.Location = new System.Drawing.Point(44, 35);
            this.lblValorDesconto.Name = "lblValorDesconto";
            this.lblValorDesconto.Size = new System.Drawing.Size(105, 36);
            this.lblValorDesconto.TabIndex = 182;
            this.lblValorDesconto.Text = "R$ 0,00";
            this.lblValorDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.BackColor = System.Drawing.Color.Transparent;
            this.lblDesconto.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.ForeColor = System.Drawing.Color.White;
            this.lblDesconto.Location = new System.Drawing.Point(38, 6);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(123, 29);
            this.lblDesconto.TabIndex = 181;
            this.lblDesconto.Text = "DESCONTO";
            // 
            // pnlFormaPagamento
            // 
            this.pnlFormaPagamento.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.pnlFormaPagamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFormaPagamento.BackgroundImage")));
            this.pnlFormaPagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFormaPagamento.BorderColor = System.Drawing.Color.Transparent;
            this.pnlFormaPagamento.BorderRadius = 50;
            this.pnlFormaPagamento.BorderThickness = 1;
            this.pnlFormaPagamento.Controls.Add(this.cmbFormaPagamento);
            this.pnlFormaPagamento.Controls.Add(this.lblFormaPamento);
            this.pnlFormaPagamento.Location = new System.Drawing.Point(205, 92);
            this.pnlFormaPagamento.Name = "pnlFormaPagamento";
            this.pnlFormaPagamento.ShowBorders = true;
            this.pnlFormaPagamento.Size = new System.Drawing.Size(237, 80);
            this.pnlFormaPagamento.TabIndex = 185;
            // 
            // cmbFormaPagamento
            // 
            this.cmbFormaPagamento.BackColor = System.Drawing.Color.Transparent;
            this.cmbFormaPagamento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPagamento.FillColor = System.Drawing.Color.DodgerBlue;
            this.cmbFormaPagamento.FocusedColor = System.Drawing.Color.Empty;
            this.cmbFormaPagamento.FocusedState.Parent = this.cmbFormaPagamento;
            this.cmbFormaPagamento.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormaPagamento.ForeColor = System.Drawing.Color.White;
            this.cmbFormaPagamento.FormattingEnabled = true;
            this.cmbFormaPagamento.HoverState.Parent = this.cmbFormaPagamento;
            this.cmbFormaPagamento.ItemHeight = 30;
            this.cmbFormaPagamento.Items.AddRange(new object[] {
            "CARNÊ",
            "CRÉDITO",
            "DÉBITO",
            "DINHEIRO",
            "PIX"});
            this.cmbFormaPagamento.ItemsAppearance.Parent = this.cmbFormaPagamento;
            this.cmbFormaPagamento.Location = new System.Drawing.Point(37, 37);
            this.cmbFormaPagamento.Name = "cmbFormaPagamento";
            this.cmbFormaPagamento.ShadowDecoration.Parent = this.cmbFormaPagamento;
            this.cmbFormaPagamento.Size = new System.Drawing.Size(161, 36);
            this.cmbFormaPagamento.TabIndex = 180;
            this.cmbFormaPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbFormaPagamento.SelectedValueChanged += new System.EventHandler(this.cmbFormaPagamento_SelectedValueChanged);
            // 
            // lblFormaPamento
            // 
            this.lblFormaPamento.AutoSize = true;
            this.lblFormaPamento.BackColor = System.Drawing.Color.Transparent;
            this.lblFormaPamento.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPamento.ForeColor = System.Drawing.Color.White;
            this.lblFormaPamento.Location = new System.Drawing.Point(3, 3);
            this.lblFormaPamento.Name = "lblFormaPamento";
            this.lblFormaPamento.Size = new System.Drawing.Size(227, 29);
            this.lblFormaPamento.TabIndex = 179;
            this.lblFormaPamento.Text = "FORMA PAGAMENTO";
            // 
            // pnlCarne
            // 
            this.pnlCarne.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.pnlCarne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCarne.BackgroundImage")));
            this.pnlCarne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCarne.BorderColor = System.Drawing.Color.Transparent;
            this.pnlCarne.BorderRadius = 30;
            this.pnlCarne.BorderThickness = 1;
            this.pnlCarne.Controls.Add(this.lblValorDebito);
            this.pnlCarne.Controls.Add(this.lblValorParcela);
            this.pnlCarne.Controls.Add(this.txtValorDinheiro);
            this.pnlCarne.Controls.Add(this.lblValorJuros);
            this.pnlCarne.Controls.Add(this.lblParcelas);
            this.pnlCarne.Controls.Add(this.lblTituloJuros);
            this.pnlCarne.Controls.Add(this.cmbParcelas);
            this.pnlCarne.Controls.Add(this.lblTituloValorParcela);
            this.pnlCarne.Controls.Add(this.lblTituloFormaPagamento);
            this.pnlCarne.Location = new System.Drawing.Point(7, 283);
            this.pnlCarne.Name = "pnlCarne";
            this.pnlCarne.ShowBorders = true;
            this.pnlCarne.Size = new System.Drawing.Size(435, 121);
            this.pnlCarne.TabIndex = 186;
            // 
            // lblValorDebito
            // 
            this.lblValorDebito.AutoSize = true;
            this.lblValorDebito.BackColor = System.Drawing.Color.Transparent;
            this.lblValorDebito.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDebito.ForeColor = System.Drawing.Color.White;
            this.lblValorDebito.Location = new System.Drawing.Point(128, 56);
            this.lblValorDebito.Name = "lblValorDebito";
            this.lblValorDebito.Size = new System.Drawing.Size(171, 59);
            this.lblValorDebito.TabIndex = 186;
            this.lblValorDebito.Text = "R$ 0,00";
            this.lblValorDebito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblValorDebito.Visible = false;
            // 
            // lblValorParcela
            // 
            this.lblValorParcela.AutoSize = true;
            this.lblValorParcela.BackColor = System.Drawing.Color.Transparent;
            this.lblValorParcela.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorParcela.ForeColor = System.Drawing.Color.White;
            this.lblValorParcela.Location = new System.Drawing.Point(310, 78);
            this.lblValorParcela.Name = "lblValorParcela";
            this.lblValorParcela.Size = new System.Drawing.Size(86, 29);
            this.lblValorParcela.TabIndex = 183;
            this.lblValorParcela.Text = "R$ 0,00";
            this.lblValorParcela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblValorParcela.Visible = false;
            // 
            // txtValorDinheiro
            // 
            this.txtValorDinheiro.AcceptsReturn = false;
            this.txtValorDinheiro.AcceptsTab = false;
            this.txtValorDinheiro.AnimationSpeed = 200;
            this.txtValorDinheiro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtValorDinheiro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtValorDinheiro.BackColor = System.Drawing.Color.Transparent;
            this.txtValorDinheiro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtValorDinheiro.BackgroundImage")));
            this.txtValorDinheiro.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtValorDinheiro.BorderColorDisabled = System.Drawing.Color.DodgerBlue;
            this.txtValorDinheiro.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtValorDinheiro.BorderColorIdle = System.Drawing.Color.Transparent;
            this.txtValorDinheiro.BorderRadius = 1;
            this.txtValorDinheiro.BorderThickness = 1;
            this.txtValorDinheiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtValorDinheiro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValorDinheiro.DefaultFont = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDinheiro.DefaultText = "";
            this.txtValorDinheiro.FillColor = System.Drawing.Color.SkyBlue;
            this.txtValorDinheiro.ForeColor = System.Drawing.Color.White;
            this.txtValorDinheiro.HideSelection = true;
            this.txtValorDinheiro.IconLeft = null;
            this.txtValorDinheiro.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValorDinheiro.IconPadding = 10;
            this.txtValorDinheiro.IconRight = null;
            this.txtValorDinheiro.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValorDinheiro.Lines = new string[0];
            this.txtValorDinheiro.Location = new System.Drawing.Point(14, 35);
            this.txtValorDinheiro.MaxLength = 32767;
            this.txtValorDinheiro.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtValorDinheiro.Modified = false;
            this.txtValorDinheiro.Multiline = false;
            this.txtValorDinheiro.Name = "txtValorDinheiro";
            stateProperties1.BorderColor = System.Drawing.Color.AliceBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtValorDinheiro.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties2.FillColor = System.Drawing.Color.DodgerBlue;
            stateProperties2.ForeColor = System.Drawing.Color.DodgerBlue;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.txtValorDinheiro.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtValorDinheiro.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Transparent;
            stateProperties4.FillColor = System.Drawing.Color.SkyBlue;
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtValorDinheiro.OnIdleState = stateProperties4;
            this.txtValorDinheiro.Padding = new System.Windows.Forms.Padding(3);
            this.txtValorDinheiro.PasswordChar = '\0';
            this.txtValorDinheiro.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txtValorDinheiro.PlaceholderText = "R$ 0,00";
            this.txtValorDinheiro.ReadOnly = false;
            this.txtValorDinheiro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValorDinheiro.SelectedText = "";
            this.txtValorDinheiro.SelectionLength = 0;
            this.txtValorDinheiro.SelectionStart = 0;
            this.txtValorDinheiro.ShortcutsEnabled = false;
            this.txtValorDinheiro.Size = new System.Drawing.Size(401, 79);
            this.txtValorDinheiro.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtValorDinheiro.TabIndex = 179;
            this.txtValorDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorDinheiro.TextMarginBottom = 0;
            this.txtValorDinheiro.TextMarginLeft = 3;
            this.txtValorDinheiro.TextMarginTop = 0;
            this.txtValorDinheiro.TextPlaceholder = "R$ 0,00";
            this.txtValorDinheiro.UseSystemPasswordChar = false;
            this.txtValorDinheiro.Visible = false;
            this.txtValorDinheiro.WordWrap = true;
            this.txtValorDinheiro.TextChange += new System.EventHandler(this.txtValorDinheiro_TextChange);
            this.txtValorDinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorDinheiro_KeyPress);
            // 
            // lblValorJuros
            // 
            this.lblValorJuros.AutoSize = true;
            this.lblValorJuros.BackColor = System.Drawing.Color.Transparent;
            this.lblValorJuros.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorJuros.ForeColor = System.Drawing.Color.White;
            this.lblValorJuros.Location = new System.Drawing.Point(184, 78);
            this.lblValorJuros.Name = "lblValorJuros";
            this.lblValorJuros.Size = new System.Drawing.Size(73, 29);
            this.lblValorJuros.TabIndex = 183;
            this.lblValorJuros.Text = "0,00%";
            this.lblValorJuros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValorJuros.Visible = false;
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.BackColor = System.Drawing.Color.Transparent;
            this.lblParcelas.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcelas.ForeColor = System.Drawing.Color.White;
            this.lblParcelas.Location = new System.Drawing.Point(27, 52);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(90, 23);
            this.lblParcelas.TabIndex = 183;
            this.lblParcelas.Text = "PARCELAS";
            this.lblParcelas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblParcelas.Visible = false;
            // 
            // lblTituloJuros
            // 
            this.lblTituloJuros.AutoSize = true;
            this.lblTituloJuros.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloJuros.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloJuros.ForeColor = System.Drawing.Color.White;
            this.lblTituloJuros.Location = new System.Drawing.Point(185, 52);
            this.lblTituloJuros.Name = "lblTituloJuros";
            this.lblTituloJuros.Size = new System.Drawing.Size(61, 23);
            this.lblTituloJuros.TabIndex = 182;
            this.lblTituloJuros.Text = "JUROS";
            this.lblTituloJuros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTituloJuros.Visible = false;
            // 
            // cmbParcelas
            // 
            this.cmbParcelas.BackColor = System.Drawing.Color.Transparent;
            this.cmbParcelas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbParcelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParcelas.FillColor = System.Drawing.Color.DodgerBlue;
            this.cmbParcelas.FocusedColor = System.Drawing.Color.Empty;
            this.cmbParcelas.FocusedState.Parent = this.cmbParcelas;
            this.cmbParcelas.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParcelas.ForeColor = System.Drawing.Color.White;
            this.cmbParcelas.FormattingEnabled = true;
            this.cmbParcelas.HoverState.Parent = this.cmbParcelas;
            this.cmbParcelas.ItemHeight = 30;
            this.cmbParcelas.Items.AddRange(new object[] {
            "1x",
            "2x",
            "3x",
            "4x",
            "5x",
            "6x",
            "7x",
            "8x",
            "9x",
            "10x",
            "11x",
            "12x"});
            this.cmbParcelas.ItemsAppearance.Parent = this.cmbParcelas;
            this.cmbParcelas.Location = new System.Drawing.Point(33, 78);
            this.cmbParcelas.Name = "cmbParcelas";
            this.cmbParcelas.ShadowDecoration.Parent = this.cmbParcelas;
            this.cmbParcelas.Size = new System.Drawing.Size(71, 36);
            this.cmbParcelas.TabIndex = 181;
            this.cmbParcelas.Visible = false;
            this.cmbParcelas.SelectedValueChanged += new System.EventHandler(this.cmbParcelas_SelectedValueChanged);
            // 
            // lblTituloValorParcela
            // 
            this.lblTituloValorParcela.AutoSize = true;
            this.lblTituloValorParcela.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloValorParcela.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloValorParcela.ForeColor = System.Drawing.Color.White;
            this.lblTituloValorParcela.Location = new System.Drawing.Point(313, 29);
            this.lblTituloValorParcela.Name = "lblTituloValorParcela";
            this.lblTituloValorParcela.Size = new System.Drawing.Size(96, 46);
            this.lblTituloValorParcela.TabIndex = 178;
            this.lblTituloValorParcela.Text = "VALOR DA \r\nPARCELA";
            this.lblTituloValorParcela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTituloValorParcela.Visible = false;
            // 
            // lblTituloFormaPagamento
            // 
            this.lblTituloFormaPagamento.AutoSize = true;
            this.lblTituloFormaPagamento.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloFormaPagamento.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormaPagamento.ForeColor = System.Drawing.Color.White;
            this.lblTituloFormaPagamento.Location = new System.Drawing.Point(9, 5);
            this.lblTituloFormaPagamento.Name = "lblTituloFormaPagamento";
            this.lblTituloFormaPagamento.Size = new System.Drawing.Size(145, 29);
            this.lblTituloFormaPagamento.TabIndex = 180;
            this.lblTituloFormaPagamento.Text = "PAGAMENTO";
            // 
            // pnlTotalRecebido
            // 
            this.pnlTotalRecebido.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.pnlTotalRecebido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTotalRecebido.BackgroundImage")));
            this.pnlTotalRecebido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTotalRecebido.BorderColor = System.Drawing.Color.Transparent;
            this.pnlTotalRecebido.BorderRadius = 50;
            this.pnlTotalRecebido.BorderThickness = 1;
            this.pnlTotalRecebido.Controls.Add(this.lblTotalRecebido);
            this.pnlTotalRecebido.Controls.Add(this.lblValores);
            this.pnlTotalRecebido.Location = new System.Drawing.Point(448, 304);
            this.pnlTotalRecebido.Name = "pnlTotalRecebido";
            this.pnlTotalRecebido.ShowBorders = true;
            this.pnlTotalRecebido.Size = new System.Drawing.Size(210, 80);
            this.pnlTotalRecebido.TabIndex = 187;
            this.pnlTotalRecebido.Visible = false;
            // 
            // lblTotalRecebido
            // 
            this.lblTotalRecebido.AutoSize = true;
            this.lblTotalRecebido.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRecebido.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecebido.ForeColor = System.Drawing.Color.White;
            this.lblTotalRecebido.Location = new System.Drawing.Point(51, 35);
            this.lblTotalRecebido.Name = "lblTotalRecebido";
            this.lblTotalRecebido.Size = new System.Drawing.Size(105, 36);
            this.lblTotalRecebido.TabIndex = 177;
            this.lblTotalRecebido.Text = "R$ 0,00";
            // 
            // lblValores
            // 
            this.lblValores.AutoSize = true;
            this.lblValores.BackColor = System.Drawing.Color.Transparent;
            this.lblValores.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValores.ForeColor = System.Drawing.Color.White;
            this.lblValores.Location = new System.Drawing.Point(18, 2);
            this.lblValores.Name = "lblValores";
            this.lblValores.Size = new System.Drawing.Size(180, 29);
            this.lblValores.TabIndex = 175;
            this.lblValores.Text = "TOTAL RECEBIDO";
            // 
            // pnlValorTotal
            // 
            this.pnlValorTotal.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.pnlValorTotal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlValorTotal.BackgroundImage")));
            this.pnlValorTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlValorTotal.BorderColor = System.Drawing.Color.Transparent;
            this.pnlValorTotal.BorderRadius = 30;
            this.pnlValorTotal.BorderThickness = 1;
            this.pnlValorTotal.Controls.Add(this.lblValorTotal);
            this.pnlValorTotal.Controls.Add(this.label2);
            this.pnlValorTotal.Location = new System.Drawing.Point(7, 185);
            this.pnlValorTotal.Name = "pnlValorTotal";
            this.pnlValorTotal.ShowBorders = true;
            this.pnlValorTotal.Size = new System.Drawing.Size(435, 80);
            this.pnlValorTotal.TabIndex = 188;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblValorTotal.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.ForeColor = System.Drawing.Color.White;
            this.lblValorTotal.Location = new System.Drawing.Point(128, 21);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(171, 59);
            this.lblValorTotal.TabIndex = 177;
            this.lblValorTotal.Text = "R$ 0,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 175;
            this.label2.Text = "VALOR ";
            // 
            // pnlTroco
            // 
            this.pnlTroco.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.pnlTroco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTroco.BackgroundImage")));
            this.pnlTroco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTroco.BorderColor = System.Drawing.Color.Transparent;
            this.pnlTroco.BorderRadius = 50;
            this.pnlTroco.BorderThickness = 1;
            this.pnlTroco.Controls.Add(this.lblTroco);
            this.pnlTroco.Controls.Add(this.label3);
            this.pnlTroco.Location = new System.Drawing.Point(696, 304);
            this.pnlTroco.Name = "pnlTroco";
            this.pnlTroco.ShowBorders = true;
            this.pnlTroco.Size = new System.Drawing.Size(219, 80);
            this.pnlTroco.TabIndex = 178;
            this.pnlTroco.Visible = false;
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.BackColor = System.Drawing.Color.Transparent;
            this.lblTroco.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.ForeColor = System.Drawing.Color.White;
            this.lblTroco.Location = new System.Drawing.Point(59, 33);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(105, 36);
            this.lblTroco.TabIndex = 176;
            this.lblTroco.Text = "R$ 0,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 174;
            this.label3.Text = "TROCO";
            // 
            // btnFechar
            // 
            this.btnFechar.AllowAnimations = true;
            this.btnFechar.AllowMouseEffects = true;
            this.btnFechar.AllowToggling = false;
            this.btnFechar.AnimationSpeed = 200;
            this.btnFechar.AutoGenerateColors = false;
            this.btnFechar.AutoRoundBorders = false;
            this.btnFechar.AutoSizeLeftIcon = true;
            this.btnFechar.AutoSizeRightIcon = true;
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackColor1 = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFechar.ButtonText = "Fechar (Esc)";
            this.btnFechar.ButtonTextMarginLeft = 0;
            this.btnFechar.ColorContrastOnClick = 45;
            this.btnFechar.ColorContrastOnHover = 45;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnFechar.CustomizableEdges = borderEdges1;
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFechar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFechar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFechar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFechar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnFechar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.Black;
            this.btnFechar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnFechar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnFechar.IconMarginLeft = 11;
            this.btnFechar.IconPadding = 10;
            this.btnFechar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnFechar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnFechar.IconSize = 25;
            this.btnFechar.IdleBorderColor = System.Drawing.Color.Black;
            this.btnFechar.IdleBorderRadius = 1;
            this.btnFechar.IdleBorderThickness = 1;
            this.btnFechar.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnFechar.IdleIconLeftImage = null;
            this.btnFechar.IdleIconRightImage = null;
            this.btnFechar.IndicateFocus = false;
            this.btnFechar.Location = new System.Drawing.Point(510, 447);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFechar.OnDisabledState.BorderRadius = 1;
            this.btnFechar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFechar.OnDisabledState.BorderThickness = 1;
            this.btnFechar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFechar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFechar.OnDisabledState.IconLeftImage = null;
            this.btnFechar.OnDisabledState.IconRightImage = null;
            this.btnFechar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnFechar.onHoverState.BorderRadius = 1;
            this.btnFechar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFechar.onHoverState.BorderThickness = 1;
            this.btnFechar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnFechar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnFechar.onHoverState.IconLeftImage = null;
            this.btnFechar.onHoverState.IconRightImage = null;
            this.btnFechar.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnFechar.OnIdleState.BorderRadius = 1;
            this.btnFechar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFechar.OnIdleState.BorderThickness = 1;
            this.btnFechar.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnFechar.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnFechar.OnIdleState.IconLeftImage = null;
            this.btnFechar.OnIdleState.IconRightImage = null;
            this.btnFechar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnFechar.OnPressedState.BorderRadius = 1;
            this.btnFechar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFechar.OnPressedState.BorderThickness = 1;
            this.btnFechar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnFechar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnFechar.OnPressedState.IconLeftImage = null;
            this.btnFechar.OnPressedState.IconRightImage = null;
            this.btnFechar.Size = new System.Drawing.Size(187, 39);
            this.btnFechar.TabIndex = 297;
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFechar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFechar.TextMarginLeft = 0;
            this.btnFechar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFechar.UseDefaultRadiusAndThickness = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AllowAnimations = true;
            this.btnConfirmar.AllowMouseEffects = true;
            this.btnConfirmar.AllowToggling = false;
            this.btnConfirmar.AnimationSpeed = 200;
            this.btnConfirmar.AutoGenerateColors = false;
            this.btnConfirmar.AutoRoundBorders = false;
            this.btnConfirmar.AutoSizeLeftIcon = true;
            this.btnConfirmar.AutoSizeRightIcon = true;
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.BackColor1 = System.Drawing.Color.Transparent;
            this.btnConfirmar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.BackgroundImage")));
            this.btnConfirmar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmar.ButtonText = "Confirmar (F10)";
            this.btnConfirmar.ButtonTextMarginLeft = 0;
            this.btnConfirmar.ColorContrastOnClick = 45;
            this.btnConfirmar.ColorContrastOnHover = 45;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnConfirmar.CustomizableEdges = borderEdges2;
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirmar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConfirmar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfirmar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConfirmar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnConfirmar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnConfirmar.IconMarginLeft = 11;
            this.btnConfirmar.IconPadding = 10;
            this.btnConfirmar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnConfirmar.IconSize = 25;
            this.btnConfirmar.IdleBorderColor = System.Drawing.Color.Black;
            this.btnConfirmar.IdleBorderRadius = 1;
            this.btnConfirmar.IdleBorderThickness = 1;
            this.btnConfirmar.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.IdleIconLeftImage = null;
            this.btnConfirmar.IdleIconRightImage = null;
            this.btnConfirmar.IndicateFocus = false;
            this.btnConfirmar.Location = new System.Drawing.Point(255, 447);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConfirmar.OnDisabledState.BorderRadius = 1;
            this.btnConfirmar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmar.OnDisabledState.BorderThickness = 1;
            this.btnConfirmar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfirmar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConfirmar.OnDisabledState.IconLeftImage = null;
            this.btnConfirmar.OnDisabledState.IconRightImage = null;
            this.btnConfirmar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConfirmar.onHoverState.BorderRadius = 1;
            this.btnConfirmar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmar.onHoverState.BorderThickness = 1;
            this.btnConfirmar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConfirmar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.onHoverState.IconLeftImage = null;
            this.btnConfirmar.onHoverState.IconRightImage = null;
            this.btnConfirmar.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmar.OnIdleState.BorderRadius = 1;
            this.btnConfirmar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmar.OnIdleState.BorderThickness = 1;
            this.btnConfirmar.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.OnIdleState.IconLeftImage = null;
            this.btnConfirmar.OnIdleState.IconRightImage = null;
            this.btnConfirmar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConfirmar.OnPressedState.BorderRadius = 1;
            this.btnConfirmar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmar.OnPressedState.BorderThickness = 1;
            this.btnConfirmar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConfirmar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.OnPressedState.IconLeftImage = null;
            this.btnConfirmar.OnPressedState.IconRightImage = null;
            this.btnConfirmar.Size = new System.Drawing.Size(187, 39);
            this.btnConfirmar.TabIndex = 298;
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirmar.TextMarginLeft = 0;
            this.btnConfirmar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnConfirmar.UseDefaultRadiusAndThickness = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // pnlQRCode
            // 
            this.pnlQRCode.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.pnlQRCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlQRCode.BackgroundImage")));
            this.pnlQRCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlQRCode.BorderColor = System.Drawing.Color.Transparent;
            this.pnlQRCode.BorderRadius = 1;
            this.pnlQRCode.BorderThickness = 1;
            this.pnlQRCode.Location = new System.Drawing.Point(467, 277);
            this.pnlQRCode.Name = "pnlQRCode";
            this.pnlQRCode.ShowBorders = true;
            this.pnlQRCode.Size = new System.Drawing.Size(173, 135);
            this.pnlQRCode.TabIndex = 179;
            this.pnlQRCode.Visible = false;
            // 
            // pnlChavePix
            // 
            this.pnlChavePix.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.pnlChavePix.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlChavePix.BackgroundImage")));
            this.pnlChavePix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlChavePix.BorderColor = System.Drawing.Color.Transparent;
            this.pnlChavePix.BorderRadius = 50;
            this.pnlChavePix.BorderThickness = 1;
            this.pnlChavePix.Controls.Add(this.lblChavePix);
            this.pnlChavePix.Controls.Add(this.label5);
            this.pnlChavePix.Location = new System.Drawing.Point(699, 304);
            this.pnlChavePix.Name = "pnlChavePix";
            this.pnlChavePix.ShowBorders = true;
            this.pnlChavePix.Size = new System.Drawing.Size(216, 80);
            this.pnlChavePix.TabIndex = 179;
            this.pnlChavePix.Visible = false;
            // 
            // lblChavePix
            // 
            this.lblChavePix.AutoSize = true;
            this.lblChavePix.BackColor = System.Drawing.Color.Transparent;
            this.lblChavePix.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChavePix.ForeColor = System.Drawing.Color.White;
            this.lblChavePix.Location = new System.Drawing.Point(5, 33);
            this.lblChavePix.Name = "lblChavePix";
            this.lblChavePix.Size = new System.Drawing.Size(20, 29);
            this.lblChavePix.TabIndex = 176;
            this.lblChavePix.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(43, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 29);
            this.label5.TabIndex = 174;
            this.label5.Text = "CHAVE - PIX";
            // 
            // gdvPagamento
            // 
            this.gdvPagamento.AllowCustomTheming = false;
            this.gdvPagamento.AllowUserToAddRows = false;
            this.gdvPagamento.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gdvPagamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvPagamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvPagamento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvPagamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvPagamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdvPagamento.ColumnHeadersHeight = 40;
            this.gdvPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ns_codigo_produto,
            this.ns_descricao,
            this.ns_quantidade,
            this.ns_valor_pago,
            this.ns_status});
            this.gdvPagamento.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gdvPagamento.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gdvPagamento.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gdvPagamento.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gdvPagamento.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gdvPagamento.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.gdvPagamento.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gdvPagamento.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gdvPagamento.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gdvPagamento.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdvPagamento.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.gdvPagamento.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gdvPagamento.CurrentTheme.Name = null;
            this.gdvPagamento.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvPagamento.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gdvPagamento.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gdvPagamento.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gdvPagamento.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvPagamento.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdvPagamento.EnableHeadersVisualStyles = false;
            this.gdvPagamento.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gdvPagamento.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gdvPagamento.HeaderBgColor = System.Drawing.Color.Empty;
            this.gdvPagamento.HeaderForeColor = System.Drawing.Color.White;
            this.gdvPagamento.Location = new System.Drawing.Point(448, 10);
            this.gdvPagamento.Name = "gdvPagamento";
            this.gdvPagamento.ReadOnly = true;
            this.gdvPagamento.RowHeadersVisible = false;
            this.gdvPagamento.RowHeadersWidth = 50;
            this.gdvPagamento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvPagamento.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gdvPagamento.RowTemplate.Height = 40;
            this.gdvPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvPagamento.Size = new System.Drawing.Size(467, 255);
            this.gdvPagamento.TabIndex = 305;
            this.gdvPagamento.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // ns_codigo_produto
            // 
            this.ns_codigo_produto.DataPropertyName = "ns_codigo_produto";
            this.ns_codigo_produto.FillWeight = 76.73907F;
            this.ns_codigo_produto.HeaderText = "Código ";
            this.ns_codigo_produto.Name = "ns_codigo_produto";
            this.ns_codigo_produto.ReadOnly = true;
            // 
            // ns_descricao
            // 
            this.ns_descricao.DataPropertyName = "ns_descricao";
            this.ns_descricao.FillWeight = 193.6406F;
            this.ns_descricao.HeaderText = "Descrição";
            this.ns_descricao.Name = "ns_descricao";
            this.ns_descricao.ReadOnly = true;
            // 
            // ns_quantidade
            // 
            this.ns_quantidade.DataPropertyName = "ns_quantidade";
            this.ns_quantidade.FillWeight = 76.73907F;
            this.ns_quantidade.HeaderText = "Qtd";
            this.ns_quantidade.Name = "ns_quantidade";
            this.ns_quantidade.ReadOnly = true;
            // 
            // ns_valor_pago
            // 
            this.ns_valor_pago.DataPropertyName = "ns_valor_pago";
            this.ns_valor_pago.FillWeight = 76.73907F;
            this.ns_valor_pago.HeaderText = "Valor";
            this.ns_valor_pago.Name = "ns_valor_pago";
            this.ns_valor_pago.ReadOnly = true;
            // 
            // ns_status
            // 
            this.ns_status.DataPropertyName = "ns_status";
            this.ns_status.FillWeight = 76.14214F;
            this.ns_status.HeaderText = "Status";
            this.ns_status.Name = "ns_status";
            this.ns_status.ReadOnly = true;
            this.ns_status.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 306;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Forms_Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlTroco);
            this.Controls.Add(this.gdvPagamento);
            this.Controls.Add(this.pnlValorTotal);
            this.Controls.Add(this.pnlChavePix);
            this.Controls.Add(this.pnlQRCode);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.pnlTotalRecebido);
            this.Controls.Add(this.pnlCarne);
            this.Controls.Add(this.pnlFormaPagamento);
            this.Controls.Add(this.pnlDesconto);
            this.Controls.Add(this.bunifuPanel13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Forms_Pagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.Forms_Pagamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Forms_Pagamento_KeyDown);
            this.bunifuPanel13.ResumeLayout(false);
            this.bunifuPanel13.PerformLayout();
            this.pnlDesconto.ResumeLayout(false);
            this.pnlDesconto.PerformLayout();
            this.pnlFormaPagamento.ResumeLayout(false);
            this.pnlFormaPagamento.PerformLayout();
            this.pnlCarne.ResumeLayout(false);
            this.pnlCarne.PerformLayout();
            this.pnlTotalRecebido.ResumeLayout(false);
            this.pnlTotalRecebido.PerformLayout();
            this.pnlValorTotal.ResumeLayout(false);
            this.pnlValorTotal.PerformLayout();
            this.pnlTroco.ResumeLayout(false);
            this.pnlTroco.PerformLayout();
            this.pnlChavePix.ResumeLayout(false);
            this.pnlChavePix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPagamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel13;
        private System.Windows.Forms.Label lblNumeroNotaFiscalSaida;
        private System.Windows.Forms.Label lblDescricaoItem;
        private Bunifu.UI.WinForms.BunifuPanel pnlDesconto;
        private System.Windows.Forms.Label lblValorDesconto;
        private System.Windows.Forms.Label lblDesconto;
        private Bunifu.UI.WinForms.BunifuPanel pnlFormaPagamento;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFormaPagamento;
        private System.Windows.Forms.Label lblFormaPamento;
        private Bunifu.UI.WinForms.BunifuPanel pnlCarne;
        private System.Windows.Forms.Label lblValorDebito;
        private System.Windows.Forms.Label lblValorParcela;
        private System.Windows.Forms.Label lblValorJuros;
        private Bunifu.UI.WinForms.BunifuTextBox txtValorDinheiro;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.Label lblTituloJuros;
        private Guna.UI2.WinForms.Guna2ComboBox cmbParcelas;
        private System.Windows.Forms.Label lblTituloValorParcela;
        private System.Windows.Forms.Label lblTituloFormaPagamento;
        private Bunifu.UI.WinForms.BunifuPanel pnlTotalRecebido;
        private System.Windows.Forms.Label lblTotalRecebido;
        private System.Windows.Forms.Label lblValores;
        private Bunifu.UI.WinForms.BunifuPanel pnlTroco;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFechar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnConfirmar;
        private Bunifu.UI.WinForms.BunifuPanel pnlValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuPanel pnlQRCode;
        private Bunifu.UI.WinForms.BunifuPanel pnlChavePix;
        private System.Windows.Forms.Label lblChavePix;
        private System.Windows.Forms.Label label5;
        public Bunifu.UI.WinForms.BunifuDataGridView gdvPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ns_codigo_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ns_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ns_quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ns_valor_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ns_status;
        private System.Windows.Forms.Button button1;
    }
}