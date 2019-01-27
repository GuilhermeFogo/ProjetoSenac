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
    public partial class cad_fornecedores : Form
    {
        public cad_fornecedores()
        {
            InitializeComponent();
        }

        private MySqlConnection conexao;
        private MySqlDataAdapter adaptador;
        private DataSet DtSet;

        private void but_pesquisa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atenção", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            DialogResult mensagem = MessageBox.Show("Click no Yes para Atualizar o registro ou NO para Deletar registro", "Mensagem",
                  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);

            if (mensagem == DialogResult.Yes)
            {
                // bloqueio dos botoes
                but_alterar.Enabled = true;
                but_inserir.Enabled = false;
                but_deletar.Enabled = false;
                caixa_cod.Enabled = true;
                but_ok.Visible = true;
                but_ok.Enabled = true;
                // bloqueio dos campos
                caixa_celular.Enabled = false;
                caixa_cnpj.Enabled = false;
                caixa_email1.Enabled = false;
                caixa_email2.Enabled = false;
                caixa_nome.Enabled = false;
                caixa_nomecontato.Enabled = false;
                caixa_telefone1.Enabled = false;
                caixa_telefone2.Enabled = false;
                // focus
                caixa_cod.Focus();

            }
            else
            {
                if (mensagem == DialogResult.No)
                {
                    // bloqueio dos botoes
                    but_alterar.Enabled = false;
                    but_inserir.Enabled = false;
                    but_deletar.Enabled = true;
                    caixa_cod.Enabled = true;
                    but_ok.Visible = true;
                    but_ok.Enabled = true;
                    // bloqueio dos campos
                    caixa_celular.Enabled = false;
                    caixa_cnpj.Enabled = false;
                    caixa_email1.Enabled = false;
                    caixa_email2.Enabled = false;
                    caixa_nome.Enabled = false;
                    caixa_nomecontato.Enabled = false;
                    caixa_telefone1.Enabled = false;
                    caixa_telefone2.Enabled = false;
                    // focus
                    caixa_cod.Focus();


                }


            }
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            // bloqueio dos botoes
            but_alterar.Enabled = false;
            but_inserir.Enabled = true;
            but_deletar.Enabled = false;
            caixa_cod.Enabled = false;
            but_ok.Visible = false;
            but_ok.Enabled = false;
            // bloqueio dos campos
            caixa_celular.Enabled = true;
            caixa_cnpj.Enabled = true;
            caixa_email1.Enabled = true;
            caixa_email2.Enabled = true;
            caixa_nome.Enabled = true;
            caixa_nomecontato.Enabled = true;
            caixa_telefone1.Enabled = true;
            caixa_telefone2.Enabled = true;

            DtSet = new DataSet();
            adaptador = new MySqlDataAdapter("SELECT * FROM fornecedores WHERE cod_fornecedor ='" + caixa_cod.Text + "'", conexao);
            adaptador.Fill(DtSet, "fornecedor");

            if (DtSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("PRODUTO NAO ENCONTRADO");
            }
            else
            {

                MySqlCommand cmd_concluir_pesquisa = new MySqlCommand("SELECT * FROM v_fornecedores where cod_fornecedor='" + caixa_cod.Text + "'", conexao);
                MySqlDataReader lerRegistro = cmd_concluir_pesquisa.ExecuteReader();


                while (lerRegistro.Read())
                {
                    caixa_nome.Text = lerRegistro["Nome"].ToString();
                    caixa_celular.Text = lerRegistro["Celular"].ToString();
                    caixa_cnpj.Text = lerRegistro["CNPJ"].ToString();
                    caixa_email1.Text = lerRegistro["EmailsDoContato1"].ToString();
                    caixa_email2.Text = lerRegistro["EmailsDoContato2"].ToString();
                    caixa_nomecontato.Text = lerRegistro["nome_contato"].ToString();
                    caixa_telefone1.Text = lerRegistro["TelefoneDoContato1"].ToString();
                    caixa_telefone2.Text = lerRegistro["TelefoneDoContato2"].ToString();
                }

            }   




        }

        private void but_inserir_Click(object sender, EventArgs e)
        {
            if (caixa_celular.Text.Trim() == "" || caixa_cnpj.Text.Trim() == "" || caixa_email1.Text.Trim() == "" || caixa_email2.Text.Trim() == "" || caixa_nome.Text.Trim() == "" || caixa_nomecontato.Text.Trim() == "" ||
                 caixa_telefone1.Text.Trim() == "" || caixa_telefone2.Text.Trim() == "")
            {
                MessageBox.Show("Preencha todos os campos", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                DtSet = new DataSet();
                conexao = new MySqlConnection("Persist Security info =False; server = 10.32.47.27;database=chocolatra;uid=chocolatra;pwd=chocolatra");

                try
                {
                    conexao.Open();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

                MessageBox.Show("Cadastro realizado com exito..", "Mensagem", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);

                // tabela email_fornecedor
                MySqlCommand cmd_cadastro_email = new MySqlCommand
                ("insert into emails_fornecedores( email1, email2)" +
                "values ('" + caixa_email1.Text + "','" + caixa_email2.Text + "')", conexao);

                cmd_cadastro_email.ExecuteNonQuery();
                long id_email_fornecedores = cmd_cadastro_email.LastInsertedId;


                adaptador = new MySqlDataAdapter("select * from emails_fornecedores", conexao);
                adaptador.Fill(DtSet, "email");

                if (DtSet.Tables[0].Rows.Count > 1)
                {

                    // tabela telefone_fornrcedor
                    MySqlCommand cmd_cadastrar_telefone = new MySqlCommand
                    ("insert into telefones_fornecedores(telefone1,telefone2,celular)" +
                    "values ('" + caixa_telefone1.Text + "','" + caixa_telefone2.Text + "','" + caixa_celular.Text + "')", conexao);

                    cmd_cadastrar_telefone.ExecuteNonQuery();
                    long id_telefone = cmd_cadastrar_telefone.LastInsertedId;

                    adaptador = new MySqlDataAdapter("select * from telefones_fornecedores", conexao);
                    adaptador.Fill(DtSet, "telefone");

                    if (DtSet.Tables[0].Rows.Count > 1)
                    {


                        // tabela contato_fornecedor
                        MySqlCommand cmd_cadastro_contato = new MySqlCommand
                        ("insert into contatos_fornecedores(cod_email, cod_tel)" +
                        "values ('" + id_email_fornecedores + "','" + id_telefone + "')", conexao);

                        cmd_cadastro_contato.ExecuteNonQuery();
                        long id_contato = cmd_cadastro_contato.LastInsertedId;

                        adaptador = new MySqlDataAdapter("select * from contatos_fornecedores", conexao);
                        adaptador.Fill(DtSet, "contato");

                        if (DtSet.Tables[0].Rows.Count > 1)
                        {

                            // tabela fornecedores
                            MySqlCommand cmd_cadastro_fornecedor = new MySqlCommand
                            ("insert into fornecedores(nome,cnpj,nome_contato,cod_contato)" +
                            "values('" + caixa_nome.Text + "','" + caixa_cnpj.Text + "','" + caixa_nomecontato.Text + "','" + id_contato + "')", conexao);

                            cmd_cadastro_fornecedor.ExecuteNonQuery();

                            adaptador = new MySqlDataAdapter("select * from fornecedores", conexao);
                            adaptador.Fill(DtSet, "Fornecedores");
                        }
                    }
                }
            }

        }

        private void but_alterar_Click(object sender, EventArgs e)
        {
            DtSet = new DataSet();
            conexao = new MySqlConnection("Persist Security info =False; server = 10.32.47.27;database=chocolatra;uid=chocolatra;pwd=chocolatra");
            try
            {
                conexao.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            // tabela de email
            MySqlCommand cmd_alterar_email_fornecedores = new MySqlCommand
            ("update emails_fornecedores set email1='" + caixa_email1.Text + "', email2='" + caixa_email2.Text + "' where cod_email='" +
            caixa_cod.Text + "'", conexao);

            cmd_alterar_email_fornecedores.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from emails_fornecedores ", conexao);
            adaptador.Fill(DtSet, "emails");

            // tabela de telefone
            MySqlCommand cmd_alterar_telefone_fornecedores = new MySqlCommand
            ("update telefones_fornecedores set telefone1='" + caixa_telefone1.Text + "',telefone2='" + caixa_telefone2.Text + "',celular='" + caixa_celular.Text + "' where cod_tel ='" +
            caixa_cod.Text + "'", conexao);

            cmd_alterar_telefone_fornecedores.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from telefones_fornecedores ", conexao);
            adaptador.Fill(DtSet, "telefone");

            //fornecedores
            MySqlCommand cmd_alterar_fornecedores = new MySqlCommand
            ("update fornecedores set nome ='" + caixa_nome.Text + "', cnpj='" + caixa_cnpj.Text + "',nome_contato='" +
            caixa_nomecontato.Text + "' where cod_fornecedor='" + caixa_cod.Text + "'", conexao);

            cmd_alterar_fornecedores.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from v_fornecedores", conexao);
            adaptador.Fill(DtSet, "fornecedores");

            MessageBox.Show("Alterado com exito...", "Mensagem", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);


        }

        private void but_deletar_Click(object sender, EventArgs e)
        {
            DtSet = new DataSet();
            conexao = new MySqlConnection("Persist Security info =False; server = 10.32.47.27;database=chocolatra;uid=chocolatra;pwd=chocolatra");
            try
            {
                conexao.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            // tabela de email
            MySqlCommand cmd_delete_email_fornecedores = new MySqlCommand
            ("delete from emails_fornecedores where cod_email='" + caixa_cod.Text + "'", conexao);

            cmd_delete_email_fornecedores.ExecuteNonQuery();
            
            adaptador = new MySqlDataAdapter("select * from emails_fornecedores", conexao);
            adaptador.Fill(DtSet, "email");

            // tabela de telefone
            MySqlCommand cmd_delete_telefone_fornecedores = new MySqlCommand
            ("delete from telefones_fornecedores where cod_tel='" + caixa_cod.Text + "'"
            , conexao);

            cmd_delete_telefone_fornecedores.ExecuteNonQuery();


            adaptador = new MySqlDataAdapter("select * from telefones_fornecedores", conexao);
            adaptador.Fill(DtSet, "telefone");

            //fornecedores
            MySqlCommand cmd_delete_fornecedores = new MySqlCommand
            ("delete from fornecedores cod_fornecedor=" +
            caixa_cod.Text + "'", conexao);

            cmd_delete_fornecedores.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from v_fornecedores", conexao);
            adaptador.Fill(DtSet, "fornecedores");

            MessageBox.Show("Deletado com exito...", "Mensagem", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);

        }
    }
}
