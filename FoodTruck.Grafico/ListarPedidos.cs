using FoodTruck.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodTruck.Grafico
{
    public partial class ListarPedidos : Form
    {
        public ListarPedidos()
        {
            InitializeComponent();
            dgPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPedidos.MultiSelect = false;
            dgPedidos.ReadOnly = true;
        }

        private void CarregarDados()
        {
            List<Pedido> pedidos = Util.Gerenciador.PedidosCadastrados();
            dgPedidos.DataSource = pedidos;
        }

        private void ListarPedidos_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        //adiciona um pedido
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            TelaCadastrarPedido tela = new TelaCadastrarPedido();
            tela.MdiParent = this.MdiParent;
            tela.FormClosed += Tela_FormClosed;
            tela.Show();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }

        //adiciona uma bebida
        private void tbAdicionarBebida_Click(object sender, EventArgs e)
        {
            if (dgPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido");
                return;
            }

            Int64 pedidoId = (Int64) dgPedidos.SelectedRows[0].Cells[0].Value;
            TelaAdicionarBebidaPedido tela = new TelaAdicionarBebidaPedido();
            tela.FormClosed += Tela_FormClosed1;
            tela.PedidoId = pedidoId;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void Tela_FormClosed1(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }

        
        private void tbLanche_Click(object sender, EventArgs e)
        {
            if (dgPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione o pedido");
                return;
            }

            Int64 pedidoId = (Int64)dgPedidos.SelectedRows[0].Cells[0].Value;
            TelaAdicionarLanchePedido tela = new TelaAdicionarLanchePedido();
            tela.FormClosed += Tela_FormClosed1;
            tela.PedidoId = pedidoId;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void btnRemoverBebida_Click(object sender, EventArgs e)
        {
            if (dgPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido");
                return;
            }

            Int64 pedidoId = (Int64)dgPedidos.SelectedRows[0].Cells[0].Value;
            TelaRemoverBebidaPedido tela = new TelaRemoverBebidaPedido(pedidoId);
            tela.FormClosed += Tela_FormClosed1;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        //remover um lanche
        private void btnRemoverLanche_Click(object sender, EventArgs e)
        {
            if (dgPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido");
                return;
            }

            Int64 pedidoId = (Int64)dgPedidos.SelectedRows[0].Cells[0].Value;
            TelaRemoverLanchePedido tela = new TelaRemoverLanchePedido(pedidoId);
            tela.FormClosed += Tela_FormClosed1;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }
    }
}
