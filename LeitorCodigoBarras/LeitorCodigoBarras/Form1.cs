using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeitorCodigoBarras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                // Codigo lido pelo leitor;
                string codigoBarra = textBox1.Text;

                //Exibir caixa de mensagem;
                MessageBox.Show(codigoBarra);
                MessageBox.Show("Produto Cadastrado com Sucesso!!!");
            }
        }

    }
}
