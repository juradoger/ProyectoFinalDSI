using ProyectoFinal.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.MODEL;

namespace ProyectoFinal.BSS
{
    public class DetalleIngresoBss
    {
        DetalleIngDal dal = new DetalleIngDal();
        public DataTable ListarDetalleIngBss()
        {
            return dal.ListarDetalleIngDal();
        }
        public void InsertarDetalleIngBss(DetalleIngresos detalleIng)
        {
            dal.InsertarDetalleIngDal(detalleIng);
        }
        public DetalleIngresos ObtenerDetalleIngIdBss(int id)
        {
            return dal.ObtenerDetalleIngIdDal(id);
        }
        public void EditarDetalleIngBss(DetalleIngresos p)
        {
            dal.EditarDetalleIngDal(p);
        }
        public void EliminarDetalleIngBss(int id)
        {
            dal.EliminarDetalleIngDal(id);
        }
        public DataTable DetalleIngDatosBss()
        {
            return dal.DetalleIngDatosDal();
        }
    }
}
