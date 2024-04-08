using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.MODEL;
using ProyectoFinal.DAL;
using ProyectoFinal.BSS;

namespace ProyectoFinal.BSS
{
    public class ProductoBss
    {
        ProductoDal dal = new ProductoDal();
        public DataTable ListarProductoBss()
        {
            return dal.ListarProductoDal();
        }

            public void InsertarProductoBss(Producto pr)
            {
                dal.InsertarProductoDal(pr);
            }
            public Producto ObtenerIdPBss(int id)
            {
                return dal.ObtenerProductoId(id);
            }
            public void EditarProductoBss(Producto p)
            {
                dal.EditarProductoDal(p);
            }
            public void EliminarProductoBss(int id)
            {
                dal.EliminarProductoDal(id);
            }
            public DataTable ProductoDatosBss()
            {
                return dal.ProductoDatosDal();
            }
        
    }
}
