using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPV.Core.Dominio
{
    public class Imagen
    {
        private int idImagen;

        public int IdImagen
        {
            get { return idImagen; }
            set { idImagen = value; }
        }
        private SobreNosotros sobreNosotros;

        public SobreNosotros SobreNosotros
        {
            get { return sobreNosotros; }
            set { sobreNosotros = value; }
        }
        private String imagen;

        public String Imagen1
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public Imagen(int idImagen, SobreNosotros sobreNosotros, String imagen)
        {
            this.idImagen = idImagen;
            this.sobreNosotros = sobreNosotros;
            this.imagen = imagen;
        }
    }
}
