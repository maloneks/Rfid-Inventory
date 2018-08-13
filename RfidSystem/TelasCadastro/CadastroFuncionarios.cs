using RfidSystem.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RfidSystem.Telas
{
    public partial class CadastroFuncionarios : Form
    {
        private object logindal;

        public CadastroFuncionarios()
        {
            InitializeComponent();
        }

        private void btnfecharcadastrar_Click(object sender, EventArgs e)
        {
            CadastroFuncionarios cadastroFuncionarios = new CadastroFuncionarios();
            this.Close();

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            //Validação para campo mascarado MasktextBox
            //@WG
            //27/07/2018
            String DataNascimentoSemMascara = System.Text.RegularExpressions.Regex.Replace(txtdatanascimento.Text, "[^0-9]+", "");
            String CpfSemMascara = System.Text.RegularExpressions.Regex.Replace(txtcpf.Text, "[^0-9]+", "");
            String CelularSemMascara = System.Text.RegularExpressions.Regex.Replace(txtcelular.Text, "[^0-9]+", "");
            //

            

                if (String.IsNullOrWhiteSpace(txtnomecompleto.Text) || String.IsNullOrWhiteSpace(txtfuncao.Text) || String.IsNullOrWhiteSpace(txtmatricula.Text) || String.IsNullOrWhiteSpace(txtlogin.Text) || String.IsNullOrWhiteSpace(txtsenha.Text) || String.IsNullOrWhiteSpace(txtconfsenha.Text)) //Validação dos campos TextBox
                {

                    MessageBox.Show("campo vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (DataNascimentoSemMascara.Equals(string.Empty)) //Validação para campo mascarado MasktextBox
                {

                    MessageBox.Show("Favor informar a Data de Nascimento!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtdatanascimento.Focus();

                }
                else if (CpfSemMascara.Equals(string.Empty)) //Validação para campo mascarado MasktextBox
                {

                    MessageBox.Show("Favor informar o CPF!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcpf.Focus();

                }
                else if (CelularSemMascara.Equals(string.Empty)) //Validação para campo mascarado MasktextBox
                {

                    MessageBox.Show("Favor informar o celular!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcelular.Focus();

                }
                else
                {
                    // Retornando valor para txtBox após validação sem Maskbox
                    txtdatanascimento.Text = DataNascimentoSemMascara;
                    txtcpf.Text = CpfSemMascara;
                    txtcelular.Text = CelularSemMascara;

                        
                            Controle controle = new Controle();
                            String mensagem = controle.CadastrarFuncionario(txtnomecompleto.Text, txtdatanascimento.Text, txtcpf.Text, txtfuncao.Text, txtcelular.Text, txtmatricula.Text, txtlogin.Text, txtsenha.Text, txtconfsenha.Text);


                            if (controle.tem)
                            {
                                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show(controle.mensagem);
                            }

                       
                }

           
        }
        
        private void txtcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtdatanascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            //Limpando os campos de cadastro
            //@WC
            //30/07/2018
            if (MessageBox.Show("Você deseja Limpar os campos?", "My Application",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                txtnomecompleto.Text = "";
                txtdatanascimento.Text = "";
                txtcpf.Text = "";
                txtfuncao.Text = "";
                txtcelular.Text = "";
                txtmatricula.Text = "";
                txtlogin.Text = "";
                txtsenha.Text = "";
                txtconfsenha.Text = "";
                           
            }
            else
            {
                 txtnomecompleto.Focus();

            }

        }

        private void CadastroFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void txtdatanascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar se os valores digitados são números
            //@WC
            //31/07/2018
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar se os valores digitados são números
            //@WC
            //31/07/2018
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtcelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtcelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar se os valores digitados são números
            //@WC
            //31/07/2018
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtsenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar se os valores digitados são números
            //@WC
            //31/07/2018
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtconfsenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar se os valores digitados são números
            //@WC
            //31/07/2018
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
