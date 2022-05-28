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
            this.txtNumeroNotaFiscal = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnExcluir = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSalvar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.gdvCompra = new Bunifu.UI.WinForms.BunifuDataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.gdvCompra)).BeginInit();
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
            this.bntSair.Location = new System.Drawing.Point(338, 25);
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
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 515);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.gdvCompra);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroNotaFiscal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.gdvCompra)).EndInit();
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
        private Bunifu.UI.WinForms.BunifuDataGridView gdvCompra;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bntSair;
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
    }
}