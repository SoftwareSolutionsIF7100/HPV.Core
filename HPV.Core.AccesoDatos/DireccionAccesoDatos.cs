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
    public class DireccionAccesoDatos
    {
        private String stringConexion;

        public DireccionAccesoDatos()
        {
            this.stringConexion = ConfigurationManager.ConnectionStrings["BDPuertoViejo"].ConnectionString;
        }

        public Direccion obtenerDireccion()
        {
            try
            {
                //conexion a base de datos
                SqlConnection sqlConnection = new SqlConnection(this.stringConexion);

                //define la consulta
                string sqlSelect = "SELECT top 1 * FROM direccion ORDER BY idDireccion ASC";

                //crea un adapter
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                //configurar el adapter (select)
                sqlDataAdapter.SelectCommand = new SqlCommand();
                sqlDataAdapter.SelectCommand.CommandText = sqlSelect;
                sqlDataAdapter.SelectCommand.Connection = sqlConnection;

                //dataSet para almacenar resultados
                DataSet dataSetGenders = new DataSet();

                //ejecutar consulta
                sqlDataAdapter.Fill(dataSetGenders, "Direccion");

                //cerrar conexion
                sqlDataAdapter.SelectCommand.Connection.Close();

                /*---------------------------------------------*/
                //obtenere filas de data set 
                DataRowCollection rows = dataSetGenders.Tables["Direccion"].Rows;

                //crear objeto
                Direccion direccion = new Direccion();

                foreach (DataRow currentRow in rows)
                {
                    //asignar los valores a objetos
                    direccion.IdDireccion = int.Parse(currentRow["idDireccion"].ToString());
                    direccion.Descripcion = currentRow["descripcion"].ToString();
                    direccion.Latitud = float.Parse(currentRow["latitud"].ToString());
                    direccion.Longitud = float.Parse(currentRow["longitud"].ToString());
                }

                return direccion;
            }
            catch (SqlException) 
            {
                return null;
            }
        }

        //actualizar Direccion
        public int modificarDireccion(Direccion direccion)
        {
            //cooneccion con bd
            SqlConnection myConnection = new SqlConnection(this.stringConexion);

            //query
            string sqlStoredProcedure = "sp_direccion_modificar";
            SqlCommand sqlCommand = new SqlCommand(sqlStoredProcedure, myConnection);

            //configuracion sqlcommand 
            sqlCommand.CommandType = CommandType.StoredProcedure;

            //crear parametros
            sqlCommand.Parameters.Add(new SqlParameter("@idDireccion", direccion.IdDireccion));
            sqlCommand.Parameters.Add(new SqlParameter("@descripcion", direccion.Descripcion));
            sqlCommand.Parameters.Add(new SqlParameter("@latitud", direccion.Latitud));
            sqlCommand.Parameters.Add(new SqlParameter("@longitud", direccion.Longitud));

            try
            {
                //ejcuta sp
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
    }
}
