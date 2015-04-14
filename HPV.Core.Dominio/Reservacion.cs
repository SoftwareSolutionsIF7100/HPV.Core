using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPV.Core.Dominio
{
    public class Reservacion
    {
        private int idReservacion;

        public int IdReservacion
        {
            get { return idReservacion; }
            set { idReservacion = value; }
        }
        private String codigoReserva;

        public String CodigoReserva
        {
            get { return codigoReserva; }
            set { codigoReserva = value; }
        }
        private String fechaCreacion;

        public String FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private String apellidos;

        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        private String tarjeta;

        public String Tarjeta
        {
            get { return tarjeta; }
            set { tarjeta = value; }
        }
        private String transaccion;

        public String Transaccion
        {
            get { return transaccion; }
            set { transaccion = value; }
        }
        private String fechaLlegada;

        public String FechaLlegada
        {
            get { return fechaLlegada; }
            set { fechaLlegada = value; }
        }
        private String fechaSalida;

        public String FechaSalida
        {
            get { return fechaSalida; }
            set { fechaSalida = value; }
        }
        private Boolean eliminado;

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
    }
}
