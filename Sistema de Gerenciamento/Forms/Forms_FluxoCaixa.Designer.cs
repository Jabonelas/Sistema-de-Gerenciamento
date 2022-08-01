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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.gdvFluxoCaixa = new Bunifu.UI.WinForms.BunifuDataGridView();
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
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblComissao = new System.Windows.Forms.Label();
            this.btnPesquisar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
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
            this.gdvFluxoCaixa.Size = new System.Drawing.Size(773, 305);
            this.gdvFluxoCaixa.TabIndex = 277;
            this.gdvFluxoCaixa.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
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
            this.label1.Location = new System.Drawing.Point(55, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 290;
            this.label1.Text = "Valor Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 291;
            this.label2.Text = "Comissão";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(132, 520);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(48, 15);
            this.lblValorTotal.TabIndex = 292;
            this.lblValorTotal.Text = "R$ 0,00";
            // 
            // lblComissao
            // 
            this.lblComissao.AutoSize = true;
            this.lblComissao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComissao.Location = new System.Drawing.Point(468, 520);
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
            this.btnPesquisar.ButtonText = "Pesquisar";
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
            this.btnPesquisar.Location = new System.Drawing.Point(301, 110);
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
            this.bunifuSeparator1.Size = new System.Drawing.Size(773, 14);
            this.bunifuSeparator1.TabIndex = 295;
            this.bunifuSeparator1.Click += new System.EventHandler(this.bunifuSeparator1_Click);
            // 
            // Forms_FluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
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
            this.Name = "Forms_FluxoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fluxo Caixa";
            this.Load += new System.EventHandler(this.Forms_FluxoCaixa_Load);
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
        public System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblComissao;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPesquisar;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
    }
}