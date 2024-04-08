using ProyectoFinal.MODEL;
using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.DAL
{
    public class DetalleVentasDal
    {
        public DataTable ListarDetalleVentaDal()
        {
            string consulta = "select * from detalleventa";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarDetalleVentaDal(DetallesVentas dv)
        {
            string consulta = $"insert into detalleventa values({dv.IdVenta}, {dv.IdProducto}, {dv.Cantidad}, {dv.PrecioVenta}, {dv.Subtotal}, 'Exitoso')";
            Conexion.Ejecutar(consulta);
        }
        DetallesVentas p = new DetallesVentas();
        public DetallesVentas ObtenerDetalleVentaIdDal(int id)
        {
            string consulta = "select * from detalleventa where iddetalleventa=" + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdDetalleVenta = Convert.ToInt32(tabla.Rows[0]["iddetalleventa"]);
                p.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                p.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                p.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                p.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["precioventa"]);
                p.Subtotal = Convert.ToDecimal(tabla.Rows[0]["subtotal"]);
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;
        }
        public void EditarDetalleVentaDal(DetallesVentas p)
        {
            string consulta = "update detalleventa set idventa=" + p.IdVenta + "," +
                                                        "idproducto=" + p.IdProducto + "," +
                                                        "cantidad=" + p.Cantidad + "," +
                                                        "precioventa=" + p.PrecioVenta + "," +
                                                        "subtotal=" + p.Subtotal + " " +
                                                "where iddetalleventa=" + p.IdDetalleVenta;
            Conexion.Ejecutar(consulta);
        }
        public void EliminarDetalleVentaDal(int id)
        {
            string consulta = "delete from detalleventa where iddetalleventa=" + id;
            Conexion.Ejecutar(consulta);
        }
        public DataTable DetalleVentaDatosDal()
        {
            string consulta = "SELECT        DETALLEVENTA.IDDETALLEVENTA,VENTA.FECHA, PRODUCTO.NOMBRE, PRODUCTO.CODIGOBARRA, PRODUCTO.DESCRIPCION, DETALLEVENTA.CANTIDAD, DETALLEVENTA.PRECIOVENTA, DETALLEVENTA.SUBTOTAL, VENTA.TOTAL\r\nFROM            DETALLEVENTA INNER JOIN\r\n                         VENTA ON DETALLEVENTA.IDVENTA = VENTA.IDVENTA INNER JOIN\r\n                         PRODUCTO ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO";
            return Conexion.EjecutarDataTabla(consulta, "sss");
        }
    }
}
