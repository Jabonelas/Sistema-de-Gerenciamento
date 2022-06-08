namespace Sistema_de_Gerenciamento.Forms
{
    partial class Forms_Despesas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forms_Despesas));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties25 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties26 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties27 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties28 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties29 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties30 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties31 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties32 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.cmbSubGrupo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmpresa = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtCodigo = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoDespesa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVencimento = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAlterar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bntSair = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSalvar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnExcluir = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.txtEmissao = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtValor = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDescricao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbSubGrupo
            // 
            this.cmbSubGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubGrupo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubGrupo.FormattingEnabled = true;
            this.cmbSubGrupo.Items.AddRange(new object[] {
            "Semanal",
            "Quinzenal",
            "Mensal",
            "Bimestral",
            "Semestral",
            "Anual"});
            this.cmbSubGrupo.Location = new System.Drawing.Point(26, 395);
            this.cmbSubGrupo.Name = "cmbSubGrupo";
            this.cmbSubGrupo.Size = new System.Drawing.Size(123, 23);
            this.cmbSubGrupo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 60;
            this.label5.Text = "Tipo de Despesa";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.AcceptsReturn = false;
            this.txtEmpresa.AcceptsTab = false;
            this.txtEmpresa.AnimationSpeed = 200;
            this.txtEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.txtEmpresa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtEmpresa.BackgroundImage")));
            this.txtEmpresa.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtEmpresa.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtEmpresa.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtEmpresa.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtEmpresa.BorderRadius = 1;
            this.txtEmpresa.BorderThickness = 1;
            this.txtEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmpresa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpresa.DefaultFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresa.DefaultText = "";
            this.txtEmpresa.FillColor = System.Drawing.Color.White;
            this.txtEmpresa.HideSelection = true;
            this.txtEmpresa.IconLeft = null;
            this.txtEmpresa.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpresa.IconPadding = 10;
            this.txtEmpresa.IconRight = null;
            this.txtEmpresa.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpresa.Lines = new string[0];
            this.txtEmpresa.Location = new System.Drawing.Point(26, 272);
            this.txtEmpresa.MaxLength = 100;
            this.txtEmpresa.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtEmpresa.Modified = false;
            this.txtEmpresa.Multiline = false;
            this.txtEmpresa.Name = "txtEmpresa";
            stateProperties17.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmpresa.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtEmpresa.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmpresa.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Empty;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmpresa.OnIdleState = stateProperties20;
            this.txtEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.txtEmpresa.PasswordChar = '\0';
            this.txtEmpresa.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtEmpresa.PlaceholderText = "";
            this.txtEmpresa.ReadOnly = false;
            this.txtEmpresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmpresa.SelectedText = "";
            this.txtEmpresa.SelectionLength = 0;
            this.txtEmpresa.SelectionStart = 0;
            this.txtEmpresa.ShortcutsEnabled = true;
            this.txtEmpresa.Size = new System.Drawing.Size(400, 28);
            this.txtEmpresa.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtEmpresa.TabIndex = 61;
            this.txtEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmpresa.TextMarginBottom = 0;
            this.txtEmpresa.TextMarginLeft = 3;
            this.txtEmpresa.TextMarginTop = 0;
            this.txtEmpresa.TextPlaceholder = "";
            this.txtEmpresa.UseSystemPasswordChar = false;
            this.txtEmpresa.WordWrap = true;
            this.txtEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpresa_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BaseColor = System.Drawing.SystemColors.Control;
            this.txtCodigo.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodigo.BorderSize = 1;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.FocusedBaseColor = System.Drawing.SystemColors.Control;
            this.txtCodigo.FocusedBorderColor = System.Drawing.Color.DodgerBlue;
            this.txtCodigo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodigo.Location = new System.Drawing.Point(26, 152);
            this.txtCodigo.MaxLength = 15;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.ShortcutsEnabled = false;
            this.txtCodigo.Size = new System.Drawing.Size(63, 26);
            this.txtCodigo.TabIndex = 166;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 168;
            this.label1.Text = "Código";
            // 
            // cmbTipoDespesa
            // 
            this.cmbTipoDespesa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoDespesa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoDespesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbTipoDespesa.FormattingEnabled = true;
            this.cmbTipoDespesa.Items.AddRange(new object[] {
            ""});
            this.cmbTipoDespesa.Location = new System.Drawing.Point(130, 153);
            this.cmbTipoDespesa.Name = "cmbTipoDespesa";
            this.cmbTipoDespesa.Size = new System.Drawing.Size(296, 26);
            this.cmbTipoDespesa.TabIndex = 239;
            this.cmbTipoDespesa.Enter += new System.EventHandler(this.cmbTipoDespesa_Enter);
            this.cmbTipoDespesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTipoDespesa_KeyPress);
            this.cmbTipoDespesa.Leave += new System.EventHandler(this.cmbTipoDespesa_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 240;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 242;
            this.label3.Text = "Empresa";
            // 
            // txtVencimento
            // 
            this.txtVencimento.AcceptsReturn = false;
            this.txtVencimento.AcceptsTab = false;
            this.txtVencimento.AnimationSpeed = 200;
            this.txtVencimento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtVencimento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtVencimento.BackColor = System.Drawing.Color.Transparent;
            this.txtVencimento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtVencimento.BackgroundImage")));
            this.txtVencimento.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtVencimento.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtVencimento.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtVencimento.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtVencimento.BorderRadius = 1;
            this.txtVencimento.BorderThickness = 1;
            this.txtVencimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtVencimento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVencimento.DefaultFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVencimento.DefaultText = "";
            this.txtVencimento.FillColor = System.Drawing.Color.White;
            this.txtVencimento.HideSelection = true;
            this.txtVencimento.IconLeft = null;
            this.txtVencimento.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVencimento.IconPadding = 10;
            this.txtVencimento.IconRight = null;
            this.txtVencimento.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVencimento.Lines = new string[0];
            this.txtVencimento.Location = new System.Drawing.Point(182, 334);
            this.txtVencimento.MaxLength = 100;
            this.txtVencimento.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtVencimento.Modified = false;
            this.txtVencimento.Multiline = false;
            this.txtVencimento.Name = "txtVencimento";
            stateProperties21.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtVencimento.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtVencimento.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtVencimento.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Silver;
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.Empty;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtVencimento.OnIdleState = stateProperties24;
            this.txtVencimento.Padding = new System.Windows.Forms.Padding(3);
            this.txtVencimento.PasswordChar = '\0';
            this.txtVencimento.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtVencimento.PlaceholderText = "";
            this.txtVencimento.ReadOnly = false;
            this.txtVencimento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVencimento.SelectedText = "";
            this.txtVencimento.SelectionLength = 0;
            this.txtVencimento.SelectionStart = 0;
            this.txtVencimento.ShortcutsEnabled = true;
            this.txtVencimento.Size = new System.Drawing.Size(123, 28);
            this.txtVencimento.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtVencimento.TabIndex = 244;
            this.txtVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtVencimento.TextMarginBottom = 0;
            this.txtVencimento.TextMarginLeft = 3;
            this.txtVencimento.TextMarginTop = 0;
            this.txtVencimento.TextPlaceholder = "";
            this.txtVencimento.UseSystemPasswordChar = false;
            this.txtVencimento.WordWrap = true;
            this.txtVencimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVencimento_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 245;
            this.label4.Text = "Vencimento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 246;
            this.label6.Text = "Emissão";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 247;
            this.label7.Text = "Frequência";
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
            this.btnAlterar.ButtonText = "Alterar \r\n";
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
            this.btnAlterar.Location = new System.Drawing.Point(231, 25);
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
            this.btnAlterar.TabIndex = 252;
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAlterar.TextMarginLeft = 0;
            this.btnAlterar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAlterar.UseDefaultRadiusAndThickness = true;
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
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.bntSair.CustomizableEdges = borderEdges6;
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
            this.bntSair.TabIndex = 251;
            this.bntSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntSair.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bntSair.TextMarginLeft = 0;
            this.bntSair.TextPadding = new System.Windows.Forms.Padding(0);
            this.bntSair.UseDefaultRadiusAndThickness = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
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
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.btnSalvar.CustomizableEdges = borderEdges7;
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
            this.btnSalvar.TabIndex = 250;
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSalvar.TextMarginLeft = 0;
            this.btnSalvar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSalvar.UseDefaultRadiusAndThickness = true;
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
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.btnExcluir.CustomizableEdges = borderEdges8;
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
            this.btnExcluir.Location = new System.Drawing.Point(123, 25);
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
            this.btnExcluir.TabIndex = 249;
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExcluir.TextMarginLeft = 0;
            this.btnExcluir.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnExcluir.UseDefaultRadiusAndThickness = true;
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
            this.bunifuSeparator1.Size = new System.Drawing.Size(424, 20);
            this.bunifuSeparator1.TabIndex = 253;
            // 
            // txtEmissao
            // 
            this.txtEmissao.AcceptsReturn = false;
            this.txtEmissao.AcceptsTab = false;
            this.txtEmissao.AnimationSpeed = 200;
            this.txtEmissao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmissao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmissao.BackColor = System.Drawing.Color.Transparent;
            this.txtEmissao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtEmissao.BackgroundImage")));
            this.txtEmissao.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtEmissao.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtEmissao.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtEmissao.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtEmissao.BorderRadius = 1;
            this.txtEmissao.BorderThickness = 1;
            this.txtEmissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmissao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmissao.DefaultFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmissao.DefaultText = "";
            this.txtEmissao.FillColor = System.Drawing.Color.White;
            this.txtEmissao.HideSelection = true;
            this.txtEmissao.IconLeft = null;
            this.txtEmissao.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmissao.IconPadding = 10;
            this.txtEmissao.IconRight = null;
            this.txtEmissao.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmissao.Lines = new string[0];
            this.txtEmissao.Location = new System.Drawing.Point(26, 334);
            this.txtEmissao.MaxLength = 100;
            this.txtEmissao.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtEmissao.Modified = false;
            this.txtEmissao.Multiline = false;
            this.txtEmissao.Name = "txtEmissao";
            stateProperties25.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties25.FillColor = System.Drawing.Color.Empty;
            stateProperties25.ForeColor = System.Drawing.Color.Empty;
            stateProperties25.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmissao.OnActiveState = stateProperties25;
            stateProperties26.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties26.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties26.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtEmissao.OnDisabledState = stateProperties26;
            stateProperties27.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties27.FillColor = System.Drawing.Color.Empty;
            stateProperties27.ForeColor = System.Drawing.Color.Empty;
            stateProperties27.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmissao.OnHoverState = stateProperties27;
            stateProperties28.BorderColor = System.Drawing.Color.Silver;
            stateProperties28.FillColor = System.Drawing.Color.White;
            stateProperties28.ForeColor = System.Drawing.Color.Empty;
            stateProperties28.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmissao.OnIdleState = stateProperties28;
            this.txtEmissao.Padding = new System.Windows.Forms.Padding(3);
            this.txtEmissao.PasswordChar = '\0';
            this.txtEmissao.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtEmissao.PlaceholderText = "";
            this.txtEmissao.ReadOnly = false;
            this.txtEmissao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmissao.SelectedText = "";
            this.txtEmissao.SelectionLength = 0;
            this.txtEmissao.SelectionStart = 0;
            this.txtEmissao.ShortcutsEnabled = true;
            this.txtEmissao.Size = new System.Drawing.Size(123, 28);
            this.txtEmissao.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtEmissao.TabIndex = 254;
            this.txtEmissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmissao.TextMarginBottom = 0;
            this.txtEmissao.TextMarginLeft = 3;
            this.txtEmissao.TextMarginTop = 0;
            this.txtEmissao.TextPlaceholder = "";
            this.txtEmissao.UseSystemPasswordChar = false;
            this.txtEmissao.WordWrap = true;
            this.txtEmissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmissao_KeyPress);
            this.txtEmissao.Leave += new System.EventHandler(this.txtEmissao_Leave);
            // 
            // txtValor
            // 
            this.txtValor.AcceptsReturn = false;
            this.txtValor.AcceptsTab = false;
            this.txtValor.AnimationSpeed = 200;
            this.txtValor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtValor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtValor.BackColor = System.Drawing.Color.Transparent;
            this.txtValor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtValor.BackgroundImage")));
            this.txtValor.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtValor.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtValor.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtValor.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtValor.BorderRadius = 1;
            this.txtValor.BorderThickness = 1;
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.DefaultFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.DefaultText = "";
            this.txtValor.FillColor = System.Drawing.Color.White;
            this.txtValor.HideSelection = true;
            this.txtValor.IconLeft = null;
            this.txtValor.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.IconPadding = 10;
            this.txtValor.IconRight = null;
            this.txtValor.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.Lines = new string[0];
            this.txtValor.Location = new System.Drawing.Point(26, 450);
            this.txtValor.MaxLength = 100;
            this.txtValor.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtValor.Modified = false;
            this.txtValor.Multiline = false;
            this.txtValor.Name = "txtValor";
            stateProperties29.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties29.FillColor = System.Drawing.Color.Empty;
            stateProperties29.ForeColor = System.Drawing.Color.Empty;
            stateProperties29.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtValor.OnActiveState = stateProperties29;
            stateProperties30.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties30.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties30.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtValor.OnDisabledState = stateProperties30;
            stateProperties31.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties31.FillColor = System.Drawing.Color.Empty;
            stateProperties31.ForeColor = System.Drawing.Color.Empty;
            stateProperties31.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtValor.OnHoverState = stateProperties31;
            stateProperties32.BorderColor = System.Drawing.Color.Silver;
            stateProperties32.FillColor = System.Drawing.Color.White;
            stateProperties32.ForeColor = System.Drawing.Color.Empty;
            stateProperties32.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtValor.OnIdleState = stateProperties32;
            this.txtValor.Padding = new System.Windows.Forms.Padding(3);
            this.txtValor.PasswordChar = '\0';
            this.txtValor.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtValor.PlaceholderText = "";
            this.txtValor.ReadOnly = false;
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.ShortcutsEnabled = true;
            this.txtValor.Size = new System.Drawing.Size(123, 28);
            this.txtValor.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtValor.TabIndex = 255;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtValor.TextMarginBottom = 0;
            this.txtValor.TextMarginLeft = 3;
            this.txtValor.TextMarginTop = 0;
            this.txtValor.TextPlaceholder = "";
            this.txtValor.UseSystemPasswordChar = false;
            this.txtValor.WordWrap = true;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 256;
            this.label8.Text = "Valor";
            // 
            // cmbDescricao
            // 
            this.cmbDescricao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDescricao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDescricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbDescricao.FormattingEnabled = true;
            this.cmbDescricao.Items.AddRange(new object[] {
            ""});
            this.cmbDescricao.Location = new System.Drawing.Point(26, 211);
            this.cmbDescricao.Name = "cmbDescricao";
            this.cmbDescricao.Size = new System.Drawing.Size(400, 26);
            this.cmbDescricao.TabIndex = 248;
            this.cmbDescricao.SelectedIndexChanged += new System.EventHandler(this.cmbDescricao_SelectedIndexChanged);
            this.cmbDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDescricao_KeyPress);
            // 
            // Forms_Despesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 494);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtEmissao);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.cmbDescricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVencimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoDespesa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSubGrupo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Forms_Despesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Despesas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbSubGrupo;
        private System.Windows.Forms.Label label5;
        public Bunifu.UI.WinForms.BunifuTextBox txtEmpresa;
        public Guna.UI.WinForms.GunaTextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoDespesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public Bunifu.UI.WinForms.BunifuTextBox txtVencimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAlterar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bntSair;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSalvar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExcluir;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        public Bunifu.UI.WinForms.BunifuTextBox txtEmissao;
        public Bunifu.UI.WinForms.BunifuTextBox txtValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDescricao;
    }
}