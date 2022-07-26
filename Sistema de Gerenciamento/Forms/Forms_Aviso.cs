using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_de_Gerenciamento.Forms
{
    public partial class Forms_Aviso : Form
    {
        private double incrementando = 0.01;
        private double decrementando = 1;
        private double tempoDeExibicao = 1;
        private int mover = 1;

        public Forms_Aviso()
        {
            InitializeComponent();

            timerAparecer.Enabled = true;
        }

        private void timerAparecer_Tick(object sender, EventArgs e)
        {
            incrementando += incrementando;
            this.Opacity = incrementando;
            mover = mover + 14;

            // Para direcionar a inicializacao do forms no canto direito inferior
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width + 100 - mover,
                Screen.PrimaryScreen.WorkingArea.Height - this.Height + 100 - mover);

            if (incrementando >= 1)
            {
                timerDesaparecer.Enabled = true;
                timerAparecer.Stop();
                incrementando = 0.1;
                mover = 1;
            }
        }

        private void timerDesaparecer_Tick(object sender, EventArgs e)
        {
            tempoDeExibicao += tempoDeExibicao;

            if (tempoDeExibicao >= 1000)
            {
                mover = mover + 14;
                decrementando = decrementando - incrementando;
                this.Opacity = decrementando;

                // Para direcionar a finalizacao do forms no canto direito inferior
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width + mover,
                    Screen.PrimaryScreen.WorkingArea.Height - this.Height + mover);

                if (decrementando <= 0.1)
                {
                    this.Close();
                }
            }
        }

        private void Alerta_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;

            if (Global.tipoDoAlerta == "Inclusao")
            {
                //this.BackColor = Color.Green;
                lblInformacao.Text = "Inclusão Realizada \nCom Sucesso!";
                pcbImagem.Image = Image.FromFile(@"C:\Users\israe\source\repos\Sistema de Gerenciamento\Sistema de Gerenciamento\Resources\Salvo.png");
            }
            else if (Global.tipoDoAlerta == "Atualizacao")
            {
                //this.BackColor = Color.Blue;
                lblInformacao.Text = "Atualização Realizada \nCom Sucesso!";
                pcbImagem.Image = Image.FromFile(@"C:\Users\israe\source\repos\Sistema de Gerenciamento\Sistema de Gerenciamento\Resources\atualizar.png");
            }
            else if (Global.tipoDoAlerta == "Exclusao")
            {
                //this.BackColor = Color.Red;
                lblInformacao.Text = "Exclusão Realizada \nCom Sucesso!";
                pcbImagem.Image = Image.FromFile(@"C:\Users\israe\source\repos\Sistema de Gerenciamento\Sistema de Gerenciamento\Resources\delete.png");
            }
            else if (Global.tipoDoAlerta == "Exportacao")
            {
                //this.BackColor = Color.Red;
                lblInformacao.Text = "Planilha Salva \nCom Sucesso!";
                pcbImagem.Image = Image.FromFile(@"C:\Users\israe\source\repos\Sistema de Gerenciamento\Sistema de Gerenciamento\Resources\Salvo.png");
            }
            else if (Global.tipoDoAlerta == "Confirmacao")
            {
                //this.BackColor = Color.Green;
                lblInformacao.Text = "Realizado \nCom Sucesso!";
                pcbImagem.Image = Image.FromFile(@"C:\Users\israe\source\repos\Sistema de Gerenciamento\Sistema de Gerenciamento\Resources\Salvo.png");
            }
        }
    }
}