using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPV.Core.Dominio
{
    public class Inicio
    {
        private int idInicio;

        public int IdInicio
        {
            get { return idInicio; }
            set { idInicio = value; }
        }
        private String titulo;

        public String Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        private String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private String imagen;

        public String Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public Inicio(int idInicio,String titulo,String descripcion,String imagen)
        {
            this.idInicio = idInicio;
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.imagen = imagen;
        }


    }
}
