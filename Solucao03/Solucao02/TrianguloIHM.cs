using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Solucao02
{
    public partial class TrianguloIHM : Form
    {
        public TrianguloIHM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float b, h, a;
            b = float.Parse(textBox1.Text);
            h = float.Parse(textBox2.Text);
            a = b * h / 2;
            textBox3.Text = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }
    }
}
