using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Conection
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String email, String senha)
        {
            LoginDaoComandos LoginDao = new LoginDaoComandos();
            tem = LoginDao.verificarLogin(email, senha);
            if (!LoginDao.mensagem.Equals(""))
                {
                this.mensagem = LoginDao.mensagem;
            }
            return tem;
        }

        public String cadastrar(string email, String senha, String confSenha)
        {
            return mensagem;
        }
    }
}
