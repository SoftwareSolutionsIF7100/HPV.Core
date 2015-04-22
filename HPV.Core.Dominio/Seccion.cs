using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HPV.Core.Dominio
{
    [DataContract]
    public class Seccion
    {
        private int idSeccion;
        private int idPagina;
        private String descripcion;
        private int idImagen;

        [DataMember]
        public int IdImagen
        {
            get { return idImagen; }
            set { idImagen = value; }
        }

        [DataMember]
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        [DataMember]
        public int IdSeccion
        {
            get { return idSeccion; }
            set { idSeccion = value; }
        }

        [DataMember]
        public int IdPagina
        {
            get { return idPagina; }
            set { idPagina = value; }
        }

        public Seccion()
        {
            this.idSeccion = 0;
            this.idPagina = 0;
            this.idImagen = 0;
            this.descripcion = "";
        }

        public Seccion(int idSeccion, int idPagina, int idImagen,String descripcion)
        {
            this.idSeccion = idSeccion;
            this.idPagina = idPagina;
            this.idImagen = idImagen;
            this.descripcion = descripcion;
        }
    }
}
