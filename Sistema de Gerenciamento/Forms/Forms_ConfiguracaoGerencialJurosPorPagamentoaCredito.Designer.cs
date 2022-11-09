
namespace Sistema_de_Gerenciamento.Forms
{
    partial class Forms_ConfiguracaoGerencialJurosPorPagamentoaCredito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forms_ConfiguracaoGerencialJurosPorPagamentoaCredito));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.txtJurosCredito = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbParcelasCredito = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConfirmarCredito = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.logoSistema1 = new Sistema_de_Gerenciamento.LogoSistema();
            this.SuspendLayout();
            // 
            // txtJurosCredito
            // 
            this.txtJurosCredito.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJurosCredito.DefaultText = "";
            this.txtJurosCredito.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJurosCredito.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJurosCredito.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJurosCredito.DisabledState.Parent = this.txtJurosCredito;
            this.txtJurosCredito.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJurosCredito.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJurosCredito.FocusedState.Parent = this.txtJurosCredito;
            this.txtJurosCredito.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJurosCredito.ForeColor = System.Drawing.Color.Black;
            this.txtJurosCredito.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJurosCredito.HoverState.Parent = this.txtJurosCredito;
            this.txtJurosCredito.Location = new System.Drawing.Point(237, 60);
            this.txtJurosCredito.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtJurosCredito.Name = "txtJurosCredito";
            this.txtJurosCredito.PasswordChar = '\0';
            this.txtJurosCredito.PlaceholderText = "";
            this.txtJurosCredito.SelectedText = "";
            this.txtJurosCredito.ShadowDecoration.Parent = this.txtJurosCredito;
            this.txtJurosCredito.ShortcutsEnabled = false;
            this.txtJurosCredito.Size = new System.Drawing.Size(97, 36);
            this.txtJurosCredito.TabIndex = 254;
            this.txtJurosCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtJurosCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJurosCredito_KeyPress);
            // 
            // cmbParcelasCredito
            // 
            this.cmbParcelasCredito.AllowDrop = true;
            this.cmbParcelasCredito.BackColor = System.Drawing.Color.White;
            this.cmbParcelasCredito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParcelasCredito.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParcelasCredito.FormattingEnabled = true;
            this.cmbParcelasCredito.Items.AddRange(new object[] {
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
            this.cmbParcelasCredito.Location = new System.Drawing.Point(77, 73);
            this.cmbParcelasCredito.Name = "cmbParcelasCredito";
            this.cmbParcelasCredito.Size = new System.Drawing.Size(66, 23);
            this.cmbParcelasCredito.TabIndex = 253;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(244, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 30);
            this.label6.TabIndex = 252;
            this.label6.Text = "Porcentagem \r\ndo Juros";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 30);
            this.label7.TabIndex = 251;
            this.label7.Text = "Parcelas P/\r\nGerar Juros";
            // 
            // btnConfirmarCredito
            // 
            this.btnConfirmarCredito.AllowAnimations = true;
            this.btnConfirmarCredito.AllowMouseEffects = true;
            this.btnConfirmarCredito.AllowToggling = false;
            this.btnConfirmarCredito.AnimationSpeed = 200;
            this.btnConfirmarCredito.AutoGenerateColors = false;
            this.btnConfirmarCredito.AutoRoundBorders = false;
            this.btnConfirmarCredito.AutoSizeLeftIcon = true;
            this.btnConfirmarCredito.AutoSizeRightIcon = true;
            this.btnConfirmarCredito.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarCredito.BackColor1 = System.Drawing.Color.Transparent;
            this.btnConfirmarCredito.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmarCredito.BackgroundImage")));
            this.btnConfirmarCredito.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarCredito.ButtonText = "(F10) Confirmar";
            this.btnConfirmarCredito.ButtonTextMarginLeft = 0;
            this.btnConfirmarCredito.ColorContrastOnClick = 45;
            this.btnConfirmarCredito.ColorContrastOnHover = 45;
            this.btnConfirmarCredito.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnConfirmarCredito.CustomizableEdges = borderEdges1;
            this.btnConfirmarCredito.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirmarCredito.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConfirmarCredito.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfirmarCredito.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConfirmarCredito.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnConfirmarCredito.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarCredito.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmarCredito.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarCredito.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmarCredito.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnConfirmarCredito.IconMarginLeft = 11;
            this.btnConfirmarCredito.IconPadding = 10;
            this.btnConfirmarCredito.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmarCredito.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmarCredito.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnConfirmarCredito.IconSize = 25;
            this.btnConfirmarCredito.IdleBorderColor = System.Drawing.Color.Black;
            this.btnConfirmarCredito.IdleBorderRadius = 1;
            this.btnConfirmarCredito.IdleBorderThickness = 1;
            this.btnConfirmarCredito.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnConfirmarCredito.IdleIconLeftImage = null;
            this.btnConfirmarCredito.IdleIconRightImage = null;
            this.btnConfirmarCredito.IndicateFocus = false;
            this.btnConfirmarCredito.Location = new System.Drawing.Point(98, 149);
            this.btnConfirmarCredito.Name = "btnConfirmarCredito";
            this.btnConfirmarCredito.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConfirmarCredito.OnDisabledState.BorderRadius = 1;
            this.btnConfirmarCredito.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarCredito.OnDisabledState.BorderThickness = 1;
            this.btnConfirmarCredito.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfirmarCredito.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConfirmarCredito.OnDisabledState.IconLeftImage = null;
            this.btnConfirmarCredito.OnDisabledState.IconRightImage = null;
            this.btnConfirmarCredito.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConfirmarCredito.onHoverState.BorderRadius = 1;
            this.btnConfirmarCredito.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarCredito.onHoverState.BorderThickness = 1;
            this.btnConfirmarCredito.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConfirmarCredito.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarCredito.onHoverState.IconLeftImage = null;
            this.btnConfirmarCredito.onHoverState.IconRightImage = null;
            this.btnConfirmarCredito.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmarCredito.OnIdleState.BorderRadius = 1;
            this.btnConfirmarCredito.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarCredito.OnIdleState.BorderThickness = 1;
            this.btnConfirmarCredito.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnConfirmarCredito.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmarCredito.OnIdleState.IconLeftImage = null;
            this.btnConfirmarCredito.OnIdleState.IconRightImage = null;
            this.btnConfirmarCredito.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConfirmarCredito.OnPressedState.BorderRadius = 1;
            this.btnConfirmarCredito.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarCredito.OnPressedState.BorderThickness = 1;
            this.btnConfirmarCredito.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConfirmarCredito.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarCredito.OnPressedState.IconLeftImage = null;
            this.btnConfirmarCredito.OnPressedState.IconRightImage = null;
            this.btnConfirmarCredito.Size = new System.Drawing.Size(187, 39);
            this.btnConfirmarCredito.TabIndex = 255;
            this.btnConfirmarCredito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmarCredito.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirmarCredito.TextMarginLeft = 0;
            this.btnConfirmarCredito.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnConfirmarCredito.UseDefaultRadiusAndThickness = true;
            this.btnConfirmarCredito.Click += new System.EventHandler(this.btnConfirmarCredito_Click);
            // 
            // logoSistema1
            // 
            this.logoSistema1.Location = new System.Drawing.Point(280, 191);
            this.logoSistema1.Name = "logoSistema1";
            this.logoSistema1.Size = new System.Drawing.Size(107, 39);
            this.logoSistema1.TabIndex = 256;
            // 
            // Forms_ConfiguracaoGerencialJurosPorPagamentoaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 231);
            this.Controls.Add(this.logoSistema1);
            this.Controls.Add(this.txtJurosCredito);
            this.Controls.Add(this.btnConfirmarCredito);
            this.Controls.Add(this.cmbParcelasCredito);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Forms_ConfiguracaoGerencialJurosPorPagamentoaCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juros Por Pagamento a Credito";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Forms_JurosPorPagamentoaCredito_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtJurosCredito;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnConfirmarCredito;
        public System.Windows.Forms.ComboBox cmbParcelasCredito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private LogoSistema logoSistema1;
    }
}