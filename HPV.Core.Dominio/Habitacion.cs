using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HPV.Core.Dominio
{
    [DataContract]
    public class Habitacion
    {
        private int idHabitacion;
        private TipoHabitacion tipoHabitacion;
        private EstadoHabitacion estado;
        private int numeroHabitacion;
        private Boolean activa;

        [DataMember]
        public int IdHabitacion
        {
            get { return idHabitacion; }
            set { idHabitacion = value; }
        }

        [DataMember]
        public TipoHabitacion TipoHabitacion
        {
            get { return tipoHabitacion; }
            set { tipoHabitacion = value; }
        }

        [DataMember]
        public EstadoHabitacion Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        [DataMember]
        public int NumeroHabitacion
        {
            get { return numeroHabitacion; }
            set { numeroHabitacion = value; }
        }

        [DataMember]
        public Boolean Activa
        {
            get { return activa; }
            set { activa = value; }
        }

        public Habitacion(int idHabitacion,TipoHabitacion tipoHabitacion,EstadoHabitacion estado,
            int numeroHabitacion,Boolean activa)
        {
            this.idHabitacion = idHabitacion;
            this.tipoHabitacion = tipoHabitacion;
            this.estado = estado;
            this.numeroHabitacion = numeroHabitacion;
            this.activa = activa;
        }

        public Habitacion()
        {
            this.idHabitacion = 0;
            this.tipoHabitacion = new TipoHabitacion();
            this.estado = new EstadoHabitacion();
            this.numeroHabitacion = 0;
            this.activa = false;
        }
    }
}
