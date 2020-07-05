using System;
using LogicLayer;
using Entities;
using System.Data;

namespace AzPrueba
{
    public partial class EditSim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EdittoshowSim();
            }

        }

        public void EdittoshowSim()
        {

            string NumSim = Request.QueryString["SimCard"];

            SqlLogicDb DataBase = new SqlLogicDb();
            DataTable Tabla = DataBase.ConsultarSimEdit(NumSim);

            CodClitext.Text = Tabla.Rows[0]["NombreCliente"].ToString();
            txtNumeroSimCard.Text = Tabla.Rows[0]["NumSim"].ToString();
            DdlSimType.DataTextField = Tabla.Rows[0]["Operador"].ToString();
            CodSimtext.Text = Tabla.Rows[0]["CodSim"].ToString();
        }





        protected void ButtonS_Click1(object sender, EventArgs e)
        {
            string NumSim = Request.QueryString["SimCard"];

            string operadortxt = Convert.ToString(DdlSimType.SelectedItem);
   
           

            int Tabla;
            SqlLogicDb DataBase = new SqlLogicDb();

            Tabla = DataBase.EditarSimCard(new SimCard
            {
                CodSim = int.Parse(CodSimtext.Text),
                Operador = operadortxt,
                NumSim = long.Parse(txtNumeroSimCard.Text)
               
            });



            Response.Redirect("SimCards.aspx");

        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            string NumSim = Request.QueryString["SimCard"];

            int Usuario;
            SqlLogicDb Database = new SqlLogicDb();

            Usuario = Database.EliminarSimCard(new SimCard
            {
                CodSim = int.Parse(CodSimtext.Text)
            });

            Response.Redirect("SimCards.aspx");
        }
    }
}