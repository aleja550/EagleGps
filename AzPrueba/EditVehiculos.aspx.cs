using System;
using LogicLayer;
using Entities;
using System.Data;

namespace AzPrueba
{
    public partial class EditVehiculos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EdittoshowVehiculos();
            }
        }

        public void EdittoshowVehiculos()
        {
            string PlacaVehiculo = Request.QueryString["Vehiculos"];

            SqlLogicDb DataBase = new SqlLogicDb();
            DataTable Tabla = DataBase.ConsultarVehiculosedit(PlacaVehiculo);

            if(Tabla.Rows.Count > 0)
            {

                VehiculoLabel.Text = Tabla.Rows[0]["CodigoVehiculo"].ToString();
                Placatxt.Text = Tabla.Rows[0]["PlacaVehiculo"].ToString();
                Marcatxt.Text = Tabla.Rows[0]["MarcaVehiculo"].ToString();
                Colortxt.Text = Tabla.Rows[0]["ColorVehiculo"].ToString();
                Modelotxt.Text = Tabla.Rows[0]["ModeloVehiculo"].ToString();
                Cilindrajetxt.Text = Tabla.Rows[0]["CilindrajeVehiculo"].ToString();
                Clientetxt.Text = Tabla.Rows[0]["NombreCliente"].ToString();
                Usuariotxt.Text = Tabla.Rows[0]["Usuario"].ToString();
                Imeitxt.Text = Tabla.Rows[0]["Imei"].ToString();
            }

        }

        protected void ButtonS_Click1(object sender, EventArgs e)
        {

            string Imei = Request.QueryString["EquipoGps"];

            int Tabla;
            SqlLogicDb DataBase = new SqlLogicDb();

            Tabla = DataBase.EditVehiculos(new Entities.Vehiculos
            {
                CodigoVehiculo = int.Parse(VehiculoLabel.Text),
                PlacaVehiculo = Placatxt.Text,
                MarcaVehiculo = Marcatxt.Text,
                ColorVehiculo = Colortxt.Text,
                ModeloVehiculo = Modelotxt.Text,
                CilindrajeVehiculo = int.Parse(Cilindrajetxt.Text)
            });

            Response.Redirect("Vehiculos.aspx");

        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            string Imei = Request.QueryString["EquipoGps"];

            int Usuario;
            SqlLogicDb Database = new SqlLogicDb();

            Usuario = Database.EliminarVehiculos(new Entities.Vehiculos
            {
                CodigoVehiculo = int.Parse(VehiculoLabel.Text)
            });

            Response.Redirect("Vehiculos.aspx");
        }
    }
}