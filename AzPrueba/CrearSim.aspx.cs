using System;
using LogicLayer;
using Entities;
using System.Data;
using System.Web.UI.WebControls;

namespace AzPrueba
{
    public partial class CrearSim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                GetClients();
        }

        private void GetClients()
        {
            SqlLogicDb DataBase = new SqlLogicDb();
            DataTable Tabla = new DataTable();
            Tabla = DataBase.ConsultarNameCliente();

            DdlCliente.DataSource = Tabla;
            DdlCliente.DataTextField = "NombreCliente";
            DdlCliente.DataValueField = "CodCli";
            DdlCliente.DataBind();
            DdlCliente.Items.Insert(0, new ListItem("Seleccione", "0", true));
        }

        protected void ButtonS_Click1(object sender, EventArgs e)
        {
            SqlLogicDb DataBase = new SqlLogicDb();

            DataTable tabla = new DataTable();
            tabla = DataBase.VerifySimCard(new SimCard
            {
                NumSim = long.Parse(txtNumeroSimCard.Text)
            });

            if (tabla == null)
            {

                string Operadortxt = Convert.ToString(DdlSimType.SelectedItem);
                int CodigoClientetxt = int.Parse(DdlCliente.SelectedValue);

                int Tabla;


                Tabla = DataBase.CrearSimCard(new SimCard
                {
                    Operador = Operadortxt,
                    NumSim = long.Parse(txtNumeroSimCard.Text),
                    FkCodCli = CodigoClientetxt

                });
                Response.Redirect("SimCards.aspx");
            }
            else
            {
                Response.Write("<script> alert(" + "'El número de SimCard ingresado ya está activo. Ingrese otro.'" + ") </script>");

            }
        }
    }
}