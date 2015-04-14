using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HPV.Core.Dominio
{
    [DataContract]
    public class Servicio
    {
        private int idServicio;
        private String descripcion;

        [DataMember]
        public int IdServicio
        {
            get { return idServicio; }
            set { idServicio = value; }
        }
        
        [DataMember]
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Servicio(int idServicio, String descripcion)
        {
            this.idServicio = idServicio;
            this.descripcion = descripcion;
        }

        public Servicio()
        {
            this.idServicio = 0;
            this.descripcion = "";
        }
    }
}
