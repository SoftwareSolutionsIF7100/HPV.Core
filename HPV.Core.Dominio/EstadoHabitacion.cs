using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HPV.Core.Dominio
{
    [DataContract]
    public class EstadoHabitacion
    {
        private int idEstado;
        private String descripcion;

        [DataMember]
        public int IdEstado
        {
            get { return idEstado; }
            set { idEstado = value; }
        }
       
        [DataMember]
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public EstadoHabitacion()
        {
            this.idEstado = 0;
            this.descripcion = "";
        }

        public EstadoHabitacion(int idEstado, String descripcion)
        {
            this.idEstado = idEstado;
            this.descripcion = descripcion;
        }
    }
}
