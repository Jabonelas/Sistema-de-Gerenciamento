
namespace Sistema_de_Gerenciamento.Forms
{
    partial class Forms_ConfiguracaoGerencialComissaoPorProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forms_ConfiguracaoGerencialComissaoPorProduto));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.txtComissao = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnConfirmarComissao = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // txtComissao
            // 
            this.txtComissao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComissao.DefaultText = "";
            this.txtComissao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtComissao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtComissao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComissao.DisabledState.Parent = this.txtComissao;
            this.txtComissao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComissao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComissao.FocusedState.Parent = this.txtComissao;
            this.txtComissao.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComissao.ForeColor = System.Drawing.Color.Black;
            this.txtComissao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComissao.HoverState.Parent = this.txtComissao;
            this.txtComissao.Location = new System.Drawing.Point(121, 55);
            this.txtComissao.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.PasswordChar = '\0';
            this.txtComissao.PlaceholderText = "";
            this.txtComissao.SelectedText = "";
            this.txtComissao.ShadowDecoration.Parent = this.txtComissao;
            this.txtComissao.ShortcutsEnabled = false;
            this.txtComissao.Size = new System.Drawing.Size(97, 36);
            this.txtComissao.TabIndex = 254;
            this.txtComissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtComissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComissao_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(128, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 30);
            this.label15.TabIndex = 252;
            this.label15.Text = "Porcentagem \r\nda Comissão";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirmarComissao
            // 
            this.btnConfirmarComissao.AllowAnimations = true;
            this.btnConfirmarComissao.AllowMouseEffects = true;
            this.btnConfirmarComissao.AllowToggling = false;
            this.btnConfirmarComissao.AnimationSpeed = 200;
            this.btnConfirmarComissao.AutoGenerateColors = false;
            this.btnConfirmarComissao.AutoRoundBorders = false;
            this.btnConfirmarComissao.AutoSizeLeftIcon = true;
            this.btnConfirmarComissao.AutoSizeRightIcon = true;
            this.btnConfirmarComissao.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarComissao.BackColor1 = System.Drawing.Color.Transparent;
            this.btnConfirmarComissao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmarComissao.BackgroundImage")));
            this.btnConfirmarComissao.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarComissao.ButtonText = "(F10) Confirmar";
            this.btnConfirmarComissao.ButtonTextMarginLeft = 0;
            this.btnConfirmarComissao.ColorContrastOnClick = 45;
            this.btnConfirmarComissao.ColorContrastOnHover = 45;
            this.btnConfirmarComissao.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnConfirmarComissao.CustomizableEdges = borderEdges1;
            this.btnConfirmarComissao.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirmarComissao.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConfirmarComissao.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfirmarComissao.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConfirmarComissao.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnConfirmarComissao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarComissao.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmarComissao.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarComissao.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmarComissao.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnConfirmarComissao.IconMarginLeft = 11;
            this.btnConfirmarComissao.IconPadding = 10;
            this.btnConfirmarComissao.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmarComissao.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmarComissao.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnConfirmarComissao.IconSize = 25;
            this.btnConfirmarComissao.IdleBorderColor = System.Drawing.Color.Black;
            this.btnConfirmarComissao.IdleBorderRadius = 1;
            this.btnConfirmarComissao.IdleBorderThickness = 1;
            this.btnConfirmarComissao.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnConfirmarComissao.IdleIconLeftImage = null;
            this.btnConfirmarComissao.IdleIconRightImage = null;
            this.btnConfirmarComissao.IndicateFocus = false;
            this.btnConfirmarComissao.Location = new System.Drawing.Point(73, 135);
            this.btnConfirmarComissao.Name = "btnConfirmarComissao";
            this.btnConfirmarComissao.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConfirmarComissao.OnDisabledState.BorderRadius = 1;
            this.btnConfirmarComissao.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarComissao.OnDisabledState.BorderThickness = 1;
            this.btnConfirmarComissao.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfirmarComissao.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConfirmarComissao.OnDisabledState.IconLeftImage = null;
            this.btnConfirmarComissao.OnDisabledState.IconRightImage = null;
            this.btnConfirmarComissao.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConfirmarComissao.onHoverState.BorderRadius = 1;
            this.btnConfirmarComissao.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarComissao.onHoverState.BorderThickness = 1;
            this.btnConfirmarComissao.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConfirmarComissao.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarComissao.onHoverState.IconLeftImage = null;
            this.btnConfirmarComissao.onHoverState.IconRightImage = null;
            this.btnConfirmarComissao.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmarComissao.OnIdleState.BorderRadius = 1;
            this.btnConfirmarComissao.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarComissao.OnIdleState.BorderThickness = 1;
            this.btnConfirmarComissao.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnConfirmarComissao.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmarComissao.OnIdleState.IconLeftImage = null;
            this.btnConfirmarComissao.OnIdleState.IconRightImage = null;
            this.btnConfirmarComissao.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConfirmarComissao.OnPressedState.BorderRadius = 1;
            this.btnConfirmarComissao.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarComissao.OnPressedState.BorderThickness = 1;
            this.btnConfirmarComissao.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConfirmarComissao.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarComissao.OnPressedState.IconLeftImage = null;
            this.btnConfirmarComissao.OnPressedState.IconRightImage = null;
            this.btnConfirmarComissao.Size = new System.Drawing.Size(187, 39);
            this.btnConfirmarComissao.TabIndex = 253;
            this.btnConfirmarComissao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmarComissao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirmarComissao.TextMarginLeft = 0;
            this.btnConfirmarComissao.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnConfirmarComissao.UseDefaultRadiusAndThickness = true;
            this.btnConfirmarComissao.Click += new System.EventHandler(this.btnConfirmarComissao_Click);
            // 
            // Forms_ConfiguracaoGerencialComissaoPorProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 212);
            this.Controls.Add(this.txtComissao);
            this.Controls.Add(this.btnConfirmarComissao);
            this.Controls.Add(this.label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Forms_ConfiguracaoGerencialComissaoPorProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração Gerencial Comissão Por Produto";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Forms_ConfiguracaoGerencialComissãoPorProduto_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtComissao;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnConfirmarComissao;
        private System.Windows.Forms.Label label15;
    }
}