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

namespace ProyectoFinalVista.ClientesVista
{


    
    public partial class PersonasVista : Form
    {
        public PersonasVista()
        {
            InitializeComponent();
        }
        PersonaBss bssc = new PersonaBss();

        private void button3_Click(object sender, EventArgs e)
        {
            int IdPersonaSelecciionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            DialogResult result = MessageBox.Show("Esta seguro de eliminar esta persona?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bssc.ObtenerIdBss(IdPersonaSelecciionada);
                dataGridView1.DataSource = bssc.ListarPersonaBss();

            }
        }
        PersonaBss bss = new PersonaBss();

        private void PersonasVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarPersonaBss();

        }
    }
}
