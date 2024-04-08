using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalVista.ProductosVista;
using ProyectoFinal.MODEL;
using ProyectoFinal.BSS;
using System.Reflection;

namespace ProyectoFinalVista.ReportesVista
{
    public partial class DetalleEditarVista : Form
    {
        int idx = 0;
        DetalleIngresos p = new DetalleIngresos();
        DetalleIngresoBss bss = new DetalleIngresoBss();
        public DetalleEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }
        public static int IdProductoSeleccionada = 0;
        ProductoBss bsspro = new ProductoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            p.IdIngreso = IdIngresoSeleccionada;
            p.IdProducto = IdProductoSeleccionada;
            p.FechaVenc = dateTimePicker1.Value;
            p.Cantidad = Convert.ToInt32(textBox4.Text);
            p.PrecioCosto = Convert.ToDecimal(textBox5.Text);
            p.PrecioVenta = Convert.ToDecimal(textBox6.Text);
            p.Subtotal = Convert.ToDecimal(textBox7.Text);

            bss.EditarDetalleIngBss(p);
            MessageBox.Show("Datos Actualizados");
        }
        public static int IdIngresoSeleccionada = 0;
        IngresoBss bssing = new IngresoBss();
        private void button4_Click(object sender, EventArgs e)
        {
            IngresoVista fr = new IngresoVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Ingreso ingreso = bssing.ObtenerIdBss(IdIngresoSeleccionada);
                textBox2.Text = ingreso.IdIngreso.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductoListarVista fr = new ProductoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bsspro.ObtenerIdPBss(IdProductoSeleccionada);
                textBox1.Text = producto.Nombre;
            }
        }
    }
}
