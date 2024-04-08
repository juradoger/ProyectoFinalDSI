using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using ProyectoFinal.BSS;
using ProyectoFinal.MODEL;
using ProyectoFinalVista;
using ProyectoFinalVista.PantaInicio;
using System.Security.Cryptography.X509Certificates;

namespace ProyectoFinalVista.Login
{
    public partial class Login : Form
    {
        LoginBss bss = new LoginBss();
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void botonesDiseño1_Click(object sender, EventArgs e)
        {

            ProyectoFinal.MODEL.Login user = new ProyectoFinal.MODEL.Login();
            user.usuario = textBox1.Text;
            user.contrasena = textBox2.Text;
            MessageBox.Show("Bienvenido Gerente...");

            int id = bss.ObtenerIdRolBss(user);
            PantallaInicioVista inicio = new PantallaInicioVista(id);
            inicio.ShowDialog();            

        }
    }
}
