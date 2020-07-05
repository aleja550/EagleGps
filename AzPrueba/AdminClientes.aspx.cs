using System;
using LogicLayer;
using Entities;
using System.Data;

namespace AzPrueba
{
    public partial class AdminClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable TablaAdmin = new DataTable();
            SqlLogicDb DataBase = new SqlLogicDb();

            TablaAdmin = DataBase.ConsultarCliente();

            GridView1.DataSource = TablaAdmin;
            GridView1.DataBind();
        }

        protected void ButtonC_Click1(object sender, EventArgs e)
        {
            Response.Redirect("CrearCliente.aspx");
        }

        protected void Todos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin1.aspx");
        }
    }
}