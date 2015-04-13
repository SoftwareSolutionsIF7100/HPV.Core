using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPV.Core.Dominio
{
    public class TipoHabitacion
    {
        private int idTipoHabitacion;

        public int IdTipoHabitacion
        {
            get { return idTipoHabitacion; }
            set { idTipoHabitacion = value; }
        }
        private String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private float tarifa;

        public float Tarifa
        {
            get { return tarifa; }
            set { tarifa = value; }
        }
        private String imagen;

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
    }
}
