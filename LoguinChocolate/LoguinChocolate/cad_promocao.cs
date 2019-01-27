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
    public partial class cad_promocao : Form
    {
        public cad_promocao()
        {
            InitializeComponent();
        }
        /*
         * VERIFICAR TODO O FORM 
         * 
         * FAZER TESTES E ETC..
         * TERMINAR OS RELATORIOS 
         * VERIFICAR SE ESTA TUDO BEM NESTE FORM
         * 
         */ 

        private MySqlConnection conexao;
        private MySqlDataAdapter adaptador;
        private DataSet DtSet;

        private void but_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_promo_ativar_Click(object sender, EventArgs e)
        {
            if (caixa_codproduto.Text.Trim() == "" || caixa_valor.Text.Trim() == "")
            {
                MessageBox.Show("Preencha os campos nescessarios", "Mensagem", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Voce deseja ativar a promoção deste produto?", "Mensagem", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

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

                // verificar aki urgente
                MySqlCommand cmd_ativar = new MySqlCommand
                    ("update produtos set validacao_promo='" + 1 + "' where cod_produto='" + caixa_codproduto.Text + "'", conexao);
                cmd_ativar.ExecuteNonQuery();

                adaptador = new MySqlDataAdapter("select * from produtos", conexao);
                adaptador.Fill(DtSet, "Verdadeiro");
                dataGridView1.DataSource = DtSet;
                dataGridView1.DataMember = "Verdadeiro";
            }

        }

        private void btn_promocao_destiva_Click(object sender, EventArgs e)
        {
            if (caixa_codproduto.Text.Trim() == "" || caixa_valor.Text.Trim() == "")
            {
                MessageBox.Show("Preencha os campos nescessarios", "Mensagem", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Voce deseja ativar a promoção deste produto?", "Mensagem", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

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

                // verificar aki urgente
                MySqlCommand cmd_desativar = new MySqlCommand
                    ("update produtos set validacao_promo='" + 0 + "' where cod_produto='" + caixa_codproduto.Text + "'", conexao);
                cmd_desativar.ExecuteNonQuery();


                adaptador = new MySqlDataAdapter("select * from produtos", conexao);
                adaptador.Fill(DtSet, "del");
                dataGridView1.DataMember = "del";
                dataGridView1.DataSource = DtSet;
            }
        }

        private void cad_promocao_Load(object sender, EventArgs e)
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


            adaptador = new MySqlDataAdapter("select * from produtos", conexao);
            adaptador.Fill(DtSet, "produto");
            dataGridView1.DataMember = "produto";
            dataGridView1.DataSource = DtSet;

        }
    }
}