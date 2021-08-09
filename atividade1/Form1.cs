using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int num1, num2, soma;
        private void buttonJogar_Click(object sender, EventArgs e)
        {
            Random numero = new Random();
          
            num1 = numero.Next(1, 7);
            num2 = numero.Next(1, 7);

            textDado1.Text = num1.ToString();
            textDado2.Text = num2.ToString();

            soma = num1 + num2;
            if (textJogador1.Text == soma.ToString())
            {
                textComputador.Text = numero.Next(1, 6).ToString();
                while (soma == int.Parse(textComputador.Text))
                {
                    textComputador.Text = numero.Next(1, 6).ToString();
                }
            }
            else
            {
                textComputador.Text = soma.ToString();
            }
        }

      
    }
}
