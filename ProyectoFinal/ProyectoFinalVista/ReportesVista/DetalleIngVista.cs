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

namespace ProyectoFinalVista.ReportesVista
{
    public partial class DetalleIngVista : Form
    {
        public DetalleIngVista()
        {
            InitializeComponent();
        }
        DetalleIngresoBss bss = new DetalleIngresoBss();
        private void button3_Click(object sender, EventArgs e)
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Desea eliminar este elemento?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarDetalleIngBss(IdSeleccionada);
                dataGridView1.DataSource = bss.ListarDetalleIngBss();
            }
        }
        DetalleIngresoBss bssc = new DetalleIngresoBss();
        private void DetalleIngVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bssc.ListarDetalleIngBss();
        }
    }
    
}
