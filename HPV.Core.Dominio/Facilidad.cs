using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPV.Core.Dominio
{
    public class Facilidad
    {
        private int idFacilidad;

        public int IdFacilidad
        {
            get { return idFacilidad; }
            set { idFacilidad = value; }
        }
        private String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private String imagen;

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

       
    }
}
