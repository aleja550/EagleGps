using System;
using LogicLayer;
using Entities;
using System.Data;

namespace AzPrueba
{
    public partial class Login : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
    

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            
            DataTable TablaUsuario = new DataTable();
            SqlLogicDb DataBase = new SqlLogicDb();

       

            TablaUsuario = DataBase.VerifyLogin(new UsuarioT {
                Usuario = txtUsuario.Text,
                Password = txtClave.Text,                         
        });

            if (TablaUsuario == null)
            {
                Response.Write("<script> alert(" + "'Verifique los datos'" + ") </script>");
                Session["Usuario"] = ErrorPage;
            }
            else
            {
                Session["CodUsuario"] = TablaUsuario.Rows[0].ItemArray[0].ToString();
                Session["Usuario"] = txtUsuario.Text;
                Session["Clave"] = txtClave.Text;
                Session["TipoUser"] = TablaUsuario.Rows[0].ItemArray[3].ToString();
                byte[] bImagen = (byte[])TablaUsuario.Rows[0].ItemArray[4];                
                Session["Avatar"] = Convert.ToBase64String(bImagen);
                Session["FkCodigoTemplate"] = TablaUsuario.Rows[0].ItemArray[5].ToString();



                if (TablaUsuario.Rows[0].ItemArray[3].ToString() == "False")
                {
                    Response.Redirect("Default.aspx?Usuario=" + txtUsuario.Text);
                }
                else
                {
                    Response.Redirect("~/Usuario/DefaultUsuario.aspx?Usuario=" + txtUsuario.Text);
                }

            }
            

           
        }
    }
}