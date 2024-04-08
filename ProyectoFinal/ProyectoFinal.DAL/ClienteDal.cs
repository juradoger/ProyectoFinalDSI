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
    public class ClienteDal
    {
        public DataTable ListarClienteDal()
        {
            string consulta = "select * from cliente";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarClienteDal(Clientes cliente)
        {
            string consulta = "insert into cliente values('" + cliente.IdPersona + "' ," +
                                                          "'" + cliente.TipoCliente + "' ," +
                                                          "'" + cliente.CodCliente + "' ," +
                                                          "'Activo')";
            Conexion.Ejecutar(consulta);
        }
        public Clientes ObtenerIdCDal(int id)
        {
            string consulta = "select * from cliente where idcliente=" + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Clientes cliente = new Clientes();
            if (tabla.Rows.Count > 0)
            {
                cliente.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                cliente.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                cliente.TipoCliente = tabla.Rows[0]["tipocliente"].ToString();
                cliente.CodCliente = tabla.Rows[0]["codcliente"].ToString();
                cliente.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return cliente;
        }
        public void EditarClienteDal(Clientes c)
        {
            string consulta = $"update cliente set idpersona= '{c.IdPersona}', tipocliente= '{c.TipoCliente.ToString()}', codigocliente='{c.CodCliente.ToString()}', where idcliente='{c.IdCliente}'";
            Conexion.Ejecutar(consulta);
        }
        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from cliente where idcliente=" + id;
            Conexion.Ejecutar(consulta);

        }
        public DataTable ClienteDatosDal()
        {
            string consulta = "SELECT        CLIENTE.IDCLIENTE, PERSONA.NOMBRE+' '+ PERSONA.APELLIDO NOMBREPERSONA,CLIENTE.TIPOCLIENTE, CLIENTE.CODIGOCLIENTE, CLIENTE.ESTADO\r\nFROM            CLIENTE INNER JOIN\r\n                         PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA";
            return Conexion.EjecutarDataTabla(consulta, "sfef");
        }
    }
}
