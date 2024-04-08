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
    public class MarcaBss
    {
        MarcaDal dal = new MarcaDal();
        public DataTable ListarMarcaBss()
        {
            return dal.ListarMarcaDal();
        }
        public void InsertarMarcaBss(Marca mar)
        {
            dal.InsertarMarcaDal(mar);
        }
        public Marca ObtenerIdBss(int id)
        {
            return dal.ObtenerIdMarca(id);
        }
        public void EditarMarcaBss(Marca p)
        {
            dal.EditarMarcaDal(p);
        }
        public void EliminarMarcaBss(int id)
        {
            dal.EliminarMarcaDal(id);
        }
    }
}
