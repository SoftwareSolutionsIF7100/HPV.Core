using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPV.Core.Dominio
{
    public class Servicio
    {
        private int idServicio;

        public int IdServicio
        {
            get { return idServicio; }
            set { idServicio = value; }
        }
        private String descripcion;

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
    }
}
