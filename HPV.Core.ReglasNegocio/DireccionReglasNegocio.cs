using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPV.Core.AccesoDatos;
using HPV.Core.Dominio;

namespace HPV.Core.ReglasNegocio
{
    public class DireccionReglasNegocio
    {
        private DireccionAccesoDatos direccionAD;

        public DireccionReglasNegocio()
        {
            direccionAD = new DireccionAccesoDatos();
        }

        public Direccion obtenerDireccion()
        {
            return direccionAD.obtenerDireccion();

        }

    }
}
