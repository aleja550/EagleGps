using System;
using LogicLayer;
using Entities;
using System.Data.SqlClient;

namespace AzPrueba
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string CodUsuario = Request.QueryString["CodUsuario"];

                using (SqlConnection conexion = new SqlConnection("Data Source=AZDESAR10;Initial Catalog=AzSmart;Persist Security Info=True;User ID=sa; Password=123"))
                {
                    string query = "select CodUsuario, Usuario, CodCli, NombreCliente,RepreLegal,Direccion, Telefono, CedulaCiu, Nit, Correo from UsuarioT " +
                    "join Cliente on CodCli = FkCodCli where CodUsuario like '" + CodUsuario + "';";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        conexion.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtCodCli.Text = reader["CodCli"].ToString();
                            Usertxt.Text = reader["Usuario"].ToString();
                            txtCliente.Text = reader["NombreCliente"].ToString();
                            txtlegal.Text = reader["RepreLegal"].ToString();
                            txtdire.Text = reader["Direccion"].ToString();
                            txttelefono.Text = reader["Telefono"].ToString();
                            txtcedula.Text = reader["CedulaCiu"].ToString();
                            txtnit.Text = reader["Nit"].ToString();
                            txtcorreo.Text = reader["Correo"].ToString();
                      
                        }
                        conexion.Close();
                        conexion.Dispose();
                    }
                }
            }
        }
    
    }
}