using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HPV.Core.Dominio
{
    [DataContract]
    public class Direccion
    {
        private int idDireccion;
        private Seccion seccion;
        private float latitud;
        private float longitud;

        public Direccion()
        {
            this.idDireccion = 0;
            this.seccion = new Seccion();
            this.latitud = 0;
            this.longitud = 0;
        }

        public Direccion(int idDireccion, Seccion seccion, float latitud, float longitud)
        {
            this.idDireccion = idDireccion;
            this.seccion = seccion;
            this.latitud = latitud;
            this.longitud = longitud;
        }

        [DataMember]
        public Seccion Seccion
        {
            get { return seccion; }
            set { seccion = value; }
        }

        [DataMember]
        public int IdDireccion
        {
            get { return idDireccion; }
            set { idDireccion = value; }
        }

        [DataMember]
        public float Latitud
        {
            get { return latitud; }
            set { latitud = value; }
        }

        [DataMember]
        public float Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
    }
}
