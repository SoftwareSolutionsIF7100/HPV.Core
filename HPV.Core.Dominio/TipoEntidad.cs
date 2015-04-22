using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HPV.Core.Dominio
{
    [DataContract]
    public class TipoEntidad
    {
        private int idTipoEntidad;
        private string descripcion;

        [DataMember]
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        [DataMember]
        public int IdTipoEntidad
        {
            get { return idTipoEntidad; }
            set { idTipoEntidad = value; }
        }

        public TipoEntidad ()
        {
            this.idTipoEntidad = 0;
            this.descripcion = "";
        }
    }
}
