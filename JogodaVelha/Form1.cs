using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogodaVelha
{
    public partial class Form1 : Form
    {

        public string Jogador_Atual = "x";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string InverteJogador()
        {
            if(Jogador_Atual=="X")
            {
                return "0";
            }
            else
            {
                return "X";
            }
            return "X";
        }

        public void Zerar()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            Jogador_Atual = "X";
        }

        public void Ganhar()
        {
            MessageBox.Show("O jogador " + Jogador_Atual + " ganhou!");
            Zerar();
        }

        public bool Verificar( string jogador_at)
        {
            //Vertical
            if(btn1.Text==jogador_at &&  btn4.Text==jogador_at && btn7.Text== jogador_at)
            {
                Ganhar();
                return true;
            }

            if (btn2.Text == jogador_at && btn5.Text == jogador_at && btn8.Text == jogador_at)
            {
                Ganhar();
                return true;
            }

            if (btn3.Text == jogador_at && btn6.Text == jogador_at && btn9.Text == jogador_at)
            {
                Ganhar();
                return true;
            }


            //Horizontal
            if (btn1.Text == jogador_at && btn2.Text == jogador_at && btn3.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            if (btn4.Text == jogador_at && btn5.Text == jogador_at && btn6.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            if (btn7.Text == jogador_at && btn8.Text == jogador_at && btn9.Text == jogador_at)
            {
                Ganhar();
                return true;
            }

            //Cruzando
            if (btn1.Text == jogador_at && btn5.Text == jogador_at && btn9.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            if (btn3.Text == jogador_at && btn5.Text == jogador_at && btn7.Text == jogador_at)
            {
                Ganhar();
                return true;
            }           
            Jogador_Atual = InverteJogador();
            label1.Text = "Jogador Atual: " + Jogador_Atual;
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(btn1.Text=="")
            {
                btn1.Text = Jogador_Atual;
                Verificar(Jogador_Atual);              
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (btn3.Text == "")
            {
                btn3.Text = Jogador_Atual;
                Verificar(Jogador_Atual);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Zerar();
        }

        private void btn2_Click(object sender, EventArgs e)
        {

            if (btn2.Text == "")
            {
                btn2.Text = Jogador_Atual;
                Verificar(Jogador_Atual);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            if (btn4.Text == "")
            {
                btn4.Text = Jogador_Atual;
                Verificar(Jogador_Atual);
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {

            if (btn5.Text == "")
            {
                btn5.Text = Jogador_Atual;
                Verificar(Jogador_Atual);
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {

            if (btn6.Text == "")
            {
                btn6.Text = Jogador_Atual;
                Verificar(Jogador_Atual);
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {

            if (btn7.Text == "")
            {
                btn7.Text = Jogador_Atual;
                Verificar(Jogador_Atual);
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {

            if (btn8.Text == "")
            {
                btn8.Text = Jogador_Atual;
                Verificar(Jogador_Atual);
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {

            if (btn9.Text == "")
            {
                btn9.Text = Jogador_Atual;
                Verificar(Jogador_Atual);
            }
        }
    }
}
