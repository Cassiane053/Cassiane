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
    public partial class TelaPrincipal : Form
    {
        private int childFormNumber = 0;

        //carregar a tela
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarClientes tela = new ListarClientes();
            tela.MdiParent = this;
            tela.Show();
        }

        private void bebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarBebidas tela = new ListarBebidas();
            tela.MdiParent = this;
            tela.Show();
        }

        private void lancheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarLanches tela = new ListarLanches();
            tela.MdiParent = this;
            tela.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarPedidos tela = new ListarPedidos();
            tela.MdiParent = this;
            tela.Show();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
