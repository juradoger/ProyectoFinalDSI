using ProyectoFinal.DAL;
using ProyectoFinal.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.MODEL;
using ProyectoFinal.DAL;

namespace ProyectoFinal.BSS
{   
    public class ClientesBss
    {

        ClienteDal dal = new ClienteDal();
        public DataTable ListarClienteBss()
        {
            return dal.ListarClienteDal();
        }
        public void InsertarClienteBss(Clientes cliente)
        {
            dal.InsertarClienteDal(cliente);
        }
        public Clientes ObtenerIdCBss(int id)
        {
            return dal.ObtenerIdCDal(id);
        }
        public void EditarClienteBss(Clientes c)
        {
            dal.EditarClienteDal(c);
        }
        public void EliminarClienteBss(int id)
        {
            dal.EliminarClienteDal(id);
        }
        public DataTable ClienteDatosBss()
        {
            return dal.ClienteDatosDal();
        }
    }
}
