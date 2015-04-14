using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HPV.Core.Dominio
{
    [DataContract]
    public class Facilidad
    {
        private int idFacilidad;
        private String descripcion;
        private String imagen;

        [DataMember]
        public int IdFacilidad
        {
            get { return idFacilidad; }
            set { idFacilidad = value; }
        }

        [DataMember]
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        
        [DataMember]
        public String Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public Facilidad(int idFacilidad, String descripcion,String imagen)
        {
            this.idFacilidad = idFacilidad;
            this.descripcion = descripcion;
            this.imagen = imagen;
        }

        public Facilidad()
        {
            this.idFacilidad = 0;
            this.descripcion = "";
            this.imagen = "";
        }
    }
}
