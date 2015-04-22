using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using HPV.Core.Dominio.Pagina;
using System.Data.SqlClient;
using System.Data;
using HPV.Core.Dominio;


namespace HPV.Core.AccesoDatos
{
    public class PaginaAccesoDatos
    {
        private String stringConexion;

        public PaginaAccesoDatos()
        {
            this.stringConexion = ConfigurationManager.ConnectionStrings["BDPuertoViejo"].ConnectionString;
        }

        /**
         * Metodo para obterner informacion de la pagina segun el ID de la pagina
         **/
        public Pagina obtenerPagina(int idPagina)
        {
            try
            {
                //cobexion con BD
                SqlConnection sqlConnection = new SqlConnection(this.stringConexion);

                //query
                //string sqlSelect = "SELECT * FROM Pagina WHERE (idPublicidad = " + idPagina + ")";
                string sqlSelect = "SELECT p.idPagina, s.descripcion, i.imagen FROM Pagina p,Seccion s,Imagen i WHERE ((p.idPagina = 1 ) AND (p.idPagina = s.idPagina AND s.idImagen = i.idImagen) )";

                //adapter
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                //configurar adapter (select)
                sqlDataAdapter.SelectCommand = new SqlCommand();
                sqlDataAdapter.SelectCommand.CommandText = sqlSelect;
                sqlDataAdapter.SelectCommand.Connection = sqlConnection;

                //dataSet para almacenar resultados
                DataSet dataSet = new DataSet();

                //ejecutar query
                sqlDataAdapter.Fill(dataSet, "Imagen");

                //cerrar conexion
                sqlDataAdapter.SelectCommand.Connection.Close();
                Pagina pagina = new Pagina(); 
                DataRowCollection filas = dataSet.Tables["Imagen"].Rows;
                foreach (DataRow fila in filas)
                {
                    pagina.IdPagina = int.Parse(fila["idPagina"].ToString());
                    pagina.Imagen =  (Imagen) fila["imagen"];
                    pagina.Descripcion = fila["descripcion"].ToString();
                }
                return pagina;
            }
            catch (SqlException)
            {
                return null;
            }

        }
    }
}
