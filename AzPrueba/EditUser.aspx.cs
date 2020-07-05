using System;
using LogicLayer;
using Entities;
using System.Data;

namespace AzPrueba
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)                
            {
                GetUsers();
                EditUser();
                      
            }                  
        }

        public void EditUser()
        {
            int id = int.Parse(Request.QueryString["CodUsuario"]);

            SqlLogicDb DataBase = new SqlLogicDb();
            DataTable Tabla = DataBase.ConsultaUser(id);

            txtNombre.Text = Tabla.Rows[0]["NombreUsuario"].ToString();
            txtApellido.Text = Tabla.Rows[0]["Apellido"].ToString();
            txtUsuario.Text = Tabla.Rows[0]["Usuario"].ToString();
            txtPass.Text = Tabla.Rows[0]["Contraseña"].ToString();
            DdlUserType.DataValueField = Tabla.Rows[0]["TipoUser"].ToString();
            CodClitext.Text = Tabla.Rows[0]["NombreCliente"].ToString();
        }

        protected void ButtonS_Click1(object sender, EventArgs e)
        {

            string CodUsuario = Request.QueryString["CodUsuario"];

            byte TipoUsertxt = byte.Parse(DdlUserType.SelectedValue);


            bool TablaUsuario;
            SqlLogicDb DataBase = new SqlLogicDb();

            TablaUsuario = DataBase.EditarUsuario(new UsuarioT
            {
                NombreUsuario = txtNombre.Text,
                Apellido = txtApellido.Text,
                Password = txtPass.Text,
                TipoUser = TipoUsertxt,
                CodUsuario = int.Parse(CodUsuario)
            });

                lblResult.Text = "Employee Data Saved!!";
            
            Response.Redirect("Admin1.aspx");
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            string CodUsuario = Request.QueryString["CodUsuario"];
            int Usuario;
            SqlLogicDb Database = new SqlLogicDb();

            Usuario = Database.EliminarUsuario(new UsuarioT
            {
                CodUsuario = int.Parse(CodUsuario)
            });

            Response.Redirect("Admin1.aspx");
        }

        public void GetUsers()
        {
            SqlLogicDb DataBase = new SqlLogicDb();
            DataTable Tabla = new DataTable();
            Tabla = DataBase.ConsultarNameUsuario();

            DdlUsuario.DataSource = Tabla;
            DdlUsuario.DataTextField = "Usuario";
            DdlUsuario.DataValueField = "CodUsuario";
            DdlUsuario.DataBind();
            DdlUsuario.Items.Insert(0, "Seleccione");    
        }

        protected void ButtonB_Click(object sender, EventArgs e)
        {
           int id = int.Parse(DdlUsuario.SelectedValue);

            SqlLogicDb DataBase = new SqlLogicDb();
            DataTable Tabla = DataBase.ConsultaUser(id);

            txtNombre.Text = Tabla.Rows[0]["NombreUsuario"].ToString();
            txtApellido.Text = Tabla.Rows[0]["Apellido"].ToString();
            txtUsuario.Text = Tabla.Rows[0]["Usuario"].ToString();
            txtPass.Text = Tabla.Rows[0]["Contraseña"].ToString();
            DdlUserType.DataValueField = Tabla.Rows[0]["TipoUser"].ToString();
            CodClitext.Text = Tabla.Rows[0]["NombreCliente"].ToString();
                     
        }
    }
 }