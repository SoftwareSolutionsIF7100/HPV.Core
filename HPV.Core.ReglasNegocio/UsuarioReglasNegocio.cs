using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPV.Core.AccesoDatos;
using HPV.Core.Dominio;

namespace HPV.Core.ReglasNegocio
{
    public class UsuarioReglasNegocio
    {
        private UsuarioAccesoDatos usuarioAD;

        public UsuarioReglasNegocio()
        {
            usuarioAD = new UsuarioAccesoDatos();
        }

        //Validacion de información del usuario
        public Usuario validarUsuario(String username, String contrasenna)
        {
            return this.usuarioAD.validarUsuario(username, contrasenna);
        }
    }
}
