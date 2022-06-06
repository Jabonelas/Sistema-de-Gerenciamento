namespace Sistema_de_Gerenciamento.Forms
{
    partial class Forms_Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forms_Compras));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNumeroNotaFiscal = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnExcluir = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSalvar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.gdvCompra = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ne_indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ne_numero_nf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ne_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ne_razao_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ne_codigo_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ne_descricao_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ne_quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ne_unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ne_valor_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ne_valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ne_data_emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ne_data_lancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntSair = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAlterar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.gdvEstoque = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ep_codigo_barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ep_desconto_por_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumeroNotaFiscal
            // 
            this.txtNumeroNotaFiscal.AcceptsReturn = false;
            this.txtNumeroNotaFiscal.AcceptsTab = false;
            this.txtNumeroNotaFiscal.AnimationSpeed = 200;
            this.txtNumeroNotaFiscal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNumeroNotaFiscal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNumeroNotaFiscal.BackColor = System.Drawing.Color.Transparent;
            this.txtNumeroNotaFiscal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNumeroNotaFiscal.BackgroundImage")));
            this.txtNumeroNotaFiscal.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtNumeroNotaFiscal.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNumeroNotaFiscal.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtNumeroNotaFiscal.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtNumeroNotaFiscal.BorderRadius = 1;
            this.txtNumeroNotaFiscal.BorderThickness = 1;
            this.txtNumeroNotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNumeroNotaFiscal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroNotaFiscal.DefaultFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroNotaFiscal.DefaultText = "";
            this.txtNumeroNotaFiscal.FillColor = System.Drawing.Color.White;
            this.txtNumeroNotaFiscal.HideSelection = true;
            this.txtNumeroNotaFiscal.IconLeft = null;
            this.txtNumeroNotaFiscal.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroNotaFiscal.IconPadding = 10;
            this.txtNumeroNotaFiscal.IconRight = null;
            this.txtNumeroNotaFiscal.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroNotaFiscal.Lines = new string[0];
            this.txtNumeroNotaFiscal.Location = new System.Drawing.Point(15, 138);
            this.txtNumeroNotaFiscal.MaxLength = 10;
            this.txtNumeroNotaFiscal.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNumeroNotaFiscal.Modified = false;
            this.txtNumeroNotaFiscal.Multiline = false;
            this.txtNumeroNotaFiscal.Name = "txtNumeroNotaFiscal";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNumeroNotaFiscal.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNumeroNotaFiscal.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNumeroNotaFiscal.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNumeroNotaFiscal.OnIdleState = stateProperties4;
            this.txtNumeroNotaFiscal.Padding = new System.Windows.Forms.Padding(3);
            this.txtNumeroNotaFiscal.PasswordChar = '\0';
            this.txtNumeroNotaFiscal.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNumeroNotaFiscal.PlaceholderText = "";
            this.txtNumeroNotaFiscal.ReadOnly = false;
            this.txtNumeroNotaFiscal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumeroNotaFiscal.SelectedText = "";
            this.txtNumeroNotaFiscal.SelectionLength = 0;
            this.txtNumeroNotaFiscal.SelectionStart = 0;
            this.txtNumeroNotaFiscal.ShortcutsEnabled = false;
            this.txtNumeroNotaFiscal.Size = new System.Drawing.Size(186, 28);
            this.txtNumeroNotaFiscal.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtNumeroNotaFiscal.TabIndex = 1;
            this.txtNumeroNotaFiscal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumeroNotaFiscal.TextMarginBottom = 0;
            this.txtNumeroNotaFiscal.TextMarginLeft = 3;
            this.txtNumeroNotaFiscal.TextMarginTop = 0;
            this.txtNumeroNotaFiscal.TextPlaceholder = "";
            this.txtNumeroNotaFiscal.UseSystemPasswordChar = false;
            this.txtNumeroNotaFiscal.WordWrap = true;
            this.txtNumeroNotaFiscal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroNotaFiscal_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 147;
            this.label1.Text = "Nº da Nota Fiscal";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AllowAnimations = true;
            this.btnBuscar.AllowMouseEffects = true;
            this.btnBuscar.AllowToggling = false;
            this.btnBuscar.AnimationSpeed = 200;
            this.btnBuscar.AutoGenerateColors = false;
            this.btnBuscar.AutoRoundBorders = false;
            this.btnBuscar.AutoSizeLeftIcon = true;
            this.btnBuscar.AutoSizeRightIcon = true;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackColor1 = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscar.ButtonText = "Procurar";
            this.btnBuscar.ButtonTextMarginLeft = 0;
            this.btnBuscar.ColorContrastOnClick = 45;
            this.btnBuscar.ColorContrastOnHover = 45;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnBuscar.CustomizableEdges = borderEdges1;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBuscar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBuscar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBuscar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.IconLeftAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscar.IconLeftPadding = new System.Windows.Forms.Padding(11, 1, 3, 3);
            this.btnBuscar.IconMarginLeft = 11;
            this.btnBuscar.IconPadding = 17;
            this.btnBuscar.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnBuscar.IconSize = 25;
            this.btnBuscar.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnBuscar.IdleBorderRadius = 1;
            this.btnBuscar.IdleBorderThickness = 1;
            this.btnBuscar.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnBuscar.IdleIconLeftImage = global::Sistema_de_Gerenciamento.Properties.Resources.procurar;
            this.btnBuscar.IdleIconRightImage = null;
            this.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscar.IndicateFocus = false;
            this.btnBuscar.Location = new System.Drawing.Point(123, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBuscar.OnDisabledState.BorderRadius = 1;
            this.btnBuscar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscar.OnDisabledState.BorderThickness = 1;
            this.btnBuscar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBuscar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBuscar.OnDisabledState.IconLeftImage = null;
            this.btnBuscar.OnDisabledState.IconRightImage = null;
            this.btnBuscar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnBuscar.onHoverState.BorderRadius = 1;
            this.btnBuscar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscar.onHoverState.BorderThickness = 1;
            this.btnBuscar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnBuscar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.onHoverState.IconLeftImage = null;
            this.btnBuscar.onHoverState.IconRightImage = null;
            this.btnBuscar.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnBuscar.OnIdleState.BorderRadius = 1;
            this.btnBuscar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscar.OnIdleState.BorderThickness = 1;
            this.btnBuscar.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnBuscar.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.OnIdleState.IconLeftImage = global::Sistema_de_Gerenciamento.Properties.Resources.procurar;
            this.btnBuscar.OnIdleState.IconRightImage = null;
            this.btnBuscar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnBuscar.OnPressedState.BorderRadius = 1;
            this.btnBuscar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuscar.OnPressedState.BorderThickness = 1;
            this.btnBuscar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnBuscar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.OnPressedState.IconLeftImage = null;
            this.btnBuscar.OnPressedState.IconRightImage = null;
            this.btnBuscar.Size = new System.Drawing.Size(88, 80);
            this.btnBuscar.TabIndex = 148;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscar.TextMarginLeft = 0;
            this.btnBuscar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnBuscar.UseDefaultRadiusAndThickness = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AllowAnimations = true;
            this.btnExcluir.AllowMouseEffects = true;
            this.btnExcluir.AllowToggling = false;
            this.btnExcluir.AnimationSpeed = 200;
            this.btnExcluir.AutoGenerateColors = false;
            this.btnExcluir.AutoRoundBorders = false;
            this.btnExcluir.AutoSizeLeftIcon = true;
            this.btnExcluir.AutoSizeRightIcon = true;
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackColor1 = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExcluir.ButtonText = "Excluir";
            this.btnExcluir.ButtonTextMarginLeft = 0;
            this.btnExcluir.ColorContrastOnClick = 45;
            this.btnExcluir.ColorContrastOnHover = 45;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnExcluir.CustomizableEdges = borderEdges2;
            this.btnExcluir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExcluir.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExcluir.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExcluir.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExcluir.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnExcluir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.IconLeftAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExcluir.IconLeftPadding = new System.Windows.Forms.Padding(11, 1, 3, 3);
            this.btnExcluir.IconMarginLeft = 11;
            this.btnExcluir.IconPadding = 17;
            this.btnExcluir.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExcluir.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExcluir.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExcluir.IconSize = 25;
            this.btnExcluir.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnExcluir.IdleBorderRadius = 1;
            this.btnExcluir.IdleBorderThickness = 1;
            this.btnExcluir.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnExcluir.IdleIconLeftImage = global::Sistema_de_Gerenciamento.Properties.Resources.bin;
            this.btnExcluir.IdleIconRightImage = null;
            this.btnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluir.IndicateFocus = false;
            this.btnExcluir.Location = new System.Drawing.Point(230, 25);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExcluir.OnDisabledState.BorderRadius = 1;
            this.btnExcluir.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExcluir.OnDisabledState.BorderThickness = 1;
            this.btnExcluir.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExcluir.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExcluir.OnDisabledState.IconLeftImage = null;
            this.btnExcluir.OnDisabledState.IconRightImage = null;
            this.btnExcluir.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnExcluir.onHoverState.BorderRadius = 1;
            this.btnExcluir.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExcluir.onHoverState.BorderThickness = 1;
            this.btnExcluir.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnExcluir.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.onHoverState.IconLeftImage = null;
            this.btnExcluir.onHoverState.IconRightImage = null;
            this.btnExcluir.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnExcluir.OnIdleState.BorderRadius = 1;
            this.btnExcluir.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExcluir.OnIdleState.BorderThickness = 1;
            this.btnExcluir.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnExcluir.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.OnIdleState.IconLeftImage = global::Sistema_de_Gerenciamento.Properties.Resources.bin;
            this.btnExcluir.OnIdleState.IconRightImage = null;
            this.btnExcluir.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExcluir.OnPressedState.BorderRadius = 1;
            this.btnExcluir.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExcluir.OnPressedState.BorderThickness = 1;
            this.btnExcluir.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExcluir.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.OnPressedState.IconLeftImage = null;
            this.btnExcluir.OnPressedState.IconRightImage = null;
            this.btnExcluir.Size = new System.Drawing.Size(88, 80);
            this.btnExcluir.TabIndex = 149;
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExcluir.TextMarginLeft = 0;
            this.btnExcluir.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnExcluir.UseDefaultRadiusAndThickness = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AllowAnimations = true;
            this.btnSalvar.AllowMouseEffects = true;
            this.btnSalvar.AllowToggling = false;
            this.btnSalvar.AnimationSpeed = 200;
            this.btnSalvar.AutoGenerateColors = false;
            this.btnSalvar.AutoRoundBorders = false;
            this.btnSalvar.AutoSizeLeftIcon = true;
            this.btnSalvar.AutoSizeRightIcon = true;
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackColor1 = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSalvar.ButtonText = "Salvar";
            this.btnSalvar.ButtonTextMarginLeft = 0;
            this.btnSalvar.ColorContrastOnClick = 45;
            this.btnSalvar.ColorContrastOnHover = 45;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnSalvar.CustomizableEdges = borderEdges3;
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSalvar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSalvar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSalvar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSalvar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSalvar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.IconLeftAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSalvar.IconLeftPadding = new System.Windows.Forms.Padding(11, 1, 3, 3);
            this.btnSalvar.IconMarginLeft = 11;
            this.btnSalvar.IconPadding = 17;
            this.btnSalvar.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalvar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSalvar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSalvar.IconSize = 25;
            this.btnSalvar.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnSalvar.IdleBorderRadius = 1;
            this.btnSalvar.IdleBorderThickness = 1;
            this.btnSalvar.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnSalvar.IdleIconLeftImage = global::Sistema_de_Gerenciamento.Properties.Resources.salve_;
            this.btnSalvar.IdleIconRightImage = null;
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.IndicateFocus = false;
            this.btnSalvar.Location = new System.Drawing.Point(15, 25);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSalvar.OnDisabledState.BorderRadius = 1;
            this.btnSalvar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSalvar.OnDisabledState.BorderThickness = 1;
            this.btnSalvar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSalvar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSalvar.OnDisabledState.IconLeftImage = null;
            this.btnSalvar.OnDisabledState.IconRightImage = null;
            this.btnSalvar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSalvar.onHoverState.BorderRadius = 1;
            this.btnSalvar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSalvar.onHoverState.BorderThickness = 1;
            this.btnSalvar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSalvar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.onHoverState.IconLeftImage = null;
            this.btnSalvar.onHoverState.IconRightImage = null;
            this.btnSalvar.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSalvar.OnIdleState.BorderRadius = 1;
            this.btnSalvar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSalvar.OnIdleState.BorderThickness = 1;
            this.btnSalvar.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnSalvar.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.OnIdleState.IconLeftImage = global::Sistema_de_Gerenciamento.Properties.Resources.salve_;
            this.btnSalvar.OnIdleState.IconRightImage = null;
            this.btnSalvar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSalvar.OnPressedState.BorderRadius = 1;
            this.btnSalvar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSalvar.OnPressedState.BorderThickness = 1;
            this.btnSalvar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSalvar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.OnPressedState.IconLeftImage = null;
            this.btnSalvar.OnPressedState.IconRightImage = null;
            this.btnSalvar.Size = new System.Drawing.Size(88, 80);
            this.btnSalvar.TabIndex = 150;
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSalvar.TextMarginLeft = 0;
            this.btnSalvar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSalvar.UseDefaultRadiusAndThickness = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 172);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(918, 18);
            this.bunifuSeparator1.TabIndex = 159;
            // 
            // gdvCompra
            // 
            this.gdvCompra.AllowCustomTheming = false;
            this.gdvCompra.AllowUserToAddRows = false;
            this.gdvCompra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gdvCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gdvCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdvCompra.ColumnHeadersHeight = 40;
            this.gdvCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ne_indice,
            this.ne_numero_nf,
            this.ne_cnpj,
            this.ne_razao_social,
            this.ne_codigo_produto,
            this.ne_descricao_produto,
            this.ne_quantidade,
            this.ne_unidade,
            this.ne_valor_unitario,
            this.ne_valor_total,
            this.ne_data_emissao,
            this.ne_data_lancamento});
            this.gdvCompra.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gdvCompra.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gdvCompra.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gdvCompra.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gdvCompra.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gdvCompra.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.gdvCompra.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gdvCompra.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gdvCompra.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gdvCompra.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdvCompra.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.gdvCompra.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gdvCompra.CurrentTheme.Name = null;
            this.gdvCompra.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvCompra.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gdvCompra.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gdvCompra.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gdvCompra.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvCompra.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdvCompra.EnableHeadersVisualStyles = false;
            this.gdvCompra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gdvCompra.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gdvCompra.HeaderBgColor = System.Drawing.Color.Empty;
            this.gdvCompra.HeaderForeColor = System.Drawing.Color.White;
            this.gdvCompra.Location = new System.Drawing.Point(15, 196);
            this.gdvCompra.Name = "gdvCompra";
            this.gdvCompra.ReadOnly = true;
            this.gdvCompra.RowHeadersVisible = false;
            this.gdvCompra.RowHeadersWidth = 50;
            this.gdvCompra.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvCompra.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gdvCompra.RowTemplate.Height = 40;
            this.gdvCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvCompra.Size = new System.Drawing.Size(912, 303);
            this.gdvCompra.TabIndex = 160;
            this.gdvCompra.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // ne_indice
            // 
            this.ne_indice.HeaderText = "ne_indice";
            this.ne_indice.Name = "ne_indice";
            this.ne_indice.ReadOnly = true;
            this.ne_indice.Visible = false;
            this.ne_indice.Width = 104;
            // 
            // ne_numero_nf
            // 
            this.ne_numero_nf.DataPropertyName = "ne_numero_nf";
            this.ne_numero_nf.HeaderText = "Nº NF";
            this.ne_numero_nf.Name = "ne_numero_nf";
            this.ne_numero_nf.ReadOnly = true;
            this.ne_numero_nf.Width = 78;
            // 
            // ne_cnpj
            // 
            this.ne_cnpj.DataPropertyName = "ne_cnpj";
            this.ne_cnpj.HeaderText = "CNPJ";
            this.ne_cnpj.Name = "ne_cnpj";
            this.ne_cnpj.ReadOnly = true;
            this.ne_cnpj.Visible = false;
            this.ne_cnpj.Width = 71;
            // 
            // ne_razao_social
            // 
            this.ne_razao_social.DataPropertyName = "ne_razao_social";
            this.ne_razao_social.HeaderText = "R. Social";
            this.ne_razao_social.Name = "ne_razao_social";
            this.ne_razao_social.ReadOnly = true;
            this.ne_razao_social.Width = 96;
            // 
            // ne_codigo_produto
            // 
            this.ne_codigo_produto.DataPropertyName = "ne_codigo_produto";
            this.ne_codigo_produto.HeaderText = "Cod. Prod.";
            this.ne_codigo_produto.Name = "ne_codigo_produto";
            this.ne_codigo_produto.ReadOnly = true;
            this.ne_codigo_produto.Width = 112;
            // 
            // ne_descricao_produto
            // 
            this.ne_descricao_produto.DataPropertyName = "ne_descricao_produto";
            this.ne_descricao_produto.HeaderText = "Desc. Prod.";
            this.ne_descricao_produto.Name = "ne_descricao_produto";
            this.ne_descricao_produto.ReadOnly = true;
            this.ne_descricao_produto.Width = 117;
            // 
            // ne_quantidade
            // 
            this.ne_quantidade.DataPropertyName = "ne_quantidade";
            this.ne_quantidade.HeaderText = "Quant.";
            this.ne_quantidade.Name = "ne_quantidade";
            this.ne_quantidade.ReadOnly = true;
            this.ne_quantidade.Width = 83;
            // 
            // ne_unidade
            // 
            this.ne_unidade.DataPropertyName = "ne_unidade";
            this.ne_unidade.HeaderText = "UN";
            this.ne_unidade.Name = "ne_unidade";
            this.ne_unidade.ReadOnly = true;
            this.ne_unidade.Width = 58;
            // 
            // ne_valor_unitario
            // 
            this.ne_valor_unitario.DataPropertyName = "ne_valor_unitario";
            this.ne_valor_unitario.HeaderText = "R$ Unit.";
            this.ne_valor_unitario.Name = "ne_valor_unitario";
            this.ne_valor_unitario.ReadOnly = true;
            this.ne_valor_unitario.Width = 92;
            // 
            // ne_valor_total
            // 
            this.ne_valor_total.DataPropertyName = "ne_valor_total";
            this.ne_valor_total.HeaderText = "R$ Total";
            this.ne_valor_total.Name = "ne_valor_total";
            this.ne_valor_total.ReadOnly = true;
            this.ne_valor_total.Width = 93;
            // 
            // ne_data_emissao
            // 
            this.ne_data_emissao.DataPropertyName = "ne_data_emissao";
            this.ne_data_emissao.HeaderText = "Emissão";
            this.ne_data_emissao.Name = "ne_data_emissao";
            this.ne_data_emissao.ReadOnly = true;
            this.ne_data_emissao.Width = 93;
            // 
            // ne_data_lancamento
            // 
            this.ne_data_lancamento.DataPropertyName = "ne_data_lancamento";
            this.ne_data_lancamento.HeaderText = "Entrada";
            this.ne_data_lancamento.Name = "ne_data_lancamento";
            this.ne_data_lancamento.ReadOnly = true;
            this.ne_data_lancamento.Width = 90;
            // 
            // bntSair
            // 
            this.bntSair.AllowAnimations = true;
            this.bntSair.AllowMouseEffects = true;
            this.bntSair.AllowToggling = false;
            this.bntSair.AnimationSpeed = 200;
            this.bntSair.AutoGenerateColors = false;
            this.bntSair.AutoRoundBorders = false;
            this.bntSair.AutoSizeLeftIcon = true;
            this.bntSair.AutoSizeRightIcon = true;
            this.bntSair.BackColor = System.Drawing.Color.Transparent;
            this.bntSair.BackColor1 = System.Drawing.Color.Transparent;
            this.bntSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntSair.BackgroundImage")));
            this.bntSair.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bntSair.ButtonText = "Sair";
            this.bntSair.ButtonTextMarginLeft = 0;
            this.bntSair.ColorContrastOnClick = 45;
            this.bntSair.ColorContrastOnHover = 45;
            this.bntSair.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.bntSair.CustomizableEdges = borderEdges4;
            this.bntSair.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bntSair.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bntSair.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bntSair.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bntSair.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bntSair.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSair.ForeColor = System.Drawing.Color.Black;
            this.bntSair.IconLeftAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntSair.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bntSair.IconLeftPadding = new System.Windows.Forms.Padding(11, 1, 3, 3);
            this.bntSair.IconMarginLeft = 11;
            this.bntSair.IconPadding = 17;
            this.bntSair.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bntSair.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bntSair.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bntSair.IconSize = 25;
            this.bntSair.IdleBorderColor = System.Drawing.Color.Transparent;
            this.bntSair.IdleBorderRadius = 1;
            this.bntSair.IdleBorderThickness = 1;
            this.bntSair.IdleFillColor = System.Drawing.Color.Transparent;
            this.bntSair.IdleIconLeftImage = global::Sistema_de_Gerenciamento.Properties.Resources.sair;
            this.bntSair.IdleIconRightImage = null;
            this.bntSair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bntSair.IndicateFocus = false;
            this.bntSair.Location = new System.Drawing.Point(445, 25);
            this.bntSair.Name = "bntSair";
            this.bntSair.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bntSair.OnDisabledState.BorderRadius = 1;
            this.bntSair.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bntSair.OnDisabledState.BorderThickness = 1;
            this.bntSair.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bntSair.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bntSair.OnDisabledState.IconLeftImage = null;
            this.bntSair.OnDisabledState.IconRightImage = null;
            this.bntSair.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bntSair.onHoverState.BorderRadius = 1;
            this.bntSair.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bntSair.onHoverState.BorderThickness = 1;
            this.bntSair.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bntSair.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bntSair.onHoverState.IconLeftImage = null;
            this.bntSair.onHoverState.IconRightImage = null;
            this.bntSair.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.bntSair.OnIdleState.BorderRadius = 1;
            this.bntSair.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bntSair.OnIdleState.BorderThickness = 1;
            this.bntSair.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.bntSair.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.bntSair.OnIdleState.IconLeftImage = global::Sistema_de_Gerenciamento.Properties.Resources.sair;
            this.bntSair.OnIdleState.IconRightImage = null;
            this.bntSair.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bntSair.OnPressedState.BorderRadius = 1;
            this.bntSair.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bntSair.OnPressedState.BorderThickness = 1;
            this.bntSair.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bntSair.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bntSair.OnPressedState.IconLeftImage = null;
            this.bntSair.OnPressedState.IconRightImage = null;
            this.bntSair.Size = new System.Drawing.Size(88, 80);
            this.bntSair.TabIndex = 161;
            this.bntSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntSair.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bntSair.TextMarginLeft = 0;
            this.bntSair.TextPadding = new System.Windows.Forms.Padding(0);
            this.bntSair.UseDefaultRadiusAndThickness = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AllowAnimations = true;
            this.btnAlterar.AllowMouseEffects = true;
            this.btnAlterar.AllowToggling = false;
            this.btnAlterar.AnimationSpeed = 200;
            this.btnAlterar.AutoGenerateColors = false;
            this.btnAlterar.AutoRoundBorders = false;
            this.btnAlterar.AutoSizeLeftIcon = true;
            this.btnAlterar.AutoSizeRightIcon = true;
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.BackColor1 = System.Drawing.Color.Transparent;
            this.btnAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.BackgroundImage")));
            this.btnAlterar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAlterar.ButtonText = "Alterar \r\nCodigo Barras";
            this.btnAlterar.ButtonTextMarginLeft = 0;
            this.btnAlterar.ColorContrastOnClick = 45;
            this.btnAlterar.ColorContrastOnHover = 45;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnAlterar.CustomizableEdges = borderEdges5;
            this.btnAlterar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAlterar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAlterar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAlterar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAlterar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAlterar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.Black;
            this.btnAlterar.IconLeftAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAlterar.IconLeftPadding = new System.Windows.Forms.Padding(11, 1, 3, 3);
            this.btnAlterar.IconMarginLeft = 11;
            this.btnAlterar.IconPadding = 17;
            this.btnAlterar.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAlterar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAlterar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAlterar.IconSize = 25;
            this.btnAlterar.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnAlterar.IdleBorderRadius = 1;
            this.btnAlterar.IdleBorderThickness = 1;
            this.btnAlterar.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnAlterar.IdleIconLeftImage = global::Sistema_de_Gerenciamento.Properties.Resources.caixa_de_retorno;
            this.btnAlterar.IdleIconRightImage = null;
            this.btnAlterar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterar.IndicateFocus = false;
            this.btnAlterar.Location = new System.Drawing.Point(338, 25);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAlterar.OnDisabledState.BorderRadius = 1;
            this.btnAlterar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAlterar.OnDisabledState.BorderThickness = 1;
            this.btnAlterar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAlterar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAlterar.OnDisabledState.IconLeftImage = null;
            this.btnAlterar.OnDisabledState.IconRightImage = null;
            this.btnAlterar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAlterar.onHoverState.BorderRadius = 1;
            this.btnAlterar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAlterar.onHoverState.BorderThickness = 1;
            this.btnAlterar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAlterar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.onHoverState.IconLeftImage = null;
            this.btnAlterar.onHoverState.IconRightImage = null;
            this.btnAlterar.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAlterar.OnIdleState.BorderRadius = 1;
            this.btnAlterar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAlterar.OnIdleState.BorderThickness = 1;
            this.btnAlterar.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnAlterar.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnAlterar.OnIdleState.IconLeftImage = global::Sistema_de_Gerenciamento.Properties.Resources.caixa_de_retorno;
            this.btnAlterar.OnIdleState.IconRightImage = null;
            this.btnAlterar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAlterar.OnPressedState.BorderRadius = 1;
            this.btnAlterar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAlterar.OnPressedState.BorderThickness = 1;
            this.btnAlterar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAlterar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.OnPressedState.IconLeftImage = null;
            this.btnAlterar.OnPressedState.IconRightImage = null;
            this.btnAlterar.Size = new System.Drawing.Size(88, 80);
            this.btnAlterar.TabIndex = 162;
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAlterar.TextMarginLeft = 0;
            this.btnAlterar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAlterar.UseDefaultRadiusAndThickness = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // gdvEstoque
            // 
            this.gdvEstoque.AllowCustomTheming = false;
            this.gdvEstoque.AllowUserToAddRows = false;
            this.gdvEstoque.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.gdvEstoque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gdvEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gdvEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvEstoque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvEstoque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gdvEstoque.ColumnHeadersHeight = 40;
            this.gdvEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.ep_codigo_barras,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn12,
            this.ep_desconto_por_item});
            this.gdvEstoque.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gdvEstoque.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gdvEstoque.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gdvEstoque.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gdvEstoque.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gdvEstoque.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.gdvEstoque.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gdvEstoque.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gdvEstoque.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gdvEstoque.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdvEstoque.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.gdvEstoque.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gdvEstoque.CurrentTheme.Name = null;
            this.gdvEstoque.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvEstoque.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gdvEstoque.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gdvEstoque.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gdvEstoque.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvEstoque.DefaultCellStyle = dataGridViewCellStyle7;
            this.gdvEstoque.EnableHeadersVisualStyles = false;
            this.gdvEstoque.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gdvEstoque.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gdvEstoque.HeaderBgColor = System.Drawing.Color.Empty;
            this.gdvEstoque.HeaderForeColor = System.Drawing.Color.White;
            this.gdvEstoque.Location = new System.Drawing.Point(15, 196);
            this.gdvEstoque.Name = "gdvEstoque";
            this.gdvEstoque.ReadOnly = true;
            this.gdvEstoque.RowHeadersVisible = false;
            this.gdvEstoque.RowHeadersWidth = 50;
            this.gdvEstoque.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdvEstoque.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gdvEstoque.RowTemplate.Height = 40;
            this.gdvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvEstoque.Size = new System.Drawing.Size(632, 303);
            this.gdvEstoque.TabIndex = 163;
            this.gdvEstoque.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.gdvEstoque.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ep_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ep_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ep_nf_entrada";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nº NF";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 78;
            // 
            // ep_codigo_barras
            // 
            this.ep_codigo_barras.DataPropertyName = "ep_codigo_barras";
            this.ep_codigo_barras.HeaderText = "ep_codigo_barras";
            this.ep_codigo_barras.Name = "ep_codigo_barras";
            this.ep_codigo_barras.ReadOnly = true;
            this.ep_codigo_barras.Visible = false;
            this.ep_codigo_barras.Width = 165;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ep_codigo_produto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cod. Prod.";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 112;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ep_descricao";
            this.dataGridViewTextBoxColumn6.HeaderText = "Desc. Prod.";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 117;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ep_quantidade";
            this.dataGridViewTextBoxColumn7.HeaderText = "Quant.";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 83;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ep_unidade";
            this.dataGridViewTextBoxColumn8.HeaderText = "UN";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 58;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ep_valor_unitario";
            this.dataGridViewTextBoxColumn9.HeaderText = "R$ Unit.";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 92;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ep_data_entrada";
            this.dataGridViewTextBoxColumn12.HeaderText = "Entrada";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 90;
            // 
            // ep_desconto_por_item
            // 
            this.ep_desconto_por_item.DataPropertyName = "ep_desconto_por_item";
            this.ep_desconto_por_item.HeaderText = "ep_desconto_por_item";
            this.ep_desconto_por_item.Name = "ep_desconto_por_item";
            this.ep_desconto_por_item.ReadOnly = true;
            this.ep_desconto_por_item.Visible = false;
            this.ep_desconto_por_item.Width = 203;
            // 
            // Forms_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 515);
            this.Controls.Add(this.gdvEstoque);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.gdvCompra);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroNotaFiscal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Forms_Compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.gdvCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuTextBox txtNumeroNotaFiscal;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBuscar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExcluir;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSalvar;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bntSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn ne_indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ne_numero_nf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ne_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ne_razao_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn ne_codigo_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ne_descricao_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ne_quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ne_unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ne_valor_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ne_valor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn ne_data_emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ne_data_lancamento;
        public Bunifu.UI.WinForms.BunifuDataGridView gdvCompra;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAlterar;
        public Bunifu.UI.WinForms.BunifuDataGridView gdvEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ep_codigo_barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ep_desconto_por_item;
    }
}