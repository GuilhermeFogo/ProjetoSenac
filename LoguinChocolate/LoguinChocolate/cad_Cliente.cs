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
    public partial class cad_Cliente : Form
    {
        public cad_Cliente()
        {
            InitializeComponent();
        }

        private MySqlConnection conexao;
        private MySqlDataAdapter adaptador;
        private DataSet DtSet;

        private void but_pesquisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atenção", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            DialogResult mensagem = MessageBox.Show("Click no Yes para Atualizar o registro ou NO para Deletar registro", "Mensagem",
                  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
            if (mensagem == DialogResult.Yes)
            {
                // bloqueio dos botoes
                but_ok.Visible = true;
                but_ok.Enabled = true;
                but_deletar.Enabled = false;
                but_cadastrar.Enabled = false;
                but_alterar.Enabled = true;
                caixa_codcliente.Enabled = true;

                // bloqueia campos
                caixa_bairro.Enabled = false;
                caixa_celular.Enabled = false;
                caixa_cep.Enabled = false;
                caixa_cidade.Enabled = false;
                caixa_cpf.Enabled = false;
                caixa_email.Enabled = false;
                caixa_estado.Enabled = false;
                caixa_nome.Enabled = false;
                caixa_numero.Enabled = false;
                caixa_rg.Enabled = false;
                caixa_rua.Enabled = false;
                caixa_telefone1.Enabled = false;
                caixa_telefone2.Enabled = false;
                dtp_nascimento.Enabled = false;
                rich_complemento.Enabled = false;
                rbtn_feminino.Enabled = false;
                rbtn_masculino.Enabled = false;
                // focus
                caixa_codcliente.Focus();


            }
            else
            {
                if (mensagem == DialogResult.No)
                {
                    // bloqueio dos botoes
                    but_alterar.Enabled = false;
                    but_cadastrar.Enabled = false;
                    but_deletar.Enabled = true;
                    caixa_codcliente.Enabled = true;
                    but_ok.Visible = true;
                    but_ok.Enabled = true;

                    // bloqueia campos
                    caixa_bairro.Enabled = false;
                    caixa_celular.Enabled = false;
                    caixa_cep.Enabled = false;
                    caixa_cidade.Enabled = false;
                    caixa_cpf.Enabled = false;
                    caixa_email.Enabled = false;
                    caixa_estado.Enabled = false;
                    caixa_nome.Enabled = false;
                    caixa_numero.Enabled = false;
                    caixa_rg.Enabled = false;
                    caixa_rua.Enabled = false;
                    caixa_telefone1.Enabled = false;
                    caixa_telefone2.Enabled = false;
                    dtp_nascimento.Enabled = false;
                    rich_complemento.Enabled = false;
                    rbtn_masculino.Enabled = false;
                    rbtn_feminino.Enabled = true;
                    // focus
                    caixa_codcliente.Focus();

                }

            }
            

        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            but_cadastrar.Enabled = true;
            but_alterar.Enabled = false;
            but_deletar.Enabled = false;
            but_ok.Visible = false;
            but_ok.Enabled = false;


            caixa_bairro.Enabled = true;
            caixa_celular.Enabled = true;
            caixa_cep.Enabled = true;
            caixa_cidade.Enabled = true;
            caixa_cpf.Enabled = true;
            caixa_email.Enabled = true;
            caixa_estado.Enabled = true;
            caixa_nome.Enabled = true;
            caixa_numero.Enabled = true;
            caixa_rg.Enabled = true;
            caixa_rua.Enabled = true;
            caixa_telefone1.Enabled = true;
            caixa_telefone2.Enabled = true;
            dtp_nascimento.Enabled = true;
            rich_complemento.Enabled = true;
            rbtn_feminino.Enabled = true;
            rbtn_masculino.Enabled = true;
           
            DtSet = new DataSet();
            adaptador = new MySqlDataAdapter("SELECT * FROM clientes WHERE cod_cliente ='" + caixa_codcliente.Text + "'", conexao);
            adaptador.Fill(DtSet, "Clientes");

            if (DtSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("PRODUTO NAO ENCONTRADO");
            }
            else
            {

                but_alterar.Enabled = true;
                but_deletar.Enabled = true;
                MySqlCommand cmd_concluir_pesquisa = new MySqlCommand("SELECT * FROM v_clientes WHERE cod_cliente ='" + caixa_codcliente.Text + "'", conexao);
                MySqlDataReader lerRegistro = cmd_concluir_pesquisa.ExecuteReader();


                while (lerRegistro.Read())
                {
                    caixa_nome.Text = lerRegistro["NomeCliente"].ToString();
                    caixa_bairro.Text = lerRegistro["Bairro"].ToString();
                    caixa_celular.Text = lerRegistro["Celular"].ToString();
                    caixa_cep.Text = lerRegistro["CEP"].ToString();
                    caixa_cidade.Text = lerRegistro["Cidade"].ToString();
                    caixa_cpf.Text = lerRegistro["CPF"].ToString();
                    caixa_email.Text = lerRegistro["EmailDoCliente"].ToString();
                    caixa_estado.Text = lerRegistro["Estado"].ToString();
                    caixa_numero.Text = lerRegistro["Numero"].ToString();
                    caixa_rg.Text = lerRegistro["RG"].ToString();
                    caixa_rua.Text = lerRegistro["Rua"].ToString();
                    caixa_telefone1.Text = lerRegistro["Telefone1"].ToString();
                    caixa_telefone2.Text = lerRegistro["Telefone2"].ToString();

                }

            }   







        }

        private void but_cadastrar_Click(object sender, EventArgs e)
        {
            if (caixa_bairro.Text.Trim() == "" || caixa_celular.Text.Trim() == "" || caixa_cep.Text.Trim() == "" || caixa_cidade.Text.Trim() == "" || caixa_cpf.Text.Trim() == "" || caixa_email.Text.Trim() == "" ||
                caixa_estado.Text.Trim() == "" || caixa_nome.Text.Trim() == "" || caixa_numero.Text.Trim() == "" || caixa_rg.Text.Trim() == "" || caixa_rua.Text.Trim() == "" || caixa_telefone1.Text.Trim() == "" || caixa_telefone2.Text.Trim() == "")
            {
                MessageBox.Show("Prencha todos os campos", "Mensagem", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);

            }
            else
            {
                DtSet = new DataSet();
                conexao = new MySqlConnection("Persist Security Info =False;server=10.32.47.27;database=chocolatra;uid=chocolatra;pwd=chocolatra");
                try
                {
                    conexao.Open();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }


                // datas
                string data_nasc = dtp_nascimento.Value.ToString("yyyy-MM-dd");

                // radio buton

                string sexo = "0";
                if (rbtn_masculino.Checked == true)
                {
                    sexo = "M";
                }
                else
                {
                    if (rbtn_feminino.Checked == true)
                    {
                        sexo = "F";
                    }
                }

                // tabela email
                MySqlCommand cmd_cadastar_emailcliente = new MySqlCommand
                    ("insert into emails_cliente(email) values('" + caixa_email.Text + "')", conexao);

                cmd_cadastar_emailcliente.ExecuteNonQuery();
                long id_email = cmd_cadastar_emailcliente.LastInsertedId;  // pega utimo id q foi colocado    

                // adaptador de emails_cliente
                adaptador = new MySqlDataAdapter("select * from emails_cliente", conexao);
                adaptador.Fill(DtSet, "Emails");

                if (DtSet.Tables[0].Rows.Count > 0)
                {

                    // Tabela telefones
                    MySqlCommand cmd_cadastrar_telefonecliente = new MySqlCommand
                    ("insert into telefones_cliente(telefone1,telefone2,celular) values ('" + caixa_telefone1.Text + "','" +
                    caixa_telefone2.Text + "','" + caixa_celular.Text + "')", conexao);

                    cmd_cadastrar_telefonecliente.ExecuteNonQuery();
                    long id_telefone = cmd_cadastrar_telefonecliente.LastInsertedId;

                    // adaptador de telefone_cliente
                    adaptador = new MySqlDataAdapter("select * from telefones_cliente", conexao);
                    adaptador.Fill(DtSet, "telefone");

                    if (DtSet.Tables[0].Rows.Count > 0)
                    {

                        // Tabela endereco
                        MySqlCommand cmd_cadastrar_endereco = new MySqlCommand
                        ("insert into enderecos_cliente(rua,numero,bairro,estado,cidade,cep,complemento)" +
                        "values('" + caixa_rua.Text + "','" + caixa_numero.Text + "','" + caixa_bairro.Text + "','" + caixa_estado.Text + "','" +
                        caixa_cidade.Text + "','" + caixa_cep.Text + "','" + rich_complemento.Text + "')", conexao);

                        cmd_cadastrar_endereco.ExecuteNonQuery();
                        long id_endereco = cmd_cadastrar_telefonecliente.LastInsertedId;

                        // adaptador de enderecos_cliente
                        adaptador = new MySqlDataAdapter("select * from enderecos_cliente", conexao);
                        adaptador.Fill(DtSet, "endereco");

                        if (DtSet.Tables[0].Rows.Count > 0)
                        {

                            // tabela cliente 
                            MySqlCommand cmd_cadastrar_cliente = new MySqlCommand
                                ("insert into clientes(nome_cliente,rg,cpf,data_nascimento,sexo , cod_email, cod_endereco_cliente,cod_telefone)" +
                                "values('" + caixa_nome.Text + "','" + caixa_rg.Text + "','" + caixa_cpf.Text + "','" + data_nasc + "','" +
                                 sexo + "','" + id_email + "','" + id_endereco + "','" + id_telefone + "')", conexao);

                            cmd_cadastrar_cliente.ExecuteNonQuery();

                            // adaptador de clientes
                            adaptador = new MySqlDataAdapter("select * from clientes", conexao);
                            adaptador.Fill(DtSet, "Clientes");


                            MessageBox.Show("Cadastro realizado com exito..", "Mensagem", MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }
        }

        private void but_alterar_Click(object sender, EventArgs e)
        {
            DtSet = new DataSet();
            conexao = new MySqlConnection("Persist Security Info=False;server=10.32.47.27;database=chocolatra;uid=chocolatra;pwd=chocolatra");
            try
            {
                conexao.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            string sexo = "0";
            if (rbtn_feminino.Checked == true)
            {
                sexo = "F";
            }
            else
            {
                if (rbtn_masculino.Checked == true)
                {
                    sexo = "M";
                }
            }

            // data
            string datas = dtp_nascimento.Value.ToString("yyyy-MM-dd");


            // tabela emails_cliente
            MySqlCommand cmd_alterar_emails = new MySqlCommand
            ("update emails_cliente set email='" + caixa_email.Text + "' where cod_emails='" +
            caixa_codcliente.Text + "'", conexao);

            cmd_alterar_emails.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from emails_cliente", conexao);
            adaptador.Fill(DtSet, "emails");

            // tabela de telefones
            MySqlCommand cmd_alterar_telefones = new MySqlCommand
            ("update telefones_cliente set telefone1='" + caixa_telefone1.Text + "', telefone2='" + caixa_telefone2.Text + "', celular='" + caixa_celular.Text + "' where cod_telefone='" +
            caixa_codcliente.Text + "'", conexao);

            cmd_alterar_telefones.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from telefones_cliente", conexao);
            adaptador.Fill(DtSet, "telefone");

            // endereço cliente
            MySqlCommand cmd_alterar_endereco = new MySqlCommand
            ("update enderecos_cliente set cep='" + caixa_cep.Text + "', cidade='" + caixa_cidade.Text + "', rua='" + caixa_rua.Text + "',numero='" +
            caixa_numero.Text + "',bairro='" + caixa_bairro.Text + "',estado='" + caixa_estado.Text + "' where cod_endereco_cliente='" + caixa_codcliente.Text + "'", conexao);

            cmd_alterar_endereco.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from enderecos_cliente", conexao);
            adaptador.Fill(DtSet, "endreco");

            // tabela clientes
            MySqlCommand cmd_alterar_clientes = new MySqlCommand
            ("update clientes set nome_cliente='" + caixa_nome.Text + "',rg='" + caixa_rg.Text + "',cpf= '" + caixa_cpf.Text + "',data_nascimento='" + datas + "',sexo='" + sexo + "' where cod_cliente='" + caixa_codcliente.Text + "'", conexao);


            cmd_alterar_clientes.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from clientes", conexao);
            adaptador.Fill(DtSet, "clientes");


            MessageBox.Show("Altereçoes realizads com exito...", "Mensagem", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }

        private void but_deletar_Click(object sender, EventArgs e)
        {
            DtSet = new DataSet();
            conexao = new MySqlConnection("Persist Security Info=False;server=10.32.47.27;database=chocolatra;uid=chocolatra;pwd=chocolatra");
            try
            {
                conexao.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            // tabela emails_cliente
            MySqlCommand cmd_delete_emails = new MySqlCommand
            ("delete from emails_cliente where cod_email='" + caixa_codcliente.Text + "'", conexao);

            cmd_delete_emails.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from emails_cliente", conexao);
            adaptador.Fill(DtSet, "emails");

            // tabela de telefones
            MySqlCommand cmd_delete_telefones = new MySqlCommand
            ("delete from telefones_cliente where cod_telefone ='" + caixa_codcliente.Text + "', telefone2='" + caixa_telefone2.Text + "', celular='" + caixa_celular.Text + "' where telefone1='" +
            caixa_telefone1.Text + "'", conexao);

            cmd_delete_telefones.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from telefones_cliente", conexao);
            adaptador.Fill(DtSet, "telefone");

            // endereço cliente
            MySqlCommand cmd_alterar_endereco = new MySqlCommand
            ("delete from  enderecos_cliente where  cod_endereco='" + caixa_codcliente.Text + "'", conexao);

            cmd_alterar_endereco.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from enderecos_cliente", conexao);
            adaptador.Fill(DtSet, "endreco");

            // tabela clientes
            MySqlCommand cmd_alterar_clientes = new MySqlCommand
            ("delete from clientes where cod_cliente='" + caixa_codcliente.Text + "'", conexao);

            cmd_alterar_clientes.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from v_clientes", conexao);
            adaptador.Fill(DtSet, "clientes");


            MessageBox.Show("Deletado com exito...", "Mensagem", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);



        }

        private void but_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

      
    }
}
