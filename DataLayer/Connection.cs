using System;
using System.Data.SqlClient;

namespace DataLayer
{
    public class Connection
    {
        public SqlConnection CrearConexion()
        {
            SqlConnection conexion = new SqlConnection("Data Source=AZDESAR10;Initial Catalog=AzSmart;Persist Security Info=True;User ID=sa; Password=123");
            try
            {
                
                conexion.Open();
                
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            SqlConnection conexion = new SqlConnection("Data Source=AZDESAR10;Initial Catalog=AzSmart;Persist Security Info=True;User ID=sa; Password=123");

            try
            {
                conexion.Close();               
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return conexion;

        }
    }
}