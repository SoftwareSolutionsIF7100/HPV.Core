using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HPV.Core.Dominio;
using HPV.Core.ReglasNegocio;
using System.Configuration;

namespace Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Servicios : IServicios
    {
        public int modificarHotel(Hotel hotel)
        {
            HotelReglasNegocio hotelRN = new HotelReglasNegocio();
            return hotelRN.modificarHotel(hotel);
        }

        public Direccion obtenerDireccion()
        {
            DireccionReglasNegocio direccionRN = new DireccionReglasNegocio();
            return direccionRN.obtenerDireccion();
        }
    }
}
