using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AzPrueba
{
    public partial class Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string firstname = Convert.ToString(Session["Usuario"]);
            Label1.Text = "   Bienvenido a tu Dashboard " + firstname;

        }

        
    }
}