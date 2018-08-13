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

namespace RfidSystem
{
    public partial class Login : Form

    {

        SqlConnection sqlConn = null;
        private string strCoon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\FAMILIA COSTA\Documents\Rfid_System\RfidSystem\Bd_Rfid.mdf";Integrated Security=True;Connect Timeout=30";
        private string _Sql = string.Empty;
        public Login()
        {
            InitializeComponent();
        }

        public void logar()
        {

            sqlConn = new SqlConnection(strCoon);

            string usu, pwd;


            try
            {
                usu = txtlogin.Text;
                pwd = txtsenha.Text;

                _Sql = "SELECT COUNT (id_usuario) FROM usuario WHERE usuario = @usuario AND senha = @senha";
                SqlCommand cmd = new SqlCommand(_Sql,sqlConn);


                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usu;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = pwd;


                sqlConn.Open();

                int v = (int)cmd.ExecuteScalar();

                    if (v > 0)
                {

                    MessageBox.Show("Logado com Sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao Logar");
                }
            }catch(SqlException errro)
            {
                MessageBox.Show(errro +"No Banco");
            }
            

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

            logar();
            
            /*
            if (txtlogin.Text == "Willian" && txtsenha.Text == "123")
            {
                PrincipalAdmin principaladmin = new PrincipalAdmin();
                principaladmin.Show();
                this.Visible = false;


            }
            */
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}