﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace ParaCasa1
{
    public partial class CadLivrosUIL : Form
    {
        Livro umlivro = new Livro();
        public CadLivrosUIL()
        {
            InitializeComponent();
        }

        private void CadLivrosUIL_Load(object sender, EventArgs e)
        {
            LivroBLL.inicializa();
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
                Application.Exit();
            }
        }

        private void CadLivrosUIL_FormClosed(object sender, FormClosedEventArgs e)
        {
            LivroBLL.finaliza();
        }

         private void button1_Click(object sender, EventArgs e)
        {
            TextWriter arquivo = new StreamWriter("teste.xml");
            XmlSerializer obj = new XmlSerializer(umlivro.GetType());
            
            umlivro = LivroBLL.getProximo();
             while (!Erro.getErro())
             {
                listBox1.Items.Add("Titulo = " + umlivro.getTitulo() + " escrito por " + umlivro.getAutor());
                obj.Serialize(arquivo, umlivro);
                umlivro = LivroBLL.getProximo();
             }
            arquivo.Close();
        }

    }
}
