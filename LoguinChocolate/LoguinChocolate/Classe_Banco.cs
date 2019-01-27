using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace LoguinChocolate
{


    class Classe_Banco
    {
        // atributos

        public MySqlConnection conexao;
        public MySqlDataAdapter adaptador;
        public MySqlDataAdapter adaptador2;
        public MySqlDataAdapter adaptador3;
        public DataSet DtSet;
        public DataSet DtSet2;
        public DataSet DtSet3;
        //==========================================================================================================================================================================================================================================================================================================================

        // metodos 
        // Inserir dados no banco do usuario
        public void cadastro_usuario(string nome_usuario, string data_criacao, string identificador, string senha, string email)
        {
            DtSet = new DataSet();
            this.conexao = new MySqlConnection("Persist Security Info=False;server=localhost;database=chocolatra;uid=root;pwd=");

            try
            {
                conexao.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), " ERRO FATAL", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }


            // tabela usuarios
            MySqlCommand cmd_cadastro_usuario = new MySqlCommand("insert into usuarios(usuario,create_time values('" + nome_usuario + "','" + data_criacao + "')", conexao);
            cmd_cadastro_usuario.ExecuteNonQuery();

            // tabela identificadores
            MySqlCommand cmd_cadastro_identificador = new MySqlCommand("insert into identificadores(identificador) values('" + identificador + "')", conexao);
            cmd_cadastro_identificador.ExecuteNonQuery();

            // tabela senhas
            MySqlCommand cmd_cadastro_senha = new MySqlCommand("insert into senhas(senha) values ('" + senha + "')", conexao);
            cmd_cadastro_senha.ExecuteNonQuery();

            // tabela email
            MySqlCommand cmd_cadastro_email = new MySqlCommand("insert into emails(email) values('" + email + "')", conexao);
            cmd_cadastro_email.ExecuteNonQuery();

            // adaptadores 
            adaptador = new MySqlDataAdapter("select * from usuarios", conexao);
            adaptador.Fill(DtSet, "Usuarios");

        }

        //==========================================================================================================================================================================================================================================================================================================================


        // Comando que deleta os usuarios de acordo com seu codigo 
        public void deletar_usuario(string nome_usuario, string data_criacao, string identificador, string senha, string email)
        {
            DtSet = new DataSet();
            this.conexao = new MySqlConnection("Persist Security Info=False;server=localhost;database=chocolatra;uid=root;pwd=");

            try
            {
                conexao.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERRO FATAL", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }


            // tabela usuarios
            MySqlCommand cmd_deletar_usuario = new MySqlCommand("delete from usuarios where usuario ='" + nome_usuario + "'", conexao);
            cmd_deletar_usuario.ExecuteNonQuery();

            // tabela identificadores
            MySqlCommand cmd_deletar_identificador = new MySqlCommand("delete from identificadores where idetificador ='" + identificador + "'", conexao);
            cmd_deletar_identificador.ExecuteNonQuery();

            // tabela senhas
            MySqlCommand cmd_deletar_senha = new MySqlCommand("delete from senhas where senha= '" + senha + "'", conexao);
            cmd_deletar_senha.ExecuteNonQuery();

            // tabela email
            MySqlCommand cmd_deletar_email = new MySqlCommand("delete from emails where email ='" + email + "'", conexao);
            cmd_deletar_email.ExecuteNonQuery();

            // adaptador
            adaptador = new MySqlDataAdapter("select * from usuarios", conexao);
            adaptador.Fill(DtSet, "Usuarios");

        }


        //==========================================================================================================================================================================================================================================================================================================================


        public void alterar_usuario(string nome_usuario, string data_criacao, string identificador, string senha, string email)
        {

            DtSet = new DataSet();
            this.conexao = new MySqlConnection("Persist Security Info =False;server=localhost;database=chocolatra;uid=root;pwd=");
            try
            {
                this.conexao.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERRO FATAL", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            // tabela usuarios
            MySqlCommand cmd_alterar_usuario = new MySqlCommand("update usuarios set usuario(usuario,create_time) values('" + nome_usuario + "','" + data_criacao + "','" + identificador + "')", conexao);
            cmd_alterar_usuario.ExecuteNonQuery();

            // tabela identificadores
            MySqlCommand cmd_alterar_identificador = new MySqlCommand("update identificadores set identificador ='" + identificador + "'", conexao);
            cmd_alterar_identificador.ExecuteNonQuery();

            // tabela senhas
            MySqlCommand cmd_alterar_senha = new MySqlCommand("update senhas set senha= '" + senha + "'", conexao);
            cmd_alterar_senha.ExecuteNonQuery();

            // tabela email
            MySqlCommand cmd_alterar_email = new MySqlCommand("update emails set email ='" + email + "'", conexao);
            cmd_alterar_email.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from funcionarios", conexao);
            adaptador.Fill(DtSet, "Usuarios");


        }


        //==========================================================================================================================================================================================================================================================================================================================


        /*adicionar produtos */
        public void cadastro_produto(string nome, string descricao, string valor, string cod_barras, string marca)
        {

            DtSet = new DataSet();
            DtSet2 = new DataSet();
            DtSet3 = new DataSet();
            this.conexao = new MySqlConnection("Persist Security Info=False;server=localhost;database=chocolatra;uid=root;pwd=");

            try
            {
                conexao.Open();
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), " ERRO FATAL", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }



            // tabela de produtos
            MySqlCommand cmd_cadastrar_produto = new MySqlCommand("insert into produtos(nome , descrisao, valor) values('" + nome + "','" + descricao + "','" + valor + "')");
            cmd_cadastrar_produto.ExecuteNonQuery();

            // cod_de_barras
            MySqlCommand cmd_cadastrar_codbarras = new MySqlCommand("insert into codigo_de_barras(codigo_de_barra) values('" + cod_barras + "')");
            cmd_cadastrar_codbarras.ExecuteNonQuery();

            //marca do produto referido
            MySqlCommand cmd_cadastrar_marca = new MySqlCommand("insert into marcas(marca) values('" + marca + "')");
            cmd_cadastrar_marca.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from produtos", conexao);
            adaptador.Fill(DtSet, "Produtos");

            adaptador2 = new MySqlDataAdapter("select * from marcas", conexao);
            adaptador2.Fill(DtSet2, "Marcas");

            adaptador3 = new MySqlDataAdapter("select * from codigo_de_barras", conexao);
            adaptador3.Fill(DtSet3, "Codigo_de_barras");

        }

        //==========================================================================================================================================================================================================================================================================================================================

        // deletar coisas do banco produtos
        public void deletar_produtos(string nome, string descricao, string valor, string cod_barras, string marca)
        {
            DtSet = new DataSet();
            DtSet2 = new DataSet();
            DtSet3 = new DataSet();

            this.conexao = new MySqlConnection("Persist Security Info=False;server=localhost;database=chocolatra;uid=root;pwd=");
            try
            {
                conexao.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERRO FATAL", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            // tabela de produtos
            MySqlCommand cmd_deletar_produto = new MySqlCommand("delete produtos(nome , descrisao, valor) values('" + nome + "','" + descricao + "','" + valor + "')");
            cmd_deletar_produto.ExecuteNonQuery();

            // cod_de_barras
            MySqlCommand cmd_deletar_codbarras = new MySqlCommand("insert into codigo_de_barras(codigo_de_barra) values('" + cod_barras + "')");
            cmd_deletar_codbarras.ExecuteNonQuery();

            //marca do produto referido
            MySqlCommand cmd_deletar_marca = new MySqlCommand("insert into marcas(marca) values('" + marca + "')");
            cmd_deletar_marca.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from produtos", conexao);
            adaptador.Fill(DtSet, "Produtos");

            adaptador2 = new MySqlDataAdapter("select * from Codigo_de_barras", conexao);
            adaptador2.Fill(DtSet2, "Codigo_de_barras");

            adaptador3 = new MySqlDataAdapter("select * from marcas", conexao);
            adaptador3.Fill(DtSet3, "Marcas");


        }

        //========================================================================================================================================================================================================================================================================================================================================================================

        public void alterar_produto(string nome, string descricao, string valor, string cod_barras, string marca, string cod_p)
        {
            DtSet = new DataSet();
            DtSet2 = new DataSet();
            DtSet3 = new DataSet();


            this.conexao = new MySqlConnection("Persist Security Info=False;server=localhost;database=chocolatra;uid=root;pwd=");

            try
            {
                conexao.Open();
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), " ERRO FATAL", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            // tabela de produtos
            MySqlCommand cmd_alterar_produto = new MySqlCommand("UPDATE produtos SET(nome,descricao,valor values('" + nome + "','" + descricao + "','" + valor + "' WHERE cod_produto ='" + cod_p + "'", conexao);
            cmd_alterar_produto.ExecuteNonQuery();

            // cod_de_barras
            MySqlCommand cmd_alterar_codbarras = new MySqlCommand("UPDATE codigo_de_barras SET(codigo_de_barra) values('" + cod_barras + "')");
            cmd_alterar_codbarras.ExecuteNonQuery();

            //marca do produto referido
            MySqlCommand cmd_alterar_marca = new MySqlCommand("UPDATE marcas SET(marca) values('" + marca + "')");
            cmd_alterar_marca.ExecuteNonQuery();



            adaptador = new MySqlDataAdapter("select * from produtos", conexao);
            adaptador.Fill(DtSet, "Produtos");

            adaptador2 = new MySqlDataAdapter("select * from marcas", conexao);
            adaptador2.Fill(DtSet2, "Marcas");

            adaptador3 = new MySqlDataAdapter("select * from codigo_de_barras", conexao);
            adaptador3.Fill(DtSet3, "Codigos_de_barras");

        }


        //metodo de cadastro de promoção, formatação de datas nao incluida, adc ao form respectivo.
        public void cadastro_promocao(string valor_p, string promo_di, string promo_df)
        {

            DtSet = new DataSet();
            this.conexao = new MySqlConnection("Persist Security Info=False;server=localhost;database=chocolatra;uid=root;pwd=");

            try
            {
                conexao.Open();
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERRO FATAL", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }


            MySqlCommand cmd_cadastro_promo_valor = new MySqlCommand("insert into promocoes(valor) values('" + valor_p + "')", conexao);
            cmd_cadastro_promo_valor.ExecuteNonQuery();

            //inicio da promoção
            MySqlCommand cmd_cadastro_promo_di = new MySqlCommand("insert into promocoes(data_inicio) values('" + promo_di + "')", conexao);
            cmd_cadastro_promo_di.ExecuteNonQuery();

            //fim da promocao
            MySqlCommand cmd_cadastro_promo_df = new MySqlCommand("insert into promocoes(data_fim) values('" + promo_df + "')", conexao);
            cmd_cadastro_promo_df.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from promocao", conexao);
            adaptador.Fill(DtSet, "Promocao");

        }


        //==========================================================================================================================================================================================================================================================================================================================

        //metodo de pesquisa de promoção, formatação de datas nao incluida, adc ao form respectivo.
        public void alterar_promocao(string valor_p, string promo_di, string promo_df, string cod_p)
        {
            DtSet = new DataSet();
            this.conexao = new MySqlConnection("Persist Security Info=False;server=localhost;database=chocolatra;uid=root;pwd=");

            try
            {
                conexao.Open();
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), " ERRO FATAL", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }


            //altera valor
            MySqlCommand cmd_alterar_promocao_valor = new MySqlCommand("UPDATE promocoes SET valor_promocao ='" + valor_p + "' WHERE cod_promocao ='" + cod_p + "'", conexao);
            cmd_alterar_promocao_valor.ExecuteNonQuery();

            //altera data de inicio
            MySqlCommand cmd_alterar_promocao_di = new MySqlCommand("UPDATE promocoes SET data_inicio ='" + promo_di + "' WHERE cod_promocao ='" + cod_p + "'", conexao);
            cmd_alterar_promocao_di.ExecuteNonQuery();

            //altera data de fim
            MySqlCommand cmd_alterar_promocao_df = new MySqlCommand("UPDATE promocoes SET data_fim ='" + promo_df + "' WHERE cod_promocao = '" + cod_p + "'", conexao);
            cmd_alterar_promocao_df.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from promocoes", conexao);
            adaptador.Fill(DtSet, "Promocoes");


        }


        //==========================================================================================================================================================================================================================================================================================================================

        // deleta a promoção selecionada
        public void deletar_promocao(string valor_p, string promo_di, string promo_df, string cod_p)
        {


            DtSet = new DataSet();
            this.conexao = new MySqlConnection("Persist Security Info=False;server=localhost;database=chocolatra;uid=root;pwd=");

            try
            {
                conexao.Open();
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERRO FATAL", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            MySqlCommand cmd_deletar_promo_v = new MySqlCommand("DELETE promocoes(valor_promocao) ='" + valor_p + "' WHERE cod_promocao = '" + cod_p + "'", conexao);
            cmd_deletar_promo_v.ExecuteNonQuery();

            MySqlCommand cmd_deletar_promo_i = new MySqlCommand("DELETE promocoes(data_inicio) ='" + promo_di + "'WHERE cod_promocao ='" + cod_p + "'", conexao);
            cmd_deletar_promo_i.ExecuteNonQuery();

            MySqlCommand cmd_deletar_promo_f = new MySqlCommand("DELETE promocoes(data_fim) ='" + promo_df + "' WHERE cod_promocao = '" + cod_p + "'", conexao);
            cmd_deletar_promo_f.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from promocao ", conexao);
            adaptador.Fill(DtSet, "Promocao");

        }



        //==========================================================================================================================================================================================================================================================================================================================

        // pesquisa produtos
        public void pesquisa_produtos(string coisa1)
        {
            DtSet = new DataSet();
            this.conexao = new MySqlConnection("Persist Security Info=False;server=localhost;database=chocolatra;uid=root;pwd=");
            try
            {
                conexao.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), " ERRO FATAL", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }


            adaptador = new MySqlDataAdapter("select * from produtos", conexao);
            adaptador.Fill(DtSet, "Produtos");

        }

        //==================================================================================================================================================================

        public void relatorio_pedidos_v()
        {
            DtSet = new DataSet();
            this.conexao = new MySqlConnection("Persist Security Info=False;server=localhost;database=chocolatra;uid=root;pwd=");
            try
            {
                conexao.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), " ERRO FATAL", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            MySqlCommand cmd_view_pedidos = new MySqlCommand("SELECT * FROM v_pedidos_vendas");
            cmd_view_pedidos.ExecuteNonQuery();

        }


        //====================================================================================================================================================

        public void relatorio_pedidos_c()
        {
            DtSet = new DataSet();

            this.conexao = new MySqlConnection("Persist Security Info=False;server=localhost;database=chocolatra;uid=root;pwd=");
            try
            {
                conexao.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), " ERRO FATAL", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }


            MySqlCommand cmd_view_pedidos = new MySqlCommand("SELECT * FROM v_pedidos_compra");
            cmd_view_pedidos.ExecuteNonQuery();

        }











































































































































































    }

}