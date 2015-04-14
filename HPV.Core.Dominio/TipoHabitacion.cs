using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HPV.Core.Dominio
{
    [DataContract]
    public class TipoHabitacion
    {
        private int idTipoHabitacion;
        private String descripcion;
        private float tarifa;
        private String imagen;

        [DataMember]
        public int IdTipoHabitacion
        {
            get { return idTipoHabitacion; }
            set { idTipoHabitacion = value; }
        }

        [DataMember]
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        [DataMember]
        public float Tarifa
        {
            get { return tarifa; }
            set { tarifa = value; }
        }

        [DataMember]
        public String Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public TipoHabitacion(int idTipoHabitacion, String descripcion,float tarifa,String imagen)
        {
            this.idTipoHabitacion = idTipoHabitacion;
            this.descripcion = descripcion;
            this.tarifa = tarifa;
            this.imagen = imagen;
        }

        public TipoHabitacion() 
        {
            this.idTipoHabitacion = 0;
            this.descripcion = "";
            this.tarifa = 0;
            this.imagen = "";
        }
    }
}
