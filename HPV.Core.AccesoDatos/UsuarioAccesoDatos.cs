using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPV.Core.Dominio;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace HPV.Core.AccesoDatos
{
    public class UsuarioAccesoDatos
    {
        private String stringConexion;

        public UsuarioAccesoDatos()
        {
            this.stringConexion = ConfigurationManager.ConnectionStrings["BDPuertoViejo"].ConnectionString;
        }

        public Usuario validarUsuario(String username, String contrasenna)
        {
            try
            {
                //conexion a base de datos
                SqlConnection sqlConnection = new SqlConnection(this.stringConexion);

                //define la consulta
                string sqlSelect = "SELECT * FROM usuario Where username=" + username + " and contrasenna=" + contrasenna;

                //crea un adapter
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                //configurar el adapter (select)
                sqlDataAdapter.SelectCommand = new SqlCommand();
                sqlDataAdapter.SelectCommand.CommandText = sqlSelect;
                sqlDataAdapter.SelectCommand.Connection = sqlConnection;

                //dataSet para almacenar resultados
                DataSet dataSetGenders = new DataSet();

                //ejecutar consulta
                sqlDataAdapter.Fill(dataSetGenders, "Usuario");

                //cerrar conexion
                sqlDataAdapter.SelectCommand.Connection.Close();

                /*---------------------------------------------*/
                //obtenere filas de data set 
                DataRowCollection rows = dataSetGenders.Tables["Usuario"].Rows;

                //crear objeto
                Usuario usuario = new Usuario();

                foreach (DataRow currentRow in rows)
                {
                    //asignar los valores a objetos
                    usuario.IdUsuario = int.Parse(currentRow["idUsuario"].ToString());
                    usuario.Cedula = currentRow["cedula"].ToString();
                    usuario.Nombre = currentRow["nombre"].ToString();
                    usuario.Apellido1 = currentRow["apellido1"].ToString();
                    usuario.Apellido2 = currentRow["apellido2"].ToString();
                    usuario.Email = currentRow["email"].ToString();
                    usuario.Telefono = currentRow["telefono"].ToString();
                    usuario.Username = currentRow["username"].ToString();
                    usuario.Contrasenna = currentRow["contrasenna"].ToString();
                    usuario.Avatar = currentRow["avatar"].ToString();
                }

                return usuario;
            }
            catch (SqlException)
            {
                return null;
            }
        }
    }
}