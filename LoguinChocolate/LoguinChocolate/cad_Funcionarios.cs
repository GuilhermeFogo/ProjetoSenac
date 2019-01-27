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
    public partial class cad_Funcionarios : Form
    {
        public cad_Funcionarios()
        {
            InitializeComponent();

            caixa_cod.Enabled = false;
            but_ok.Visible = false;
            but_ok.Enabled = false;
        }

        private MySqlConnection conexao;
        private MySqlDataAdapter adaptador;
        private DataSet DtSet;


        private void but_pesquisar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Atenção", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            DialogResult mensagem = MessageBox.Show("Click Sim para fazer alteraçoes ou Não para deletar ", "Mensagem",
                  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);

            if (mensagem == DialogResult.Yes)
            {
                // bloqueio dos botoes
                but_alterar.Enabled = true;
                but_concluir.Enabled = false;
                but_deletar.Enabled = false;
                caixa_cod.Enabled = true;
                but_ok.Visible = true;
                but_ok.Enabled = true;
                // bloqueio dos campos
                caixa_cidade.Enabled = false;
                caixa_bairro.Enabled = false;
                caixa_cargo.Enabled = false;
                caixa_celular.Enabled = false;
                caixa_cep.Enabled = false;
                caixa_cpf.Enabled = false;
                caixa_estado.Enabled = false;
                caixa_nome.Enabled = false;
                caixa_numero.Enabled = false;
                caixa_rg.Enabled = false;
                caixa_rua.Enabled = false;
                caixa_salario.Enabled = false;
                caixa_telefone1.Enabled = false;
                caixa_telefone2.Enabled = false;
                cbox_turno.Enabled = false;
                // focus
                caixa_cod.Focus();

            
            }
            else
            {
                if (mensagem == DialogResult.No)
                {
                    //bloqueio de botao
                    but_alterar.Enabled = false;
                    but_concluir.Enabled = false;
                    but_deletar.Enabled = true;
                    but_ok.Visible = false;
                    but_ok.Enabled = false;
                    // bloqueio de campos
                    caixa_cidade.Enabled = false;
                    caixa_bairro.Enabled = false;
                    caixa_cargo.Enabled = false;
                    caixa_celular.Enabled = false;
                    caixa_cep.Enabled = false;
                    caixa_cpf.Enabled = false;
                    caixa_estado.Enabled = false;
                    caixa_nome.Enabled = false;
                    caixa_numero.Enabled = false;
                    caixa_rg.Enabled = false;
                    caixa_rua.Enabled = false;
                    caixa_salario.Enabled = false;
                    caixa_telefone1.Enabled = false;
                    caixa_telefone2.Enabled = false;
                    cbox_turno.Enabled = false;
                    // focus
                    caixa_cod.Focus();

            
                }

            }

        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            // bloqueio de botao
            but_alterar.Enabled = false;
            but_concluir.Enabled = true;
            but_deletar.Enabled = false;
            but_ok.Visible = true;
            but_ok.Enabled = false;
            // bloqueio de campo
            caixa_cidade.Enabled = true;
            caixa_bairro.Enabled = true;
            caixa_cargo.Enabled = true;
            caixa_celular.Enabled = true;
            caixa_cep.Enabled = true;
            caixa_cpf.Enabled = true;
            caixa_estado.Enabled = true;
            caixa_nome.Enabled = true;
            caixa_numero.Enabled = true;
            caixa_rg.Enabled = true;
            caixa_rua.Enabled = true;
            caixa_salario.Enabled = true;
            caixa_telefone1.Enabled = true;
            caixa_telefone2.Enabled = true;
            cbox_turno.Enabled = true;

          
            DtSet = new DataSet();
            conexao = new MySqlConnection("Persist Security info = False;server=10.32.47.27;database=chocolatra;uid=chocolatra;pwd=chocolatra");
            try
            {
                conexao.Open();
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            if (conexao.State == ConnectionState.Open)
            {

                DtSet = new DataSet();
                adaptador = new MySqlDataAdapter("SELECT * FROM funcionarios WHERE cod_funcionario ='" + caixa_cod.Text + "'", conexao);
                adaptador.Fill(DtSet, "fucionario");

                if (DtSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Funcionario nao encontrado", "Mensagem", MessageBoxButtons.OK,
MessageBoxIcon.Asterisk);
                }
                else
                {
                    MySqlCommand cmd_concluir_pesquisa = new MySqlCommand("SELECT * FROM v_funcionario where cod_funcionario ='" + caixa_cod.Text + "'", conexao);
                    MySqlDataReader lerRegistro = cmd_concluir_pesquisa.ExecuteReader();


                    while (lerRegistro.Read())
                    {
                        caixa_nome.Text = lerRegistro["nome"].ToString();
                        caixa_bairro.Text = lerRegistro["bairro"].ToString();
                        caixa_cargo.Text = lerRegistro["cargo"].ToString();
                        caixa_celular.Text = lerRegistro["celular"].ToString();
                        caixa_cep.Text = lerRegistro["cep"].ToString();
                        caixa_cidade.Text = lerRegistro["cidade"].ToString();
                        caixa_cpf.Text = lerRegistro["cpf"].ToString();
                        caixa_estado.Text = lerRegistro["estado"].ToString();
                        caixa_numero.Text = lerRegistro["numero"].ToString();
                        caixa_rg.Text = lerRegistro["rg"].ToString();
                        caixa_rua.Text = lerRegistro["rua"].ToString();
                        caixa_salario.Text = lerRegistro["salario"].ToString();
                        caixa_telefone1.Text = lerRegistro["telefone"].ToString();
                        caixa_telefone2.Text = lerRegistro["telefone2"].ToString();
                        dtp_nascimento.Text = lerRegistro["data_nasc"].ToString();
                    }

                }


            }

        }

        private void but_concluir_Click(object sender, EventArgs e)
        {
            if (caixa_bairro.Text.Trim() == "" || caixa_cargo.Text.Trim() == "" || caixa_celular.Text.Trim() == "" || caixa_cep.Text == "" || caixa_cidade.Text.Trim() == "" || caixa_cpf.Text.Trim() == "" ||
                 caixa_estado.Text.Trim() == "" || caixa_nome.Text.Trim() == "" || caixa_numero.Text.Trim() == "" || caixa_rg.Text.Trim() == "" || caixa_rua.Text.Trim() == "" || caixa_salario.Text.Trim() == "" ||
                 caixa_telefone1.Text.Trim() == "" || caixa_telefone2.Text.Trim() == "")
            {
                MessageBox.Show("Preencha todos os campos nescessarios", "Mensagem", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            else
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
                // radios button

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


                // formatando datas
                    string Data_nasc = dtp_nascimento.Value.ToString("yyyy-MM-dd");
                
                // tabela turno
                MySqlCommand cmd_cadastro_turno = new MySqlCommand
                ("insert into turnos(turno) values('" + cbox_turno.Text + "')", conexao);

                cmd_cadastro_turno.ExecuteNonQuery();
                long id_turno = cmd_cadastro_turno.LastInsertedId;

                adaptador = new MySqlDataAdapter("select * from turnos", conexao);
                adaptador.Fill(DtSet, "Turnos");
                if (DtSet.Tables[0].Rows.Count > 10)
                {

                    // tabela telefone
                    MySqlCommand cmd_cadastro_telefone = new MySqlCommand
                    ("insert into telefones_funcionarios(telefone,telefone2,celular)" +
                    " values('" + caixa_telefone1.Text + "','" + caixa_telefone2.Text + "','" + caixa_celular.Text + "')", conexao);

                    cmd_cadastro_telefone.ExecuteNonQuery();
                    long id_telefone = cmd_cadastro_telefone.LastInsertedId;

                    adaptador = new MySqlDataAdapter("select * from telefones_funcionarios", conexao);
                    adaptador.Fill(DtSet, "Telefones");

                    if (DtSet.Tables[0].Rows.Count > 10)
                    {

                        // tabela endereco
                        MySqlCommand cmd_cadastro_endereco = new MySqlCommand
                        ("insert into enderecos_funcionarios(cep,numero,rua,bairro,cidade,estado,complemento)" +
                        "values('" + caixa_cep.Text + "','" + caixa_numero.Text + "','" + caixa_rua.Text + "','" + caixa_bairro.Text + "','" + caixa_cidade.Text + "','" + caixa_estado + "','" +
                        rich_complemento.Text + "')", conexao);

                        cmd_cadastro_endereco.ExecuteNonQuery();
                        long id_endereco = cmd_cadastro_endereco.LastInsertedId;

                        adaptador = new MySqlDataAdapter("select * from enderecos_funcionarios", conexao);
                        adaptador.Fill(DtSet, "endereco");

                        if (DtSet.Tables[0].Rows.Count > 10)
                        {

                            // tabela cargo
                            MySqlCommand cmd_cadastro_cargo = new MySqlCommand
                            ("insert into cargos(cargo) values('" + caixa_cargo.Text + "')", conexao);

                            cmd_cadastro_cargo.ExecuteNonQuery();
                            long id_cargo = cmd_cadastro_cargo.LastInsertedId;

                            adaptador = new MySqlDataAdapter("select * from cargos", conexao);
                            adaptador.Fill(DtSet, "cargo");

                            if (DtSet.Tables[0].Rows.Count > 10)
                            {

                                // tabela funcionarios 
                                MySqlCommand cmd_cadastro_funcionario = new MySqlCommand
                                ("insert into funcionarios(nome,cpf,rg,data_nasc,salario,cod_endereco,cod_telefone,cod_turno,cod_cargo, sexo)" +
                                "values ('" + caixa_nome.Text + "','" + caixa_cpf.Text + "','" + caixa_rg.Text + "','" + Data_nasc + "','" + caixa_salario.Text + "','" +
                                id_endereco + "','" + id_telefone + "','" + id_turno + "','" + id_cargo + "','" + sexo + "')", conexao);

                                cmd_cadastro_funcionario.ExecuteNonQuery();

                                adaptador = new MySqlDataAdapter("select * from funcionarios", conexao);
                                adaptador.Fill(DtSet, "Funcionario");

                                MessageBox.Show("Cadastro feito com exito...", "Messagem", MessageBoxButtons.OK,
                                    MessageBoxIcon.Asterisk);
                            }
                        }
                    }
                }
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

            // tabela cargo
            MySqlCommand cmd_deletar_cargo = new MySqlCommand
             ("delete  from cargos where cod_cargo='" + caixa_cod.Text + "'", conexao);
            cmd_deletar_cargo.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from cargos", conexao);
            adaptador.Fill(DtSet, "cargo");

            // tabela turno
            MySqlCommand cmd_alterar_turno = new MySqlCommand
                ("delete  from turnos where cod_turno ='" + caixa_cod.Text + "'", conexao);
            cmd_alterar_turno.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from turnos", conexao);
            adaptador.Fill(DtSet, "turno");

            // tabela endereço
            MySqlCommand cmd_delete_endereco = new MySqlCommand
         ("delete from enderecos_funcionarios where cod_endereco='" + caixa_cod.Text + "'", conexao);
            cmd_delete_endereco.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from enderecos_funcionarios ", conexao);
            adaptador.Fill(DtSet, "endereco");

            // tabela telefone_funcionarios
            MySqlCommand cmd_delete_telefone_funcionario = new MySqlCommand
                ("delete from telefones_funcionarios where telefone='"+ caixa_cod.Text+"'",conexao);
            cmd_delete_telefone_funcionario.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from telefones_funcionarios", conexao);
            adaptador.Fill(DtSet, "telefone");

            MySqlCommand cmd_deletar_funcionario = new MySqlCommand
                ("delete from funcionarios where cod_funcionario='" + caixa_cod.Text + "'", conexao);

            cmd_deletar_funcionario.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from funcionarios", conexao);
            adaptador.Fill(DtSet, "funcionario");

            MessageBox.Show("Deletado com exito...", "Mensagem", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);

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
            // formatando datas
            string Data_nasc = dtp_nascimento.Value.ToString("yyyy-MM-dd");

            // tabela cargo
            MySqlCommand cmd_alterar_cargo = new MySqlCommand
             ("update cargos set cargo='" + caixa_cargo.Text + "' where cod_cargo='" + caixa_cod.Text + "'", conexao);
            cmd_alterar_cargo.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from cargos", conexao);
            adaptador.Fill(DtSet, "Cargos");

            // tabela turno
            MySqlCommand cmd_alterar_turno = new MySqlCommand
             ("update turnos set turno ='" + cbox_turno + "' where cod_turnos='" + caixa_cod.Text + "'", conexao);
            cmd_alterar_turno.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from turnos", conexao);
            adaptador.Fill(DtSet, "turno");

            // tabela endereço
            MySqlCommand cmd_alterar_endereco = new MySqlCommand
           ("update enderecos_funcionarios set cep='" + caixa_cep.Text + "',rua='" + caixa_rua.Text + "',bairro='" + caixa_bairro.Text + "',numero='" + caixa_numero.Text +
           "',cidade='" + caixa_cidade.Text + "',estado='" + caixa_estado.Text + "',complemento='" + rich_complemento.Text + "' where cod_endereco='" +
           caixa_cod.Text + "'", conexao);

            cmd_alterar_endereco.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from enderecos_funcionarios", conexao);
            adaptador.Fill(DtSet, "endereco");

            // tabela telefone_funcionarios
            MySqlCommand cmd_telefone_funcionario = new MySqlCommand
                ("update telefones_funcionarios set telefone='" + caixa_telefone1.Text + "',telefone2='" + caixa_telefone2.Text + "', celular='" + caixa_celular.Text + "'" +
                "where cod_telefone_funcionario='" + caixa_cod.Text + "'", conexao);

            cmd_telefone_funcionario.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from telefones_funcionarios", conexao);
            adaptador.Fill(DtSet, "telefone");

            MySqlCommand cmd_funcionario = new MySqlCommand
                ("update funcionarios set nome='" + caixa_nome.Text + "', cpf='" + caixa_cpf.Text + "', rg='" + caixa_rg.Text + "', salario='" + caixa_salario.Text + "', sexo='" + sexo + "', data_nasc='" + Data_nasc + "'", conexao);

            cmd_funcionario.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from funcionarios", conexao);
            adaptador.Fill(DtSet, "funcionario");

            MessageBox.Show("Alterado com exito", "Mensagem", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);

        }

        private void but_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

    }
}
