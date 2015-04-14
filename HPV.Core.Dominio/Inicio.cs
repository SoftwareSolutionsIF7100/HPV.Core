using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HPV.Core.Dominio
{
    [DataContract]
    public class Inicio
    {
        private int idInicio;
        private String titulo;
        private String descripcion;
        private String imagen;

        [DataMember]
        public int IdInicio
        {
            get { return idInicio; }
            set { idInicio = value; }
        }

        [DataMember]
        public String Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        [DataMember]
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        [DataMember]
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

        public Inicio()
        {
            this.idInicio = 0;
            this.titulo = "";
            this.descripcion = "";
            this.imagen = "";
        }


    }
}
