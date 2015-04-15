using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using HPV.Core.Dominio;
using System.Data.SqlClient;
using System.Data;

namespace HPV.Core.AccesoDatos
{
    public class PublicidadAccesoDatos
    {
        private String stringConexion;

        public PublicidadAccesoDatos()
        {
            this.stringConexion = ConfigurationManager.ConnectionStrings["BDPuertoViejo"].ConnectionString;
        }

        //insertar publicidad
        public int insertarPublicidad(Publicidad publicidad)
        {
            //conexion con BD
            SqlConnection myConnection = new SqlConnection(this.stringConexion);

            //consulta
            string sqlStoredProcedure = "sp_publicidad_insertar";
            SqlCommand sqlCommand = new SqlCommand(sqlStoredProcedure, myConnection);

            //configuracion sqlcommand 
            sqlCommand.CommandType = CommandType.StoredProcedure;

            //parametos
            sqlCommand.Parameters.Add(new SqlParameter("@imagen", publicidad.Imagen));
            sqlCommand.Parameters.Add(new SqlParameter("@enlace", publicidad.Enlace));

            try
            {
                //ejecutar sp
                sqlCommand.Connection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Connection.Close();
            }
            catch (SqlException ex)
            {
                sqlCommand.Connection.Close();
                return ex.ErrorCode;
            }
            return 1;
        }

        //modificar publicidad
        public int modificarPublicidad(Publicidad publicidad)
        {
            //conexion con BD
            SqlConnection myConnection = new SqlConnection(this.stringConexion);

            //consulta
            string sqlStoredProcedure = "sp_publicidad_modificar";
            SqlCommand sqlCommand = new SqlCommand(sqlStoredProcedure, myConnection);

            //configuracion sqlcommand 
            sqlCommand.CommandType = CommandType.StoredProcedure;

            //parametos
            sqlCommand.Parameters.Add(new SqlParameter("@idPublicidad", publicidad.IdPublicidad));
            sqlCommand.Parameters.Add(new SqlParameter("@imagen", publicidad.Imagen));
            sqlCommand.Parameters.Add(new SqlParameter("@enlace", publicidad.Enlace));

            try
            {
                //ejecutar sp
                sqlCommand.Connection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Connection.Close();
            }
            catch (SqlException ex)
            {
                sqlCommand.Connection.Close();
                return ex.ErrorCode;
            }
            return 1;
        }

        //eliminar publicidad
        public int eliminarPublicidad(int idPublicidad)
        {
            //conexion BD
            SqlConnection myConnection = new SqlConnection(this.stringConexion);

            //query
            string sqlStoredProcedure = "sp_publicidad_eliminar";
            SqlCommand sqlCommand = new SqlCommand(sqlStoredProcedure, myConnection);

            //configuracion sqlcommand 
            sqlCommand.CommandType = CommandType.StoredProcedure;

            //parametro
            sqlCommand.Parameters.Add(new SqlParameter("@idPublicidad", idPublicidad));
           
            try
            {
                //ejecutar sp
                sqlCommand.Connection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Connection.Close();
            }
            catch (SqlException ex)
            {
                sqlCommand.Connection.Close();
                return ex.ErrorCode;
            }

            return 1;
        }

        public Publicidad obtenerPublicidad(int idPublicidad)
        {
            try
            {
                //cobexion con BD
                SqlConnection sqlConnection = new SqlConnection(this.stringConexion);

                //query
                string sqlSelect = "SELECT * FROM Publicidad WHERE (idPublicidad = " + idPublicidad + ")";

                //adapter
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                //configurar adapter (select)
                sqlDataAdapter.SelectCommand = new SqlCommand();
                sqlDataAdapter.SelectCommand.CommandText = sqlSelect;
                sqlDataAdapter.SelectCommand.Connection = sqlConnection;

                //dataSet para almacenar resultados
                DataSet dataSet = new DataSet();

                //ejecutar query
                sqlDataAdapter.Fill(dataSet, "Publicidad");

                //cerrar conexion
                sqlDataAdapter.SelectCommand.Connection.Close();
                Publicidad publicidad = new Publicidad();
                DataRowCollection filas = dataSet.Tables["Publicidad"].Rows;
                foreach (DataRow fila in filas)
                {
                    publicidad.IdPublicidad = int.Parse(fila["idPublicidad"].ToString());
                    publicidad.Imagen = fila["imagen"].ToString();
                    publicidad.Enlace = fila["enlace"].ToString();
                }
                return publicidad;
            }
            catch (SqlException)
            {
                return null;
            }
           
        }

        //obtener la publicidades de la BD
        public List<Publicidad> obtenerPublicidades()
        {
            try
            {
                //conexion con BD
                SqlConnection sqlConnection = new SqlConnection(this.stringConexion);

                //query
                string sqlSelect = "SELECT * FROM Publicidad";

                //adapter
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                //configurar el adapter (select)
                sqlDataAdapter.SelectCommand = new SqlCommand();
                sqlDataAdapter.SelectCommand.CommandText = sqlSelect;
                sqlDataAdapter.SelectCommand.Connection = sqlConnection;

                //dataSet para almacenar la publicidad
                DataSet dataSet = new DataSet();

                //ejecutar query
                sqlDataAdapter.Fill(dataSet, "Publicidad");

                //cerrar conexion
                sqlDataAdapter.SelectCommand.Connection.Close();

                /*---------------------------------------------*/
                //obtener filas de dataset 
                DataRowCollection filas = dataSet.Tables["Publicidad"].Rows;

                List<Publicidad> listaPublicidad = new List<Publicidad>();

                foreach (DataRow fila in filas)
                {
                    Publicidad publicidad = new Publicidad();
                    publicidad.IdPublicidad = int.Parse(fila["idPublicidad"].ToString());
                    publicidad.Imagen = fila["imagen"].ToString();
                    publicidad.Enlace = fila["enlace"].ToString();

                    //agregar a la lista
                    listaPublicidad.Add(publicidad);
                }

                return listaPublicidad;
            }
            catch (SqlException) 
            {
                return null;
            }
        }
    }
}
