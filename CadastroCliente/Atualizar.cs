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
    public partial class Atualizar : Form
    {
        DAO bd;
        Cadastrar cad;
        public Atualizar()
        {
            InitializeComponent();
            bd = new DAO();
            cad = new Cadastrar();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Campo CPF

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Campo Campo

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//Campo Novo Dado

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //coletar os dados
                long cpf = Convert.ToInt64(cad.RemoverFormatacaoCPF(maskedTextBox1.Text));
                string campo = textBox1.Text;
                string novoDado = textBox4.Text;
                //Atualizar
                MessageBox.Show(bd.Atualizar(cpf, campo, novoDado));
                //Limpar Tela
                maskedTextBox1.Text = "";
                textBox1.Text = "";
                textBox4.Text = "";
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu Errado\n\n" + erro);
            }
        }//Botao atualizar
    }
}
