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
    public partial class TelaAdicionarLanchePedido : Form
    {
        public Int64 PedidoId { get; set; }

        public TelaAdicionarLanchePedido()
        {
            InitializeComponent();

            cbxLanches.DisplayMember = "Nome";
            cbxLanches.ValueMember = "Id";

            List<Lanche> lanches = Util.Gerenciador.LanchesCadastrados();
            cbxLanches.DataSource = lanches;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido pedido = Util.Gerenciador.BuscarPedidoPorCodigo(PedidoId);
                Int64 lancheId = (Int64)cbxLanches.SelectedValue;
                Lanche lanche = Util.Gerenciador.BuscarLanchePorCodigo(lancheId);
                Util.Gerenciador.AdicionarLancheAoPedido(pedido, lanche);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
