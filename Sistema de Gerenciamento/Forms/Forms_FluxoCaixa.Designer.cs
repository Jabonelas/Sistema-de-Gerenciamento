namespace Sistema_de_Gerenciamento.Forms
{
    partial class Forms_FluxoCaixa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forms_FluxoCaixa));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.gdvFluxoCaixa = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ns_numero_nf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ns_cpf_cpnj_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ns_nome_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ns_codigo_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ns_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ns_quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ns_valor_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblComissao = new System.Windows.Forms.Label();
            this.btnPesquisar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lblComissaoPorProduto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFechar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFluxoCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(187, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 275;
            this.label10.Text = "Data Final";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 274;
            this.label9.Text = "Data Inicial";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(190, 52);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(123, 23);
            this.dtpDataFinal.TabIndex = 273;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(41, 52);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(123, 23);
            this.dtpDataInicial.TabIndex = 271;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 270;
            this.label4.Text = "Período";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(166, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 36);
            this.label7.TabIndex = 272;
            this.label7.Text = "-";
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(15, 25);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(326, 64);
            this.bunifuGroupBox1.TabIndex = 276;
            this.bunifuGroupBox1.TabStop = false;
            // 
            // gdvFluxoCaixa
            // 
            this.gdvFluxoCaixa.AllowCustomTheming = false;
            this.gdvFluxoCaixa.AllowUserToAddRows = false;
            this.gdvFluxoCaixa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gdvFluxoCaixa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvFluxoCaixa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvFluxoCaixa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvFluxoCaixa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvFluxoCaixa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvFluxoCaixa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdvFluxoCaixa.ColumnHeadersHeight = 40;
            this.gdvFluxoCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ns_numero_nf,
            this.ns_cpf_cpnj_cliente,
            this.ns_nome_cliente,
            this.ns_codigo_produto,
            this.ns_descricao,
            this.ns_quantidade,
            this.ns_valor_pago});
            this.gdvFluxoCaixa.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gdvFluxoCaixa.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gdvFluxoCaixa.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gdvFluxoCaixa.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gdvFluxoCaixa.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gdvFluxoCaixa.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.gdvFluxoCaixa.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gdvFluxoCaixa.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gdvFluxoCaixa.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gdvFluxoCaixa.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdvFluxoCaixa.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.gdvFluxoCaixa.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gdvFluxoCaixa.CurrentTheme.Name = null;
            this.gdvFluxoCaixa.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvFluxoCaixa.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gdvFluxoCaixa.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gdvFluxoCaixa.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gdvFluxoCaixa.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvFluxoCaixa.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdvFluxoCaixa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.gdvFluxoCaixa.EnableHeadersVisualStyles = false;
            this.gdvFluxoCaixa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gdvFluxoCaixa.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gdvFluxoCaixa.HeaderBgColor = System.Drawing.Color.Empty;
            this.gdvFluxoCaixa.HeaderForeColor = System.Drawing.Color.White;
            this.gdvFluxoCaixa.Location = new System.Drawing.Point(15, 185);
            this.gdvFluxoCaixa.Name = "gdvFluxoCaixa";
            this.gdvFluxoCaixa.ReadOnly = true;
            this.gdvFluxoCaixa.RowHeadersVisible = false;
            this.gdvFluxoCaixa.RowTemplate.Height = 40;
            this.gdvFluxoCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvFluxoCaixa.Size = new System.Drawing.Size(820, 305);
            this.gdvFluxoCaixa.TabIndex = 277;
            this.gdvFluxoCaixa.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // ns_numero_nf
            // 
            this.ns_numero_nf.DataPropertyName = "ns_numero_nf";
            this.ns_numero_nf.FillWeight = 81.21828F;
            this.ns_numero_nf.HeaderText = "Nº NF";
            this.ns_numero_nf.Name = "ns_numero_nf";
            this.ns_numero_nf.ReadOnly = true;
            // 
            // ns_cpf_cpnj_cliente
            // 
            this.ns_cpf_cpnj_cliente.DataPropertyName = "ns_cpf_cpnj_cliente";
            this.ns_cpf_cpnj_cliente.FillWeight = 102.6831F;
            this.ns_cpf_cpnj_cliente.HeaderText = "CPF/CNPJ";
            this.ns_cpf_cpnj_cliente.Name = "ns_cpf_cpnj_cliente";
            this.ns_cpf_cpnj_cliente.ReadOnly = true;
            // 
            // ns_nome_cliente
            // 
            this.ns_nome_cliente.DataPropertyName = "ns_nome_cliente";
            this.ns_nome_cliente.FillWeight = 102.6831F;
            this.ns_nome_cliente.HeaderText = "Nome Cliente";
            this.ns_nome_cliente.Name = "ns_nome_cliente";
            this.ns_nome_cliente.ReadOnly = true;
            // 
            // ns_codigo_produto
            // 
            this.ns_codigo_produto.DataPropertyName = "ns_codigo_produto";
            this.ns_codigo_produto.FillWeight = 102.6831F;
            this.ns_codigo_produto.HeaderText = "Cod. Produto";
            this.ns_codigo_produto.Name = "ns_codigo_produto";
            this.ns_codigo_produto.ReadOnly = true;
            // 
            // ns_descricao
            // 
            this.ns_descricao.DataPropertyName = "ns_descricao";
            this.ns_descricao.FillWeight = 102.6831F;
            this.ns_descricao.HeaderText = "Descrição";
            this.ns_descricao.Name = "ns_descricao";
            this.ns_descricao.ReadOnly = true;
            // 
            // ns_quantidade
            // 
            this.ns_quantidade.DataPropertyName = "ns_quantidade";
            this.ns_quantidade.FillWeight = 102.6831F;
            this.ns_quantidade.HeaderText = "Quantidade";
            this.ns_quantidade.Name = "ns_quantidade";
            this.ns_quantidade.ReadOnly = true;
            // 
            // ns_valor_pago
            // 
            this.ns_valor_pago.DataPropertyName = "ns_valor_pago";
            this.ns_valor_pago.FillWeight = 102.6831F;
            this.ns_valor_pago.HeaderText = "Valor ";
            this.ns_valor_pago.Name = "ns_valor_pago";
            this.ns_valor_pago.ReadOnly = true;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUsuario.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(378, 55);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(243, 23);
            this.cmbUsuario.TabIndex = 288;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(375, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 289;
            this.label8.Text = "Usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 290;
            this.label1.Text = "Valor Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 291;
            this.label2.Text = "Comissão Geral";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(81, 530);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(48, 15);
            this.lblValorTotal.TabIndex = 292;
            this.lblValorTotal.Text = "R$ 0,00";
            // 
            // lblComissao
            // 
            this.lblComissao.AutoSize = true;
            this.lblComissao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComissao.Location = new System.Drawing.Point(408, 530);
            this.lblComissao.Name = "lblComissao";
            this.lblComissao.Size = new System.Drawing.Size(48, 15);
            this.lblComissao.TabIndex = 293;
            this.lblComissao.Text = "R$ 0,00";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AllowAnimations = true;
            this.btnPesquisar.AllowMouseEffects = true;
            this.btnPesquisar.AllowToggling = false;
            this.btnPesquisar.AnimationSpeed = 200;
            this.btnPesquisar.AutoGenerateColors = false;
            this.btnPesquisar.AutoRoundBorders = false;
            this.btnPesquisar.AutoSizeLeftIcon = true;
            this.btnPesquisar.AutoSizeRightIcon = true;
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackColor1 = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPesquisar.ButtonText = "(F2) Pesquisar";
            this.btnPesquisar.ButtonTextMarginLeft = 0;
            this.btnPesquisar.ColorContrastOnClick = 45;
            this.btnPesquisar.ColorContrastOnHover = 45;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnPesquisar.CustomizableEdges = borderEdges1;
            this.btnPesquisar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPesquisar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPesquisar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPesquisar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPesquisar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPesquisar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPesquisar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPesquisar.IconMarginLeft = 11;
            this.btnPesquisar.IconPadding = 10;
            this.btnPesquisar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPesquisar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPesquisar.IconSize = 25;
            this.btnPesquisar.IdleBorderColor = System.Drawing.Color.Black;
            this.btnPesquisar.IdleBorderRadius = 1;
            this.btnPesquisar.IdleBorderThickness = 1;
            this.btnPesquisar.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.IdleIconLeftImage = null;
            this.btnPesquisar.IdleIconRightImage = null;
            this.btnPesquisar.IndicateFocus = false;
            this.btnPesquisar.Location = new System.Drawing.Point(341, 112);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPesquisar.OnDisabledState.BorderRadius = 1;
            this.btnPesquisar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPesquisar.OnDisabledState.BorderThickness = 1;
            this.btnPesquisar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPesquisar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPesquisar.OnDisabledState.IconLeftImage = null;
            this.btnPesquisar.OnDisabledState.IconRightImage = null;
            this.btnPesquisar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPesquisar.onHoverState.BorderRadius = 1;
            this.btnPesquisar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPesquisar.onHoverState.BorderThickness = 1;
            this.btnPesquisar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPesquisar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.onHoverState.IconLeftImage = null;
            this.btnPesquisar.onHoverState.IconRightImage = null;
            this.btnPesquisar.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnPesquisar.OnIdleState.BorderRadius = 1;
            this.btnPesquisar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPesquisar.OnIdleState.BorderThickness = 1;
            this.btnPesquisar.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisar.OnIdleState.IconLeftImage = null;
            this.btnPesquisar.OnIdleState.IconRightImage = null;
            this.btnPesquisar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPesquisar.OnPressedState.BorderRadius = 1;
            this.btnPesquisar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPesquisar.OnPressedState.BorderThickness = 1;
            this.btnPesquisar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPesquisar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.OnPressedState.IconLeftImage = null;
            this.btnPesquisar.OnPressedState.IconRightImage = null;
            this.btnPesquisar.Size = new System.Drawing.Size(187, 39);
            this.btnPesquisar.TabIndex = 294;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPesquisar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPesquisar.TextMarginLeft = 0;
            this.btnPesquisar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPesquisar.UseDefaultRadiusAndThickness = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(15, 165);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(820, 14);
            this.bunifuSeparator1.TabIndex = 295;
            // 
            // lblComissaoPorProduto
            // 
            this.lblComissaoPorProduto.AutoSize = true;
            this.lblComissaoPorProduto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComissaoPorProduto.Location = new System.Drawing.Point(709, 530);
            this.lblComissaoPorProduto.Name = "lblComissaoPorProduto";
            this.lblComissaoPorProduto.Size = new System.Drawing.Size(48, 15);
            this.lblComissaoPorProduto.TabIndex = 296;
            this.lblComissaoPorProduto.Text = "R$ 0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(667, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 15);
            this.label5.TabIndex = 297;
            this.label5.Text = "Comissão Por Produto";
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
            this.btnFechar.ButtonText = "(Esc) Fechar";
            this.btnFechar.ButtonTextMarginLeft = 0;
            this.btnFechar.ColorContrastOnClick = 45;
            this.btnFechar.ColorContrastOnHover = 45;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnFechar.CustomizableEdges = borderEdges2;
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
            this.btnFechar.Location = new System.Drawing.Point(341, 580);
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
            this.btnFechar.TabIndex = 298;
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFechar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFechar.TextMarginLeft = 0;
            this.btnFechar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFechar.UseDefaultRadiusAndThickness = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Forms_FluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 631);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblComissaoPorProduto);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblComissao);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.gdvFluxoCaixa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bunifuGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Forms_FluxoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fluxo Caixa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Forms_FluxoCaixa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gdvFluxoCaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        public Bunifu.UI.WinForms.BunifuDataGridView gdvFluxoCaixa;
        public System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblComissao;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPesquisar;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ns_numero_nf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ns_cpf_cpnj_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ns_nome_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ns_codigo_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ns_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ns_quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ns_valor_pago;
        private System.Windows.Forms.Label lblComissaoPorProduto;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFechar;
    }
}