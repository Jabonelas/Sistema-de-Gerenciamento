
namespace Sistema_de_Gerenciamento.Forms
{
    partial class Forms_ConfiguracaoGerencialDescontoGrupoSubGrupoProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forms_ConfiguracaoGerencialDescontoGrupoSubGrupoProdutos));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.txtDescontoPorGrupo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSub_GrupoProduto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGrupoProduto = new System.Windows.Forms.ComboBox();
            this.btnConfirmarGrupo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // txtDescontoPorGrupo
            // 
            this.txtDescontoPorGrupo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescontoPorGrupo.DefaultText = "";
            this.txtDescontoPorGrupo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescontoPorGrupo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescontoPorGrupo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescontoPorGrupo.DisabledState.Parent = this.txtDescontoPorGrupo;
            this.txtDescontoPorGrupo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescontoPorGrupo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescontoPorGrupo.FocusedState.Parent = this.txtDescontoPorGrupo;
            this.txtDescontoPorGrupo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontoPorGrupo.ForeColor = System.Drawing.Color.Black;
            this.txtDescontoPorGrupo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescontoPorGrupo.HoverState.Parent = this.txtDescontoPorGrupo;
            this.txtDescontoPorGrupo.Location = new System.Drawing.Point(238, 80);
            this.txtDescontoPorGrupo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtDescontoPorGrupo.Name = "txtDescontoPorGrupo";
            this.txtDescontoPorGrupo.PasswordChar = '\0';
            this.txtDescontoPorGrupo.PlaceholderText = "";
            this.txtDescontoPorGrupo.SelectedText = "";
            this.txtDescontoPorGrupo.ShadowDecoration.Parent = this.txtDescontoPorGrupo;
            this.txtDescontoPorGrupo.ShortcutsEnabled = false;
            this.txtDescontoPorGrupo.Size = new System.Drawing.Size(97, 36);
            this.txtDescontoPorGrupo.TabIndex = 260;
            this.txtDescontoPorGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescontoPorGrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescontoPorGrupo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 30);
            this.label4.TabIndex = 258;
            this.label4.Text = "Porcentagem \r\ndo Desconto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSub_GrupoProduto
            // 
            this.cmbSub_GrupoProduto.AllowDrop = true;
            this.cmbSub_GrupoProduto.BackColor = System.Drawing.Color.White;
            this.cmbSub_GrupoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSub_GrupoProduto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSub_GrupoProduto.FormattingEnabled = true;
            this.cmbSub_GrupoProduto.Location = new System.Drawing.Point(12, 119);
            this.cmbSub_GrupoProduto.Name = "cmbSub_GrupoProduto";
            this.cmbSub_GrupoProduto.Size = new System.Drawing.Size(135, 23);
            this.cmbSub_GrupoProduto.TabIndex = 257;
            this.cmbSub_GrupoProduto.Enter += new System.EventHandler(this.cmbSub_GrupoProduto_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 254;
            this.label1.Text = "Grupo Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 256;
            this.label2.Text = "Sub-Grupo Produto";
            // 
            // cmbGrupoProduto
            // 
            this.cmbGrupoProduto.AllowDrop = true;
            this.cmbGrupoProduto.BackColor = System.Drawing.Color.White;
            this.cmbGrupoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupoProduto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrupoProduto.FormattingEnabled = true;
            this.cmbGrupoProduto.Items.AddRange(new object[] {
            "wef",
            "iop"});
            this.cmbGrupoProduto.Location = new System.Drawing.Point(12, 51);
            this.cmbGrupoProduto.Name = "cmbGrupoProduto";
            this.cmbGrupoProduto.Size = new System.Drawing.Size(135, 23);
            this.cmbGrupoProduto.TabIndex = 255;
            this.cmbGrupoProduto.SelectedValueChanged += new System.EventHandler(this.cmbGrupoProduto_SelectedValueChanged);
            // 
            // btnConfirmarGrupo
            // 
            this.btnConfirmarGrupo.AllowAnimations = true;
            this.btnConfirmarGrupo.AllowMouseEffects = true;
            this.btnConfirmarGrupo.AllowToggling = false;
            this.btnConfirmarGrupo.AnimationSpeed = 200;
            this.btnConfirmarGrupo.AutoGenerateColors = false;
            this.btnConfirmarGrupo.AutoRoundBorders = false;
            this.btnConfirmarGrupo.AutoSizeLeftIcon = true;
            this.btnConfirmarGrupo.AutoSizeRightIcon = true;
            this.btnConfirmarGrupo.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarGrupo.BackColor1 = System.Drawing.Color.Transparent;
            this.btnConfirmarGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmarGrupo.BackgroundImage")));
            this.btnConfirmarGrupo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarGrupo.ButtonText = "Confirmar";
            this.btnConfirmarGrupo.ButtonTextMarginLeft = 0;
            this.btnConfirmarGrupo.ColorContrastOnClick = 45;
            this.btnConfirmarGrupo.ColorContrastOnHover = 45;
            this.btnConfirmarGrupo.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnConfirmarGrupo.CustomizableEdges = borderEdges1;
            this.btnConfirmarGrupo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirmarGrupo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConfirmarGrupo.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfirmarGrupo.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConfirmarGrupo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnConfirmarGrupo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarGrupo.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmarGrupo.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarGrupo.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmarGrupo.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnConfirmarGrupo.IconMarginLeft = 11;
            this.btnConfirmarGrupo.IconPadding = 10;
            this.btnConfirmarGrupo.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmarGrupo.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmarGrupo.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnConfirmarGrupo.IconSize = 25;
            this.btnConfirmarGrupo.IdleBorderColor = System.Drawing.Color.Black;
            this.btnConfirmarGrupo.IdleBorderRadius = 1;
            this.btnConfirmarGrupo.IdleBorderThickness = 1;
            this.btnConfirmarGrupo.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnConfirmarGrupo.IdleIconLeftImage = null;
            this.btnConfirmarGrupo.IdleIconRightImage = null;
            this.btnConfirmarGrupo.IndicateFocus = false;
            this.btnConfirmarGrupo.Location = new System.Drawing.Point(104, 189);
            this.btnConfirmarGrupo.Name = "btnConfirmarGrupo";
            this.btnConfirmarGrupo.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConfirmarGrupo.OnDisabledState.BorderRadius = 1;
            this.btnConfirmarGrupo.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarGrupo.OnDisabledState.BorderThickness = 1;
            this.btnConfirmarGrupo.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfirmarGrupo.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConfirmarGrupo.OnDisabledState.IconLeftImage = null;
            this.btnConfirmarGrupo.OnDisabledState.IconRightImage = null;
            this.btnConfirmarGrupo.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConfirmarGrupo.onHoverState.BorderRadius = 1;
            this.btnConfirmarGrupo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarGrupo.onHoverState.BorderThickness = 1;
            this.btnConfirmarGrupo.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConfirmarGrupo.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarGrupo.onHoverState.IconLeftImage = null;
            this.btnConfirmarGrupo.onHoverState.IconRightImage = null;
            this.btnConfirmarGrupo.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmarGrupo.OnIdleState.BorderRadius = 1;
            this.btnConfirmarGrupo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarGrupo.OnIdleState.BorderThickness = 1;
            this.btnConfirmarGrupo.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnConfirmarGrupo.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmarGrupo.OnIdleState.IconLeftImage = null;
            this.btnConfirmarGrupo.OnIdleState.IconRightImage = null;
            this.btnConfirmarGrupo.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConfirmarGrupo.OnPressedState.BorderRadius = 1;
            this.btnConfirmarGrupo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmarGrupo.OnPressedState.BorderThickness = 1;
            this.btnConfirmarGrupo.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConfirmarGrupo.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarGrupo.OnPressedState.IconLeftImage = null;
            this.btnConfirmarGrupo.OnPressedState.IconRightImage = null;
            this.btnConfirmarGrupo.Size = new System.Drawing.Size(187, 39);
            this.btnConfirmarGrupo.TabIndex = 259;
            this.btnConfirmarGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmarGrupo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirmarGrupo.TextMarginLeft = 0;
            this.btnConfirmarGrupo.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnConfirmarGrupo.UseDefaultRadiusAndThickness = true;
            this.btnConfirmarGrupo.Click += new System.EventHandler(this.btnConfirmarGrupo_Click);
            // 
            // Forms_ConfiguracaoGerencialDescontoGrupoSubGrupoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 264);
            this.Controls.Add(this.btnConfirmarGrupo);
            this.Controls.Add(this.txtDescontoPorGrupo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSub_GrupoProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGrupoProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Forms_ConfiguracaoGerencialDescontoGrupoSubGrupoProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracao Gerencial Desconto Grupo Sub-Grupo Produtos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Forms_ConfiguracaoGerencialDescontoGrupoSubGrupoProdutos_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnConfirmarGrupo;
        public Guna.UI2.WinForms.Guna2TextBox txtDescontoPorGrupo;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cmbSub_GrupoProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbGrupoProduto;
    }
}