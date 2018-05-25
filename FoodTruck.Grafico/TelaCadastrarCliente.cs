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
    public partial class TelaCadastrarCliente : Form
    {
        public TelaCadastrarCliente()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            tbCpf.Text = "";
            tbNome.Text = "";
            tbEmail.Text = "";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.CPF = tbCpf.Text;
                cliente.Nome = tbNome.Text;
                cliente.Email = tbEmail.Text;
                Util.Gerenciador.AdicionarCliente(cliente);

                Limpar();
                MessageBox.Show("Cliente adicionado com sucesso!");
                this.Close();
               

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //digitar cpf
        private void tbCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void imagemCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
