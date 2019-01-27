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
    public partial class cad_pedidos_venda : Form
    {
        public cad_pedidos_venda()
        {
            InitializeComponent();
        }

        private MySqlConnection conexao;
        private MySqlDataAdapter adaptador;
        private DataSet DtSet;

        private void but_concluir_Click(object sender, EventArgs e)
        {
            DtSet = new DataSet();
            conexao = new MySqlConnection("  Persist Security Info=False;server=10.32.47.27;database=chocolatra;uid=chocolatra;pwd=chocolatra");


            try
            {
                conexao.Open();
            }
            catch (System.Exception g)
            {
                MessageBox.Show(g.Message.ToString());
            }

            {
                string datas = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                MySqlCommand cmd_cadastro_pedido = new MySqlCommand("insert into pedidos_venda(valor_total , data_pedido, desconto) values ('" + txt_valor.Text + "','" + datas + "','" + txt_descrisao.Text + "')", conexao);
                cmd_cadastro_pedido.ExecuteNonQuery();

                adaptador = new MySqlDataAdapter("select * from pedidos_venda", conexao);
                adaptador.Fill(DtSet, "pedidos");

                MessageBox.Show("Cadastrado com exito","Mensagem",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            DtSet = new DataSet();
            conexao = new MySqlConnection("Persist Security Info=False;server=10.32.47.27;database=chocolatra;uid=chocolatra;pwd=chocolatra");

            try
            {
                conexao.Open();
            }
            catch (System.Exception g)
            {
                MessageBox.Show(g.Message.ToString());
            }
            MySqlCommand cmd_delete = new MySqlCommand("delete from pedidos_venda where cod_pedido = '" + txt_cod.Text + "'", conexao);
            cmd_delete.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("delete from pedidos_vendas", conexao);
            adaptador.Fill(DtSet, "delete");

            MessageBox.Show("Deletado com exito", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void but_pesquisa_Click(object sender, EventArgs e)
        {
            txt_cod.Enabled = true;
            dateTimePicker1.Enabled = false;

            txt_valor.Enabled = false;
            but_ok.Enabled = true;
            but_ok.Visible = true;
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            txt_cod.Enabled = false;
            dateTimePicker1.Enabled = true;

            txt_valor.Enabled = true;
        }
    }
}
        