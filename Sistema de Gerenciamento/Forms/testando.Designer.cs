
namespace Sistema_de_Gerenciamento.Forms
{
    partial class testando
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testando));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.tb_NotaFiscalSaidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.dataInicial = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dataFinal = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.btnPreencherNotaFiscalSaida = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnValorProduto = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_NotaFiscalSaidaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.tb_NotaFiscalSaidaBindingSource;
            this.chartControl1.Location = new System.Drawing.Point(58, 96);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(685, 265);
            this.chartControl1.TabIndex = 0;
            // 
            // tb_NotaFiscalSaidaBindingSource
            // 
            this.tb_NotaFiscalSaidaBindingSource.DataMember = "tb_NotaFiscalSaida";
            this.tb_NotaFiscalSaidaBindingSource.DataSource = this.sqlDataSource2;
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "Principal";
            this.sqlDataSource2.Name = "sqlDataSource2";
            columnExpression1.ColumnName = "ns_valor_pago";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"503\" />";
            table1.Name = "tb_NotaFiscalSaida";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "ns_emissao";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Name = "tb_NotaFiscalSaida";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // dataInicial
            // 
            this.dataInicial.BackColor = System.Drawing.Color.Transparent;
            this.dataInicial.BorderRadius = 1;
            this.dataInicial.Color = System.Drawing.Color.Silver;
            this.dataInicial.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dataInicial.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dataInicial.DisabledColor = System.Drawing.Color.Gray;
            this.dataInicial.DisplayWeekNumbers = false;
            this.dataInicial.DPHeight = 0;
            this.dataInicial.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dataInicial.FillDatePicker = false;
            this.dataInicial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataInicial.ForeColor = System.Drawing.Color.Black;
            this.dataInicial.Icon = ((System.Drawing.Image)(resources.GetObject("dataInicial.Icon")));
            this.dataInicial.IconColor = System.Drawing.Color.Gray;
            this.dataInicial.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dataInicial.LeftTextMargin = 5;
            this.dataInicial.Location = new System.Drawing.Point(3, 0);
            this.dataInicial.MinimumSize = new System.Drawing.Size(4, 32);
            this.dataInicial.Name = "dataInicial";
            this.dataInicial.Size = new System.Drawing.Size(220, 32);
            this.dataInicial.TabIndex = 1;
            // 
            // dataFinal
            // 
            this.dataFinal.BackColor = System.Drawing.Color.Transparent;
            this.dataFinal.BorderRadius = 1;
            this.dataFinal.Color = System.Drawing.Color.Silver;
            this.dataFinal.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dataFinal.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dataFinal.DisabledColor = System.Drawing.Color.Gray;
            this.dataFinal.DisplayWeekNumbers = false;
            this.dataFinal.DPHeight = 0;
            this.dataFinal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dataFinal.FillDatePicker = false;
            this.dataFinal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataFinal.ForeColor = System.Drawing.Color.Black;
            this.dataFinal.Icon = ((System.Drawing.Image)(resources.GetObject("dataFinal.Icon")));
            this.dataFinal.IconColor = System.Drawing.Color.Gray;
            this.dataFinal.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dataFinal.LeftTextMargin = 5;
            this.dataFinal.Location = new System.Drawing.Point(229, 0);
            this.dataFinal.MinimumSize = new System.Drawing.Size(4, 32);
            this.dataFinal.Name = "dataFinal";
            this.dataFinal.Size = new System.Drawing.Size(220, 32);
            this.dataFinal.TabIndex = 2;
            // 
            // btnPreencherNotaFiscalSaida
            // 
            this.btnPreencherNotaFiscalSaida.AllowAnimations = true;
            this.btnPreencherNotaFiscalSaida.AllowMouseEffects = true;
            this.btnPreencherNotaFiscalSaida.AllowToggling = false;
            this.btnPreencherNotaFiscalSaida.AnimationSpeed = 200;
            this.btnPreencherNotaFiscalSaida.AutoGenerateColors = false;
            this.btnPreencherNotaFiscalSaida.AutoRoundBorders = false;
            this.btnPreencherNotaFiscalSaida.AutoSizeLeftIcon = true;
            this.btnPreencherNotaFiscalSaida.AutoSizeRightIcon = true;
            this.btnPreencherNotaFiscalSaida.BackColor = System.Drawing.Color.Transparent;
            this.btnPreencherNotaFiscalSaida.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnPreencherNotaFiscalSaida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPreencherNotaFiscalSaida.BackgroundImage")));
            this.btnPreencherNotaFiscalSaida.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPreencherNotaFiscalSaida.ButtonText = "Nota Fiscal Saida";
            this.btnPreencherNotaFiscalSaida.ButtonTextMarginLeft = 0;
            this.btnPreencherNotaFiscalSaida.ColorContrastOnClick = 45;
            this.btnPreencherNotaFiscalSaida.ColorContrastOnHover = 45;
            this.btnPreencherNotaFiscalSaida.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnPreencherNotaFiscalSaida.CustomizableEdges = borderEdges1;
            this.btnPreencherNotaFiscalSaida.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPreencherNotaFiscalSaida.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPreencherNotaFiscalSaida.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPreencherNotaFiscalSaida.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPreencherNotaFiscalSaida.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPreencherNotaFiscalSaida.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPreencherNotaFiscalSaida.ForeColor = System.Drawing.Color.White;
            this.btnPreencherNotaFiscalSaida.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreencherNotaFiscalSaida.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPreencherNotaFiscalSaida.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPreencherNotaFiscalSaida.IconMarginLeft = 11;
            this.btnPreencherNotaFiscalSaida.IconPadding = 10;
            this.btnPreencherNotaFiscalSaida.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreencherNotaFiscalSaida.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPreencherNotaFiscalSaida.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPreencherNotaFiscalSaida.IconSize = 25;
            this.btnPreencherNotaFiscalSaida.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPreencherNotaFiscalSaida.IdleBorderRadius = 1;
            this.btnPreencherNotaFiscalSaida.IdleBorderThickness = 1;
            this.btnPreencherNotaFiscalSaida.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnPreencherNotaFiscalSaida.IdleIconLeftImage = null;
            this.btnPreencherNotaFiscalSaida.IdleIconRightImage = null;
            this.btnPreencherNotaFiscalSaida.IndicateFocus = false;
            this.btnPreencherNotaFiscalSaida.Location = new System.Drawing.Point(12, 51);
            this.btnPreencherNotaFiscalSaida.Name = "btnPreencherNotaFiscalSaida";
            this.btnPreencherNotaFiscalSaida.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPreencherNotaFiscalSaida.OnDisabledState.BorderRadius = 1;
            this.btnPreencherNotaFiscalSaida.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPreencherNotaFiscalSaida.OnDisabledState.BorderThickness = 1;
            this.btnPreencherNotaFiscalSaida.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPreencherNotaFiscalSaida.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPreencherNotaFiscalSaida.OnDisabledState.IconLeftImage = null;
            this.btnPreencherNotaFiscalSaida.OnDisabledState.IconRightImage = null;
            this.btnPreencherNotaFiscalSaida.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPreencherNotaFiscalSaida.onHoverState.BorderRadius = 1;
            this.btnPreencherNotaFiscalSaida.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPreencherNotaFiscalSaida.onHoverState.BorderThickness = 1;
            this.btnPreencherNotaFiscalSaida.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPreencherNotaFiscalSaida.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPreencherNotaFiscalSaida.onHoverState.IconLeftImage = null;
            this.btnPreencherNotaFiscalSaida.onHoverState.IconRightImage = null;
            this.btnPreencherNotaFiscalSaida.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPreencherNotaFiscalSaida.OnIdleState.BorderRadius = 1;
            this.btnPreencherNotaFiscalSaida.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPreencherNotaFiscalSaida.OnIdleState.BorderThickness = 1;
            this.btnPreencherNotaFiscalSaida.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnPreencherNotaFiscalSaida.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnPreencherNotaFiscalSaida.OnIdleState.IconLeftImage = null;
            this.btnPreencherNotaFiscalSaida.OnIdleState.IconRightImage = null;
            this.btnPreencherNotaFiscalSaida.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPreencherNotaFiscalSaida.OnPressedState.BorderRadius = 1;
            this.btnPreencherNotaFiscalSaida.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPreencherNotaFiscalSaida.OnPressedState.BorderThickness = 1;
            this.btnPreencherNotaFiscalSaida.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPreencherNotaFiscalSaida.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPreencherNotaFiscalSaida.OnPressedState.IconLeftImage = null;
            this.btnPreencherNotaFiscalSaida.OnPressedState.IconRightImage = null;
            this.btnPreencherNotaFiscalSaida.Size = new System.Drawing.Size(150, 39);
            this.btnPreencherNotaFiscalSaida.TabIndex = 3;
            this.btnPreencherNotaFiscalSaida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPreencherNotaFiscalSaida.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPreencherNotaFiscalSaida.TextMarginLeft = 0;
            this.btnPreencherNotaFiscalSaida.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPreencherNotaFiscalSaida.UseDefaultRadiusAndThickness = true;
            this.btnPreencherNotaFiscalSaida.Click += new System.EventHandler(this.btnPreencher_Click);
            // 
            // btnValorProduto
            // 
            this.btnValorProduto.AllowAnimations = true;
            this.btnValorProduto.AllowMouseEffects = true;
            this.btnValorProduto.AllowToggling = false;
            this.btnValorProduto.AnimationSpeed = 200;
            this.btnValorProduto.AutoGenerateColors = false;
            this.btnValorProduto.AutoRoundBorders = false;
            this.btnValorProduto.AutoSizeLeftIcon = true;
            this.btnValorProduto.AutoSizeRightIcon = true;
            this.btnValorProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnValorProduto.BackColor1 = System.Drawing.Color.Red;
            this.btnValorProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnValorProduto.BackgroundImage")));
            this.btnValorProduto.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnValorProduto.ButtonText = "Valor Produto";
            this.btnValorProduto.ButtonTextMarginLeft = 0;
            this.btnValorProduto.ColorContrastOnClick = 45;
            this.btnValorProduto.ColorContrastOnHover = 45;
            this.btnValorProduto.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnValorProduto.CustomizableEdges = borderEdges2;
            this.btnValorProduto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnValorProduto.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnValorProduto.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnValorProduto.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnValorProduto.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnValorProduto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnValorProduto.ForeColor = System.Drawing.Color.White;
            this.btnValorProduto.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValorProduto.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnValorProduto.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnValorProduto.IconMarginLeft = 11;
            this.btnValorProduto.IconPadding = 10;
            this.btnValorProduto.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValorProduto.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnValorProduto.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnValorProduto.IconSize = 25;
            this.btnValorProduto.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnValorProduto.IdleBorderRadius = 1;
            this.btnValorProduto.IdleBorderThickness = 1;
            this.btnValorProduto.IdleFillColor = System.Drawing.Color.Red;
            this.btnValorProduto.IdleIconLeftImage = null;
            this.btnValorProduto.IdleIconRightImage = null;
            this.btnValorProduto.IndicateFocus = false;
            this.btnValorProduto.Location = new System.Drawing.Point(215, 51);
            this.btnValorProduto.Name = "btnValorProduto";
            this.btnValorProduto.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnValorProduto.OnDisabledState.BorderRadius = 1;
            this.btnValorProduto.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnValorProduto.OnDisabledState.BorderThickness = 1;
            this.btnValorProduto.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnValorProduto.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnValorProduto.OnDisabledState.IconLeftImage = null;
            this.btnValorProduto.OnDisabledState.IconRightImage = null;
            this.btnValorProduto.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnValorProduto.onHoverState.BorderRadius = 1;
            this.btnValorProduto.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnValorProduto.onHoverState.BorderThickness = 1;
            this.btnValorProduto.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnValorProduto.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnValorProduto.onHoverState.IconLeftImage = null;
            this.btnValorProduto.onHoverState.IconRightImage = null;
            this.btnValorProduto.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnValorProduto.OnIdleState.BorderRadius = 1;
            this.btnValorProduto.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnValorProduto.OnIdleState.BorderThickness = 1;
            this.btnValorProduto.OnIdleState.FillColor = System.Drawing.Color.Red;
            this.btnValorProduto.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnValorProduto.OnIdleState.IconLeftImage = null;
            this.btnValorProduto.OnIdleState.IconRightImage = null;
            this.btnValorProduto.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnValorProduto.OnPressedState.BorderRadius = 1;
            this.btnValorProduto.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnValorProduto.OnPressedState.BorderThickness = 1;
            this.btnValorProduto.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnValorProduto.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnValorProduto.OnPressedState.IconLeftImage = null;
            this.btnValorProduto.OnPressedState.IconRightImage = null;
            this.btnValorProduto.Size = new System.Drawing.Size(150, 39);
            this.btnValorProduto.TabIndex = 4;
            this.btnValorProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnValorProduto.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnValorProduto.TextMarginLeft = 0;
            this.btnValorProduto.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnValorProduto.UseDefaultRadiusAndThickness = true;
            this.btnValorProduto.Click += new System.EventHandler(this.btnValorProduto_Click);
            // 
            // testando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValorProduto);
            this.Controls.Add(this.btnPreencherNotaFiscalSaida);
            this.Controls.Add(this.dataFinal);
            this.Controls.Add(this.dataInicial);
            this.Controls.Add(this.chartControl1);
            this.Name = "testando";
            this.Text = "testando";
            this.Load += new System.EventHandler(this.testando_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_NotaFiscalSaidaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private Bunifu.UI.WinForms.BunifuDatePicker dataInicial;
        private Bunifu.UI.WinForms.BunifuDatePicker dataFinal;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPreencherNotaFiscalSaida;
        private System.Windows.Forms.BindingSource tb_NotaFiscalSaidaBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnValorProduto;
    }
}