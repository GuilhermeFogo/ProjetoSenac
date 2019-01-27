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
    public partial class cad_Usuarios : Form
    {
        public cad_Usuarios()
        {
            InitializeComponent();
            // bloqueio do campo de cod
            caixa_cod.Enabled = false;
          
        }

        private MySqlConnection conexao;
        private MySqlDataAdapter adaptador;
        private DataSet DtSet;


        private void but_pesquisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atenção", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Stop);

          DialogResult mensagem= MessageBox.Show("Click no Yes para Atualizar o registro ou NO para Deletar registro", "Mensagem",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);

          if (mensagem == DialogResult.Yes)
          {
              but_alterar.Enabled = true;
              but_concluir.Enabled = false;
              but_deletar.Enabled = false;
              caixa_cod.Enabled = true;
              but_ok.Visible = true;
              but_ok.Enabled = true;

              caixa_cod.Focus();

              caixa_email.Enabled = false;
              caixa_nome.Enabled = false;
              caixa_senha.Enabled = false;
              dtp_nascimento.Enabled = false;
          }
          else
          {
              if (mensagem == DialogResult.No)
              {
                  but_alterar.Enabled = false;
                  but_concluir.Enabled = false;
                  but_deletar.Enabled = true;
                  but_ok.Visible = true;
                  but_ok.Enabled = true;

                  caixa_cod.Focus();

                  caixa_email.Enabled = false;
                  caixa_nome.Enabled= false;
                  caixa_senha.Enabled = false;
                  dtp_nascimento.Enabled = false;
              }

          }


        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            but_ok.Visible = false;
            but_ok.Enabled = false;
            but_concluir.Enabled = true;
            but_deletar.Enabled = false;
            but_alterar.Enabled = false;

            caixa_email.Enabled = true;
            caixa_nome.Enabled = true;
            caixa_senha.Enabled = true;
            dtp_nascimento.Enabled = true;

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
                adaptador = new MySqlDataAdapter("SELECT * FROM usuarios WHERE cod_usuario ='" + caixa_cod.Text + "'", conexao);
                adaptador.Fill(DtSet, "Produtos");

                if (DtSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("PRODUTO NAO ENCONTRADO");
                }
                else
                {

                    but_alterar.Enabled = true;
                    but_deletar.Enabled = true;
                    MySqlCommand cmd_concluir_pesquisa = new MySqlCommand("SELECT * FROM v_usuarios WHERE cod_usuario ='" + caixa_cod.Text + "'", conexao);
                    MySqlDataReader lerRegistro = cmd_concluir_pesquisa.ExecuteReader();

                    while (lerRegistro.Read())
                    {
                        caixa_nome.Text = lerRegistro["nome"].ToString();
                        caixa_email.Text = lerRegistro["email"].ToString();
                        caixa_senha.Text = lerRegistro["senha"].ToString();
                        dtp_nascimento.Text = lerRegistro["create_time"].ToString();
                        
                    }

                }


            }


        }

        private void but_concluir_Click(object sender, EventArgs e)
        {
             if (caixa_nome.Text == "" || caixa_email.Text == "" || caixa_senha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Mensagem", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            else
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

                // tabela email_clientes
                MySqlCommand cmd_cadastro_email = new MySqlCommand
                ("insert into emails(email) values('" + caixa_email.Text + "')", conexao);

                cmd_cadastro_email.ExecuteNonQuery();
                long id_email = cmd_cadastro_email.LastInsertedId;// capitura id cadastrado

                adaptador = new MySqlDataAdapter("select * from emails where email='" + caixa_email.Text + "'", conexao);
                adaptador.Fill(DtSet, "email");

                if (DtSet.Tables[0].Rows.Count > 0)
                {

                    // tabela senhas
                    MySqlCommand cmd_cadastro_senha = new MySqlCommand
                    ("insert into senhas_usuarios(senha) values('" + caixa_senha.Text + "')", conexao);

                    cmd_cadastro_senha.ExecuteNonQuery();
                    long id_senha = cmd_cadastro_senha.LastInsertedId;// capitura id cadastrado

                    adaptador = new MySqlDataAdapter("select * from senhas_usuarios", conexao);
                    adaptador.Fill(DtSet, "Senhas");

                    if (DtSet.Tables[0].Rows.Count > 0)
                    {

                        // tabela idemtificadores
                        MySqlCommand cmd_cadastro_identificador = new MySqlCommand
                        ("insert into identificadores(identificador) values('" + numericupdown.Text + "')", conexao);

                        cmd_cadastro_identificador.ExecuteNonQuery();
                        long id_idem = cmd_cadastro_identificador.LastInsertedId;// capitura id cadastrado

                        adaptador = new MySqlDataAdapter("select * from identificadores where identificador='" + numericupdown.Text + "'", conexao);
                        adaptador.Fill(DtSet, "identificador");

                        if (DtSet.Tables[0].Rows.Count > 0)
                        {

                            // datas
                            string data_nasc = dtp_nascimento.Value.ToString("yyyy-MM-dd");

                            MySqlCommand cmd_cadastro_usuario = new MySqlCommand
                            ("insert into  usuarios(cod_senha,cod_email, cod_identificador,usuario,create_time)" +
                             "values ('" + id_senha + "','" + id_email + "','" + id_idem + "','" + caixa_nome.Text + "','" + data_nasc + "')", conexao);
                            cmd_cadastro_usuario.ExecuteNonQuery();

                            adaptador = new MySqlDataAdapter("select * from v_usuarios", conexao);
                            adaptador.Fill(DtSet, "user");

                            
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
            conexao = new MySqlConnection("Persist Security Info=False;server=10.32.47.27;database=chocolatra;uid=chocolatra;pwd= chocolatra");
            try
            {
                conexao.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


            MySqlCommand cmd_alterar_identificadores = new MySqlCommand
                ("update identificadores set identificador='" + numericupdown.Text + "' where cod_identificador='" + caixa_cod.Text + "'", conexao);
            cmd_alterar_identificadores.ExecuteNonQuery();

            // adaptador 
            adaptador = new MySqlDataAdapter("select * from identificadores", conexao);
            adaptador.Fill(DtSet, "identificador");


            MySqlCommand cmd_alterar_senhas = new MySqlCommand
                ("update senhas_usuarios set senha='" + caixa_senha.Text + "' where cod_senha='" + caixa_cod.Text + "'", conexao);
            cmd_alterar_senhas.ExecuteNonQuery();

            // adaptador 
            adaptador = new MySqlDataAdapter("select * from senhas_usuarios", conexao);
            adaptador.Fill(DtSet, "senha");

            MySqlCommand cmd_alterar_email = new MySqlCommand
                ("update emails set email='" + caixa_email.Text + "' where cod_email='" + caixa_cod.Text + "'", conexao);
            cmd_alterar_email.ExecuteNonQuery();

            // adaptador 
            adaptador = new MySqlDataAdapter("select * from emails", conexao);
            adaptador.Fill(DtSet, "emails");

            MySqlCommand cmd_delete_usuario = new MySqlCommand
           ("update usuarios set usuario='" + caixa_nome.Text + "' where cod_usuario='" + caixa_cod.Text + "'", conexao);
            cmd_delete_usuario.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from v_usuarios", conexao);
            adaptador.Fill(DtSet, "usuario");
           

            MessageBox.Show("Alterado com exito...", "Mensagem", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }

        private void but_deletar_Click(object sender, EventArgs e)
        {
            DtSet = new DataSet();
            conexao= new MySqlConnection("Persist Security Info=False;server=10.32.47.27;database=chocolatra;uid=chocolatra;pwd=chocolatra");
            try{
                conexao.Open();
            }catch(System.Exception ex){
                MessageBox.Show(ex.Message.ToString());
            }


       MySqlCommand cmd_delete_identificadores= new MySqlCommand
           ("delete from identificadores where identificadores.cod_identificador = '"+caixa_cod+"';", conexao);
            cmd_delete_identificadores.ExecuteNonQuery();

            // adaptador 
            adaptador = new MySqlDataAdapter("select * from identificadores", conexao);
            adaptador.Fill(DtSet, "identificador");

       MySqlCommand cmd_delete_senhas = new MySqlCommand
           ("delete from senhas_usuarios where cod_senha='"+ caixa_cod.Text+"'", conexao);
            cmd_delete_senhas.ExecuteNonQuery();

            // adaptador 
            adaptador = new MySqlDataAdapter("select * from senhas_usuarios", conexao);
            adaptador.Fill(DtSet, "senha");


        MySqlCommand cmd_delete_email = new MySqlCommand
            ("delete from emails where cod_email='"+caixa_cod.Text+"';",conexao);
         cmd_delete_email.ExecuteNonQuery();

         // adaptador 
         adaptador = new MySqlDataAdapter("select * from emails", conexao);
         adaptador.Fill(DtSet, "emails");

        MySqlCommand cmd_delete_usuario = new MySqlCommand
        ("delete from usuarios where cod_usuario ='"+ caixa_cod.Text+"'", conexao);
            cmd_delete_usuario.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from v_usuarios", conexao);
            adaptador.Fill(DtSet, "usuario");

            MessageBox.Show("Deletado com exito...", "Mensagem", MessageBoxButtons.OK, 
                MessageBoxIcon.Asterisk);

        }
     }
  }
    
