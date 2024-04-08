using ProyectoFinal.DAL;
using ProyectoFinal.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.BSS
{
    public class IngresoBss
    {

        IngresoDal dal = new IngresoDal();
        public DataTable ListarIngresoBss()
        {
            return dal.ListarIngresoDal();
        }
        public void InsertarIngresoBss(Ingreso i)
        {
            dal.InsertarIngresoDal(i);
        }
        public Ingreso ObtenerIdBss(int id)
        {
            return dal.ObtenerIngresoId(id);
        }
        public void EditarIngresoBss(Ingreso p)
        {
            dal.EditarIngresoDal(p);
        }
        public void EliminarIngresoBss(int id)
        {
            dal.EliminarIngresoDal(id);
        }
        public DataTable IngresoDatosBsss()
        {
            return dal.IngresoDatosDal();
        }
    }
}
