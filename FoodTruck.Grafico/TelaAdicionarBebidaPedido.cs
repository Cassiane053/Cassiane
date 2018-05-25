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
    public partial class TelaAdicionarBebidaPedido : Form
    {
        public Int64 PedidoId { get; set; }

        public TelaAdicionarBebidaPedido()
        {
            InitializeComponent();
            ConfigurarCombobox();
        }

        private void ConfigurarCombobox()
        {
            cbBebidas.DisplayMember = "Nome";
            cbBebidas.ValueMember = "Id";
        }

        private void CarregarCombobox()
        {
            List<Bebida> bebidas = Util.Gerenciador.BebidasCadastradas();
            cbBebidas.DataSource = bebidas;
        }

        private void TelaAdicionarBebidaPedido_Load(object sender, EventArgs e)
        {
            CarregarCombobox();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido pedido = Util.Gerenciador.BuscarPedidoPorCodigo(PedidoId);
                Int64 bebidaId = (Int64) cbBebidas.SelectedValue;
                Bebida bebida = Util.Gerenciador.BuscarBebidaPorCodigo(bebidaId);
                Util.Gerenciador.AdicionarBebidaAoPedido(pedido, bebida);
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //mostra a bebida para escolher
        private void cbBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
