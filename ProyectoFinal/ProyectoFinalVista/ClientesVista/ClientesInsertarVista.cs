using ProyectoFinal.BSS;
using ProyectoFinal.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalVista.ClientesVista;

namespace ProyectoFinalVista.ClientesVista
{
    public partial class ClientesInsertarVista : Form
    {
        public ClientesInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bss = new PersonaBss();
        private void button3_Click(object sender, EventArgs e)
        {
            PersonasVista fr = new PersonasVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Personas persona = bss.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;

            }
        }
        ClientesBss bssc = new ClientesBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.IdPersona = IdPersonaSeleccionada;
            cliente.TipoCliente = textBox2.Text;
            cliente.CodCliente = textBox3.Text;
            bssc.InsertarClienteBss(cliente);
            MessageBox.Show("Cliente registrado");
        }
    }
}
