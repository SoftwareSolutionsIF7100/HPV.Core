using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HPV.Core.Dominio
{
    [DataContract]
    public class SobreNosotros
    {
        private int id;
        private String titulo;
        private String descripcion;

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
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

        public SobreNosotros(int id,String titulo,String descripcion)
        {
            this.id = id;
            this.titulo = titulo;
            this.descripcion = descripcion;
        }

        public SobreNosotros()
        {
            this.id = 0;
            this.titulo = "";
            this.descripcion = "";
        }
    }
}
