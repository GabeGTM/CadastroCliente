using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class Excluir : Form
    {
        DAO bd;
        public Excluir()
        {
            InitializeComponent();
            bd = new DAO();
        }//fim do construtor



        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim botão voltar

        private void exc_Click(object sender, EventArgs e)
        {
            try
            {
                long cpf = Convert.ToInt64(textBox1.Text);
                MessageBox.Show(bd.Excluir(cpf));
                //limpar campo
                textBox1.Text = "";

            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }//fim do botão excluir

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//campo cpf
    }//fim da classe
}//fim do projeto
