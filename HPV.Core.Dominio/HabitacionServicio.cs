using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPV.Core.Dominio
{
    public class HabitacionServicio
    {
          private int idServicio;

        public int IdServicio
        {
            get { return idServicio; }
            set { idServicio = value; }
        }
        private int idHabitacion;

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
    }
}
