
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
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.tb_NotaFiscalSaidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.dataInicial = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dataFinal = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.chkValorBruto = new DevExpress.XtraEditors.CheckEdit();
            this.chkValorProduto = new DevExpress.XtraEditors.CheckEdit();
            this.chkValorContasAPagar = new DevExpress.XtraEditors.CheckEdit();
            this.chkValorContasAReceber = new DevExpress.XtraEditors.CheckEdit();
            this.chkValorContasPagas = new DevExpress.XtraEditors.CheckEdit();
            this.chkValorLiquido = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_NotaFiscalSaidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorBruto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorContasAPagar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorContasAReceber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorContasPagas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorLiquido.Properties)).BeginInit();
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
            // chkValorBruto
            // 
            this.chkValorBruto.Location = new System.Drawing.Point(12, 38);
            this.chkValorBruto.Name = "chkValorBruto";
            this.chkValorBruto.Properties.Caption = "Valor Bruto";
            this.chkValorBruto.Size = new System.Drawing.Size(128, 20);
            this.chkValorBruto.TabIndex = 3;
            this.chkValorBruto.CheckedChanged += new System.EventHandler(this.chkValorBruto_CheckedChanged);
            // 
            // chkValorProduto
            // 
            this.chkValorProduto.Location = new System.Drawing.Point(12, 70);
            this.chkValorProduto.Name = "chkValorProduto";
            this.chkValorProduto.Properties.Caption = "Valor Produto";
            this.chkValorProduto.Size = new System.Drawing.Size(128, 20);
            this.chkValorProduto.TabIndex = 4;
            this.chkValorProduto.CheckedChanged += new System.EventHandler(this.chkValorProduto_CheckedChanged);
            // 
            // chkValorContasAPagar
            // 
            this.chkValorContasAPagar.Location = new System.Drawing.Point(229, 38);
            this.chkValorContasAPagar.Name = "chkValorContasAPagar";
            this.chkValorContasAPagar.Properties.Caption = "Valor Contas A Pagar";
            this.chkValorContasAPagar.Size = new System.Drawing.Size(128, 20);
            this.chkValorContasAPagar.TabIndex = 5;
            this.chkValorContasAPagar.CheckedChanged += new System.EventHandler(this.chkValorContasAPagar_CheckedChanged);
            // 
            // chkValorContasAReceber
            // 
            this.chkValorContasAReceber.Location = new System.Drawing.Point(229, 64);
            this.chkValorContasAReceber.Name = "chkValorContasAReceber";
            this.chkValorContasAReceber.Properties.Caption = "Valor Contas A Receber";
            this.chkValorContasAReceber.Size = new System.Drawing.Size(128, 20);
            this.chkValorContasAReceber.TabIndex = 6;
            this.chkValorContasAReceber.CheckedChanged += new System.EventHandler(this.chkValorContasAReceber_CheckedChanged);
            // 
            // chkValorContasPagas
            // 
            this.chkValorContasPagas.Location = new System.Drawing.Point(469, 38);
            this.chkValorContasPagas.Name = "chkValorContasPagas";
            this.chkValorContasPagas.Properties.Caption = "Valor Contas Pagas";
            this.chkValorContasPagas.Size = new System.Drawing.Size(128, 20);
            this.chkValorContasPagas.TabIndex = 7;
            this.chkValorContasPagas.CheckedChanged += new System.EventHandler(this.chkValorContasPagas_CheckedChanged);
            // 
            // chkValorLiquido
            // 
            this.chkValorLiquido.Location = new System.Drawing.Point(469, 64);
            this.chkValorLiquido.Name = "chkValorLiquido";
            this.chkValorLiquido.Properties.Caption = "Valor Liquido";
            this.chkValorLiquido.Size = new System.Drawing.Size(128, 20);
            this.chkValorLiquido.TabIndex = 8;
            this.chkValorLiquido.CheckedChanged += new System.EventHandler(this.chkValorLiquido_CheckedChanged);
            // 
            // testando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkValorLiquido);
            this.Controls.Add(this.chkValorContasPagas);
            this.Controls.Add(this.chkValorContasAReceber);
            this.Controls.Add(this.chkValorContasAPagar);
            this.Controls.Add(this.chkValorProduto);
            this.Controls.Add(this.chkValorBruto);
            this.Controls.Add(this.dataFinal);
            this.Controls.Add(this.dataInicial);
            this.Controls.Add(this.chartControl1);
            this.Name = "testando";
            this.Text = "testando";
            this.Load += new System.EventHandler(this.testando_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_NotaFiscalSaidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorBruto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorContasAPagar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorContasAReceber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorContasPagas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorLiquido.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private Bunifu.UI.WinForms.BunifuDatePicker dataInicial;
        private Bunifu.UI.WinForms.BunifuDatePicker dataFinal;
        private System.Windows.Forms.BindingSource tb_NotaFiscalSaidaBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraEditors.CheckEdit chkValorBruto;
        private DevExpress.XtraEditors.CheckEdit chkValorProduto;
        private DevExpress.XtraEditors.CheckEdit chkValorContasAPagar;
        private DevExpress.XtraEditors.CheckEdit chkValorContasAReceber;
        private DevExpress.XtraEditors.CheckEdit chkValorContasPagas;
        private DevExpress.XtraEditors.CheckEdit chkValorLiquido;
    }
}