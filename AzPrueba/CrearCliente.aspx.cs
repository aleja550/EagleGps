using System;
using LogicLayer;
using Entities;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace AzPrueba
{
    public partial class CrearCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {          
            string nombretxt = txtNombre.Text;
            string representantetxt = txtRepresentante.Text;
            string direcciontxt = txtDireccion.Text;

            string IdNit = null;
            long IdCedula = 0;

            if (DdlID.SelectedValue == "0")
                IdNit = idtxt.Text;
            else if (DdlID.SelectedValue == "1")
                IdCedula = Convert.ToInt64(idtxt.Text);

            

            

            int TablaCliente;
            SqlLogicDb DataBase = new SqlLogicDb();

            TablaCliente = DataBase.CrearCliente(new Cliente
            {
                NombreCliente = nombretxt,
                RepreLegal = representantetxt,
                Dirección = direcciontxt,
                Telefono = long.Parse(txtTel.Text),  
                Nit = IdNit,
                CedulaCiu = IdCedula,      
                Correo = txtCorreo.Text
            });
     
          
                Response.Redirect("CrearUser.aspx");     
        }




    }
}