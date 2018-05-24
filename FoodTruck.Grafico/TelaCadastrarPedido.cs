
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
    public partial class TelaCadastrarPedido : Form
    {
        public TelaCadastrarPedido()
        {
            InitializeComponent();
            ConfigurarCombobox();
        }

        private void ConfigurarCombobox()
        {
            cbCliente.DisplayMember = "Nome";
            cbCliente.ValueMember = "CPF";
        }

        private void CarregarComboboxClientes()
        {
            List<Cliente> clientes = Util.Gerenciador.ClientesCadastrados();
            cbCliente.DataSource = clientes;
        }

        //carrega pedido
        private void TelaCadastrarPedido_Load(object sender, EventArgs e)
        {
            CarregarComboboxClientes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido pedido = new Pedido();
                pedido.Id = Convert.ToInt64(tbId.Text);
                pedido.Data = DateTime.ParseExact(tbData.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                String clienteCpf = (String)cbCliente.SelectedValue;
                pedido.Cliente = Util.Gerenciador.BuscarClientePorCPF(clienteCpf);
                Util.Gerenciador.AdicionarPedido(pedido);
                MessageBox.Show("Pedido cadastrado com sucesso!");
                
                this.Close();                 
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbId.Text))
                return;

            long bebidaId = 0;
            if (!Int64.TryParse(tbId.Text, out bebidaId))
                tbId.Text = tbId.Text.Substring(0, tbId.Text.Length - 1);


        }

        //testar data
        private void tbData_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbData.Text))
                return;

            DateTime dataPedido;
            if(!DateTime.TryParseExact(tbData.Text, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out dataPedido)){
                MessageBox.Show("A data deve estar no formato DD/MM/AAAA HH:MM");
                tbData.Text = "";
            }
        }

        //data do pedido
        private void tbData_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
