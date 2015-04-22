using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HPV.Core.Dominio
{
    [DataContract]
    public class Galeria
    {
        private int id;
        private int idPagina;
        private string imagen;

        [DataMember]
        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        [DataMember]
        public int IdPagina
        {
            get { return idPagina; }
            set { idPagina = value; }
        }

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Galeria()
        {
            this.id = 0;
            this.idPagina = 0;
            this.imagen = "";
        }

        public Galeria(int id, int idPagina,String imagen)
        {
            this.id = id;
            this.idPagina = idPagina;
            this.imagen = imagen;
        }
    }
}
