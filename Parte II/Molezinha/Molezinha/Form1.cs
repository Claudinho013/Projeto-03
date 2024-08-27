using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Molezinha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDLivrosDataSet1.TabPessoa' table. You can move, or remove it, as needed.
            this.tabPessoaTableAdapter.Fill(this.bDLivrosDataSet1.TabPessoa);
            // TODO: esta linha de código carrega dados na tabela 'bDLivrosDataSet.TabLivro'. Você pode movê-la ou removê-la conforme necessário.
            this.tabLivroTableAdapter.Fill(this.bDLivrosDataSet.TabLivro);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bDLivrosDataSet.WriteXml("teste.xml");
        }
    }
}
