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
    public partial class TelaCadastrarBebida : Form
    {
        private Bebida bebida;
        private Boolean edit = false;

        public TelaCadastrarBebida()
        {
            InitializeComponent();
            this.bebida = new Bebida();
            this.btnRemover.Enabled = false;
        }

        public TelaCadastrarBebida(long Id)
        {
            InitializeComponent();
            this.bebida = Util.Gerenciador.BuscarBebidaPorCodigo(Id);
            this.edit = true;
            tbId.Text = this.bebida.Id.ToString();
            tbId.ReadOnly = true;
            tbNome.Text = this.bebida.Nome;
            tbValor.Text = this.bebida.Valor.ToString();
            tbTamanho.Text = this.bebida.Tamanho.ToString();
            this.Text = "Alterar bebida";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bebida.Nome = tbNome.Text;
                bebida.Valor = Convert.ToDecimal(tbValor.Text);
                bebida.Tamanho = Convert.ToInt64(tbTamanho.Text);


                if (!edit)
                {
                    bebida.Id = Convert.ToInt64(tbId.Text);
                    Util.Gerenciador.AdicionarBebida(bebida);
                    MessageBox.Show("Bebida cadastrada com sucesso");
                } else
                {
                    Util.Gerenciador.Salvar();
                }

                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbId.Text))
                return;

            long bebidaId = 0;
            if(!Int64.TryParse(tbId.Text, out bebidaId))
                tbId.Text = tbId.Text.Substring(0, tbId.Text.Length - 1);
        }

        //preços
        private void tbValor_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbValor.Text))
                return;

            decimal valorBebida = 0;
            if (!Decimal.TryParse(tbValor.Text, out valorBebida))
                tbValor.Text = tbValor.Text.Substring(0, tbValor.Text.Length - 1);
        }

        //escolha do tamanho <<ml
        private void tbTamanho_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbTamanho.Text))
                return;

            long tamanhoBebida = 0;
            if (!Int64.TryParse(tbTamanho.Text, out tamanhoBebida))
                tbTamanho.Text = tbTamanho.Text.Substring(0, tbTamanho.Text.Length - 1);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Util.Gerenciador.RemoverBebidaPorCodigo(this.bebida.Id);
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
