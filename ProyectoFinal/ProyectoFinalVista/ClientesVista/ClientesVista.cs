using ProyectoFinal.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.MODEL;
using ProyectoFinalVista;

namespace ProyectoFinalVista.ClientesVista
{
    public partial class ClientesVista : Form
    {
        public ClientesVista()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        ClientesBss bss = new ClientesBss();
        private void ClientesVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClienteBss();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Desea eliminar este Cliente?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarClienteBss(IdSeleccionada);
                dataGridView1.DataSource = bss.ListarClienteBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClientesInsertarVista fr = new ClientesInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarClienteBss();
            }
        }
    }
}
