
namespace Sistema_de_Gerenciamento.Forms
{
    partial class Forms_ConfiguracaoGerencialDescontoPorPagamentoAvista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forms_ConfiguracaoGerencialDescontoPorPagamentoAvista));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.txtDescontoAvista = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmarAvista = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // txtDescontoAvista
            // 
            this.txtDescontoAvista.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescontoAvista.DefaultText = "";
            this.txtDescontoAvista.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescontoAvista.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescontoAvista.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescontoAvista.DisabledState.Parent = this.txtDescontoAvista;
            this.txtDescontoAvista.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescontoAvista.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescontoAvista.FocusedState.Parent = this.txtDescontoAvista;
            this.txtDescontoAvista.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontoAvista.ForeColor = System.Drawing.Color.Black;
            this.txtDescontoAvista.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescontoAvista.HoverState.Parent = this.txtDescontoAvista;
            this.txtDescontoAvista.Location = new System.Drawing.Point(117, 57);
            this.txtDescontoAvista.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtDescontoAvista.Name = "txtDescontoAvista";
            this.txtDescontoAvista.PasswordChar = '\0';
            this.txtDescontoAvista.PlaceholderText = "";
            this.txtDescontoAvista.SelectedText = "";
            this.txtDescontoAvista.ShadowDecoration.Parent = this.txtDescontoAvista;
            this.txtDescontoAvista.ShortcutsEnabled = false;
            this.txtDescontoAvista.Size = new System.Drawing.Size(97, 36);
            this.txtDescontoAvista.TabIndex = 255;
            this.txtDescontoAvista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescontoAvista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescontoAvista_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 30);
            this.label5.TabIndex = 253;
            this.label5.Text = "Porcentagem \r\ndo Desconto";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirmarAvista
            // 
            this.btnConfirmarAvista.AllowAnimations = true;
            this.btnConfirmarAvista.AllowMouseEffects = true;
            this.btnConfirmarAvista.AllowToggling = false;
            this.btnConfirmarAvista.AnimationSpeed = 200;
            this.btnConfirmarAvista.AutoGenerateColors = false;
            this.btnConfirmarAvista.AutoRoundBorders = false;
            this.btnConfirmarAvista.AutoSizeLeftIcon = true;
            this.btnConfirmarAvista.AutoSizeRightIcon = true;
            this.btnConfirmarAvista.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarAvista.BackColor1 = System.Drawing.Color.Transparent;
            this.btnConfirmarAvista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmarAvista.BackgroundImage")));
            this.btnConfirmarAvista.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarAvista.ButtonText = "(F10) Confirmar";
            this.btnConfirmarAvista.ButtonTextMarginLeft = 0;
            this.btnConfirmarAvista.ColorContrastOnClick = 45;
            this.btnConfirmarAvista.ColorContrastOnHover = 45;
            this.btnConfirmarAvista.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnConfirmarAvista.CustomizableEdges = borderEdges1;
            this.btnConfirmarAvista.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirmarAvista.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConfirmarAvista.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfirmarAvista.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConfirmarAvista.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnConfirmarAvista.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarAvista.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmarAvista.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarAvista.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmarAvista.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnConfirmarAvista.IconMarginLeft = 11;
            this.btnConfirmarAvista.IconPadding = 10;
            this.btnConfirmarAvista.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmarAvista.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmarAvista.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnConfirmarAvista.IconSize = 25;
            this.btnConfirmarAvista.IdleBorderColor = System.Drawing.Color.Black;
            this.btnConfirmarAvista.IdleBorderRadius = 1;
            this.btnConfirmarAvista.IdleBorderThickness = 1;
            this.btnConfirmarAvista.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnConfirmarAvista.IdleIconLeftImage = null;
            this.btnConfirmarAvista.IdleIconRightImage = null;
            this.btnConfirmarAvista.IndicateFocus = false;
            this.btnConfirmarAvista.Location = new System.Drawing.Point(75, 140);
            this.btnConfirmarAvista.Name = "btnConfirmarAvista";
            this.btnConfirmarAvista.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConfirmarAvista.OnDisabledState.BorderRadius = 1;
            this.btnConfirmarAvista.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarAvista.OnDisabledState.BorderThickness = 1;
            this.btnConfirmarAvista.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfirmarAvista.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConfirmarAvista.OnDisabledState.IconLeftImage = null;
            this.btnConfirmarAvista.OnDisabledState.IconRightImage = null;
            this.btnConfirmarAvista.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConfirmarAvista.onHoverState.BorderRadius = 1;
            this.btnConfirmarAvista.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarAvista.onHoverState.BorderThickness = 1;
            this.btnConfirmarAvista.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConfirmarAvista.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarAvista.onHoverState.IconLeftImage = null;
            this.btnConfirmarAvista.onHoverState.IconRightImage = null;
            this.btnConfirmarAvista.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmarAvista.OnIdleState.BorderRadius = 1;
            this.btnConfirmarAvista.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarAvista.OnIdleState.BorderThickness = 1;
            this.btnConfirmarAvista.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnConfirmarAvista.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmarAvista.OnIdleState.IconLeftImage = null;
            this.btnConfirmarAvista.OnIdleState.IconRightImage = null;
            this.btnConfirmarAvista.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConfirmarAvista.OnPressedState.BorderRadius = 1;
            this.btnConfirmarAvista.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarAvista.OnPressedState.BorderThickness = 1;
            this.btnConfirmarAvista.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConfirmarAvista.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarAvista.OnPressedState.IconLeftImage = null;
            this.btnConfirmarAvista.OnPressedState.IconRightImage = null;
            this.btnConfirmarAvista.Size = new System.Drawing.Size(187, 39);
            this.btnConfirmarAvista.TabIndex = 254;
            this.btnConfirmarAvista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmarAvista.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirmarAvista.TextMarginLeft = 0;
            this.btnConfirmarAvista.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnConfirmarAvista.UseDefaultRadiusAndThickness = true;
            this.btnConfirmarAvista.Click += new System.EventHandler(this.btnConfirmarAvista_Click);
            // 
            // Forms_ConfiguracaoGerencialDescontoPorPagamentoAvista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 212);
            this.Controls.Add(this.txtDescontoAvista);
            this.Controls.Add(this.btnConfirmarAvista);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Forms_ConfiguracaoGerencialDescontoPorPagamentoAvista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração Gerencial Desconto Por Pagamento Avista";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Forms_ConfiguracaoGerencialDescontoPorPagamentoAvista_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtDescontoAvista;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnConfirmarAvista;
        private System.Windows.Forms.Label label5;
    }
}