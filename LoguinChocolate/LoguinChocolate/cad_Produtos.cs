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
    public partial class cad_Produtos : Form
    {

        public cad_Produtos()
        {
            InitializeComponent();
        }
        private MySqlConnection conexao;
        private MySqlDataAdapter adaptador;
        private MySqlDataAdapter adaptador2;
        private MySqlDataAdapter adaptador3;
        private DataSet DtSet;
        private DataSet DtSet2;
        private DataSet DtSet3;
        private MySqlDataAdapter v_adaptador1;
        private MySqlDataAdapter v_adaptador2;
        private MySqlDataAdapter v_adaptador3;
        private MySqlDataAdapter adaptador_gridmarcas;
        private DataSet DtSet_grid_Marcas;

        private void but_concluir_Click(object sender, EventArgs e)
        {
            caixa_preco.ReadOnly = false;
            caixa_nome.ReadOnly = false;
            caixa_codmarca.ReadOnly = false;
            caixa_descricao.ReadOnly = false;
            caixa_cod_barras.ReadOnly = false;
            caixa_cod_p.ReadOnly = true;
            caixa_nome.Focus();
            but_concluir.Visible = false;

            DtSet = new DataSet();
            conexao = new MySqlConnection("Persist Security info = False;server=10.32.47.27;database=chocolatra;uid=chocolatra;pwd=chocolatra");
            try
            {
                conexao.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            if (conexao.State == ConnectionState.Open)
            {

                DtSet = new DataSet();
                adaptador = new MySqlDataAdapter("SELECT * FROM produtos WHERE cod_produto ='" + caixa_cod_p.Text + "'", conexao);
                adaptador.Fill(DtSet, "Produtos");

                if (DtSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("PRODUTO NAO ENCONTRADO");
                }
                else
                {

                    but_alterar.Enabled = true;
                    but_deletar.Enabled = true;
                    MySqlCommand cmd_concluir_pesquisa = new MySqlCommand("SELECT * FROM produtos INNER JOIN codigo_de_barras on produtos.cod_codbarras = codigo_de_barras.cod_codbarras WHERE cod_produto ='" + caixa_cod_p.Text + "'", conexao);
                    MySqlDataReader lerRegistro = cmd_concluir_pesquisa.ExecuteReader();


                    while (lerRegistro.Read())
                    {
                        caixa_nome.Text = lerRegistro["nome"].ToString();
                        caixa_cod_barras.Text = lerRegistro["codigo_de_barra"].ToString();
                        caixa_preco.Text = lerRegistro["valor"].ToString();
                        caixa_codmarca.Text = lerRegistro["cod_marca"].ToString();
                        caixa_descricao.Text = lerRegistro["descricao"].ToString();

                    }

                }


            }
        }

        private void but_promocao_Click(object sender, EventArgs e)
        {
            Form procao = new cad_promocao();
            procao.ShowDialog();
        }

        private void but_pesquisar_Click(object sender, EventArgs e)
        {
            caixa_preco.ReadOnly = true;
            caixa_nome.ReadOnly = true;
            caixa_codmarca.ReadOnly = true;
            caixa_descricao.ReadOnly = true;
            caixa_cod_barras.ReadOnly = true;


            caixa_cod_p.ReadOnly = false;
            caixa_cod_p.Focus();
            but_concluir.Visible = true;
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {

            v_adaptador1 = new MySqlDataAdapter();
            v_adaptador2 = new MySqlDataAdapter();
            v_adaptador3 = new MySqlDataAdapter();

            DtSet2 = new DataSet();
            DtSet3 = new DataSet();
            this.conexao = new MySqlConnection("Persist Security Info=False;server=10.32.47.27;database=chocolatra;uid=chocolatra;pwd=chocolatra");
            // Persist Security Info=False;server=10.32.47.27;database=chocolatra;uid=chocolatra;pwd=chocolatra"


            try
            {
                conexao.Open();
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), " ERRO FATAL", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            // TESTA SE TODOS OS CAMPOS ESTÃO PREENCHIDOS.

            if (caixa_nome.Text.Trim() != "" && caixa_descricao.Text.Trim() != "" && caixa_preco.Text.Trim() != "" && caixa_cod_barras.Text.Trim() != "" && caixa_codmarca.Text.Trim() != "")
            {
                //INSERE PRIMEIRO O CODIGO DE BARRAS
                DtSet = new DataSet();
                // cod_de_barras
                MySqlCommand cmd_cadastrar_codbarras = new MySqlCommand("insert into codigo_de_barras(codigo_de_barra) values('" + caixa_cod_barras.Text + "')", conexao);
                cmd_cadastrar_codbarras.ExecuteNonQuery();
                //ID valor que guarda ultimo codigo gerado em codigo_de_barras
                long id_var = cmd_cadastrar_codbarras.LastInsertedId;




                v_adaptador1 = new MySqlDataAdapter("SELECT * FROM codigo_de_barras WHERE codigo_de_barra = '" + caixa_cod_barras.Text + "'", conexao);
                v_adaptador1.Fill(DtSet, "Produtos CodBarras");

                if (DtSet.Tables[0].Rows.Count == 1)
                {

                    MessageBox.Show(" CODIGO DE BARRRAS JÁ CADASTRADOS");
                }

                else
                {



                    // TERMINA O INSERT EM PRODUTOS, E LIMPA OS CAMPOS
                    MySqlCommand cmd_cadastrar_produto = new MySqlCommand("insert into produtos(nome , descricao, valor, cod_codbarras, cod_marca) values('" + caixa_nome.Text + "','" + caixa_descricao.Text + "','" + caixa_preco.Text + "'," + id_var + ",'" + caixa_codmarca.Text + "')", conexao);
                    cmd_cadastrar_produto.ExecuteNonQuery();

                    adaptador = new MySqlDataAdapter("select * from produtos", conexao);
                    adaptador.Fill(DtSet, "Produtos");

                    adaptador2 = new MySqlDataAdapter("select * from marcas", conexao);
                    adaptador2.Fill(DtSet2, "Marcas");

                    adaptador3 = new MySqlDataAdapter("select * from codigo_de_barras", conexao);
                    adaptador3.Fill(DtSet3, "Codigo_de_barras");

                    long teste1 = cmd_cadastrar_produto.LastInsertedId;

                    MessageBox.Show("CADASTRADO COM SUCESSO!!!");
                    caixa_preco.Text = "";
                    caixa_cod_p.Text = "";
                    caixa_nome.Text = "";
                    caixa_cod_barras.Text = "";
                    caixa_codmarca.Text = "";
                    caixa_descricao.Text = "";

                }
            }

            else
            {

                MessageBox.Show("CAMPOS VAZIOS");

            }
        }

        private void but_alterar_Click(object sender, EventArgs e)
        {
            DtSet = new DataSet();
            conexao = new MySqlConnection("Persist Security info = False;server=10.32.47.27;database=chocolatra;uid=chocolatra;pwd=chocolatra");
            try
            {
                conexao.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            if (caixa_nome.Text.Trim() == "" && caixa_descricao.Text.Trim() == "" && caixa_preco.Text.Trim() == "" && caixa_cod_barras.Text.Trim() == "" && caixa_codmarca.Text.Trim() == "")
            {
                MessageBox.Show("CAMPOS EM BRANCO");
            }

            else
            {


                MySqlCommand cmd_alterar_produtos = new MySqlCommand("UPDATE produtos INNER JOIN codigo_de_barras ON produtos.cod_codbarras = codigo_de_barras.cod_codbarras SET produtos.nome = '" + caixa_nome.Text + "', produtos.descricao = '" + caixa_descricao.Text + "', produtos.valor = '" + caixa_preco.Text + "', cod_marca = '" + caixa_codmarca.Text + "', codigo_de_barras.codigo_de_barra = '" + caixa_cod_barras.Text + "' WHERE produtos.cod_produto = '" + caixa_cod_p.Text + "'", conexao);
                cmd_alterar_produtos.ExecuteNonQuery();

                but_deletar.Enabled = false;
                but_alterar.Enabled = false;

                MessageBox.Show("DELETADO COM SUCESSO!!!");
                caixa_preco.Text = "";
                caixa_cod_p.Text = "";
                caixa_nome.Text = "";
                caixa_cod_barras.Text = "";
                caixa_codmarca.Text = "";
                caixa_descricao.Text = "";

            }

        }

        private void but_deletar_Click(object sender, EventArgs e)
        {
            DtSet = new DataSet();
            conexao = new MySqlConnection("Persist Security info = False;server=10.32.47.27;database=chocolatra;uid=chocolatra;pwd=chocolatra");
            try
            {
                conexao.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


            MySqlCommand cmd_deletar_produto = new MySqlCommand("DELETE FROM produtos WHERE cod_produto = '" + caixa_cod_p.Text + "'", conexao);
            cmd_deletar_produto.ExecuteNonQuery();

            but_deletar.Enabled = false;
            but_alterar.Enabled = false;

            MessageBox.Show("DELETADO COM SUCESSO!!!");
            caixa_preco.Text = "";
            caixa_cod_p.Text = "";
            caixa_nome.Text = "";
            caixa_cod_barras.Text = "";
            caixa_codmarca.Text = "";
            caixa_descricao.Text = "";
        }

        private void but_CadastrarMarcas_Click(object sender, EventArgs e)
        {
            conexao = new MySqlConnection("Persist Security info = False;server=10.32.47.27;database=chocolatra;uid=chocolatra;pwd=chocolatra");
            DtSet = new DataSet();
            conexao.Open();
            MySqlCommand cmd_cadastrar_marca = new MySqlCommand("INSERT into marcas(marca) values('" + caixa_nova_marca.Text + "')", conexao);
            cmd_cadastrar_marca.ExecuteNonQuery();
            adaptador = new MySqlDataAdapter("SELECT * FROM marcas", conexao);
            adaptador.Fill(DtSet, "CadastroMarcas");
            dataGrid_Marcas.DataSource = DtSet;
            dataGrid_Marcas.DataMember = "CadastroMarcas";
            long cod_marca = cmd_cadastrar_marca.LastInsertedId;
            lb_CodMarca.Text = Convert.ToString(cod_marca);
        }

        private void dataGrid_Marcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            caixa_codmarca.Text = dataGrid_Marcas.CurrentRow.Cells[0].Value.ToString();
        }

        private void but_selecionar_marcas_Click(object sender, EventArgs e)
        {
            DtSet = new DataSet();
            conexao = new MySqlConnection("Persist Security info = False;server=10.32.47.27;database=chocolatra;uid=chocolatra;pwd=chocolatra");
            try
            {
                conexao.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            if (caixa_cod_marca.Text.Trim() != "")
            {
                DtSet = new DataSet();
                adaptador = new MySqlDataAdapter("SELECT * FROM marcas WHERE cod_marca ='" + caixa_cod_marca.Text + "'", conexao);
                adaptador.Fill(DtSet, "Produtos");

                if (DtSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("MARCA NÃO ENCONTRADA");
                }

                else
                {
                    MySqlCommand cmd_selecionar_marca = new MySqlCommand("SELECT * FROM marcas WHERE cod_marca = '" + caixa_cod_marca.Text + "'", conexao);
                    MySqlDataReader lerMarca = cmd_selecionar_marca.ExecuteReader();


                    while (lerMarca.Read())
                    {
                        caixa_alterar_marca.Text = lerMarca["marca"].ToString();
                    }

                    caixa_nova_marca.ReadOnly = true;
                    caixa_alterar_marca.Visible = true;
                    but_alterar_marca.Visible = true;
                    lbl_novo_nome.Visible = true;
                    but_deletar_marca.Visible = true;

                }
            }
        }

        private void but_alterar_marca_Click(object sender, EventArgs e)
        {
            conexao = new MySqlConnection("Persist Security info = False;server=10.32.47.27;database=chocolatra;uid=chocolatra;pwd=chocolatra");

            try
            {
                conexao.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            if (caixa_alterar_marca.Text.Trim() != "")
            {
                MySqlCommand cmd_alterar_marca = new MySqlCommand("UPDATE marcas SET marca = '" + caixa_alterar_marca.Text + "' WHERE cod_marca = '" + caixa_cod_marca.Text + "'", conexao);
                cmd_alterar_marca.ExecuteNonQuery();

                MessageBox.Show("ALTERADO COM SUCESSO");

                caixa_nova_marca.ReadOnly = false;
                caixa_alterar_marca.Visible = false;
                but_alterar_marca.Visible = false;
                lbl_novo_nome.Visible = false;
                but_deletar_marca.Visible = false;
            }

            else
            {
                MessageBox.Show("CAMPO VAZIO");
            }
            
        }

        private void but_deletar_marca_Click(object sender, EventArgs e)
        {
            DtSet = new DataSet();
            conexao = new MySqlConnection("Persist Security info = False;server=10.32.47.27;database=chocolatra;uid=chocolatra;pwd=chocolatra");
            try
            {
                conexao.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

                MySqlCommand cmd_deletar_marca = new MySqlCommand("DELETE FROM marcas WHERE cod_marca = '" + caixa_cod_marca.Text + "'", conexao);
                cmd_deletar_marca.ExecuteNonQuery();

                MessageBox.Show("DELETADO COM SUCESSO");

                caixa_cod_marca.ReadOnly = false;
                caixa_alterar_marca.Visible = false;
                but_alterar_marca.Visible = false;
                lbl_novo_nome.Visible = false;
                but_deletar_marca.Visible = false;
                caixa_cod_marca.Text = "";

            }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cad_Produtos_Load(object sender, EventArgs e)
        {
            DtSet = new DataSet();
            conexao = new MySqlConnection("Persist Security info = False;server=10.32.47.27;database=chocolatra;uid=chocolatra;pwd=chocolatra");

            try
            {
                conexao.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            adaptador = new MySqlDataAdapter("select * from marcas", conexao);
            adaptador.Fill(DtSet, "marcas");
            dataGrid_Marcas.DataMember = "marcas";
            dataGrid_Marcas.DataSource = DtSet;

        }

       

  }
}
