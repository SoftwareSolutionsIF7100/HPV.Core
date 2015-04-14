using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HPV.Core.Dominio
{
    [DataContract]
    public class Usuario
    {
        private int idUsuario;
        private String cedula;
        private String nombre;
        private String apellido1;
        private String apellido2;
        private String email;
        private String telefono;
        private String username;
        private String contrasenna;
        private String avatar;

        [DataMember]
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }


        [DataMember]
        public String Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        [DataMember]
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [DataMember]
        public String Apellido1
        {
            get { return apellido1; }
            set { apellido1 = value; }
        }

        [DataMember]
        public String Apellido2
        {
            get { return apellido2; }
            set { apellido2 = value; }
        }

        [DataMember]
        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        [DataMember]
        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        [DataMember]
        public String Username
        {
            get { return username; }
            set { username = value; }
        }

        [DataMember]
        public String Contrasenna
        {
            get { return contrasenna; }
            set { contrasenna = value; }
        }

        [DataMember]
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

        public Usuario()
        {
            this.idUsuario = 0;
            this.cedula = "";
            this.nombre = "";
            this.apellido1 = "";
            this.apellido2 = "";
            this.email = "";
            this.telefono = "";
            this.username = "";
            this.contrasenna = "";
            this.avatar = "";
        }

    }
}
