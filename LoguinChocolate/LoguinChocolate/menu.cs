using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoguinChocolate
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form produtos = new cad_Produtos();
            produtos.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form clientes = new cad_Cliente();
            clientes.ShowDialog();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form funcionarios = new cad_Funcionarios();
            funcionarios.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form user = new cad_Usuarios();
            user.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form produtos = new relatorio_produtos();
            produtos.ShowDialog();
          
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void promoçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form promocao = new cad_promocao();
            promocao.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fornecedores = new cad_fornecedores();
            fornecedores.ShowDialog();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form compras = new relatorio_compra();
            compras.ShowDialog();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vendas = new relatorio_vendas();
            vendas.ShowDialog();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pedido_compra = new cad_pedidos_compra();
            pedido_compra.ShowDialog();
        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form pedido_venda = new cad_pedidos_venda();
            pedido_venda.ShowDialog();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_cad_produto_Click(object sender, EventArgs e)
        {
            Form produto = new cad_Produtos();
            produto.ShowDialog();
        }

        private void button_cad_cliente_Click(object sender, EventArgs e)
        {
            Form cliente = new cad_Cliente();
            cliente.ShowDialog();
        }

        private void button_cad_fornecedor_Click(object sender, EventArgs e)
        {
            Form forne = new cad_fornecedores();
            forne.ShowDialog();
        }

        private void button_cad_fun_Click(object sender, EventArgs e)
        {
            Form funcio = new cad_Funcionarios();
            funcio.ShowDialog();
        }

        private void button_cad_user_Click(object sender, EventArgs e)
        {
            Form users = new cad_Usuarios();
            users.ShowDialog();
        }

        private void button_cad_promo_Click(object sender, EventArgs e)
        {
            Form promo = new cad_promocao();
            promo.ShowDialog();
        }

        private void button_pedido_c_Click(object sender, EventArgs e)
        {
            Form pedido_c = new cad_pedidos_compra();
            pedido_c.ShowDialog();
        }

        private void button_pedido_v_Click(object sender, EventArgs e)
        {
            Form pedido_v = new cad_pedidos_venda();
            pedido_v.ShowDialog();
        }

        private void button_relatorio_v_Click(object sender, EventArgs e)
        {
            Form relato_v = new relatorio_vendas();
            relato_v.ShowDialog();
        }

        private void button_relatorio_c_Click(object sender, EventArgs e)
        {
            Form relato_c = new relatorio_compra();
            relato_c.ShowDialog();
        }

        private void button_relatorio_p_Click(object sender, EventArgs e)
        {
            Form relato_p = new relatorio_produtos();
            relato_p.ShowDialog();
        }
    }
}
