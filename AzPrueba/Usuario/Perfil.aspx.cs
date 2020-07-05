using System;
using LogicLayer;
using Entities;
using System.Data;

namespace AzPrueba.Usuario
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string firstname = Convert.ToString(Session["Usuario"]);
            Label1.Text = "Perfil " + firstname;

            BringUser();
        }

        protected void BringUser()
        {
            int id = Convert.ToInt32(Session["CodUsuario"]);

            SqlLogicDb DataBase = new SqlLogicDb();
            DataTable Tabla = DataBase.ConsultaUser(id);

            txtNombre.Text = Tabla.Rows[0]["NombreUsuario"].ToString();
            txtApellido.Text = Tabla.Rows[0]["Apellido"].ToString();
            txtUsuario.Text = Tabla.Rows[0]["Usuario"].ToString();
            DdlUserType.Text = Tabla.Rows[0]["TipoUser"].ToString();

            if (Tabla.Rows[0]["TipoUser"].ToString() == "False")
            {
                DdlUserType.Text = "Administrador";
            }

            CodClitext.Text = Tabla.Rows[0]["NombreCliente"].ToString();


        }
    }
}