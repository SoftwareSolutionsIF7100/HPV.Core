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
        private string descripcion;
        private float latitud;
        private float longitud;

        public Direccion()
        {
            this.idDireccion = 0;
            this.descripcion = "";
            this.latitud = 0;
            this.longitud = 0;
        }

        public Direccion(int idDireccion, String descripcion,float latitud,float longitud)
        {
            this.idDireccion = idDireccion;
            this.descripcion = descripcion;
            this.latitud = latitud;
            this.longitud = longitud;
        }

        [DataMember]
        public int IdDireccion
        {
            get { return idDireccion; }
            set { idDireccion = value; }
        }

        [DataMember]
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
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
