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
    public partial class ListarLanches : Form
    {
        public ListarLanches()
        {
            InitializeComponent();
            dgLanches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLanches.ReadOnly = true;
        }

        private void CarregarDados()
        {
            List<Lanche> lanches = Util.Gerenciador.LanchesCadastrados();
            dgLanches.DataSource = lanches;
        }

        private void ListarBebidas_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        //adicionar um lanche
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            TelaCadastrarLanche tela = new TelaCadastrarLanche();
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
            object obj = Util.GetCellValueFromColumnHeader(dgLanches.SelectedRows[0].Cells, "Id");

            if (obj == null)
                return;

            long Id = (long)Util.GetCellValueFromColumnHeader(dgLanches.SelectedRows[0].Cells, "Id");

            TelaCadastrarLanche tela = new TelaCadastrarLanche(Id);
            tela.FormClosed += Tela_FormClosed;
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void dgLanches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
