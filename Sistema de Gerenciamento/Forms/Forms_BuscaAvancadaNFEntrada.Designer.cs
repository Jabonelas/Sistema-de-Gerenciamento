
namespace Sistema_de_Gerenciamento.Forms
{
    partial class Forms_BuscaAvancadaNFEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forms_BuscaAvancadaNFEntrada));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.btnPesquisar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.gdvBuscaAvancadaNFEntrada = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ep_nf_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ep_codigo_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ep_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ep_unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ne_quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ne_valor_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ne_valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ep_data_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ep_data_exclusao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFechar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnExportar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnImprimir = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBuscaAvancadaNFEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(184, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 275;
            this.label10.Text = "Data Final";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 274;
            this.label9.Text = "Data Inicial";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(187, 51);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(123, 23);
            this.dtpDataFinal.TabIndex = 273;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(38, 51);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(123, 23);
            this.dtpDataInicial.TabIndex = 271;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 270;
            this.label4.Text = "Período";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(163, 41);
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
            this.bunifuGroupBox1.Location = new System.Drawing.Point(12, 24);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(326, 64);
            this.bunifuGroupBox1.TabIndex = 276;
            this.bunifuGroupBox1.TabStop = false;
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
            this.btnPesquisar.Location = new System.Drawing.Point(441, 51);
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
            this.btnPesquisar.TabIndex = 277;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPesquisar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPesquisar.TextMarginLeft = 0;
            this.btnPesquisar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPesquisar.UseDefaultRadiusAndThickness = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // gdvBuscaAvancadaNFEntrada
            // 
            this.gdvBuscaAvancadaNFEntrada.AllowCustomTheming = false;
            this.gdvBuscaAvancadaNFEntrada.AllowUserToAddRows = false;
            this.gdvBuscaAvancadaNFEntrada.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gdvBuscaAvancadaNFEntrada.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvBuscaAvancadaNFEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvBuscaAvancadaNFEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvBuscaAvancadaNFEntrada.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvBuscaAvancadaNFEntrada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvBuscaAvancadaNFEntrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdvBuscaAvancadaNFEntrada.ColumnHeadersHeight = 40;
            this.gdvBuscaAvancadaNFEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ep_nf_entrada,
            this.ep_codigo_produto,
            this.ep_descricao,
            this.ep_unidade,
            this.ne_quantidade,
            this.ne_valor_unitario,
            this.ne_valor_total,
            this.ep_data_entrada,
            this.ep_data_exclusao});
            this.gdvBuscaAvancadaNFEntrada.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gdvBuscaAvancadaNFEntrada.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gdvBuscaAvancadaNFEntrada.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gdvBuscaAvancadaNFEntrada.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gdvBuscaAvancadaNFEntrada.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gdvBuscaAvancadaNFEntrada.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.gdvBuscaAvancadaNFEntrada.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gdvBuscaAvancadaNFEntrada.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gdvBuscaAvancadaNFEntrada.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gdvBuscaAvancadaNFEntrada.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdvBuscaAvancadaNFEntrada.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.gdvBuscaAvancadaNFEntrada.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gdvBuscaAvancadaNFEntrada.CurrentTheme.Name = null;
            this.gdvBuscaAvancadaNFEntrada.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvBuscaAvancadaNFEntrada.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gdvBuscaAvancadaNFEntrada.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gdvBuscaAvancadaNFEntrada.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gdvBuscaAvancadaNFEntrada.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvBuscaAvancadaNFEntrada.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdvBuscaAvancadaNFEntrada.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.gdvBuscaAvancadaNFEntrada.EnableHeadersVisualStyles = false;
            this.gdvBuscaAvancadaNFEntrada.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gdvBuscaAvancadaNFEntrada.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gdvBuscaAvancadaNFEntrada.HeaderBgColor = System.Drawing.Color.Empty;
            this.gdvBuscaAvancadaNFEntrada.HeaderForeColor = System.Drawing.Color.White;
            this.gdvBuscaAvancadaNFEntrada.Location = new System.Drawing.Point(12, 133);
            this.gdvBuscaAvancadaNFEntrada.Name = "gdvBuscaAvancadaNFEntrada";
            this.gdvBuscaAvancadaNFEntrada.ReadOnly = true;
            this.gdvBuscaAvancadaNFEntrada.RowHeadersVisible = false;
            this.gdvBuscaAvancadaNFEntrada.RowTemplate.Height = 40;
            this.gdvBuscaAvancadaNFEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvBuscaAvancadaNFEntrada.Size = new System.Drawing.Size(1001, 305);
            this.gdvBuscaAvancadaNFEntrada.TabIndex = 278;
            this.gdvBuscaAvancadaNFEntrada.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // ep_nf_entrada
            // 
            this.ep_nf_entrada.DataPropertyName = "ep_nf_entrada";
            this.ep_nf_entrada.FillWeight = 54.82234F;
            this.ep_nf_entrada.HeaderText = "Nº NF";
            this.ep_nf_entrada.Name = "ep_nf_entrada";
            this.ep_nf_entrada.ReadOnly = true;
            // 
            // ep_codigo_produto
            // 
            this.ep_codigo_produto.DataPropertyName = "ep_codigo_produto";
            this.ep_codigo_produto.FillWeight = 94.57654F;
            this.ep_codigo_produto.HeaderText = "Cod. Prod.";
            this.ep_codigo_produto.Name = "ep_codigo_produto";
            this.ep_codigo_produto.ReadOnly = true;
            // 
            // ep_descricao
            // 
            this.ep_descricao.DataPropertyName = "ep_descricao";
            this.ep_descricao.FillWeight = 116.9625F;
            this.ep_descricao.HeaderText = "Descriçao";
            this.ep_descricao.Name = "ep_descricao";
            this.ep_descricao.ReadOnly = true;
            // 
            // ep_unidade
            // 
            this.ep_unidade.DataPropertyName = "ep_unidade";
            this.ep_unidade.FillWeight = 58.10954F;
            this.ep_unidade.HeaderText = "UN";
            this.ep_unidade.Name = "ep_unidade";
            this.ep_unidade.ReadOnly = true;
            // 
            // ne_quantidade
            // 
            this.ne_quantidade.DataPropertyName = "ne_quantidade";
            this.ne_quantidade.FillWeight = 107.6792F;
            this.ne_quantidade.HeaderText = "Qtd.";
            this.ne_quantidade.Name = "ne_quantidade";
            this.ne_quantidade.ReadOnly = true;
            // 
            // ne_valor_unitario
            // 
            this.ne_valor_unitario.DataPropertyName = "ne_valor_unitario";
            this.ne_valor_unitario.FillWeight = 116.9625F;
            this.ne_valor_unitario.HeaderText = "Valor Uni.";
            this.ne_valor_unitario.Name = "ne_valor_unitario";
            this.ne_valor_unitario.ReadOnly = true;
            // 
            // ne_valor_total
            // 
            this.ne_valor_total.DataPropertyName = "ne_valor_total";
            this.ne_valor_total.FillWeight = 116.9625F;
            this.ne_valor_total.HeaderText = "Valor Total";
            this.ne_valor_total.Name = "ne_valor_total";
            this.ne_valor_total.ReadOnly = true;
            // 
            // ep_data_entrada
            // 
            this.ep_data_entrada.DataPropertyName = "ep_data_entrada";
            this.ep_data_entrada.FillWeight = 116.9625F;
            this.ep_data_entrada.HeaderText = "Data Entrada";
            this.ep_data_entrada.Name = "ep_data_entrada";
            this.ep_data_entrada.ReadOnly = true;
            // 
            // ep_data_exclusao
            // 
            this.ep_data_exclusao.DataPropertyName = "ep_data_exclusao";
            this.ep_data_exclusao.FillWeight = 116.9625F;
            this.ep_data_exclusao.HeaderText = "Data Exclusão";
            this.ep_data_exclusao.Name = "ep_data_exclusao";
            this.ep_data_exclusao.ReadOnly = true;
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
            this.btnFechar.Location = new System.Drawing.Point(714, 462);
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
            this.btnFechar.TabIndex = 282;
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFechar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFechar.TextMarginLeft = 0;
            this.btnFechar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFechar.UseDefaultRadiusAndThickness = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.AllowAnimations = true;
            this.btnExportar.AllowMouseEffects = true;
            this.btnExportar.AllowToggling = false;
            this.btnExportar.AnimationSpeed = 200;
            this.btnExportar.AutoGenerateColors = false;
            this.btnExportar.AutoRoundBorders = false;
            this.btnExportar.AutoSizeLeftIcon = true;
            this.btnExportar.AutoSizeRightIcon = true;
            this.btnExportar.BackColor = System.Drawing.Color.Transparent;
            this.btnExportar.BackColor1 = System.Drawing.Color.Transparent;
            this.btnExportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportar.BackgroundImage")));
            this.btnExportar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportar.ButtonText = "(Ctrl + E) Exportar para o Excel \r\nRelação Nota Fiscal";
            this.btnExportar.ButtonTextMarginLeft = 0;
            this.btnExportar.ColorContrastOnClick = 45;
            this.btnExportar.ColorContrastOnHover = 45;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnExportar.CustomizableEdges = borderEdges3;
            this.btnExportar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExportar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExportar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExportar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExportar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnExportar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.Black;
            this.btnExportar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExportar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExportar.IconMarginLeft = 11;
            this.btnExportar.IconPadding = 10;
            this.btnExportar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExportar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExportar.IconSize = 25;
            this.btnExportar.IdleBorderColor = System.Drawing.Color.Black;
            this.btnExportar.IdleBorderRadius = 1;
            this.btnExportar.IdleBorderThickness = 1;
            this.btnExportar.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnExportar.IdleIconLeftImage = null;
            this.btnExportar.IdleIconRightImage = null;
            this.btnExportar.IndicateFocus = false;
            this.btnExportar.Location = new System.Drawing.Point(425, 462);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExportar.OnDisabledState.BorderRadius = 1;
            this.btnExportar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportar.OnDisabledState.BorderThickness = 1;
            this.btnExportar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExportar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExportar.OnDisabledState.IconLeftImage = null;
            this.btnExportar.OnDisabledState.IconRightImage = null;
            this.btnExportar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnExportar.onHoverState.BorderRadius = 1;
            this.btnExportar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportar.onHoverState.BorderThickness = 1;
            this.btnExportar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnExportar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnExportar.onHoverState.IconLeftImage = null;
            this.btnExportar.onHoverState.IconRightImage = null;
            this.btnExportar.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnExportar.OnIdleState.BorderRadius = 1;
            this.btnExportar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportar.OnIdleState.BorderThickness = 1;
            this.btnExportar.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnExportar.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnExportar.OnIdleState.IconLeftImage = null;
            this.btnExportar.OnIdleState.IconRightImage = null;
            this.btnExportar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExportar.OnPressedState.BorderRadius = 1;
            this.btnExportar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportar.OnPressedState.BorderThickness = 1;
            this.btnExportar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExportar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExportar.OnPressedState.IconLeftImage = null;
            this.btnExportar.OnPressedState.IconRightImage = null;
            this.btnExportar.Size = new System.Drawing.Size(187, 39);
            this.btnExportar.TabIndex = 281;
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExportar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExportar.TextMarginLeft = 0;
            this.btnExportar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnExportar.UseDefaultRadiusAndThickness = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
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
            this.btnImprimir.ButtonText = "(Ctrl + P) Imprimir \r\nRelação Nota Fiscal";
            this.btnImprimir.ButtonTextMarginLeft = 0;
            this.btnImprimir.ColorContrastOnClick = 45;
            this.btnImprimir.ColorContrastOnHover = 45;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnImprimir.CustomizableEdges = borderEdges4;
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
            this.btnImprimir.Location = new System.Drawing.Point(123, 462);
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
            this.btnImprimir.TabIndex = 280;
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImprimir.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnImprimir.TextMarginLeft = 0;
            this.btnImprimir.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnImprimir.UseDefaultRadiusAndThickness = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Forms_BuscaAvancadaNFEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 525);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gdvBuscaAvancadaNFEntrada);
            this.Controls.Add(this.btnPesquisar);
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
            this.Name = "Forms_BuscaAvancadaNFEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Avançada";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Forms_BuscaAvancadaNFEntrada_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gdvBuscaAvancadaNFEntrada)).EndInit();
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPesquisar;
        public Bunifu.UI.WinForms.BunifuDataGridView gdvBuscaAvancadaNFEntrada;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFechar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExportar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ep_nf_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ep_codigo_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ep_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ep_unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ne_quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ne_valor_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ne_valor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn ep_data_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ep_data_exclusao;
    }
}