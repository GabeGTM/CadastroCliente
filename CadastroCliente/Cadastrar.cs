using Google.Protobuf.WellKnownTypes;
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
    public partial class Cadastrar : Form
    {
        DAO bd;//Chamando a clasee DAO
        public Cadastrar()
        {
            InitializeComponent();
            bd = new DAO();//Instanciado a variável 
        }

        

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do botao voltar

        private void cadastrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                //Coletando os dados da tela para enviar ao banco de dados
                long cpf        = Convert.ToInt64(RemoverFormatacaoCPF(maskedTextBox1.Text));
                string nome     = textBox2.Text;
                string telefone = maskedTextBox2.Text;
                string endereco = textBox4.Text;

                //Cadastro no banco
                MessageBox.Show(bd.Cadastrar(cpf, nome, telefone, endereco));

                //Limpar tela
                LimparTela();
                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }//fim do botao cadastrar

        public string RemoverFormatacaoCPF(string cpf)
        {
            string cpfAlterado = cpf.Replace(",", "");
            cpfAlterado = cpfAlterado.Replace("-", "");
            return cpfAlterado;
        }//fim do remover

        public void LimparTela()
        {

            maskedTextBox1.Text = "";
            textBox2.Text = "";
            maskedTextBox2.Text = "";
            textBox4.Text = "";
        }//fim do método limpar tela

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do campo cpf

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim do campo nome

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do campo telefone

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//fim do campo endereco
    }//fim da classe
}//fim do projeto
