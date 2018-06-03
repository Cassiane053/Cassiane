using System;
using FoodTruck.Negocio;
using FoodTruck.Grafico;
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
    public partial class TelaRemoverCliente : Form
    {
        private string CPF;
        private Cliente cliente;

        public TelaRemoverCliente(string cpf)
        {
            
            //InitializeComponent();            
            this.CPF = cpf;
            cliente = Util.Gerenciador.BuscarClientePorCPF(cpf);
            cbxClientes.DataSource = cliente.CPF.Equals(cpf);
            cbxClientes.DisplayMember = "Cliente";
            cbxClientes.ValueMember = "CPF";
        }

        private void bt_Remover_Click(object sender, EventArgs e)
        {
            Util.Gerenciador.RemoverCliente(this.cliente.CPF);
            this.Close();
        }

        private void cbxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
