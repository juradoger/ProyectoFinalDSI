using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.BSS;
using ProyectoFinalVista;
namespace ProyectoFinalVista.ReportesVista
{
    public partial class Detallesdatos : Form
    {
        public Detallesdatos()
        {
            InitializeComponent();
        }
        DetalleIngVista first = new DetalleIngVista();
        private void botonesDiseño1_Click(object sender, EventArgs e)
        {
            first.ShowDialog();
        }

        private void botonesDiseño2_Click(object sender, EventArgs e)
        {

        }
        IngresoBss bss = new IngresoBss();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Detallesdatos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.IngresoDatosBsss();
        }
    }
}
