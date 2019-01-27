/*using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace LoguinChocoate
{
    public class Bancos
    {
        /// <summary>
        /// Metodo responsável por incluir os usuários no banco
        /// </summary>
        /// <param name="nome">Nome do usuário</param>
        /// <param name="login">Login do usuário</param>
        /// <param name="senha">Senha do usuário</param>
        public void incluirUsuario(string nome, string login, string senha)
        {

            SqlConnection conexao = new SqlConnection(@"Data Source=ELTON-PC;Initial Catalog=dbPowerAPF; User Id=usr_app; Password=usr_app");

            SqlCommand cmd =
                new SqlCommand("insert into GER_USUARIO (usr_login, usr_senha, usr_nome) values (@login,@senha,@nome)", conexao);

            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);

            conexao.Open();
            cmd.ExecuteNonQuery();
            conexao.Close();

        }

    }
}
*/