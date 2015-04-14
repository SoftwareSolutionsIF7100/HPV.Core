using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HPV.Core.Dominio
{
    [DataContract]
    public class Reservacion
    {

        private int idReservacion;
        private String codigoReserva;
        private String fechaCreacion;
        private String nombre;
        private String apellidos;
        private String email;
        private String tarjeta;
        private String transaccion;
        private String fechaLlegada;
        private String fechaSalida;
        private Boolean eliminado;

        [DataMember]
        public int IdReservacion
        {
            get { return idReservacion; }
            set { idReservacion = value; }
        }

        [DataMember]
        public String CodigoReserva
        {
            get { return codigoReserva; }
            set { codigoReserva = value; }
        }

        [DataMember]
        public String FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }

        [DataMember]
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [DataMember]
        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        [DataMember]
        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        [DataMember]
        public String Tarjeta
        {
            get { return tarjeta; }
            set { tarjeta = value; }
        }

        [DataMember]
        public String Transaccion
        {
            get { return transaccion; }
            set { transaccion = value; }
        }

        [DataMember]
        public String FechaLlegada
        {
            get { return fechaLlegada; }
            set { fechaLlegada = value; }
        }

        [DataMember]
        public String FechaSalida
        {
            get { return fechaSalida; }
            set { fechaSalida = value; }
        }

        [DataMember]
        public Boolean Eliminado
        {
            get { return eliminado; }
            set { eliminado = value; }
        }

        public Reservacion(int idReservacion, String codigo, String fechaCreacion, String nombre, String apellidos,
            String email, String tarjeta, String transaccion, String fechaLLegada, String fechaSalida,Boolean eliminado)
        {
            this.idReservacion = idReservacion;
            this.codigoReserva = codigo;
            this.fechaCreacion = fechaCreacion;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.email = email;
            this.tarjeta = tarjeta;
            this.transaccion = transaccion;
            this.fechaLlegada = fechaLLegada;
            this.fechaSalida = fechaSalida;
            this.eliminado = eliminado;
        }

        public Reservacion()
        {
            this.idReservacion = 0;
            this.codigoReserva = "";
            this.fechaCreacion = "";
            this.nombre = "";
            this.apellidos = "";
            this.email = "";
            this.tarjeta = "";
            this.transaccion = "";
            this.fechaLlegada = "";
            this.fechaSalida = "";
            this.eliminado = false;
        }
    }
}
