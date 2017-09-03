using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treino12
{
    public partial class Form1 : Form
    {
       //String conteudo = textBox1.Text;
        String caminho = @"C:\Users\Public\Documents\text.txt";
        public Form1()
        {
            InitializeComponent();
           // String conteudo = textBox1.Text;
           
           // textBox1.Text = conteudo;
        }
        #region Salvar
        public void Salve()
        {
          String textoSalvar = texto.Text;
          StreamWriter salve = new StreamWriter(caminho);
          salve.WriteLine(textoSalvar);
          salve.Close();
        }
        #endregion
        #region MenuScript
        private void salveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salve();
            cencurado();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #region if/else
        public void cencurado()
        {
           String palavra = "viado";
           String palavra02 = "gay";
           String palavra03 = "sexo";
          
           
           if (palavra == texto.Text)
            {
                MessageBox.Show("Tais palavras são inadequadas");
            }
           else if (palavra02 == texto.Text)
           {
               MessageBox.Show("Tais palavras são inadequadas");
           }
           else if(palavra03 == texto.Text)
           {
               MessageBox.Show("Tais palavras são inadequadas");
           }
           else
           { }

        }
        #endregion

        #region Form02
        public void chamar_form02()
        {
            Form2 form = new Form2();
            form.ShowDialog();
            
        }
        #endregion

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chamar_form02();
        }

        private void texto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
