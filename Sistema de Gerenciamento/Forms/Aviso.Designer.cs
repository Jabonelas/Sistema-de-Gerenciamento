namespace Sistema_de_Gerenciamento.Forms
{
    partial class Aviso
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
            this.lblAlerta = new System.Windows.Forms.Label();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.pcbImagem = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.timerAparecer = new System.Windows.Forms.Timer(this.components);
            this.timerDesaparecer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlerta
            // 
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerta.Location = new System.Drawing.Point(89, 41);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(0, 15);
            this.lblAlerta.TabIndex = 0;
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacao.ForeColor = System.Drawing.Color.White;
            this.lblInformacao.Location = new System.Drawing.Point(70, 21);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(185, 46);
            this.lblInformacao.TabIndex = 2;
            this.lblInformacao.Text = "Atualização Realizada \r\nCom Sucesso!";
            this.lblInformacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbImagem
            // 
            this.pcbImagem.AllowFocused = false;
            this.pcbImagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbImagem.AutoSizeHeight = true;
            this.pcbImagem.BorderRadius = 21;
            this.pcbImagem.Image = global::Sistema_de_Gerenciamento.Properties.Resources.Salvo;
            this.pcbImagem.IsCircle = true;
            this.pcbImagem.Location = new System.Drawing.Point(14, 19);
            this.pcbImagem.Name = "pcbImagem";
            this.pcbImagem.Size = new System.Drawing.Size(42, 42);
            this.pcbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagem.TabIndex = 1;
            this.pcbImagem.TabStop = false;
            this.pcbImagem.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // timerAparecer
            // 
            this.timerAparecer.Interval = 125;
            this.timerAparecer.Tick += new System.EventHandler(this.timerAparecer_Tick);
            // 
            // timerDesaparecer
            // 
            this.timerDesaparecer.Interval = 150;
            this.timerDesaparecer.Tick += new System.EventHandler(this.timerDesaparecer_Tick);
            // 
            // Aviso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(286, 90);
            this.Controls.Add(this.lblInformacao);
            this.Controls.Add(this.pcbImagem);
            this.Controls.Add(this.lblAlerta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(750, 600);
            this.Name = "Aviso";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmacaoInclusao";
            this.Load += new System.EventHandler(this.Alerta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAlerta;
        private Bunifu.UI.WinForms.BunifuPictureBox pcbImagem;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.Timer timerAparecer;
        private System.Windows.Forms.Timer timerDesaparecer;
    }
}