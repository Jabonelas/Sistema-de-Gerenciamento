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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forms_PesquisarContasAPagar));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.txtFornecedor = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtTipoDeServico = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gdvContarPagar = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.gdvContarPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.AcceptsReturn = false;
            this.txtFornecedor.AcceptsTab = false;
            this.txtFornecedor.AnimationSpeed = 200;
            this.txtFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.txtFornecedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFornecedor.BackgroundImage")));
            this.txtFornecedor.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtFornecedor.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFornecedor.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtFornecedor.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtFornecedor.BorderRadius = 1;
            this.txtFornecedor.BorderThickness = 1;
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFornecedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFornecedor.DefaultFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedor.DefaultText = "";
            this.txtFornecedor.FillColor = System.Drawing.Color.White;
            this.txtFornecedor.HideSelection = true;
            this.txtFornecedor.IconLeft = null;
            this.txtFornecedor.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFornecedor.IconPadding = 10;
            this.txtFornecedor.IconRight = null;
            this.txtFornecedor.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFornecedor.Lines = new string[0];
            this.txtFornecedor.Location = new System.Drawing.Point(14, 27);
            this.txtFornecedor.MaxLength = 32767;
            this.txtFornecedor.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFornecedor.Modified = false;
            this.txtFornecedor.Multiline = false;
            this.txtFornecedor.Name = "txtFornecedor";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFornecedor.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFornecedor.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFornecedor.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFornecedor.OnIdleState = stateProperties4;
            this.txtFornecedor.Padding = new System.Windows.Forms.Padding(3);
            this.txtFornecedor.PasswordChar = '\0';
            this.txtFornecedor.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFornecedor.PlaceholderText = "";
            this.txtFornecedor.ReadOnly = false;
            this.txtFornecedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFornecedor.SelectedText = "";
            this.txtFornecedor.SelectionLength = 0;
            this.txtFornecedor.SelectionStart = 0;
            this.txtFornecedor.ShortcutsEnabled = true;
            this.txtFornecedor.Size = new System.Drawing.Size(374, 28);
            this.txtFornecedor.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFornecedor.TabIndex = 2;
            this.txtFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFornecedor.TextMarginBottom = 0;
            this.txtFornecedor.TextMarginLeft = 3;
            this.txtFornecedor.TextMarginTop = 0;
            this.txtFornecedor.TextPlaceholder = "";
            this.txtFornecedor.UseSystemPasswordChar = false;
            this.txtFornecedor.WordWrap = true;
            this.txtFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFornecedor_KeyPress);
            // 
            // txtTipoDeServico
            // 
            this.txtTipoDeServico.AcceptsReturn = false;
            this.txtTipoDeServico.AcceptsTab = false;
            this.txtTipoDeServico.AnimationSpeed = 200;
            this.txtTipoDeServico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTipoDeServico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTipoDeServico.BackColor = System.Drawing.Color.Transparent;
            this.txtTipoDeServico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTipoDeServico.BackgroundImage")));
            this.txtTipoDeServico.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTipoDeServico.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTipoDeServico.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTipoDeServico.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTipoDeServico.BorderRadius = 1;
            this.txtTipoDeServico.BorderThickness = 1;
            this.txtTipoDeServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTipoDeServico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipoDeServico.DefaultFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoDeServico.DefaultText = "";
            this.txtTipoDeServico.FillColor = System.Drawing.Color.White;
            this.txtTipoDeServico.HideSelection = true;
            this.txtTipoDeServico.IconLeft = null;
            this.txtTipoDeServico.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipoDeServico.IconPadding = 10;
            this.txtTipoDeServico.IconRight = null;
            this.txtTipoDeServico.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipoDeServico.Lines = new string[0];
            this.txtTipoDeServico.Location = new System.Drawing.Point(414, 27);
            this.txtTipoDeServico.MaxLength = 32767;
            this.txtTipoDeServico.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTipoDeServico.Modified = false;
            this.txtTipoDeServico.Multiline = false;
            this.txtTipoDeServico.Name = "txtTipoDeServico";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTipoDeServico.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTipoDeServico.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTipoDeServico.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTipoDeServico.OnIdleState = stateProperties8;
            this.txtTipoDeServico.Padding = new System.Windows.Forms.Padding(3);
            this.txtTipoDeServico.PasswordChar = '\0';
            this.txtTipoDeServico.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTipoDeServico.PlaceholderText = "";
            this.txtTipoDeServico.ReadOnly = false;
            this.txtTipoDeServico.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTipoDeServico.SelectedText = "";
            this.txtTipoDeServico.SelectionLength = 0;
            this.txtTipoDeServico.SelectionStart = 0;
            this.txtTipoDeServico.ShortcutsEnabled = true;
            this.txtTipoDeServico.Size = new System.Drawing.Size(374, 28);
            this.txtTipoDeServico.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtTipoDeServico.TabIndex = 6;
            this.txtTipoDeServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTipoDeServico.TextMarginBottom = 0;
            this.txtTipoDeServico.TextMarginLeft = 3;
            this.txtTipoDeServico.TextMarginTop = 0;
            this.txtTipoDeServico.TextPlaceholder = "";
            this.txtTipoDeServico.UseSystemPasswordChar = false;
            this.txtTipoDeServico.WordWrap = true;
            this.txtTipoDeServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoDeServico_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo de Serviço";
            // 
            // gdvContarPagar
            // 
            this.gdvContarPagar.AllowCustomTheming = false;
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
            this.Codigo,
            this.Fornecedor,
            this.Endereco,
            this.Telefone});
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
            this.gdvContarPagar.EnableHeadersVisualStyles = false;
            this.gdvContarPagar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gdvContarPagar.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gdvContarPagar.HeaderBgColor = System.Drawing.Color.Empty;
            this.gdvContarPagar.HeaderForeColor = System.Drawing.Color.White;
            this.gdvContarPagar.Location = new System.Drawing.Point(14, 133);
            this.gdvContarPagar.Name = "gdvContarPagar";
            this.gdvContarPagar.ReadOnly = true;
            this.gdvContarPagar.RowHeadersVisible = false;
            this.gdvContarPagar.RowTemplate.Height = 40;
            this.gdvContarPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvContarPagar.Size = new System.Drawing.Size(772, 305);
            this.gdvContarPagar.TabIndex = 9;
            this.gdvContarPagar.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Fornecedor
            // 
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.ReadOnly = true;
            // 
            // Endereco
            // 
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
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
            this.btnPesquisar.Location = new System.Drawing.Point(313, 70);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fornecedor";
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(15, 111);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(771, 20);
            this.bunifuSeparator1.TabIndex = 160;
            // 
            // Forms_PesquisarContasAPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.gdvContarPagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTipoDeServico);
            this.Controls.Add(this.txtFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Forms_PesquisarContasAPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Contas a Pagar";
            ((System.ComponentModel.ISupportInitialize)(this.gdvContarPagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox txtFornecedor;
        private Bunifu.UI.WinForms.BunifuTextBox txtTipoDeServico;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDataGridView gdvContarPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPesquisar;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
    }
}