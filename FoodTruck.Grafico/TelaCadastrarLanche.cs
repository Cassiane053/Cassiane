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
    public partial class TelaCadastrarLanche : Form
    {
        private Lanche lanche;
        private Boolean edit = false;

        public TelaCadastrarLanche()
        {
            InitializeComponent();
            this.lanche = new Lanche();
            this.btnRemover.Enabled = false;
        }

        public TelaCadastrarLanche(long Id)
        {
            InitializeComponent();
            this.lanche = Util.Gerenciador.BuscarLanchePorCodigo(Id);
            this.btnRemover.Enabled = true;
            this.tbId.Text = Id.ToString();
            this.tbId.ReadOnly = true;
            this.tbNome.Text = this.lanche.Nome;
            this.tbValor.Text = this.lanche.Valor.ToString();
            this.edit = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lanche.Nome = tbNome.Text;
                lanche.Valor = Convert.ToDecimal(tbValor.Text);

                if (!edit)
                {
                    lanche.Id = Convert.ToInt64(tbId.Text);
                    Util.Gerenciador.AdicionarLanche(lanche);
                    MessageBox.Show("Lanche cadastrado com sucesso");
                }
                else
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

        //código lanche
        private void tbId_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbId.Text))
                return;

            long bebidaId = 0;
            if(!Int64.TryParse(tbId.Text, out bebidaId))
                tbId.Text = tbId.Text.Substring(0, tbId.Text.Length - 1);
        }

        private void tbValor_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbValor.Text))
                return;

            decimal valorBebida = 0;
            if (!Decimal.TryParse(tbValor.Text, out valorBebida))
                tbValor.Text = tbValor.Text.Substring(0, tbValor.Text.Length - 1);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Util.Gerenciador.RemoverLanchePorCodigo(this.lanche.Id);
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
