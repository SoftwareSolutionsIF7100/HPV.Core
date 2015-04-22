using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HPV.Core.Dominio
{
    [DataContract]
    public class Pagina
    {
        private int idPagina;
        private String descripcion;

        [DataMember]
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        [DataMember]
        public int IdPagina
        {
            get { return idPagina; }
            set { idPagina = value; }
        }

        public Pagina()
        {
            this.idPagina = 0;
            this.descripcion = "";
        }

        public Pagina(int idPagina, String descripcion)
        {
            this.idPagina = 0;
            this.descripcion = "";
        }
    }
}
