using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HPV.Core.Dominio
{
    [DataContract]
    public class Hotel
    {
       
        private int idHotel;
        private String nombreHotel;
        private String checkIn;
        private String checkOut;
        private String telefono1;
        private String telefono2;
        private String email;
        private String apartadoPostal;
        
        

        public Hotel(int idHotel, String nombreHotel,String checkIn,String checkOut, String telefono1,
            String telefono2,String email,String apartadoPostal)
        {
            this.idHotel = idHotel;
            this.nombreHotel = nombreHotel;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.telefono1 = telefono1;
            this.telefono2 = telefono2;
            this.email = email;
            this.apartadoPostal = apartadoPostal;

        }

        public Hotel()
        {
            this.idHotel = 0;
            this.nombreHotel = "";
            this.checkIn = "";
            this.checkOut = "";
            this.telefono1 = "";
            this.telefono2 = "";
            this.email = "";
            this.apartadoPostal = "";
        }

        [DataMember]
        public int IdHotel
        {
            get { return idHotel; }
            set { idHotel = value; }
        }
        [DataMember]
        public String NombreHotel
        {
            get { return nombreHotel; }
            set { nombreHotel = value; }
        }

        [DataMember]
        public String CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }
        [DataMember]
        public String CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }

        [DataMember]
        public String Telefono1
        {
            get { return telefono1; }
            set { telefono1 = value; }
        }

        [DataMember]
        public String Telefono2
        {
            get { return telefono2; }
            set { telefono2 = value; }
        }

        [DataMember]
        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        [DataMember]
        public String ApartadoPostal
        {
            get { return apartadoPostal; }
            set { apartadoPostal = value; }
        }
    }
}
