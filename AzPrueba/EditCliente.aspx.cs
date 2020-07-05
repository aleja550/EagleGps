using System;
using LogicLayer;
using Entities;
using System.Data.SqlClient;
using System.Data;

namespace AzPrueba
{
    public partial class EditCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EdittoshowClientes();
            }
        }

        public void EdittoshowClientes()
        {
            string NombreCliente = Request.QueryString["Cliente"];

            SqlLogicDb DataBase = new SqlLogicDb();
            DataTable Tabla = DataBase.ConsultarClientetoEdit(NombreCliente);

            if (Tabla.Rows.Count > 0)
            {
                txtCliente.Text = Tabla.Rows[0]["NombreCliente"].ToString();
                txtlegal.Text = Tabla.Rows[0]["RepreLegal"].ToString();
                txtdire.Text = Tabla.Rows[0]["Direccion"].ToString();
                txttelefono.Text = Tabla.Rows[0]["Telefono"].ToString();
                idtxt.Text = Tabla.Rows[0]["Nit"].ToString();
                if (Tabla.Rows[0]["Nit"] == DBNull.Value)
                    idtxt.Text = Tabla.Rows[0]["CedulaCiu"].ToString();                             
                txtcorreo.Text = Tabla.Rows[0]["Correo"].ToString();
            }
        }

        protected void ButtonUpdate_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            string NombreCliente = Request.QueryString["Cliente"];

            //string IdNit = null;
            //long IdCedula = 0;

            //if (idtxt.Text == null)
            //    IdNit = idtxt.Text;

            //else if (long.Parse(idtxt.Text) == 0)
            //    IdCedula = Convert.ToInt64(idtxt.Text);

            bool Tabla;
            SqlLogicDb DataBase = new SqlLogicDb();

            Tabla = DataBase.EditarCliente(new Cliente
            {
                Nit = idtxt.Text,
                CedulaCiu = long.Parse(idtxt.Text),
                NombreCliente = txtCliente.Text,
                RepreLegal = txtlegal.Text,
                Dirección = txtdire.Text,
                Telefono = long.Parse(txttelefono.Text),
                Correo = txtcorreo.Text

            });

            Response.Redirect("Admin1.aspx");
        }

        protected void ButtonDelete_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            string NombreCliente = Request.QueryString["Cliente"];
            int Cliente;
            SqlLogicDb Database = new SqlLogicDb();

            Cliente = Database.EliminarCliente(new Cliente
            {
                NombreCliente = txtCliente.Text
            });

            Response.Redirect("AdminClientes.aspx");
        }
    }
}
