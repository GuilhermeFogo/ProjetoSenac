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
    public partial class relatorio_vendas : Form
    {
        public relatorio_vendas()
        {
            InitializeComponent();
        }

        private void relatorio_vendas_Load(object sender, EventArgs e)
        {

            this.reportVendasMes.RefreshReport();
            this.reportVendasSemana.RefreshReport();
            this.reportVendasDia.RefreshReport();
        }

        private void but_relatorio_dia_Click(object sender, EventArgs e)
        {
            reportVendasDia.Visible = true;
            reportVendasSemana.Visible = false;
            reportVendasMes.Visible = false;
            // TODO: This line of code loads data into the 'chocolatraDataSet.v_pedidos_vendas_dia' table. You can move, or remove it, as needed.
            this.v_pedidos_vendas_diaTableAdapter.Fill(this.chocolatraDataSet.v_pedidos_vendas_dia);
            // TODO: This line of code loads data into the 'chocolatraDataSet.v_pedidos_vendas_dia' table. You can move, or remove it, as needed.

            this.reportVendasDia.RefreshReport();
        }

        private void but_relatorio_semana_Click(object sender, EventArgs e)
        {
            reportVendasSemana.Visible = true;
            reportVendasDia.Visible = false;
            reportVendasMes.Visible = false;
            this.v_pedidos_vendas_semanaTableAdapter.Fill(this.chocolatraDataSet2.v_pedidos_vendas_semana);
            this.reportVendasSemana.RefreshReport();
        }

        private void but_relatorio_mes_Click(object sender, EventArgs e)
        {
             reportVendasMes.Visible = true;
            reportVendasSemana.Visible = false;
            reportVendasDia.Visible = false;
            this.v_pedidos_venda_mesTableAdapter.Fill(this.chocolatraDataSet3.v_pedidos_venda_mes);
            this.reportVendasMes.RefreshReport()
        }

    




    }
}
