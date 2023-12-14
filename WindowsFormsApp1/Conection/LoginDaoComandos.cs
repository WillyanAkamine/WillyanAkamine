using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Conection
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Connection con = new Connection();
        SqlDataReader dr;

        public bool verificarLogin(String email, String senha)
        {
            cmd.CommandText = "select * from User013 where email = @email and senha = @senha";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                // Obter a conexão do objeto Connection
                cmd.Connection = con.ReturnConnection();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados";
            }
            finally
            {
                // Certifique-se de fechar a conexão quando terminar
                con.CloseConnection();
            }
            return tem;
        }
    }
}