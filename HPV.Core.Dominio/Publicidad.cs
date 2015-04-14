using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPV.Core.Dominio
{
    public class Publicidad
    {
        private int idPublicidad;

        public int IdPublicidad
        {
            get { return idPublicidad; }
            set { idPublicidad = value; }
        }
        private string imagen;

        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
        private string enlace;

        public string Enlace
        {
            get { return enlace; }
            set { enlace = value; }
        }

        public Publicidad(int idPublicidad, string imagen, String enlace)
        {
            this.idPublicidad = idPublicidad;
            this.imagen = imagen;
            this.enlace = enlace;
        }
    }
}
