using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HPV.Core.Dominio
{
    [DataContract]
    public class Publicidad
    {
        private int idPublicidad;
        private string imagen;
        private string enlace;

        [DataMember]
        public int IdPublicidad
        {
            get { return idPublicidad; }
            set { idPublicidad = value; }
        }

        [DataMember]
        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        [DataMember]
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

        public Publicidad()
        {
            this.idPublicidad = 0;
            this.imagen = "";
            this.enlace = "";
        }
    }
}
