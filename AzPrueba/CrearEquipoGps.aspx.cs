using System;
using LogicLayer;
using Entities;
using System.Data;
using System.Web.UI.WebControls;

namespace AzPrueba
{
    public partial class CrearEquipoGps : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GetClients();
              
            }

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
            DdlCliente.Items.Insert(0, new ListItem("Seleccione", "0"));
        }

        protected void ButtonS_Click1(object sender, EventArgs e)
        {
            SqlLogicDb DataBase = new SqlLogicDb();

            DataTable tabla = new DataTable();
            tabla = DataBase.VerifyImei(new EquipoGps
            {
                Imei = long.Parse(Imeitxt.Text)
            });

            if (tabla == null)
            {

                int CodigoSimtxt = int.Parse(DdlNumero.SelectedValue);
                int CodigoClientetxt = int.Parse(DdlCliente.SelectedValue);

                int Tabla;


                Tabla = DataBase.CrearEquipoGps(new EquipoGps
                {
                    Imei = long.Parse(Imeitxt.Text),
                    Serial = Serialtxt.Text,
                    FkCodCli = CodigoClientetxt,
                    FkCodSim = CodigoSimtxt                 
                });
                Response.Redirect("EquipoGps.aspx");
            }
            else
            {
                Response.Write("<script> alert(" + "'El número de Imei ingresado ya está activo. Ingrese otro.'" + ") </script>");

            }
        }

        protected void ButtonB_Click(object sender, EventArgs e)
        {
            SqlLogicDb DataBase = new SqlLogicDb();
            DataTable Tabla = new DataTable();
            int id = int.Parse(DdlCliente.SelectedValue);
            Tabla = DataBase.ConsultarNumerosSimCard(id);

            DdlNumero.DataSource = Tabla;
            DdlNumero.DataTextField = "NumSim";
            DdlNumero.DataValueField = "CodSim";
            DdlNumero.DataBind();
            DdlNumero.Items.Insert(0, "Seleccione");
        }
    }
}