using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using HPV.Core.Dominio;

namespace HPV.Core.AccesoDatos
{
    public class HotelAccesoDatos
    {
        private String stringConexion;

        public HotelAccesoDatos()
        {
            this.stringConexion = ConfigurationManager.ConnectionStrings["BDPuertoViejo"].ConnectionString;
        }

        public int modificarHotel(Hotel hotel)
        {
            return 1;
        }
    }
}
