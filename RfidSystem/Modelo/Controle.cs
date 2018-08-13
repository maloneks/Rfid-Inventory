using RfidSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RfidSystem.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";

        public object MessageBox { get; internal set; }

        public bool acessar(String login, String senha)
        {
            LoginDalComandos loginDal = new LoginDalComandos();
            tem = loginDal.verificarLogin(login, senha);
            if (!loginDal.mensagem.Equals("")){

                this.mensagem = loginDal.mensagem;

            }
            return tem;
        }

        public String CadastrarFuncionario (String NomeCompleto, String DataNascimento,String Cpf, String Funcao, String Celular, String Matricula, String Login, String Senha, String ConfSenha)
        {
            LoginDalComandos loginDal = new LoginDalComandos(); // Estanciando logindal


            this.mensagem = loginDal.CadastrarFuncionario(NomeCompleto, DataNascimento, Cpf, Funcao, Celular, Matricula, Login, Senha, ConfSenha);

            if (loginDal.tem)
            {

                this.tem = true;

            }

            return mensagem;
        }

        internal void CadastrarFuncionario()
        {
            throw new NotImplementedException();
        }
    }
}
