using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPV.Core.Dominio
{
    public class SobreNosotros
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
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

        public SobreNosotros(int id,String titulo,String descripcion)
        {
            this.id = id;
            this.titulo = titulo;
            this.descripcion = descripcion;
        }
    }
}
