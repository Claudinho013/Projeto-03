using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Triangulo umtriangulo = new Triangulo();

            umtriangulo.B = tbBase.Text;
            umtriangulo.H = tbAltura.Text;
            tbArea.Text = umtriangulo.getArea();
            tbBase.Enabled = false;
            tbAltura.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbBase.Clear();
            tbAltura.Clear();
            tbArea.Clear();
            tbBase.Enabled = true;
            tbAltura.Enabled = true;
            tbBase.Focus();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // propriedade keypreview do form em true
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
