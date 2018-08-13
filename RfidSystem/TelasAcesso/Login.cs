using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  //usando extensão sql
using RfidSystem.Modelo;

namespace RfidSystem
{
    public partial class Login : Form

    {

      
        public Login()
        {
            InitializeComponent();
        }

        public void logar()
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Controle controle = new Controle();
            controle.acessar(txtlogin.Text, txtsenha.Text);
            if (controle.mensagem.Equals("")) { 

                if (controle.tem)
                 {
                    MessageBox.Show("Logado com sucesso","Entrando" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PrincipalAdmin principaladmin = new PrincipalAdmin();
                    principaladmin.Show();
                    this.Close();  //inserido 23-07-2018  //@WC
                }
                 else
                 {
                     MessageBox.Show("Login não encontrado, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
                     
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            //@WC
            //Evento para habilitar o enter na confirmação da tela de login
            //inserido 23-07-2018
            if (e.KeyChar == 13)
            {

                Controle controle = new Controle();
                controle.acessar(txtlogin.Text, txtsenha.Text);
                if (controle.mensagem.Equals(""))
                {

                    if (controle.tem)
                    {
                        MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PrincipalAdmin principaladmin = new PrincipalAdmin();
                        principaladmin.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login não encontrado, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(controle.mensagem);
                }

            }

        }

        private void txtlogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //@WC
            //Evento para habilitar o enter na mudança de campo txtbox e o tab
            //inserido 23-07-2018
            //13 = enter
            //45 = tab

            if ((e.KeyChar == 13) || (e.KeyChar == 45))
            {
                SendKeys.Send("{TAB}");
            }

        }
    }
}