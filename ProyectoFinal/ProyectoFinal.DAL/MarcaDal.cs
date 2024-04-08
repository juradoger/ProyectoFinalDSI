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
    public class MarcaDal
    {
        public DataTable ListarMarcaDal()
        {
            string consulta = "select * from marca";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarMarcaDal(Marca m)
        {
            string consulta = $"insert into marca values('{m.Nombre.ToString()}', 'Activo')";
            Conexion.Ejecutar(consulta);
        }
        public Marca ObtenerIdMarca(int id)
        {
            string consulta = "select * from marca where idmarca=" + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Marca marca = new Marca();
            if (tabla.Rows.Count > 0)
            {
                marca.IdMarca = Convert.ToInt32(tabla.Rows[0]["idmarca"]);
                marca.Nombre = tabla.Rows[0]["nombre"].ToString();
                marca.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return marca;
        }
        Marca p = new Marca();
        public Marca ObtenerMarcaIdDal(int id)
        {
            string consulta = "select * from marca where idmarca=" + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdMarca = Convert.ToInt32(tabla.Rows[0]["idmarca"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;
        }
        public void EditarMarcaDal(Marca p)
        {
            string consulta = "update marca set nombre='" + p.Nombre + "'," +
                                                        "estado='" + p.Estado + "' " +
                                                "where idmarca=" + p.IdMarca;
            Conexion.Ejecutar(consulta);
        }
        public void EliminarMarcaDal(int id)
        {
            string consulta = "delete from marca where idmarca=" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
