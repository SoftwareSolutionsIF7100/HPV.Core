using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPV.Core.Dominio
{
    public class Usuario
    {
        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        private String cedula;

        public String Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private String apellido1;

        public String Apellido1
        {
            get { return apellido1; }
            set { apellido1 = value; }
        }
        private String apellido2;

        public String Apellido2
        {
            get { return apellido2; }
            set { apellido2 = value; }
        }
        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        private String telefono;

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private String username;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }
        private String contrasenna;

        public String Contrasenna
        {
            get { return contrasenna; }
            set { contrasenna = value; }
        }
        private String avatar;

        public String Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }

        public Usuario(int idUsuario,String cedula,String nombre,String apellido1,String apellido2,String email,String telefono,
            String username,String contrasenna, String avatar)
        {
            this.idUsuario = idUsuario;
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.email = email;
            this.telefono = telefono;
            this.username = username;
            this.contrasenna = contrasenna;
            this.avatar = avatar;
        }

    }
}
