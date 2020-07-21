using System;
using System.Windows.Forms;

namespace CicloWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string varx = "";
            int x = 0;

            while (x <= 10)
            {
                varx += (x + "-");
                x++;
            }

            textBox1.Text = varx;

            do
            {
                varx += (x + '/');
                x++;
            } while (x<5);

            label1.Text = varx;

            int[] numeros;
            numeros = new int[5];

            numeros[0] = 01234;
            numeros[1] = 12345;
            numeros[2] = 23456;
            numeros[3] = 34567;
            numeros[4] = 45678;

            foreach (var t in numeros)
            {
                MessageBox.Show(Convert.ToString(t));
            }

        }
    }
}
