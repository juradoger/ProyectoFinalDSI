using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.MODEL;
using ProyectoFinal.DAL;

namespace ProyectoFinal.BSS
{
    public class LoginBss
    {
        LoginDal dal = new LoginDal();
        public void ValidarUsuarioBss(Login user)
        {
            dal.ValidarUsuarioDal(user);
        }
        public int ObtenerIdRolBss(Login user)
        {
           return dal.ObtenerIdRol(user);
        }
    }
}
