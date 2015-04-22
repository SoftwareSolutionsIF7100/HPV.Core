using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Drawing;

namespace HPV.Core.Dominio
{
    [DataContract]
    public class Imagen
    {
        private int idImagen;
        private Image imagen;
        private int idTipoEntidad;

        [DataMember]
        public int IdTipoEntidad
        {
            get { return idTipoEntidad; }
            set { idTipoEntidad = value; }
        } 

        [DataMember]
        public int IdImagen
        {
            get { return idImagen; }
            set { idImagen = value; }
        }
        
        
        [DataMember]
        public Image Imagen1
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public Imagen(int idImagen, Image imagen,int idTipoEntidad)
        {
            this.idImagen = idImagen;
            this.imagen = imagen;
            this.idTipoEntidad = idTipoEntidad;
        }

        public Imagen()
        {
            this.idImagen = 0;
            this.imagen = null;
            this.idTipoEntidad = 0;
        }
    }
}
