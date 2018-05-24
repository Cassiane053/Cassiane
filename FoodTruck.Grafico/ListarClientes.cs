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
    public partial class ListarClientes : Form
    {
        public ListarClientes()
        {
            InitializeComponent();
        }

        private void AtualizarDados()
        {
            List<Cliente> clientes = Util.Gerenciador.ClientesCadastrados();
            dgCliente.DataSource = clientes;
        }

        private void ListarClientes_Load(object sender, EventArgs e)
        {
            AtualizarDados();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarDados();
        }

        private void tbCadastrarCliente_Click(object sender, EventArgs e)
        {
            TelaCadastrarCliente cadastro = new TelaCadastrarCliente();
            cadastro.FormClosed += Cadastro_FormClosed;
            cadastro.MdiParent = this.MdiParent;
            cadastro.Show();
        }

        private void Cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            AtualizarDados();
        }

       
    }
}
