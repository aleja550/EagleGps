using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AzPrueba.MasterPage
{
    public partial class SiteUsuario : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadStyleSheet();

            if (Session["Usuario"] == null || Session["Usuario"] != Session["Usuario"])

                Response.Redirect("/Login.aspx");

            if (!IsPostBack)
                if (Session["Usuario"] == null)
                    Response.Redirect("/Login.aspx");
        }

        protected void ButtonLogout_Click1(object sender, EventArgs e)
        {
            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("/Login.aspx");
            Response.AppendHeader("Cache-Control", "no-store");
        }

        protected void LoadStyleSheet()
        {
            switch (Session["FkCodigoTemplate"])
            {
                case "":
                    LinkCss.Attributes.Add("href", "Estilos/MasterStyle.css");
                    break;

                case "1":
                    LinkCss.Attributes.Add("href", "Estilos/MasterStyle.css");
                    break;

                case "2":
                    LinkCss.Attributes.Add("href", "Estilos/GreenTheme.css");
                    break;

                case "3":
                    LinkCss.Attributes.Add("href", "Estilos/YellowTheme.css");
                    break;
            }
        }
    }
}