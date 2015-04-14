using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPV.Core.AccesoDatos;
using HPV.Core.Dominio;

namespace HPV.Core.ReglasNegocio
{
    public class HotelReglasNegocio
    {
        private HotelAccesoDatos hotelAD;

        public HotelReglasNegocio()
        {
            this.hotelAD = new HotelAccesoDatos();
        }

        public int modificarHotel(Hotel hotel)
        {
            return hotelAD.modificarHotel(hotel);
        }


    }
}
