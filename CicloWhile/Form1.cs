﻿using System;
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
                varx += x.ToString() + "-";
                x++;
            }

            textBox1.Text = varx;
        }
    }
}
