using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HPV.Core.Dominio
{
    [DataContract]
    public class Pagina
    {
        private int idPagina;
        private String descripcion;
        private Imagen imagen;


        [DataMember]
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        [DataMember]
        public int IdPagina
        {
            get { return idPagina; }
            set { idPagina = value; }
        }

        [DataMember]
        public Imagen Imagen {
            get { return imagen; }
            set { imagen = value; }
        }

        public Pagina()
        {
            this.idPagina = 0;
            this.descripcion = "";
            this.imagen = null;
        }

        public Pagina(int idPagina, String descripcion, Imagen imagen)
        {
            this.idPagina = idPagina;
            this.descripcion = descripcion;
            this.imagen = imagen;
        }
    }
}
