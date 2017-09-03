using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treino12
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
       public void SalvarComo()
        {
          Form formulario01 = new Form1();
           
           
          
           String caminho = caminho02.Text;
            //String textoSalvar = texto.Text;
            StreamWriter salve = new StreamWriter(caminho);
            salve.WriteLine(textoSalvar);
            salve.Close();

        }

       private void button1_Click(object sender, EventArgs e)
       {
           SalvarComo();
       }

        
    }
}
