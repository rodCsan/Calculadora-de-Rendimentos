using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoradeRendimentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            decimal aporte = Convert.ToDecimal(textBox1.Text);
            int prazo = Convert.ToInt32(textBox2.Text);
            decimal taxa = Convert.ToDecimal(textBox3.Text);
            taxa /= 100;

            // Calculo juros sobre juros
            decimal valorFinal = aporte;
            for (int meses = 0; meses < prazo; meses++) 
            {
                valorFinal = valorFinal + (valorFinal * taxa);
            }


            string[] vf = Convert.ToString(valorFinal).Split(',');
            textBox4.Text = $"{vf[0]},{vf[1].Substring(0, 2)}";

            // textBox4.Text = valorFinal.ToString("F2");
        }
    }
}
