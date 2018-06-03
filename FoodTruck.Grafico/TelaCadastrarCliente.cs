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
        private Cliente cliente;
        private Boolean edit = false;

        public TelaCadastrarCliente()
        {
            InitializeComponent();
            this.cliente = new Cliente();
            this.btRemover.Enabled = false;
        }

        public TelaCadastrarCliente(String CPF)
        {
            InitializeComponent();
            this.cliente = Util.Gerenciador.BuscarClientePorCPF(CPF);
            this.edit = true;
            tbCpf.Text = this.cliente.CPF.ToString();
            tbCpf.ReadOnly = true;
            tbNome.Text = this.cliente.Nome;
            tbEmail.Text = this.cliente.Email.ToString();
            this.Text = "Alterar cliente";
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

        private void btRemover_Click(object sender, EventArgs e)
        {
            Util.Gerenciador.RemoverCliente(this.cliente.CPF);
            this.Close();
        }
    }
}
