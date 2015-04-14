using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HPV.Core.Dominio
{
    [DataContract]
    public class HabitacionServicio
    {
        private int idServicio;
        private int idHabitacion;

        [DataMember]
        public int IdServicio
        {
            get { return idServicio; }
            set { idServicio = value; }
        }
        
        [DataMember]
        public int IdHabitacion
        {
            get { return idHabitacion; }
            set { idHabitacion = value; }
        }

        
        public HabitacionServicio(int idHabitacion, int idServicio)
        {
            this.idHabitacion = idHabitacion;
            this.idServicio = idServicio;
        }

        public HabitacionServicio()
        {
            this.idHabitacion = 0;
            this.idServicio = 0;
        }
    }
}
