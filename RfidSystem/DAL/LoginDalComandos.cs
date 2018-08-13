using RfidSystem.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RfidSystem.DAL
{
    class LoginDalComandos
    {
        public bool tem = false;
        public String mensagem = ""; //tudo ok
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        private string nomeCompleto;
        private string dataNascimento;
        private string cpf;
        private string funcao;
        private string celular;
        private string matricula;
        private string login;
        private string senha;
        

        public LoginDalComandos(string nomeCompleto, string dataNascimento, string cpf, string funcao, string celular, string matricula, string login, string senha, String ConfSenha)
        {
            this.nomeCompleto = nomeCompleto;
            this.dataNascimento = dataNascimento;
            this.cpf = cpf;
            this.funcao = funcao;
            this.celular = celular;
            this.matricula = matricula;
            this.login = login;
            this.senha = senha;
        }

        public LoginDalComandos()
        {
        }

        internal void CadastrarFuncionario()
        {
            throw new NotImplementedException();
        }

        public bool verificarLogin(String login, String senha)
        {
            //comandos sql para verificar se tem no banco
            cmd.CommandText = "select * from funcionarios where Login = @Login and Senha = @Senha";
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Senha", senha);
            

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) // se foi encontrado a informação no banco de dados
                {
                    tem = true;
                    
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com banco de Dados!";
                
            }
            
            return tem;
        }

        public String CadastrarFuncionario (String NomeCompleto, String DataNascimento, String Cpf, String Funcao, String Celular, String Matricula, String Login, String Senha, String ConfSenha)
        {
            tem = false;
            //comandos para inserir no banco de dados
            
            if (Senha.Equals(ConfSenha))
            {
                                
                cmd.CommandText = "insert into  funcionarios values (@Nome, @Data, @Cpf, @Funcao, @Celular, @Matricula, @Login, @Senha)";
                cmd.Parameters.AddWithValue("@Nome", NomeCompleto);
                cmd.Parameters.AddWithValue("@Data", DataNascimento);
                cmd.Parameters.AddWithValue("@Cpf", Cpf);
                cmd.Parameters.AddWithValue("@Funcao", Funcao);
                cmd.Parameters.AddWithValue("@Celular", Celular);
                cmd.Parameters.AddWithValue("@Matricula", Matricula);
                cmd.Parameters.AddWithValue("@Login", Login);
                cmd.Parameters.AddWithValue("@Senha", Senha);

                try
                {
                    //Abertura do banco de dados
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery(); //método para inserção
                    con.desconectar();//deconectando do banco

                    this.mensagem = "Cadastrado com sucesso!";
                    tem = true; // tem recebe a confirmação do banco


                }
                catch (SqlException)
                {

                    this.mensagem = "Erro com o Banco de Dados!";

                }


                return mensagem;
            }
            else
            {
                this.mensagem = "Senhas não correspondem!";
            }
            return mensagem;
        }
    }
}
