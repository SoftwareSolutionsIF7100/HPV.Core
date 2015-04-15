using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPV.Core.Dominio;
using HPV.Core.AccesoDatos;

namespace HPV.Core.ReglasNegocio
{
    public class PublicidadReglasNegocio
    {
        private PublicidadAccesoDatos publicidadAD;

        public PublicidadReglasNegocio()
        {
            this.publicidadAD = new PublicidadAccesoDatos();
        }

        //insertar publicidad
        public int insertarPublicidad(Publicidad publicidad)
        {
            return this.publicidadAD.insertarPublicidad(publicidad);
        }

         //modificar publicidad
        public int modificarPublicidad(Publicidad publicidad)
        {
            return this.publicidadAD.modificarPublicidad(publicidad);
        }

        //eliminar publicidad
        public int eliminarPublicidad(int idPublicidad)
        {
            return this.publicidadAD.eliminarPublicidad(idPublicidad);
        }

        //obtener publicidad
        public Publicidad obtenerPublicidad(int idPublicidad)
        {
            return this.publicidadAD.obtenerPublicidad(idPublicidad);
        }

        //obtener la publicidades de la BD
        public List<Publicidad> obtenerPublicidades()
        {
            return this.publicidadAD.obtenerPublicidades();
        }
    }
}
