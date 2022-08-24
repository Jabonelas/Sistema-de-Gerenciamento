namespace Sistema_de_Gerenciamento.Forms
{
    partial class Forms_EstatisticasFinanceiras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forms_EstatisticasFinanceiras));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.chkValorLiquido = new DevExpress.XtraEditors.CheckEdit();
            this.chkValorContasPagas = new DevExpress.XtraEditors.CheckEdit();
            this.chkValorContasAReceber = new DevExpress.XtraEditors.CheckEdit();
            this.chkValorContasAPagar = new DevExpress.XtraEditors.CheckEdit();
            this.chkValorProduto = new DevExpress.XtraEditors.CheckEdit();
            this.chkValorBruto = new DevExpress.XtraEditors.CheckEdit();
            this.chrEstatisicasFinanceiras = new DevExpress.XtraCharts.ChartControl();
            this.tb_NotaFiscalSaidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.btnPesquisar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorLiquido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorContasPagas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorContasAReceber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorContasAPagar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorBruto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrEstatisicasFinanceiras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_NotaFiscalSaidaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(179, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 277;
            this.label10.Text = "Data Final";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 276;
            this.label9.Text = "Data Inicial";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(182, 50);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(123, 23);
            this.dtpDataFinal.TabIndex = 275;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(33, 50);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(123, 23);
            this.dtpDataInicial.TabIndex = 273;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 272;
            this.label4.Text = "Período";
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(7, 88);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(932, 14);
            this.bunifuSeparator1.TabIndex = 271;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(158, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 36);
            this.label7.TabIndex = 274;
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
            this.bunifuGroupBox1.Location = new System.Drawing.Point(7, 23);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(326, 64);
            this.bunifuGroupBox1.TabIndex = 278;
            this.bunifuGroupBox1.TabStop = false;
            // 
            // chkValorLiquido
            // 
            this.chkValorLiquido.Location = new System.Drawing.Point(764, 321);
            this.chkValorLiquido.Name = "chkValorLiquido";
            this.chkValorLiquido.Properties.Caption = "Valor Liquido";
            this.chkValorLiquido.Size = new System.Drawing.Size(88, 20);
            this.chkValorLiquido.TabIndex = 311;
            this.chkValorLiquido.CheckedChanged += new System.EventHandler(this.chkValorLiquido_CheckedChanged);
            // 
            // chkValorContasPagas
            // 
            this.chkValorContasPagas.Location = new System.Drawing.Point(764, 407);
            this.chkValorContasPagas.Name = "chkValorContasPagas";
            this.chkValorContasPagas.Properties.Caption = "Valor Contas Pagas";
            this.chkValorContasPagas.Size = new System.Drawing.Size(128, 20);
            this.chkValorContasPagas.TabIndex = 310;
            this.chkValorContasPagas.CheckedChanged += new System.EventHandler(this.chkValorContasPagas_CheckedChanged);
            // 
            // chkValorContasAReceber
            // 
            this.chkValorContasAReceber.Location = new System.Drawing.Point(764, 502);
            this.chkValorContasAReceber.Name = "chkValorContasAReceber";
            this.chkValorContasAReceber.Properties.Caption = "Valor Contas A Receber";
            this.chkValorContasAReceber.Size = new System.Drawing.Size(143, 20);
            this.chkValorContasAReceber.TabIndex = 309;
            this.chkValorContasAReceber.CheckedChanged += new System.EventHandler(this.chkValorContasAReceber_CheckedChanged);
            // 
            // chkValorContasAPagar
            // 
            this.chkValorContasAPagar.Location = new System.Drawing.Point(764, 456);
            this.chkValorContasAPagar.Name = "chkValorContasAPagar";
            this.chkValorContasAPagar.Properties.Caption = "Valor Contas A Pagar";
            this.chkValorContasAPagar.Size = new System.Drawing.Size(128, 20);
            this.chkValorContasAPagar.TabIndex = 308;
            this.chkValorContasAPagar.CheckedChanged += new System.EventHandler(this.chkValorContasAPagar_CheckedChanged);
            // 
            // chkValorProduto
            // 
            this.chkValorProduto.Location = new System.Drawing.Point(764, 362);
            this.chkValorProduto.Name = "chkValorProduto";
            this.chkValorProduto.Properties.Caption = "Valor Produto";
            this.chkValorProduto.Size = new System.Drawing.Size(101, 20);
            this.chkValorProduto.TabIndex = 307;
            this.chkValorProduto.CheckedChanged += new System.EventHandler(this.chkValorProduto_CheckedChanged);
            // 
            // chkValorBruto
            // 
            this.chkValorBruto.Location = new System.Drawing.Point(764, 278);
            this.chkValorBruto.Name = "chkValorBruto";
            this.chkValorBruto.Properties.Caption = "Valor Bruto";
            this.chkValorBruto.Size = new System.Drawing.Size(91, 20);
            this.chkValorBruto.TabIndex = 306;
            this.chkValorBruto.CheckedChanged += new System.EventHandler(this.chkValorBruto_CheckedChanged);
            // 
            // chrEstatisicasFinanceiras
            // 
            this.chrEstatisicasFinanceiras.DataSource = this.tb_NotaFiscalSaidaBindingSource;
            this.chrEstatisicasFinanceiras.Location = new System.Drawing.Point(12, 108);
            this.chrEstatisicasFinanceiras.Name = "chrEstatisicasFinanceiras";
            this.chrEstatisicasFinanceiras.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chrEstatisicasFinanceiras.Size = new System.Drawing.Size(913, 438);
            this.chrEstatisicasFinanceiras.TabIndex = 312;
            // 
            // tb_NotaFiscalSaidaBindingSource
            // 
            this.tb_NotaFiscalSaidaBindingSource.DataMember = "tb_NotaFiscalSaida";
            this.tb_NotaFiscalSaidaBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_SistemaGerenciamento_Connection 3";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression3.ColumnName = "ns_valor_pago";
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"503\" />";
            table2.Name = "tb_NotaFiscalSaida";
            columnExpression3.Table = table2;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "ns_emissao";
            columnExpression4.Table = table2;
            column4.Expression = columnExpression4;
            selectQuery2.Columns.Add(column3);
            selectQuery2.Columns.Add(column4);
            selectQuery2.Name = "tb_NotaFiscalSaida";
            selectQuery2.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnPesquisar.CustomizableEdges = borderEdges2;
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
            this.btnPesquisar.Location = new System.Drawing.Point(388, 48);
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
            this.btnPesquisar.TabIndex = 313;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPesquisar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPesquisar.TextMarginLeft = 0;
            this.btnPesquisar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPesquisar.UseDefaultRadiusAndThickness = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
            // 
            // Forms_EstatisticasFinanceiras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 563);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.chkValorContasAReceber);
            this.Controls.Add(this.chkValorContasAPagar);
            this.Controls.Add(this.chkValorContasPagas);
            this.Controls.Add(this.chkValorProduto);
            this.Controls.Add(this.chkValorLiquido);
            this.Controls.Add(this.chkValorBruto);
            this.Controls.Add(this.chrEstatisicasFinanceiras);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bunifuGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Forms_EstatisticasFinanceiras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estatisticas Financeiras";
            this.Load += new System.EventHandler(this.Forms_EstatisticasFinanceiras_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Forms_EstatisticasFinanceiras_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.chkValorLiquido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorContasPagas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorContasAReceber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorContasAPagar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorBruto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrEstatisicasFinanceiras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_NotaFiscalSaidaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private DevExpress.XtraEditors.CheckEdit chkValorLiquido;
        private DevExpress.XtraEditors.CheckEdit chkValorContasPagas;
        private DevExpress.XtraEditors.CheckEdit chkValorContasAReceber;
        private DevExpress.XtraEditors.CheckEdit chkValorContasAPagar;
        private DevExpress.XtraEditors.CheckEdit chkValorProduto;
        private DevExpress.XtraEditors.CheckEdit chkValorBruto;
        private DevExpress.XtraCharts.ChartControl chrEstatisicasFinanceiras;
        private System.Windows.Forms.BindingSource tb_NotaFiscalSaidaBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPesquisar;
    }
}