using System;
using LogicLayer;
using Entities;
using System.Data;

namespace AzPrueba
{
    public partial class Admin1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable TablaAdmin = new DataTable();
            SqlLogicDb DataBase = new SqlLogicDb();

            TablaAdmin = DataBase.ConsultaInfo();

            GridView1.DataSource = TablaAdmin;    
            GridView1.DataBind();
        }


        protected void ButtonC_Click1(object sender, EventArgs e)
        {
            Response.Redirect("CrearUser.aspx");
        }

        protected void Todos_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminClientes.aspx");

        }

        protected void ButtonB_Click(object sender, EventArgs e)
        {
            
            string NombreUsuariotxt = Buscartxt.Text;

            DataTable Buscar = new DataTable();
            SqlLogicDb DataBase = new SqlLogicDb();



            if(Buscar == null)
            {
                Response.Write("<script> alert(" + "'No existen datos'" + ") </script>");
            }
            else
            {
                Buscar = DataBase.Buscador(new UsuarioT
                {
                    NombreUsuario = NombreUsuariotxt

                });

                GridView1.DataSource = Buscar;
                GridView1.DataBind();
            }
        }
    }
}