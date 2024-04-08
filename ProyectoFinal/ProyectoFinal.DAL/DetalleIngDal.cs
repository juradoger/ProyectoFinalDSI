using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.MODEL;

namespace ProyectoFinal.DAL
{
    public class DetalleIngDal
    {
        public DataTable ListarDetalleIngDal()
        {
            string consulta = "select * from detalleing";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarDetalleIngDal(DetalleIngresos d)
        {

            string consulta = $"insert into detalleing values({d.IdIngreso}, {d.IdProducto}, '{d.FechaVenc.ToString("yyyy-MM-dd HH:mm:ss.fff")}', {d.Cantidad}, {d.PrecioCosto}, {d.PrecioVenta}, {d.Subtotal}, 'Exitoso')";

            Conexion.Ejecutar(consulta);
        }
        DetalleIngresos c = new DetalleIngresos();
        public DetalleIngresos ObtenerDetalleIngIdDal(int id)
        {
            string consulta = "select * from detalleing where iddetalleing=" + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                c.IdDetalleIng = Convert.ToInt32(tabla.Rows[0]["iddetalleing"]);
                c.IdIngreso = Convert.ToInt32(tabla.Rows[0]["idingreso"]);
                c.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                c.FechaVenc = Convert.ToDateTime(tabla.Rows[0]["fechavenc"]);
                c.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                c.PrecioCosto = Convert.ToDecimal(tabla.Rows[0]["preciocosto"]);
                c.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["precioventa"]);
                c.Subtotal = Convert.ToDecimal(tabla.Rows[0]["subtotal"]);
                c.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return c;
        }
        public void EditarDetalleIngDal(DetalleIngresos p)
        {
            string consulta = "update detalleing set idingreso=" + p.IdIngreso + "," +
                                                        "idproducto=" + p.IdProducto + "," +
                                                        "fechavenc='" + p.FechaVenc + "'," +
                                                        "cantidad=" + p.Cantidad + "," +
                                                        "preciocosto=" + p.PrecioCosto + "," +
                                                        "precioventa=" + p.PrecioVenta + "," +
                                                        "subtotal=" + p.Subtotal + " " +
                                                "where iddetalleing=" + p.IdDetalleIng;
            Conexion.Ejecutar(consulta);
        }
        public void EliminarDetalleIngDal(int id)
        {
            string consulta = "delete from detalleing where iddetalleing=" + id;
            Conexion.Ejecutar(consulta);
        }
        public DataTable DetalleIngDatosDal()
        {
            string consulta = "SELECT DETALLEING.IDDETALLEING,PRODUCTO.NOMBRE, PRODUCTO.CODIGOBARRA, PRODUCTO.UNIDAD, PRODUCTO.DESCRIPCION, DETALLEING.FECHAVENC, INGRESO.FECHAINGRESO, DETALLEING.CANTIDAD, DETALLEING.PRECIOCOSTO, \r\nDETALLEING.PRECIOVENTA, DETALLEING.SUBTOTAL, \r\n                         INGRESO.TOTAL\r\nFROM   DETALLEING INNER JOIN\r\n                         INGRESO ON DETALLEING.IDINGRESO = INGRESO.IDINGRESO INNER JOIN\r\n                         PRODUCTO ON DETALLEING.IDPRODUCTO = PRODUCTO.IDPRODUCTO";
            return Conexion.EjecutarDataTabla(consulta, "aaa");
        }
    }
}
