namespace Sistema_de_Gerenciamento.Forms
{
    partial class Forms_PesquisarDespesaCustos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forms_PesquisarDespesaCustos));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.gdvPesquisarDespesa = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dc_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_fornecedor_titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_frequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_quantidade_parcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_valor_parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_imagem_pagamento = new System.Windows.Forms.DataGridViewImageColumn();
            this.dc_estatus_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_data_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_desconto_taxas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_juros_multa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc_valor_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoDespesa = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtTitulo = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btnFechar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnExportarParaExcel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnImprimir = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSelecionar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtCodigoDespesa = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnPesquisar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtDescricao = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblEstatusPagamento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPesquisarDespesa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 202;
            this.label1.Text = "Titulo";
            // 
            // gdvPesquisarDespesa
            // 
            this.gdvPesquisarDespesa.AllowCustomTheming = false;
            this.gdvPesquisarDespesa.AllowUserToAddRows = false;
            this.gdvPesquisarDespesa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gdvPesquisarDespesa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvPesquisarDespesa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvPesquisarDespesa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvPesquisarDespesa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvPesquisarDespesa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvPesquisarDespesa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdvPesquisarDespesa.ColumnHeadersHeight = 40;
            this.gdvPesquisarDespesa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dc_codigo,
            this.dc_id,
            this.dc_tipo,
            this.dc_fornecedor_titulo,
            this.dc_descricao,
            this.dc_emissao,
            this.dc_vencimento,
            this.dc_frequencia,
            this.dc_valor,
            this.dc_quantidade_parcelas,
            this.dc_valor_parcela,
            this.dc_categoria,
            this.dc_cnpj,
            this.dc_imagem_pagamento,
            this.dc_estatus_pagamento,
            this.dc_data_pagamento,
            this.dc_desconto_taxas,
            this.dc_juros_multa,
            this.dc_valor_pago});
            this.gdvPesquisarDespesa.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gdvPesquisarDespesa.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gdvPesquisarDespesa.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gdvPesquisarDespesa.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gdvPesquisarDespesa.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gdvPesquisarDespesa.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.gdvPesquisarDespesa.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gdvPesquisarDespesa.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gdvPesquisarDespesa.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gdvPesquisarDespesa.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdvPesquisarDespesa.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.gdvPesquisarDespesa.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gdvPesquisarDespesa.CurrentTheme.Name = null;
            this.gdvPesquisarDespesa.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvPesquisarDespesa.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gdvPesquisarDespesa.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gdvPesquisarDespesa.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gdvPesquisarDespesa.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvPesquisarDespesa.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdvPesquisarDespesa.EnableHeadersVisualStyles = false;
            this.gdvPesquisarDespesa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gdvPesquisarDespesa.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gdvPesquisarDespesa.HeaderBgColor = System.Drawing.Color.Empty;
            this.gdvPesquisarDespesa.HeaderForeColor = System.Drawing.Color.White;
            this.gdvPesquisarDespesa.Location = new System.Drawing.Point(12, 155);
            this.gdvPesquisarDespesa.Name = "gdvPesquisarDespesa";
            this.gdvPesquisarDespesa.ReadOnly = true;
            this.gdvPesquisarDespesa.RowHeadersVisible = false;
            this.gdvPesquisarDespesa.RowHeadersWidth = 50;
            this.gdvPesquisarDespesa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvPesquisarDespesa.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gdvPesquisarDespesa.RowTemplate.Height = 40;
            this.gdvPesquisarDespesa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvPesquisarDespesa.Size = new System.Drawing.Size(850, 267);
            this.gdvPesquisarDespesa.TabIndex = 193;
            this.gdvPesquisarDespesa.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.gdvPesquisarDespesa.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gdvPesquisarDespesa_MouseDoubleClick);
            // 
            // dc_codigo
            // 
            this.dc_codigo.DataPropertyName = "dc_codigo";
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
            // dc_tipo
            // 
            this.dc_tipo.DataPropertyName = "dc_tipo";
            this.dc_tipo.HeaderText = "Tipo";
            this.dc_tipo.Name = "dc_tipo";
            this.dc_tipo.ReadOnly = true;
            // 
            // dc_fornecedor_titulo
            // 
            this.dc_fornecedor_titulo.DataPropertyName = "dc_fornecedor_titulo";
            this.dc_fornecedor_titulo.HeaderText = "Titulo";
            this.dc_fornecedor_titulo.Name = "dc_fornecedor_titulo";
            this.dc_fornecedor_titulo.ReadOnly = true;
            // 
            // dc_descricao
            // 
            this.dc_descricao.DataPropertyName = "dc_descricao";
            this.dc_descricao.HeaderText = "Descricao";
            this.dc_descricao.Name = "dc_descricao";
            this.dc_descricao.ReadOnly = true;
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
            this.dc_vencimento.HeaderText = "dc_vencimento";
            this.dc_vencimento.Name = "dc_vencimento";
            this.dc_vencimento.ReadOnly = true;
            this.dc_vencimento.Visible = false;
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
            this.dc_valor.HeaderText = "Valor";
            this.dc_valor.Name = "dc_valor";
            this.dc_valor.ReadOnly = true;
            // 
            // dc_quantidade_parcelas
            // 
            this.dc_quantidade_parcelas.DataPropertyName = "dc_quantidade_parcelas";
            this.dc_quantidade_parcelas.HeaderText = "dc_quantidade_parcelas";
            this.dc_quantidade_parcelas.Name = "dc_quantidade_parcelas";
            this.dc_quantidade_parcelas.ReadOnly = true;
            this.dc_quantidade_parcelas.Visible = false;
            // 
            // dc_valor_parcela
            // 
            this.dc_valor_parcela.DataPropertyName = "dc_valor_parcela";
            this.dc_valor_parcela.HeaderText = "dc_valor_parcela";
            this.dc_valor_parcela.Name = "dc_valor_parcela";
            this.dc_valor_parcela.ReadOnly = true;
            this.dc_valor_parcela.Visible = false;
            // 
            // dc_categoria
            // 
            this.dc_categoria.DataPropertyName = "dc_categoria";
            this.dc_categoria.HeaderText = "dc_categoria";
            this.dc_categoria.Name = "dc_categoria";
            this.dc_categoria.ReadOnly = true;
            this.dc_categoria.Visible = false;
            // 
            // dc_cnpj
            // 
            this.dc_cnpj.DataPropertyName = "dc_cnpj";
            this.dc_cnpj.HeaderText = "dc_cnpj";
            this.dc_cnpj.Name = "dc_cnpj";
            this.dc_cnpj.ReadOnly = true;
            this.dc_cnpj.Visible = false;
            // 
            // dc_imagem_pagamento
            // 
            this.dc_imagem_pagamento.DataPropertyName = "dc_imagem_pagamento";
            this.dc_imagem_pagamento.HeaderText = "Imagem Pagamento";
            this.dc_imagem_pagamento.Name = "dc_imagem_pagamento";
            this.dc_imagem_pagamento.ReadOnly = true;
            this.dc_imagem_pagamento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dc_imagem_pagamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dc_imagem_pagamento.Visible = false;
            // 
            // dc_estatus_pagamento
            // 
            this.dc_estatus_pagamento.DataPropertyName = "dc_estatus_pagamento";
            this.dc_estatus_pagamento.HeaderText = "Pagamento";
            this.dc_estatus_pagamento.Name = "dc_estatus_pagamento";
            this.dc_estatus_pagamento.ReadOnly = true;
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
            // dc_valor_pago
            // 
            this.dc_valor_pago.DataPropertyName = "dc_valor_pago";
            this.dc_valor_pago.HeaderText = "dc_valor_pago";
            this.dc_valor_pago.Name = "dc_valor_pago";
            this.dc_valor_pago.ReadOnly = true;
            this.dc_valor_pago.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 200;
            this.label8.Text = "Código";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(533, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 198;
            this.label6.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(181, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 199;
            this.label5.Text = "Tipo";
            // 
            // cmbTipoDespesa
            // 
            this.cmbTipoDespesa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoDespesa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoDespesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDespesa.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoDespesa.FormattingEnabled = true;
            this.cmbTipoDespesa.Items.AddRange(new object[] {
            "Fixa",
            "Variavel",
            ""});
            this.cmbTipoDespesa.Location = new System.Drawing.Point(184, 38);
            this.cmbTipoDespesa.Name = "cmbTipoDespesa";
            this.cmbTipoDespesa.Size = new System.Drawing.Size(92, 23);
            this.cmbTipoDespesa.TabIndex = 240;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(813, 9);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(49, 13);
            this.lblCategoria.TabIndex = 250;
            this.lblCategoria.Text = "Despesa";
            this.lblCategoria.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtTitulo
            // 
            this.txtTitulo.AcceptsReturn = false;
            this.txtTitulo.AcceptsTab = false;
            this.txtTitulo.AnimationSpeed = 200;
            this.txtTitulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTitulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTitulo.BackColor = System.Drawing.Color.Transparent;
            this.txtTitulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTitulo.BackgroundImage")));
            this.txtTitulo.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTitulo.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTitulo.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTitulo.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTitulo.BorderRadius = 1;
            this.txtTitulo.BorderThickness = 1;
            this.txtTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTitulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitulo.DefaultFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.DefaultText = "";
            this.txtTitulo.FillColor = System.Drawing.Color.White;
            this.txtTitulo.HideSelection = true;
            this.txtTitulo.IconLeft = null;
            this.txtTitulo.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitulo.IconPadding = 10;
            this.txtTitulo.IconRight = null;
            this.txtTitulo.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitulo.Lines = new string[0];
            this.txtTitulo.Location = new System.Drawing.Point(331, 35);
            this.txtTitulo.MaxLength = 32767;
            this.txtTitulo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTitulo.Modified = false;
            this.txtTitulo.Multiline = false;
            this.txtTitulo.Name = "txtTitulo";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTitulo.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTitulo.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTitulo.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTitulo.OnIdleState = stateProperties4;
            this.txtTitulo.Padding = new System.Windows.Forms.Padding(3);
            this.txtTitulo.PasswordChar = '\0';
            this.txtTitulo.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTitulo.PlaceholderText = "";
            this.txtTitulo.ReadOnly = false;
            this.txtTitulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.SelectionLength = 0;
            this.txtTitulo.SelectionStart = 0;
            this.txtTitulo.ShortcutsEnabled = true;
            this.txtTitulo.Size = new System.Drawing.Size(158, 28);
            this.txtTitulo.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtTitulo.TabIndex = 251;
            this.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTitulo.TextMarginBottom = 0;
            this.txtTitulo.TextMarginLeft = 3;
            this.txtTitulo.TextMarginTop = 0;
            this.txtTitulo.TextPlaceholder = "";
            this.txtTitulo.UseSystemPasswordChar = false;
            this.txtTitulo.WordWrap = true;
            this.txtTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTitulo_KeyPress);
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 132);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(847, 20);
            this.bunifuSeparator1.TabIndex = 201;
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
            this.btnFechar.Location = new System.Drawing.Point(640, 445);
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
            this.btnFechar.TabIndex = 197;
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFechar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFechar.TextMarginLeft = 0;
            this.btnFechar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFechar.UseDefaultRadiusAndThickness = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
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
            this.btnExportarParaExcel.ButtonText = "(Ctrl + E) Exportar para o Excel \r\nRelação Nota Fiscal Saida";
            this.btnExportarParaExcel.ButtonTextMarginLeft = 0;
            this.btnExportarParaExcel.ColorContrastOnClick = 45;
            this.btnExportarParaExcel.ColorContrastOnHover = 45;
            this.btnExportarParaExcel.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnExportarParaExcel.CustomizableEdges = borderEdges2;
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
            this.btnExportarParaExcel.Location = new System.Drawing.Point(444, 445);
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
            this.btnExportarParaExcel.TabIndex = 196;
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
            this.btnImprimir.ButtonText = "(Ctrl + P) Imprimir \r\nRelação das Despesas";
            this.btnImprimir.ButtonTextMarginLeft = 0;
            this.btnImprimir.ColorContrastOnClick = 45;
            this.btnImprimir.ColorContrastOnHover = 45;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnImprimir.CustomizableEdges = borderEdges3;
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
            this.btnImprimir.Location = new System.Drawing.Point(247, 445);
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
            this.btnImprimir.TabIndex = 195;
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
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnSelecionar.CustomizableEdges = borderEdges4;
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
            this.btnSelecionar.Location = new System.Drawing.Point(50, 445);
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
            this.btnSelecionar.TabIndex = 194;
            this.btnSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelecionar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSelecionar.TextMarginLeft = 0;
            this.btnSelecionar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSelecionar.UseDefaultRadiusAndThickness = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
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
            this.txtCodigoDespesa.Location = new System.Drawing.Point(12, 35);
            this.txtCodigoDespesa.MaxLength = 6;
            this.txtCodigoDespesa.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCodigoDespesa.Modified = false;
            this.txtCodigoDespesa.Multiline = false;
            this.txtCodigoDespesa.Name = "txtCodigoDespesa";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCodigoDespesa.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCodigoDespesa.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCodigoDespesa.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCodigoDespesa.OnIdleState = stateProperties8;
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
            this.txtCodigoDespesa.TabIndex = 189;
            this.txtCodigoDespesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigoDespesa.TextMarginBottom = 0;
            this.txtCodigoDespesa.TextMarginLeft = 3;
            this.txtCodigoDespesa.TextMarginTop = 0;
            this.txtCodigoDespesa.TextPlaceholder = "";
            this.txtCodigoDespesa.UseSystemPasswordChar = false;
            this.txtCodigoDespesa.WordWrap = true;
            this.txtCodigoDespesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoDespesa_KeyPress);
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
            this.btnPesquisar.Location = new System.Drawing.Point(340, 90);
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
            this.btnPesquisar.TabIndex = 192;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPesquisar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPesquisar.TextMarginLeft = 0;
            this.btnPesquisar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPesquisar.UseDefaultRadiusAndThickness = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
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
            this.txtDescricao.Location = new System.Drawing.Point(536, 35);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtDescricao.Modified = false;
            this.txtDescricao.Multiline = false;
            this.txtDescricao.Name = "txtDescricao";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDescricao.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDescricao.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDescricao.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDescricao.OnIdleState = stateProperties12;
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
            this.txtDescricao.Size = new System.Drawing.Size(326, 28);
            this.txtDescricao.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtDescricao.TabIndex = 190;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescricao.TextMarginBottom = 0;
            this.txtDescricao.TextMarginLeft = 3;
            this.txtDescricao.TextMarginTop = 0;
            this.txtDescricao.TextPlaceholder = "";
            this.txtDescricao.UseSystemPasswordChar = false;
            this.txtDescricao.WordWrap = true;
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
            // 
            // lblEstatusPagamento
            // 
            this.lblEstatusPagamento.AutoSize = true;
            this.lblEstatusPagamento.Location = new System.Drawing.Point(752, 9);
            this.lblEstatusPagamento.Name = "lblEstatusPagamento";
            this.lblEstatusPagamento.Size = new System.Drawing.Size(55, 13);
            this.lblEstatusPagamento.TabIndex = 252;
            this.lblEstatusPagamento.Text = "Nao Pago";
            this.lblEstatusPagamento.Visible = false;
            // 
            // Forms_PesquisarDespesaCustos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 502);
            this.Controls.Add(this.lblEstatusPagamento);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cmbTipoDespesa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExportarParaExcel);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.gdvPesquisarDespesa);
            this.Controls.Add(this.txtCodigoDespesa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Forms_PesquisarDespesaCustos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pesquisar Despesa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Forms_PesquisarDespesaCustos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gdvPesquisarDespesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFechar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExportarParaExcel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnImprimir;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSelecionar;
        private Bunifu.UI.WinForms.BunifuDataGridView gdvPesquisarDespesa;
        private Bunifu.UI.WinForms.BunifuTextBox txtCodigoDespesa;
        private System.Windows.Forms.Label label8;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPesquisar;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuTextBox txtDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoDespesa;
        private System.Windows.Forms.Label lblCategoria;
        private Bunifu.UI.WinForms.BunifuTextBox txtTitulo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblEstatusPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_fornecedor_titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_frequencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_quantidade_parcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_valor_parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_cnpj;
        private System.Windows.Forms.DataGridViewImageColumn dc_imagem_pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_estatus_pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_data_pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_desconto_taxas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_juros_multa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc_valor_pago;
    }
}