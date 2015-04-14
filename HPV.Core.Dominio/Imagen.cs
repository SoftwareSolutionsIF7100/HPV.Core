using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HPV.Core.Dominio
{
    [DataContract]
    public class Imagen
    {
        private int idImagen;
        private SobreNosotros sobreNosotros;
        private String imagen;

        [DataMember]
        public int IdImagen
        {
            get { return idImagen; }
            set { idImagen = value; }
        }
        
        [DataMember]
        public SobreNosotros SobreNosotros
        {
            get { return sobreNosotros; }
            set { sobreNosotros = value; }
        }
        
        [DataMember]
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

        public Imagen()
        {
            this.idImagen = 0;
            this.sobreNosotros = new SobreNosotros();
            this.imagen = "";
        }
    }
}
