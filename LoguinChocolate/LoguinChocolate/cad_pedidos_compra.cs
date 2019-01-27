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
    public partial class cad_pedidos_compra : Form
    {
        public cad_pedidos_compra()
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


            string datas = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string datass = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            MySqlCommand cmd_cadastro_pedido = new MySqlCommand("insert into pedidos_compra(valor_total , data_chegada , data_pedido) values ('" + txt_valor.Text + "','" + datas + "','" + datass + "')", conexao);
            cmd_cadastro_pedido.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("select * from pedidos_compra", conexao);
            adaptador.Fill(DtSet, "pedidos");

            MessageBox.Show("Cadastrado com exito");
        }

        private void but_delete_Click(object sender, EventArgs e)
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
            MySqlCommand cmd_delete = new MySqlCommand("delete from pedidos_compra where cod_pedido = '" + txt_cod.Text + "'", conexao);
            cmd_delete.ExecuteNonQuery();

            adaptador = new MySqlDataAdapter("delete from pedidos_compra", conexao);
            adaptador.Fill(DtSet, "delete");

            MessageBox.Show("Deletado com exito");
        }

        private void but_pesquisa_Click(object sender, EventArgs e)
        {
             txt_cod.Enabled = true;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            txt_valor.Enabled = false;
            but_ok.Enabled = true;
            but_ok.Visible = true;
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
             txt_cod.Enabled = false;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            txt_valor.Enabled = true;
        }
        }

    }
}
