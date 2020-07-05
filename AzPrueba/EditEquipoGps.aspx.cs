using System;
using LogicLayer;
using Entities;
using System.Data;

namespace AzPrueba
{
    public partial class EditEquipoGps : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EdittoshowEquipoGps();
            }
        }

        public void EdittoshowEquipoGps()
        {

            string Imei = Request.QueryString["EquipoGps"];

            SqlLogicDb DataBase = new SqlLogicDb();
            DataTable Tabla = DataBase.ConsultarGpsEdit(Imei);

            CodigoGpstext.Value = Tabla.Rows[0]["CodigoGps"].ToString();
            Imeitxt.Text = Tabla.Rows[0]["Imei"].ToString();
            Serialtxt.Text = Tabla.Rows[0]["Serial"].ToString();
            CodClitext.Text = Tabla.Rows[0]["NombreCliente"].ToString();           
            NumSimtxt.Text = Tabla.Rows[0]["NumSim"].ToString();
            
        }

        protected void ButtonS_Click1(object sender, EventArgs e)
        {
            string Imei = Request.QueryString["EquipoGps"];

            int Tabla;
            SqlLogicDb DataBase = new SqlLogicDb();

            Tabla = DataBase.EditEquipoGps(new EquipoGps
            {
                CodigoGps = int.Parse(CodigoGpstext.Value),
                Imei = long.Parse(Imeitxt.Text),
                Serial = Serialtxt.Text,          
            });
  
            Response.Redirect("EquipoGPS.aspx");
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            string Imei = Request.QueryString["EquipoGps"];

            int Usuario;
            SqlLogicDb Database = new SqlLogicDb();

            Usuario = Database.EliminarEquipoGps(new EquipoGps
            {
               CodigoGps = int.Parse(CodigoGpstext.Value)
            });

            Response.Redirect("EquipoGPS.aspx");
        }
    }
}