using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPV.Core.Dominio
{
    public class Habitacion
    {
        private int idHabitacion;

        public int IdHabitacion
        {
            get { return idHabitacion; }
            set { idHabitacion = value; }
        }
        private TipoHabitacion tipoHabitacion;

        public TipoHabitacion TipoHabitacion
        {
            get { return tipoHabitacion; }
            set { tipoHabitacion = value; }
        }
        private EstadoHabitacion estado;

        public EstadoHabitacion Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private int numeroHabitacion;

        public int NumeroHabitacion
        {
            get { return numeroHabitacion; }
            set { numeroHabitacion = value; }
        }
        private Boolean activa;

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

    }
}
