using System;
using LogicLayer;
using Entities;
using System.Data;

namespace AzPrueba
{
    public partial class SimCards : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable Tabla = new DataTable();
            SqlLogicDb DataBase = new SqlLogicDb();

            Tabla = DataBase.ConsultaSims();

            GridView1.DataSource = Tabla;
            GridView1.DataBind();
        }

        protected void Todos_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminClientes.aspx");
        }

        protected void ButtonC_Click1(object sender, EventArgs e)
        {
            Response.Redirect("CrearSim.aspx");
        }
    }
}