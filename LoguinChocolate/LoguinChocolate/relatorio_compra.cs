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
    public partial class relatorio_compra : Form
    {
        public relatorio_compra()
        {
            InitializeComponent();
        }

        private MySqlConnection conexao;
        private MySqlDataAdapter adaptador;
        private DataSet DtSet;

        private void but_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Isso vai iniciar junto com o grid 
        private void relatorio_compra_Load(object sender, EventArgs e)
        {

        }

        private void relatorio_compra_Load_1(object sender, EventArgs e)
        {

            this.report_compras_dia.RefreshReport();
            this.report_compras_semana.RefreshReport();
            this.report_compras_mes.RefreshReport();
        }

        private void but_relatorio_dia_Click(object sender, EventArgs e)
        {
            report_compras_dia.Visible = true;
            report_compras_mes.Visible = false;
            report_compras_semana.Visible = false;

            // TODO: This line of code loads data into the 'chocolatraDataSet7.v_pedidos_compra_dia' table. You can move, or remove it, as needed.
            this.v_pedidos_compra_diaTableAdapter.Fill(this.chocolatraDataSet7.v_pedidos_compra_dia);

            this.report_compras_dia.RefreshReport();

        }

        private void but_relatorio_semana_Click(object sender, EventArgs e)
        {
            report_compras_dia.Visible = false;
            report_compras_mes.Visible = false;
            report_compras_semana.Visible = true;
            this.v_pedido_compra_semanaTableAdapter.Fill(this.chocolatraDataSet8.v_pedido_compra_semana);
            this.report_compras_semana.RefreshReport();

        }

        private void but_relatorio_mes_Click(object sender, EventArgs e)
        {
            report_compras_dia.Visible = false;
            report_compras_mes.Visible = true;
            report_compras_semana.Visible = false;
            this.v_pedido_compra_mesTableAdapter.Fill(this.chocolatraDataSet9.v_pedido_compra_mes);
            this.report_compras_mes.RefreshReport();
        }

       
    }
}
