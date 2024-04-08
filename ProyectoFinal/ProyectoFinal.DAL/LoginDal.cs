using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.MODEL;
using SistemasVentas.DAL;

namespace ProyectoFinal.DAL
{
    public class LoginDal
    {
        Login usuario = new Login();
        public void ValidarUsuarioDal(Login usuario)
        {
            string consultas = $@"SELECT * 
                FROM USUARIO U INNER JOIN USUARIOROL UR ON U.IDUSUARIO = UR.IDUSUARIO INNER JOIN ROL R ON R.IDROL=UR.IDROL
            WHERE nombreuser = '{usuario.usuario}' AND contrasena = '{usuario.contrasena}'";
            Conexion.Ejecutar(consultas);

        }
        public int ObtenerIdRol(Login user)
        {
            string consulta = $@"SELECT R.IDROL
                FROM USUARIO U INNER JOIN USUARIOROL UR ON U.IDUSUARIO = UR.IDUSUARIO INNER JOIN ROL R ON R.IDROL=UR.IDROL
            WHERE nombreuser = '{user.usuario}' AND contrasena = '{user.contrasena}'";
            return Conexion.EjecutarEscalar(consulta);
        }
    }
}
