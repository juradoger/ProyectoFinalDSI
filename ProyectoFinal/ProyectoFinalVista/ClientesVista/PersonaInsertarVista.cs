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
using ProyectoFinal.BSS;
using ProyectoFinal.MODEL;
namespace ProyectoFinalVista.ClientesVista
{
    public partial class PersonaInsertarVista : Form
    {
        public PersonaInsertarVista()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Personas p = new Personas();
            p.Nombre = textBox1.Text;
            p.Apellido = textBox2.Text;
            p.Telefono = textBox3.Text;
            p.CI = textBox4.Text;
            p.Correo = textBox5.Text;

            bss.InsertarPersonasBss(p);

            MessageBox.Show("Registro Exitoso!");
        }
    }
}
