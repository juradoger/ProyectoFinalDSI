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
    public class PersonaBss
    {
        //instanciamos la clase Persona para crear un objeto llamado dal
        PersonaDal dal = new PersonaDal();
        //luego creamos un procedimiento para listar los registros de la tabla Bss
        public DataTable ListarPersonaBss()
        {
            return dal.ListarPersonasDal();
            //como es el mismo procedimiento, por eficiencia, llamo al procedimiento de la clase dal

        }
        public void InsertarPersonasBss(Personas persona)
        {
            dal.InsertarPersonaDal(persona);
        }
        public Personas ObtenerIdBss(int id)
        {
            return dal.ObtenerPersonaId(id);
        }
        public void EditarPersonaBss(Personas persona)
        {
            dal.EditarPersonaDal(persona);
        }
        public void EliminarPersonaBss(int id)
        {
            dal.EliminarPersonaDal(id);
        }
    }
}
