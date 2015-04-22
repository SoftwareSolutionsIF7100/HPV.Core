using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPV.Core.Dominio;
using HPV.Core.AccesoDatos;

namespace HPV.Core.ReglasNegocio
{
    class PaginaReglasNegocio
    {
        private PaginaAccesoDatos paginaAD;

        public PaginaReglasNegocio()
        {
            this.paginaAD = new PaginaAccesoDatos();
        }

        //obtener publicidad
        public Publicidad obtenerPagina(int idPagina)
        {
            return this.paginaAD.obtenerPagina(idPagina);
        }

    }
}
