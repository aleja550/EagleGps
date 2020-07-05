using System;
using LogicLayer;
using Entities;
using System.Data;
using System.Web.UI.WebControls;

namespace AzPrueba
{
    public partial class CreateVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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
            tabla = DataBase.VerifyPlaca(new Entities.Vehiculos
            {
                PlacaVehiculo = Placatxt.Text
            });


            if (tabla == null)
            {

                int CodigoUsuario = int.Parse(DdlUsuario.SelectedValue);
                int CodigoCliente = int.Parse(DdlCliente.SelectedValue);
                int CodigoEquipogps = int.Parse(DdlImei.SelectedValue);

                int Tabla;


                Tabla = DataBase.CrearVehiculos(new Entities.Vehiculos
                {
                    PlacaVehiculo = Placatxt.Text,
                    MarcaVehiculo = Marcatxt.Text,
                    ColorVehiculo = Colortxt.Text,
                    ModeloVehiculo = Modelotxt.Text,
                    CilindrajeVehiculo = int.Parse(Cilindrajetxt.Text),
                    FkCodCli = CodigoCliente,
                    FkCodUsuario = CodigoUsuario,
                    FkCodigoGps = CodigoEquipogps
                });

                Response.Redirect("Vehiculos.aspx");
            }
            else
            {
                Response.Write("<script> alert(" + "'El número de Placa ingresado ya está activo. Ingrese otro.'" + ") </script>");

            }
        }
        
        protected void ButtonB_Click(object sender, EventArgs e)
        {
            SqlLogicDb DataBase = new SqlLogicDb();
            DataTable Tabla = new DataTable();
            int id = int.Parse(DdlCliente.SelectedValue);
            Tabla = DataBase.ConsultarUsuariosdeunCliente(id);

            DdlUsuario.DataSource = Tabla;
            DdlUsuario.DataTextField = "Usuario";
            DdlUsuario.DataValueField = "CodUsuario";
            DdlUsuario.DataBind();
            DdlUsuario.Items.Insert(0, "Seleccione");
        }

        protected void ButtonO_Click(object sender, EventArgs e)
        {
            SqlLogicDb DataBase = new SqlLogicDb();
            DataTable Tabla = new DataTable();
            int id = int.Parse(DdlCliente.SelectedValue);
            Tabla = DataBase.ConsultarEquiposdeunCliente(id);

            DdlImei.DataSource = Tabla;
            DdlImei.DataTextField = "Imei";
            DdlImei.DataValueField = "CodigoGps";
            DdlImei.DataBind();
            DdlImei.Items.Insert(0, "Seleccione");
        }
    }
}