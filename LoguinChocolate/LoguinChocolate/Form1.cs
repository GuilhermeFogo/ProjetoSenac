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
    public partial class Loguin : Form
    {
        public Loguin()
        {
            InitializeComponent();
        }
        private MySqlConnection conexao;
        private MySqlDataAdapter adaptador;
        private DataSet DtSet;

        private void but_entrar_Click(object sender, EventArgs e)
        {
            if (caixa_senha.Text.Trim() == "" || caixa_usuario.Text.Trim() == "")
            {
                MessageBox.Show("Coloque a Senha e o Usuario", "Mensagem", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {

                string user = caixa_usuario.Text;
                string senha = caixa_senha.Text;
                conexao = new MySqlConnection(" Persist Security Info=False;server=10.32.47.27;database=chocolatra;uid=chocolatra;pwd=chocolatra");

                MySqlCommand cmd_loguin = new MySqlCommand("select usuario , email, senha from v_usuarios where @email= email or @usuario = usuario and @senha = senha", conexao);

                cmd_loguin.Parameters.AddWithValue("@usuario", user);
                cmd_loguin.Parameters.AddWithValue("@email", user);
                cmd_loguin.Parameters.AddWithValue("@senha", senha);

                conexao.Open();
                bool Verificar_usuario = cmd_loguin.ExecuteReader().HasRows;

                if (Verificar_usuario == true)
                {
                    // Mensagem
                    MessageBox.Show("Click no OK para contiuar", "Mensagem", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    this.Visible = false; // tela invisivel
                    // indo para outra janela
                    Form menus = new menu();
                    menus.ShowDialog();
                    // minimiza as janelas
                    this.WindowState = FormWindowState.Minimized;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tente novamente", "Mensagem", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }

            }
        }

        private void but_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
