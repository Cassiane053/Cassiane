using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodTruck.Negocio;

namespace FoodTruck.Grafico
{
    public partial class ListarBebidas : Form
    {
        public ListarBebidas()
        {
            InitializeComponent();
            ConfigurarDg();
        }

        //o que vai aparecer na lista
        private void ConfigurarDg()
        {
            dgBebidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgBebidas.ColumnCount = 4;
            dgBebidas.ColumnHeadersVisible = true;
            dgBebidas.Columns[0].Name = "Código";
            dgBebidas.Columns[0].DataPropertyName = "Id";
            dgBebidas.Columns[0].ReadOnly = true;
            dgBebidas.Columns[1].Name = "Nome";
            dgBebidas.Columns[1].DataPropertyName = "Nome";
            dgBebidas.Columns[1].ReadOnly = true;
            dgBebidas.Columns[2].Name = "Preço";
            dgBebidas.Columns[2].DataPropertyName = "Valor";
            dgBebidas.Columns[2].ReadOnly = true;
            dgBebidas.Columns[3].Name = "Tamanho (ml)";
            dgBebidas.Columns[3].DataPropertyName = "Tamanho";
            dgBebidas.Columns[3].ReadOnly = true;
            dgBebidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //puxa as bebidas inseridas na lista
        private void CarregarDados()
        {
            List<Bebida> bebidas = Util.Gerenciador.BebidasCadastradas();
            dgBebidas.DataSource = bebidas;
        }

        private void ListarBebidas_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            TelaCadastrarBebida tela = new TelaCadastrarBebida();
            tela.FormClosed += Tela_FormClosed;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }

        private void dgBebidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object obj = Util.GetCellValueFromColumnHeader(dgBebidas.SelectedRows[0].Cells, "Id");

            if (obj == null)
                return;

            long Id = (long)Util.GetCellValueFromColumnHeader(dgBebidas.SelectedRows[0].Cells, "Id");

            TelaCadastrarBebida tela = new TelaCadastrarBebida(Id);
            tela.FormClosed += Tela_FormClosed;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void dgBebidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
