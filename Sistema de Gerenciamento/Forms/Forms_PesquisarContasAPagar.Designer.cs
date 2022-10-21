namespace Sistema_de_Gerenciamento
{
    partial class Forms_PesquisarContasAPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forms_PesquisarContasAPagar));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.gdvContarPagar = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dc_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_fornecedor_titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_frequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_quantidade_parcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_valor_parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_estatus_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_imagem_pagamento = new System.Windows.Forms.DataGridViewImageColumn();
            this.dc_valor_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_data_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_desconto_taxas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_juros_multa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_verificar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPagamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPagas = new System.Windows.Forms.Label();
            this.lblAPagar = new System.Windows.Forms.Label();
            this.lblTotalPagamento = new System.Windows.Forms.Label();
            this.lblVencidas = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblNumeroLancamentos = new System.Windows.Forms.Label();
            this.lblTotalLancamentoSelecionado = new System.Windows.Forms.Label();
            this.cmbTitulo = new System.Windows.Forms.ComboBox();
            this.bunifuGroupBox2 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btnExportarParaExcel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnImprimir = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSelecionar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnFechar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtCodigoDespesa = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtDescricao = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btnPesquisar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblNumeroLancamentosSelecionados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdvContarPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvContarPagar
            // 
            this.gdvContarPagar.AllowCustomTheming = false;
            this.gdvContarPagar.AllowUserToAddRows = false;
            this.gdvContarPagar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gdvContarPagar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvContarPagar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvContarPagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvContarPagar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvContarPagar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvContarPagar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdvContarPagar.ColumnHeadersHeight = 40;
            this.gdvContarPagar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dc_codigo,
            this.dc_id,
            this.dc_categoria,
            this.dc_tipo,
            this.dc_fornecedor_titulo,
            this.dc_descricao,
            this.dc_cnpj,
            this.dc_emissao,
            this.dc_vencimento,
            this.dc_frequencia,
            this.dc_valor,
            this.dc_quantidade_parcelas,
            this.dc_valor_parcela,
            this.dc_estatus_pagamento,
            this.dc_imagem_pagamento,
            this.dc_valor_pago,
            this.dc_data_pagamento,
            this.dc_desconto_taxas,
            this.dc_juros_multa,
            this.dc_verificar});
            this.gdvContarPagar.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gdvContarPagar.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gdvContarPagar.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gdvContarPagar.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gdvContarPagar.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gdvContarPagar.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.gdvContarPagar.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gdvContarPagar.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gdvContarPagar.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gdvContarPagar.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdvContarPagar.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.gdvContarPagar.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gdvContarPagar.CurrentTheme.Name = null;
            this.gdvContarPagar.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvContarPagar.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gdvContarPagar.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gdvContarPagar.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gdvContarPagar.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvContarPagar.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdvContarPagar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.gdvContarPagar.EnableHeadersVisualStyles = false;
            this.gdvContarPagar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gdvContarPagar.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gdvContarPagar.HeaderBgColor = System.Drawing.Color.Empty;
            this.gdvContarPagar.HeaderForeColor = System.Drawing.Color.White;
            this.gdvContarPagar.Location = new System.Drawing.Point(14, 166);
            this.gdvContarPagar.Name = "gdvContarPagar";
            this.gdvContarPagar.ReadOnly = true;
            this.gdvContarPagar.RowHeadersVisible = false;
            this.gdvContarPagar.RowTemplate.Height = 40;
            this.gdvContarPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvContarPagar.Size = new System.Drawing.Size(908, 305);
            this.gdvContarPagar.TabIndex = 9;
            this.gdvContarPagar.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.gdvContarPagar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvContarPagar_CellClick);
            this.gdvContarPagar.DoubleClick += new System.EventHandler(this.gdvContarPagar_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.FalseValue = "false";
            this.Column1.FillWeight = 22.50072F;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.TrueValue = "true";
            // 
            // dc_codigo
            // 
            this.dc_codigo.DataPropertyName = "dc_codigo";
            this.dc_codigo.FillWeight = 68.2226F;
            this.dc_codigo.HeaderText = "Codigo";
            this.dc_codigo.Name = "dc_codigo";
            this.dc_codigo.ReadOnly = true;
            // 
            // dc_id
            // 
            this.dc_id.DataPropertyName = "dc_id";
            this.dc_id.HeaderText = "dc_id";
            this.dc_id.Name = "dc_id";
            this.dc_id.ReadOnly = true;
            this.dc_id.Visible = false;
            // 
            // dc_categoria
            // 
            this.dc_categoria.DataPropertyName = "dc_categoria";
            this.dc_categoria.FillWeight = 92.02452F;
            this.dc_categoria.HeaderText = "Categoria";
            this.dc_categoria.Name = "dc_categoria";
            this.dc_categoria.ReadOnly = true;
            // 
            // dc_tipo
            // 
            this.dc_tipo.DataPropertyName = "dc_tipo";
            this.dc_tipo.FillWeight = 75.9568F;
            this.dc_tipo.HeaderText = "Tipo";
            this.dc_tipo.Name = "dc_tipo";
            this.dc_tipo.ReadOnly = true;
            // 
            // dc_fornecedor_titulo
            // 
            this.dc_fornecedor_titulo.DataPropertyName = "dc_fornecedor_titulo";
            this.dc_fornecedor_titulo.FillWeight = 79.63145F;
            this.dc_fornecedor_titulo.HeaderText = "Titulo";
            this.dc_fornecedor_titulo.Name = "dc_fornecedor_titulo";
            this.dc_fornecedor_titulo.ReadOnly = true;
            // 
            // dc_descricao
            // 
            this.dc_descricao.DataPropertyName = "dc_descricao";
            this.dc_descricao.FillWeight = 245.2517F;
            this.dc_descricao.HeaderText = "Descricao";
            this.dc_descricao.Name = "dc_descricao";
            this.dc_descricao.ReadOnly = true;
            // 
            // dc_cnpj
            // 
            this.dc_cnpj.DataPropertyName = "dc_cnpj";
            this.dc_cnpj.HeaderText = "dc_cnpj";
            this.dc_cnpj.Name = "dc_cnpj";
            this.dc_cnpj.ReadOnly = true;
            this.dc_cnpj.Visible = false;
            // 
            // dc_emissao
            // 
            this.dc_emissao.DataPropertyName = "dc_emissao";
            this.dc_emissao.HeaderText = "dc_emissao";
            this.dc_emissao.Name = "dc_emissao";
            this.dc_emissao.ReadOnly = true;
            this.dc_emissao.Visible = false;
            // 
            // dc_vencimento
            // 
            this.dc_vencimento.DataPropertyName = "dc_vencimento";
            this.dc_vencimento.FillWeight = 118.9589F;
            this.dc_vencimento.HeaderText = "Vencimento";
            this.dc_vencimento.Name = "dc_vencimento";
            this.dc_vencimento.ReadOnly = true;
            // 
            // dc_frequencia
            // 
            this.dc_frequencia.DataPropertyName = "dc_frequencia";
            this.dc_frequencia.HeaderText = "dc_frequencia";
            this.dc_frequencia.Name = "dc_frequencia";
            this.dc_frequencia.ReadOnly = true;
            this.dc_frequencia.Visible = false;
            // 
            // dc_valor
            // 
            this.dc_valor.DataPropertyName = "dc_valor";
            this.dc_valor.HeaderText = "dc_valor";
            this.dc_valor.Name = "dc_valor";
            this.dc_valor.ReadOnly = true;
            this.dc_valor.Visible = false;
            // 
            // dc_quantidade_parcelas
            // 
            this.dc_quantidade_parcelas.DataPropertyName = "dc_quantidade_parcelas";
            this.dc_quantidade_parcelas.HeaderText = "Quant. Parcelas";
            this.dc_quantidade_parcelas.Name = "dc_quantidade_parcelas";
            this.dc_quantidade_parcelas.ReadOnly = true;
            this.dc_quantidade_parcelas.Visible = false;
            // 
            // dc_valor_parcela
            // 
            this.dc_valor_parcela.DataPropertyName = "dc_valor_parcela";
            this.dc_valor_parcela.FillWeight = 106.0827F;
            this.dc_valor_parcela.HeaderText = "Valor ";
            this.dc_valor_parcela.Name = "dc_valor_parcela";
            this.dc_valor_parcela.ReadOnly = true;
            // 
            // dc_estatus_pagamento
            // 
            this.dc_estatus_pagamento.DataPropertyName = "dc_estatus_pagamento";
            this.dc_estatus_pagamento.HeaderText = "dc_estatus_pagamento";
            this.dc_estatus_pagamento.Name = "dc_estatus_pagamento";
            this.dc_estatus_pagamento.ReadOnly = true;
            this.dc_estatus_pagamento.Visible = false;
            // 
            // dc_imagem_pagamento
            // 
            this.dc_imagem_pagamento.DataPropertyName = "dc_imagem_pagamento";
            this.dc_imagem_pagamento.FillWeight = 91.37055F;
            this.dc_imagem_pagamento.HeaderText = "Pagamento";
            this.dc_imagem_pagamento.Name = "dc_imagem_pagamento";
            this.dc_imagem_pagamento.ReadOnly = true;
            this.dc_imagem_pagamento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dc_imagem_pagamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dc_valor_pago
            // 
            this.dc_valor_pago.DataPropertyName = "dc_valor_pago";
            this.dc_valor_pago.HeaderText = "dc_valor_pago";
            this.dc_valor_pago.Name = "dc_valor_pago";
            this.dc_valor_pago.ReadOnly = true;
            this.dc_valor_pago.Visible = false;
            // 
            // dc_data_pagamento
            // 
            this.dc_data_pagamento.DataPropertyName = "dc_data_pagamento";
            this.dc_data_pagamento.HeaderText = "dc_data_pagamento";
            this.dc_data_pagamento.Name = "dc_data_pagamento";
            this.dc_data_pagamento.ReadOnly = true;
            this.dc_data_pagamento.Visible = false;
            // 
            // dc_desconto_taxas
            // 
            this.dc_desconto_taxas.DataPropertyName = "dc_desconto_taxas";
            this.dc_desconto_taxas.HeaderText = "dc_desconto_taxas";
            this.dc_desconto_taxas.Name = "dc_desconto_taxas";
            this.dc_desconto_taxas.ReadOnly = true;
            this.dc_desconto_taxas.Visible = false;
            // 
            // dc_juros_multa
            // 
            this.dc_juros_multa.DataPropertyName = "dc_juros_multa";
            this.dc_juros_multa.HeaderText = "dc_juros_multa";
            this.dc_juros_multa.Name = "dc_juros_multa";
            this.dc_juros_multa.ReadOnly = true;
            this.dc_juros_multa.Visible = false;
            // 
            // dc_verificar
            // 
            this.dc_verificar.DataPropertyName = "dc_verificar";
            this.dc_verificar.HeaderText = "dc_verificar";
            this.dc_verificar.Name = "dc_verificar";
            this.dc_verificar.ReadOnly = true;
            this.dc_verificar.Visible = false;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Custo",
            "Despesa",
            ""});
            this.cmbCategoria.Location = new System.Drawing.Point(155, 28);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(92, 23);
            this.cmbCategoria.TabIndex = 241;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 242;
            this.label1.Text = "Categoria";
            // 
            // cmbTipo
            // 
            this.cmbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Fixa",
            "Variavel",
            ""});
            this.cmbTipo.Location = new System.Drawing.Point(265, 28);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(92, 23);
            this.cmbTipo.TabIndex = 258;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            this.cmbTipo.Enter += new System.EventHandler(this.cmbTipo_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 257;
            this.label2.Text = "Titulo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 256;
            this.label8.Text = "Código";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(552, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 254;
            this.label6.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(262, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 255;
            this.label5.Text = "Tipo";
            // 
            // cmbPagamento
            // 
            this.cmbPagamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPagamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPagamento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPagamento.FormattingEnabled = true;
            this.cmbPagamento.Items.AddRange(new object[] {
            "Nao Pago",
            "Pago",
            ""});
            this.cmbPagamento.Location = new System.Drawing.Point(843, 29);
            this.cmbPagamento.Name = "cmbPagamento";
            this.cmbPagamento.Size = new System.Drawing.Size(79, 23);
            this.cmbPagamento.TabIndex = 261;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(840, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 262;
            this.label3.Text = "Pagamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 263;
            this.label4.Text = "Período";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(41, 109);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(123, 23);
            this.dtpDataInicial.TabIndex = 264;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(166, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 36);
            this.label7.TabIndex = 265;
            this.label7.Text = "-";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(190, 109);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(123, 23);
            this.dtpDataFinal.TabIndex = 266;
            this.dtpDataFinal.Leave += new System.EventHandler(this.dtpDataFinal_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 267;
            this.label9.Text = "Data Inicial";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(187, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 268;
            this.label10.Text = "Data Final";
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
            this.bunifuGroupBox1.Location = new System.Drawing.Point(15, 82);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(326, 64);
            this.bunifuGroupBox1.TabIndex = 269;
            this.bunifuGroupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 508);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 270;
            this.label11.Text = "Pagas (R$)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 547);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 15);
            this.label12.TabIndex = 271;
            this.label12.Text = "A pagar (R$)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 586);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 15);
            this.label13.TabIndex = 272;
            this.label13.Text = "Vencidas (R$)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 622);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 15);
            this.label14.TabIndex = 273;
            this.label14.Text = "Total de Pagamentos (R$)";
            // 
            // lblPagas
            // 
            this.lblPagas.AutoSize = true;
            this.lblPagas.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPagas.Location = new System.Drawing.Point(219, 508);
            this.lblPagas.Name = "lblPagas";
            this.lblPagas.Size = new System.Drawing.Size(48, 15);
            this.lblPagas.TabIndex = 274;
            this.lblPagas.Text = "R$ 0,00";
            // 
            // lblAPagar
            // 
            this.lblAPagar.AutoSize = true;
            this.lblAPagar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPagar.ForeColor = System.Drawing.Color.Red;
            this.lblAPagar.Location = new System.Drawing.Point(219, 547);
            this.lblAPagar.Name = "lblAPagar";
            this.lblAPagar.Size = new System.Drawing.Size(48, 15);
            this.lblAPagar.TabIndex = 275;
            this.lblAPagar.Text = "R$ 0,00";
            // 
            // lblTotalPagamento
            // 
            this.lblTotalPagamento.AutoSize = true;
            this.lblTotalPagamento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalPagamento.Location = new System.Drawing.Point(219, 622);
            this.lblTotalPagamento.Name = "lblTotalPagamento";
            this.lblTotalPagamento.Size = new System.Drawing.Size(48, 15);
            this.lblTotalPagamento.TabIndex = 276;
            this.lblTotalPagamento.Text = "R$ 0,00";
            // 
            // lblVencidas
            // 
            this.lblVencidas.AutoSize = true;
            this.lblVencidas.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencidas.ForeColor = System.Drawing.Color.Red;
            this.lblVencidas.Location = new System.Drawing.Point(219, 586);
            this.lblVencidas.Name = "lblVencidas";
            this.lblVencidas.Size = new System.Drawing.Size(48, 15);
            this.lblVencidas.TabIndex = 276;
            this.lblVencidas.Text = "R$ 0,00";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(439, 508);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(128, 15);
            this.label19.TabIndex = 277;
            this.label19.Text = "Número Lançamentos";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(439, 547);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(201, 15);
            this.label20.TabIndex = 278;
            this.label20.Text = "Número Lançamentos Selecionados";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(439, 586);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(226, 15);
            this.label21.TabIndex = 279;
            this.label21.Text = "Total de Lançamentos Selecionados  (R$)";
            // 
            // lblNumeroLancamentos
            // 
            this.lblNumeroLancamentos.AutoSize = true;
            this.lblNumeroLancamentos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroLancamentos.Location = new System.Drawing.Point(734, 508);
            this.lblNumeroLancamentos.Name = "lblNumeroLancamentos";
            this.lblNumeroLancamentos.Size = new System.Drawing.Size(14, 15);
            this.lblNumeroLancamentos.TabIndex = 280;
            this.lblNumeroLancamentos.Text = "0";
            // 
            // lblTotalLancamentoSelecionado
            // 
            this.lblTotalLancamentoSelecionado.AutoSize = true;
            this.lblTotalLancamentoSelecionado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLancamentoSelecionado.Location = new System.Drawing.Point(734, 586);
            this.lblTotalLancamentoSelecionado.Name = "lblTotalLancamentoSelecionado";
            this.lblTotalLancamentoSelecionado.Size = new System.Drawing.Size(48, 15);
            this.lblTotalLancamentoSelecionado.TabIndex = 282;
            this.lblTotalLancamentoSelecionado.Text = "R$ 0,00";
            // 
            // cmbTitulo
            // 
            this.cmbTitulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTitulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTitulo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTitulo.FormattingEnabled = true;
            this.cmbTitulo.Location = new System.Drawing.Point(376, 28);
            this.cmbTitulo.Name = "cmbTitulo";
            this.cmbTitulo.Size = new System.Drawing.Size(161, 23);
            this.cmbTitulo.TabIndex = 287;
            this.cmbTitulo.Enter += new System.EventHandler(this.cmbTitulo_Enter);
            // 
            // bunifuGroupBox2
            // 
            this.bunifuGroupBox2.BorderColor = System.Drawing.Color.Black;
            this.bunifuGroupBox2.BorderRadius = 1;
            this.bunifuGroupBox2.BorderThickness = 1;
            this.bunifuGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox2.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox2.LabelIndent = 10;
            this.bunifuGroupBox2.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox2.Location = new System.Drawing.Point(144, 4);
            this.bunifuGroupBox2.Name = "bunifuGroupBox2";
            this.bunifuGroupBox2.Size = new System.Drawing.Size(404, 59);
            this.bunifuGroupBox2.TabIndex = 288;
            this.bunifuGroupBox2.TabStop = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator2.LineThickness = 3;
            this.bunifuSeparator2.Location = new System.Drawing.Point(14, 475);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(907, 14);
            this.bunifuSeparator2.TabIndex = 289;
            // 
            // btnExportarParaExcel
            // 
            this.btnExportarParaExcel.AllowAnimations = true;
            this.btnExportarParaExcel.AllowMouseEffects = true;
            this.btnExportarParaExcel.AllowToggling = false;
            this.btnExportarParaExcel.AnimationSpeed = 200;
            this.btnExportarParaExcel.AutoGenerateColors = false;
            this.btnExportarParaExcel.AutoRoundBorders = false;
            this.btnExportarParaExcel.AutoSizeLeftIcon = true;
            this.btnExportarParaExcel.AutoSizeRightIcon = true;
            this.btnExportarParaExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExportarParaExcel.BackColor1 = System.Drawing.Color.Transparent;
            this.btnExportarParaExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportarParaExcel.BackgroundImage")));
            this.btnExportarParaExcel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarParaExcel.ButtonText = "(Ctrl + E) Exportar para o Excel \r\nRelação Despesas/Custos";
            this.btnExportarParaExcel.ButtonTextMarginLeft = 0;
            this.btnExportarParaExcel.ColorContrastOnClick = 45;
            this.btnExportarParaExcel.ColorContrastOnHover = 45;
            this.btnExportarParaExcel.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnExportarParaExcel.CustomizableEdges = borderEdges1;
            this.btnExportarParaExcel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExportarParaExcel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExportarParaExcel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExportarParaExcel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExportarParaExcel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnExportarParaExcel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarParaExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExportarParaExcel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarParaExcel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExportarParaExcel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExportarParaExcel.IconMarginLeft = 11;
            this.btnExportarParaExcel.IconPadding = 10;
            this.btnExportarParaExcel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarParaExcel.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExportarParaExcel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExportarParaExcel.IconSize = 25;
            this.btnExportarParaExcel.IdleBorderColor = System.Drawing.Color.Black;
            this.btnExportarParaExcel.IdleBorderRadius = 1;
            this.btnExportarParaExcel.IdleBorderThickness = 1;
            this.btnExportarParaExcel.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnExportarParaExcel.IdleIconLeftImage = null;
            this.btnExportarParaExcel.IdleIconRightImage = null;
            this.btnExportarParaExcel.IndicateFocus = false;
            this.btnExportarParaExcel.Location = new System.Drawing.Point(483, 669);
            this.btnExportarParaExcel.Name = "btnExportarParaExcel";
            this.btnExportarParaExcel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExportarParaExcel.OnDisabledState.BorderRadius = 1;
            this.btnExportarParaExcel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarParaExcel.OnDisabledState.BorderThickness = 1;
            this.btnExportarParaExcel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExportarParaExcel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExportarParaExcel.OnDisabledState.IconLeftImage = null;
            this.btnExportarParaExcel.OnDisabledState.IconRightImage = null;
            this.btnExportarParaExcel.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnExportarParaExcel.onHoverState.BorderRadius = 1;
            this.btnExportarParaExcel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarParaExcel.onHoverState.BorderThickness = 1;
            this.btnExportarParaExcel.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnExportarParaExcel.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnExportarParaExcel.onHoverState.IconLeftImage = null;
            this.btnExportarParaExcel.onHoverState.IconRightImage = null;
            this.btnExportarParaExcel.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnExportarParaExcel.OnIdleState.BorderRadius = 1;
            this.btnExportarParaExcel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarParaExcel.OnIdleState.BorderThickness = 1;
            this.btnExportarParaExcel.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnExportarParaExcel.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnExportarParaExcel.OnIdleState.IconLeftImage = null;
            this.btnExportarParaExcel.OnIdleState.IconRightImage = null;
            this.btnExportarParaExcel.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExportarParaExcel.OnPressedState.BorderRadius = 1;
            this.btnExportarParaExcel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportarParaExcel.OnPressedState.BorderThickness = 1;
            this.btnExportarParaExcel.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExportarParaExcel.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExportarParaExcel.OnPressedState.IconLeftImage = null;
            this.btnExportarParaExcel.OnPressedState.IconRightImage = null;
            this.btnExportarParaExcel.Size = new System.Drawing.Size(187, 39);
            this.btnExportarParaExcel.TabIndex = 286;
            this.btnExportarParaExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExportarParaExcel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExportarParaExcel.TextMarginLeft = 0;
            this.btnExportarParaExcel.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnExportarParaExcel.UseDefaultRadiusAndThickness = true;
            this.btnExportarParaExcel.Click += new System.EventHandler(this.btnExportarParaExcel_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AllowAnimations = true;
            this.btnImprimir.AllowMouseEffects = true;
            this.btnImprimir.AllowToggling = false;
            this.btnImprimir.AnimationSpeed = 200;
            this.btnImprimir.AutoGenerateColors = false;
            this.btnImprimir.AutoRoundBorders = false;
            this.btnImprimir.AutoSizeLeftIcon = true;
            this.btnImprimir.AutoSizeRightIcon = true;
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BackColor1 = System.Drawing.Color.Transparent;
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnImprimir.ButtonText = "(Ctrl + P) Imprimir Relação das \r\nDespesas/Custos";
            this.btnImprimir.ButtonTextMarginLeft = 0;
            this.btnImprimir.ColorContrastOnClick = 45;
            this.btnImprimir.ColorContrastOnHover = 45;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnImprimir.CustomizableEdges = borderEdges2;
            this.btnImprimir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImprimir.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnImprimir.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnImprimir.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnImprimir.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnImprimir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Black;
            this.btnImprimir.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnImprimir.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnImprimir.IconMarginLeft = 11;
            this.btnImprimir.IconPadding = 10;
            this.btnImprimir.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnImprimir.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnImprimir.IconSize = 25;
            this.btnImprimir.IdleBorderColor = System.Drawing.Color.Black;
            this.btnImprimir.IdleBorderRadius = 1;
            this.btnImprimir.IdleBorderThickness = 1;
            this.btnImprimir.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnImprimir.IdleIconLeftImage = null;
            this.btnImprimir.IdleIconRightImage = null;
            this.btnImprimir.IndicateFocus = false;
            this.btnImprimir.Location = new System.Drawing.Point(286, 669);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnImprimir.OnDisabledState.BorderRadius = 1;
            this.btnImprimir.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnImprimir.OnDisabledState.BorderThickness = 1;
            this.btnImprimir.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnImprimir.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnImprimir.OnDisabledState.IconLeftImage = null;
            this.btnImprimir.OnDisabledState.IconRightImage = null;
            this.btnImprimir.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnImprimir.onHoverState.BorderRadius = 1;
            this.btnImprimir.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnImprimir.onHoverState.BorderThickness = 1;
            this.btnImprimir.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnImprimir.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.onHoverState.IconLeftImage = null;
            this.btnImprimir.onHoverState.IconRightImage = null;
            this.btnImprimir.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnImprimir.OnIdleState.BorderRadius = 1;
            this.btnImprimir.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnImprimir.OnIdleState.BorderThickness = 1;
            this.btnImprimir.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnImprimir.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnImprimir.OnIdleState.IconLeftImage = null;
            this.btnImprimir.OnIdleState.IconRightImage = null;
            this.btnImprimir.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnImprimir.OnPressedState.BorderRadius = 1;
            this.btnImprimir.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnImprimir.OnPressedState.BorderThickness = 1;
            this.btnImprimir.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnImprimir.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.OnPressedState.IconLeftImage = null;
            this.btnImprimir.OnPressedState.IconRightImage = null;
            this.btnImprimir.Size = new System.Drawing.Size(187, 39);
            this.btnImprimir.TabIndex = 285;
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImprimir.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnImprimir.TextMarginLeft = 0;
            this.btnImprimir.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnImprimir.UseDefaultRadiusAndThickness = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.AllowAnimations = true;
            this.btnSelecionar.AllowMouseEffects = true;
            this.btnSelecionar.AllowToggling = false;
            this.btnSelecionar.AnimationSpeed = 200;
            this.btnSelecionar.AutoGenerateColors = false;
            this.btnSelecionar.AutoRoundBorders = false;
            this.btnSelecionar.AutoSizeLeftIcon = true;
            this.btnSelecionar.AutoSizeRightIcon = true;
            this.btnSelecionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSelecionar.BackColor1 = System.Drawing.Color.Transparent;
            this.btnSelecionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelecionar.BackgroundImage")));
            this.btnSelecionar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSelecionar.ButtonText = "(F10) Selecionar";
            this.btnSelecionar.ButtonTextMarginLeft = 0;
            this.btnSelecionar.ColorContrastOnClick = 45;
            this.btnSelecionar.ColorContrastOnHover = 45;
            this.btnSelecionar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnSelecionar.CustomizableEdges = borderEdges3;
            this.btnSelecionar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSelecionar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSelecionar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSelecionar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSelecionar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSelecionar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.ForeColor = System.Drawing.Color.Black;
            this.btnSelecionar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSelecionar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSelecionar.IconMarginLeft = 11;
            this.btnSelecionar.IconPadding = 10;
            this.btnSelecionar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSelecionar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSelecionar.IconSize = 25;
            this.btnSelecionar.IdleBorderColor = System.Drawing.Color.Black;
            this.btnSelecionar.IdleBorderRadius = 1;
            this.btnSelecionar.IdleBorderThickness = 1;
            this.btnSelecionar.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnSelecionar.IdleIconLeftImage = null;
            this.btnSelecionar.IdleIconRightImage = null;
            this.btnSelecionar.IndicateFocus = false;
            this.btnSelecionar.Location = new System.Drawing.Point(89, 669);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSelecionar.OnDisabledState.BorderRadius = 1;
            this.btnSelecionar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSelecionar.OnDisabledState.BorderThickness = 1;
            this.btnSelecionar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSelecionar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSelecionar.OnDisabledState.IconLeftImage = null;
            this.btnSelecionar.OnDisabledState.IconRightImage = null;
            this.btnSelecionar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSelecionar.onHoverState.BorderRadius = 1;
            this.btnSelecionar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSelecionar.onHoverState.BorderThickness = 1;
            this.btnSelecionar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSelecionar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSelecionar.onHoverState.IconLeftImage = null;
            this.btnSelecionar.onHoverState.IconRightImage = null;
            this.btnSelecionar.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnSelecionar.OnIdleState.BorderRadius = 1;
            this.btnSelecionar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSelecionar.OnIdleState.BorderThickness = 1;
            this.btnSelecionar.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnSelecionar.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnSelecionar.OnIdleState.IconLeftImage = null;
            this.btnSelecionar.OnIdleState.IconRightImage = null;
            this.btnSelecionar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSelecionar.OnPressedState.BorderRadius = 1;
            this.btnSelecionar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSelecionar.OnPressedState.BorderThickness = 1;
            this.btnSelecionar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSelecionar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSelecionar.OnPressedState.IconLeftImage = null;
            this.btnSelecionar.OnPressedState.IconRightImage = null;
            this.btnSelecionar.Size = new System.Drawing.Size(187, 39);
            this.btnSelecionar.TabIndex = 284;
            this.btnSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelecionar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSelecionar.TextMarginLeft = 0;
            this.btnSelecionar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSelecionar.UseDefaultRadiusAndThickness = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
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
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnFechar.CustomizableEdges = borderEdges4;
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
            this.btnFechar.Location = new System.Drawing.Point(678, 669);
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
            this.btnFechar.TabIndex = 283;
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFechar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFechar.TextMarginLeft = 0;
            this.btnFechar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFechar.UseDefaultRadiusAndThickness = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtCodigoDespesa
            // 
            this.txtCodigoDespesa.AcceptsReturn = false;
            this.txtCodigoDespesa.AcceptsTab = false;
            this.txtCodigoDespesa.AnimationSpeed = 200;
            this.txtCodigoDespesa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCodigoDespesa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCodigoDespesa.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigoDespesa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCodigoDespesa.BackgroundImage")));
            this.txtCodigoDespesa.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtCodigoDespesa.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCodigoDespesa.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtCodigoDespesa.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtCodigoDespesa.BorderRadius = 1;
            this.txtCodigoDespesa.BorderThickness = 1;
            this.txtCodigoDespesa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigoDespesa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoDespesa.DefaultFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDespesa.DefaultText = "";
            this.txtCodigoDespesa.FillColor = System.Drawing.Color.White;
            this.txtCodigoDespesa.HideSelection = true;
            this.txtCodigoDespesa.IconLeft = null;
            this.txtCodigoDespesa.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoDespesa.IconPadding = 10;
            this.txtCodigoDespesa.IconRight = null;
            this.txtCodigoDespesa.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoDespesa.Lines = new string[0];
            this.txtCodigoDespesa.Location = new System.Drawing.Point(15, 28);
            this.txtCodigoDespesa.MaxLength = 6;
            this.txtCodigoDespesa.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCodigoDespesa.Modified = false;
            this.txtCodigoDespesa.Multiline = false;
            this.txtCodigoDespesa.Name = "txtCodigoDespesa";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCodigoDespesa.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCodigoDespesa.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCodigoDespesa.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCodigoDespesa.OnIdleState = stateProperties4;
            this.txtCodigoDespesa.Padding = new System.Windows.Forms.Padding(3);
            this.txtCodigoDespesa.PasswordChar = '\0';
            this.txtCodigoDespesa.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtCodigoDespesa.PlaceholderText = "";
            this.txtCodigoDespesa.ReadOnly = false;
            this.txtCodigoDespesa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigoDespesa.SelectedText = "";
            this.txtCodigoDespesa.SelectionLength = 0;
            this.txtCodigoDespesa.SelectionStart = 0;
            this.txtCodigoDespesa.ShortcutsEnabled = true;
            this.txtCodigoDespesa.Size = new System.Drawing.Size(123, 28);
            this.txtCodigoDespesa.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtCodigoDespesa.TabIndex = 252;
            this.txtCodigoDespesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigoDespesa.TextMarginBottom = 0;
            this.txtCodigoDespesa.TextMarginLeft = 3;
            this.txtCodigoDespesa.TextMarginTop = 0;
            this.txtCodigoDespesa.TextPlaceholder = "";
            this.txtCodigoDespesa.UseSystemPasswordChar = false;
            this.txtCodigoDespesa.WordWrap = true;
            this.txtCodigoDespesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoDespesa_KeyPress);
            // 
            // txtDescricao
            // 
            this.txtDescricao.AcceptsReturn = false;
            this.txtDescricao.AcceptsTab = false;
            this.txtDescricao.AnimationSpeed = 200;
            this.txtDescricao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDescricao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDescricao.BackColor = System.Drawing.Color.Transparent;
            this.txtDescricao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtDescricao.BackgroundImage")));
            this.txtDescricao.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtDescricao.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDescricao.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtDescricao.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtDescricao.BorderRadius = 1;
            this.txtDescricao.BorderThickness = 1;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescricao.DefaultFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.DefaultText = "";
            this.txtDescricao.FillColor = System.Drawing.Color.White;
            this.txtDescricao.HideSelection = true;
            this.txtDescricao.IconLeft = null;
            this.txtDescricao.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescricao.IconPadding = 10;
            this.txtDescricao.IconRight = null;
            this.txtDescricao.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescricao.Lines = new string[0];
            this.txtDescricao.Location = new System.Drawing.Point(555, 26);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtDescricao.Modified = false;
            this.txtDescricao.Multiline = false;
            this.txtDescricao.Name = "txtDescricao";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDescricao.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDescricao.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDescricao.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDescricao.OnIdleState = stateProperties8;
            this.txtDescricao.Padding = new System.Windows.Forms.Padding(3);
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDescricao.PlaceholderText = "";
            this.txtDescricao.ReadOnly = false;
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.ShortcutsEnabled = true;
            this.txtDescricao.Size = new System.Drawing.Size(272, 28);
            this.txtDescricao.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtDescricao.TabIndex = 253;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescricao.TextMarginBottom = 0;
            this.txtDescricao.TextMarginLeft = 3;
            this.txtDescricao.TextMarginTop = 0;
            this.txtDescricao.TextPlaceholder = "";
            this.txtDescricao.UseSystemPasswordChar = false;
            this.txtDescricao.WordWrap = true;
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(15, 147);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(907, 14);
            this.bunifuSeparator1.TabIndex = 160;
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
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnPesquisar.CustomizableEdges = borderEdges5;
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
            this.btnPesquisar.Location = new System.Drawing.Point(398, 98);
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
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPesquisar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPesquisar.TextMarginLeft = 0;
            this.btnPesquisar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPesquisar.UseDefaultRadiusAndThickness = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblNumeroLancamentosSelecionados
            // 
            this.lblNumeroLancamentosSelecionados.AutoSize = true;
            this.lblNumeroLancamentosSelecionados.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroLancamentosSelecionados.Location = new System.Drawing.Point(734, 547);
            this.lblNumeroLancamentosSelecionados.Name = "lblNumeroLancamentosSelecionados";
            this.lblNumeroLancamentosSelecionados.Size = new System.Drawing.Size(14, 15);
            this.lblNumeroLancamentosSelecionados.TabIndex = 290;
            this.lblNumeroLancamentosSelecionados.Text = "0";
            // 
            // Forms_PesquisarContasAPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 730);
            this.Controls.Add(this.lblNumeroLancamentosSelecionados);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.cmbTitulo);
            this.Controls.Add(this.btnExportarParaExcel);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblTotalLancamentoSelecionado);
            this.Controls.Add(this.lblNumeroLancamentos);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblVencidas);
            this.Controls.Add(this.lblTotalPagamento);
            this.Controls.Add(this.lblAPagar);
            this.Controls.Add(this.lblPagas);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPagamento);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoDespesa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.gdvContarPagar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bunifuGroupBox1);
            this.Controls.Add(this.bunifuGroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Forms_PesquisarContasAPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Contas a Pagar";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Forms_PesquisarContasAPagar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gdvContarPagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPesquisar;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox txtCodigoDespesa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuTextBox txtDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPagas;
        private System.Windows.Forms.Label lblAPagar;
        private System.Windows.Forms.Label lblTotalPagamento;
        private System.Windows.Forms.Label lblVencidas;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblNumeroLancamentos;
        private System.Windows.Forms.Label lblTotalLancamentoSelecionado;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFechar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExportarParaExcel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnImprimir;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSelecionar;
        public System.Windows.Forms.ComboBox cmbTitulo;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox2;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        public Bunifu.UI.WinForms.BunifuDataGridView gdvContarPagar;
        private System.Windows.Forms.Label lblNumeroLancamentosSelecionados;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_fornecedor_titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_frequencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_quantidade_parcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_valor_parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_estatus_pagamento;
        private System.Windows.Forms.DataGridViewImageColumn dc_imagem_pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_valor_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_data_pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_desconto_taxas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_juros_multa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_verificar;
    }
}