
namespace Sistema_de_Gerenciamento.Forms
{
    partial class Forms_ConfiguracaoGerencialPagamentoCarne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forms_ConfiguracaoGerencialPagamentoCarne));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.txtMultaCarneAtrasoPagamento = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtJurosCarneAtrasoPagamento = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtJurosCarneParcelas = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbParcelasCarne = new System.Windows.Forms.ComboBox();
            this.btnConfirmarCarne = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtPrazoCarne = new Bunifu.UI.WinForms.BunifuTextBox();
            this.SuspendLayout();
            // 
            // txtMultaCarneAtrasoPagamento
            // 
            this.txtMultaCarneAtrasoPagamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMultaCarneAtrasoPagamento.DefaultText = "";
            this.txtMultaCarneAtrasoPagamento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMultaCarneAtrasoPagamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMultaCarneAtrasoPagamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMultaCarneAtrasoPagamento.DisabledState.Parent = this.txtMultaCarneAtrasoPagamento;
            this.txtMultaCarneAtrasoPagamento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMultaCarneAtrasoPagamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMultaCarneAtrasoPagamento.FocusedState.Parent = this.txtMultaCarneAtrasoPagamento;
            this.txtMultaCarneAtrasoPagamento.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMultaCarneAtrasoPagamento.ForeColor = System.Drawing.Color.Black;
            this.txtMultaCarneAtrasoPagamento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMultaCarneAtrasoPagamento.HoverState.Parent = this.txtMultaCarneAtrasoPagamento;
            this.txtMultaCarneAtrasoPagamento.Location = new System.Drawing.Point(205, 174);
            this.txtMultaCarneAtrasoPagamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMultaCarneAtrasoPagamento.Name = "txtMultaCarneAtrasoPagamento";
            this.txtMultaCarneAtrasoPagamento.PasswordChar = '\0';
            this.txtMultaCarneAtrasoPagamento.PlaceholderText = "";
            this.txtMultaCarneAtrasoPagamento.SelectedText = "";
            this.txtMultaCarneAtrasoPagamento.ShadowDecoration.Parent = this.txtMultaCarneAtrasoPagamento;
            this.txtMultaCarneAtrasoPagamento.ShortcutsEnabled = false;
            this.txtMultaCarneAtrasoPagamento.Size = new System.Drawing.Size(97, 36);
            this.txtMultaCarneAtrasoPagamento.TabIndex = 276;
            this.txtMultaCarneAtrasoPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMultaCarneAtrasoPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMultaCarneAtrasoPagamento_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(203, 128);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 30);
            this.label17.TabIndex = 275;
            this.label17.Text = "Porcentagem \r\nMulta Por Atraso";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtJurosCarneAtrasoPagamento
            // 
            this.txtJurosCarneAtrasoPagamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJurosCarneAtrasoPagamento.DefaultText = "";
            this.txtJurosCarneAtrasoPagamento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJurosCarneAtrasoPagamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJurosCarneAtrasoPagamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJurosCarneAtrasoPagamento.DisabledState.Parent = this.txtJurosCarneAtrasoPagamento;
            this.txtJurosCarneAtrasoPagamento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJurosCarneAtrasoPagamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJurosCarneAtrasoPagamento.FocusedState.Parent = this.txtJurosCarneAtrasoPagamento;
            this.txtJurosCarneAtrasoPagamento.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJurosCarneAtrasoPagamento.ForeColor = System.Drawing.Color.Black;
            this.txtJurosCarneAtrasoPagamento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJurosCarneAtrasoPagamento.HoverState.Parent = this.txtJurosCarneAtrasoPagamento;
            this.txtJurosCarneAtrasoPagamento.Location = new System.Drawing.Point(388, 58);
            this.txtJurosCarneAtrasoPagamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtJurosCarneAtrasoPagamento.Name = "txtJurosCarneAtrasoPagamento";
            this.txtJurosCarneAtrasoPagamento.PasswordChar = '\0';
            this.txtJurosCarneAtrasoPagamento.PlaceholderText = "";
            this.txtJurosCarneAtrasoPagamento.SelectedText = "";
            this.txtJurosCarneAtrasoPagamento.ShadowDecoration.Parent = this.txtJurosCarneAtrasoPagamento;
            this.txtJurosCarneAtrasoPagamento.ShortcutsEnabled = false;
            this.txtJurosCarneAtrasoPagamento.Size = new System.Drawing.Size(97, 36);
            this.txtJurosCarneAtrasoPagamento.TabIndex = 274;
            this.txtJurosCarneAtrasoPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtJurosCarneAtrasoPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJurosCarneAtrasoPagamento_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(374, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 30);
            this.label16.TabIndex = 273;
            this.label16.Text = "Porcentagem do Juros\r\nPor Dia de Atraso";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtJurosCarneParcelas
            // 
            this.txtJurosCarneParcelas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJurosCarneParcelas.DefaultText = "";
            this.txtJurosCarneParcelas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJurosCarneParcelas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJurosCarneParcelas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJurosCarneParcelas.DisabledState.Parent = this.txtJurosCarneParcelas;
            this.txtJurosCarneParcelas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJurosCarneParcelas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJurosCarneParcelas.FocusedState.Parent = this.txtJurosCarneParcelas;
            this.txtJurosCarneParcelas.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJurosCarneParcelas.ForeColor = System.Drawing.Color.Black;
            this.txtJurosCarneParcelas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJurosCarneParcelas.HoverState.Parent = this.txtJurosCarneParcelas;
            this.txtJurosCarneParcelas.Location = new System.Drawing.Point(205, 58);
            this.txtJurosCarneParcelas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtJurosCarneParcelas.Name = "txtJurosCarneParcelas";
            this.txtJurosCarneParcelas.PasswordChar = '\0';
            this.txtJurosCarneParcelas.PlaceholderText = "";
            this.txtJurosCarneParcelas.SelectedText = "";
            this.txtJurosCarneParcelas.ShadowDecoration.Parent = this.txtJurosCarneParcelas;
            this.txtJurosCarneParcelas.ShortcutsEnabled = false;
            this.txtJurosCarneParcelas.Size = new System.Drawing.Size(97, 36);
            this.txtJurosCarneParcelas.TabIndex = 271;
            this.txtJurosCarneParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtJurosCarneParcelas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJurosCarneParcelas_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 30);
            this.label11.TabIndex = 268;
            this.label11.Text = "Parcelas P/\r\nGerar Juros";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 30);
            this.label9.TabIndex = 270;
            this.label9.Text = "Prazo P/ \r\n1ª Parcela Dias";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(203, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 30);
            this.label10.TabIndex = 267;
            this.label10.Text = "Porcentagem \r\ndo Juros Parcelas";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbParcelasCarne
            // 
            this.cmbParcelasCarne.AllowDrop = true;
            this.cmbParcelasCarne.BackColor = System.Drawing.Color.White;
            this.cmbParcelasCarne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParcelasCarne.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParcelasCarne.FormattingEnabled = true;
            this.cmbParcelasCarne.Items.AddRange(new object[] {
            "x1",
            "x2",
            "x3",
            "x4",
            "x5",
            "x6",
            "x7",
            "x8",
            "x9",
            "x10",
            "x11",
            "x12",
            ""});
            this.cmbParcelasCarne.Location = new System.Drawing.Point(31, 66);
            this.cmbParcelasCarne.Name = "cmbParcelasCarne";
            this.cmbParcelasCarne.Size = new System.Drawing.Size(66, 23);
            this.cmbParcelasCarne.TabIndex = 266;
            // 
            // btnConfirmarCarne
            // 
            this.btnConfirmarCarne.AllowAnimations = true;
            this.btnConfirmarCarne.AllowMouseEffects = true;
            this.btnConfirmarCarne.AllowToggling = false;
            this.btnConfirmarCarne.AnimationSpeed = 200;
            this.btnConfirmarCarne.AutoGenerateColors = false;
            this.btnConfirmarCarne.AutoRoundBorders = false;
            this.btnConfirmarCarne.AutoSizeLeftIcon = true;
            this.btnConfirmarCarne.AutoSizeRightIcon = true;
            this.btnConfirmarCarne.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarCarne.BackColor1 = System.Drawing.Color.Transparent;
            this.btnConfirmarCarne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmarCarne.BackgroundImage")));
            this.btnConfirmarCarne.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarCarne.ButtonText = "(F10) Confirmar";
            this.btnConfirmarCarne.ButtonTextMarginLeft = 0;
            this.btnConfirmarCarne.ColorContrastOnClick = 45;
            this.btnConfirmarCarne.ColorContrastOnHover = 45;
            this.btnConfirmarCarne.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnConfirmarCarne.CustomizableEdges = borderEdges1;
            this.btnConfirmarCarne.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirmarCarne.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConfirmarCarne.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfirmarCarne.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConfirmarCarne.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnConfirmarCarne.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarCarne.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmarCarne.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarCarne.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmarCarne.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnConfirmarCarne.IconMarginLeft = 11;
            this.btnConfirmarCarne.IconPadding = 10;
            this.btnConfirmarCarne.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmarCarne.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmarCarne.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnConfirmarCarne.IconSize = 25;
            this.btnConfirmarCarne.IdleBorderColor = System.Drawing.Color.Black;
            this.btnConfirmarCarne.IdleBorderRadius = 1;
            this.btnConfirmarCarne.IdleBorderThickness = 1;
            this.btnConfirmarCarne.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnConfirmarCarne.IdleIconLeftImage = null;
            this.btnConfirmarCarne.IdleIconRightImage = null;
            this.btnConfirmarCarne.IndicateFocus = false;
            this.btnConfirmarCarne.Location = new System.Drawing.Point(169, 255);
            this.btnConfirmarCarne.Name = "btnConfirmarCarne";
            this.btnConfirmarCarne.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConfirmarCarne.OnDisabledState.BorderRadius = 1;
            this.btnConfirmarCarne.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarCarne.OnDisabledState.BorderThickness = 1;
            this.btnConfirmarCarne.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfirmarCarne.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConfirmarCarne.OnDisabledState.IconLeftImage = null;
            this.btnConfirmarCarne.OnDisabledState.IconRightImage = null;
            this.btnConfirmarCarne.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConfirmarCarne.onHoverState.BorderRadius = 1;
            this.btnConfirmarCarne.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarCarne.onHoverState.BorderThickness = 1;
            this.btnConfirmarCarne.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConfirmarCarne.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarCarne.onHoverState.IconLeftImage = null;
            this.btnConfirmarCarne.onHoverState.IconRightImage = null;
            this.btnConfirmarCarne.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmarCarne.OnIdleState.BorderRadius = 1;
            this.btnConfirmarCarne.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarCarne.OnIdleState.BorderThickness = 1;
            this.btnConfirmarCarne.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnConfirmarCarne.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmarCarne.OnIdleState.IconLeftImage = null;
            this.btnConfirmarCarne.OnIdleState.IconRightImage = null;
            this.btnConfirmarCarne.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConfirmarCarne.OnPressedState.BorderRadius = 1;
            this.btnConfirmarCarne.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarCarne.OnPressedState.BorderThickness = 1;
            this.btnConfirmarCarne.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConfirmarCarne.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarCarne.OnPressedState.IconLeftImage = null;
            this.btnConfirmarCarne.OnPressedState.IconRightImage = null;
            this.btnConfirmarCarne.Size = new System.Drawing.Size(187, 39);
            this.btnConfirmarCarne.TabIndex = 272;
            this.btnConfirmarCarne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmarCarne.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirmarCarne.TextMarginLeft = 0;
            this.btnConfirmarCarne.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnConfirmarCarne.UseDefaultRadiusAndThickness = true;
            this.btnConfirmarCarne.Click += new System.EventHandler(this.btnConfirmarCarne_Click);
            // 
            // txtPrazoCarne
            // 
            this.txtPrazoCarne.AcceptsReturn = false;
            this.txtPrazoCarne.AcceptsTab = false;
            this.txtPrazoCarne.AnimationSpeed = 200;
            this.txtPrazoCarne.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPrazoCarne.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPrazoCarne.BackColor = System.Drawing.Color.Transparent;
            this.txtPrazoCarne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPrazoCarne.BackgroundImage")));
            this.txtPrazoCarne.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtPrazoCarne.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPrazoCarne.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtPrazoCarne.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPrazoCarne.BorderRadius = 1;
            this.txtPrazoCarne.BorderThickness = 1;
            this.txtPrazoCarne.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrazoCarne.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrazoCarne.DefaultFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrazoCarne.DefaultText = "";
            this.txtPrazoCarne.FillColor = System.Drawing.Color.White;
            this.txtPrazoCarne.HideSelection = true;
            this.txtPrazoCarne.IconLeft = null;
            this.txtPrazoCarne.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrazoCarne.IconPadding = 10;
            this.txtPrazoCarne.IconRight = null;
            this.txtPrazoCarne.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrazoCarne.Lines = new string[0];
            this.txtPrazoCarne.Location = new System.Drawing.Point(31, 174);
            this.txtPrazoCarne.MaxLength = 3;
            this.txtPrazoCarne.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPrazoCarne.Modified = false;
            this.txtPrazoCarne.Multiline = false;
            this.txtPrazoCarne.Name = "txtPrazoCarne";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPrazoCarne.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPrazoCarne.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPrazoCarne.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPrazoCarne.OnIdleState = stateProperties4;
            this.txtPrazoCarne.Padding = new System.Windows.Forms.Padding(3);
            this.txtPrazoCarne.PasswordChar = '\0';
            this.txtPrazoCarne.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPrazoCarne.PlaceholderText = "";
            this.txtPrazoCarne.ReadOnly = false;
            this.txtPrazoCarne.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrazoCarne.SelectedText = "";
            this.txtPrazoCarne.SelectionLength = 0;
            this.txtPrazoCarne.SelectionStart = 0;
            this.txtPrazoCarne.ShortcutsEnabled = false;
            this.txtPrazoCarne.Size = new System.Drawing.Size(97, 36);
            this.txtPrazoCarne.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPrazoCarne.TabIndex = 269;
            this.txtPrazoCarne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrazoCarne.TextMarginBottom = 0;
            this.txtPrazoCarne.TextMarginLeft = 3;
            this.txtPrazoCarne.TextMarginTop = 0;
            this.txtPrazoCarne.TextPlaceholder = "";
            this.txtPrazoCarne.UseSystemPasswordChar = false;
            this.txtPrazoCarne.WordWrap = true;
            this.txtPrazoCarne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrazoCarne_KeyPress);
            // 
            // Forms_ConfiguracaoGerencialPagamentoCarne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 314);
            this.Controls.Add(this.txtMultaCarneAtrasoPagamento);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtJurosCarneAtrasoPagamento);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtJurosCarneParcelas);
            this.Controls.Add(this.btnConfirmarCarne);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPrazoCarne);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbParcelasCarne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "Forms_ConfiguracaoGerencialPagamentoCarne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracao Gerencial Pagamento Carne";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Forms_ConfiguracaoGerencialPagamentoCarne_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtMultaCarneAtrasoPagamento;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2TextBox txtJurosCarneAtrasoPagamento;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox txtJurosCarneParcelas;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnConfirmarCarne;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        public Bunifu.UI.WinForms.BunifuTextBox txtPrazoCarne;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmbParcelasCarne;
    }
}