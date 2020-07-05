using System;
using LogicLayer;
using Entities;
using System.Data;
using System.Web.UI.WebControls;
using System.Drawing;

namespace AzPrueba
{
    public partial class CrearUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                GetClients();
            ConsultarImagenTemplate();
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
            tabla = DataBase.VerifyUser(new UsuarioT
            {
                Usuario = Usuariotxt.Text
            });

            if (tabla == null)
            {
                string nombretxt = txtNombreUsuario.Text;
                string apellidotxt = txtApellido.Text;
                string usertext = Usuariotxt.Text;
                string clavetxt = Passtxt.Text;
                byte TipoUsertxt = byte.Parse(DdlUserType.SelectedValue);
                int CodigoCliente = int.Parse(DdlCliente.SelectedValue);
     

                //Obtener datos de la imagen
                int Tamanio = fuploadImagen.PostedFile.ContentLength; // Devolver el tamaño de la imagen que el usuario esta enviando.
                byte[] ImagenOriginal = new byte[Tamanio];
                fuploadImagen.PostedFile.InputStream.Read(ImagenOriginal, 0, Tamanio);
                Bitmap ImagenOriginalBinaria = new Bitmap(fuploadImagen.PostedFile.InputStream);

                //Crera una imagen Thumnail
                System.Drawing.Image imagenredimensionada;          
                int Tamanioredimensinado = 200;
                imagenredimensionada = redimensionarimagen(ImagenOriginalBinaria, Tamanioredimensinado);
                byte[] bImagenredimensionada = new byte[Tamanioredimensinado];
                ImageConverter convertidor = new ImageConverter();
                bImagenredimensionada = (byte[])convertidor.ConvertTo(imagenredimensionada, typeof(byte[]));
           
                int TablaUsuario;

                TablaUsuario = DataBase.CrearUsuario(new UsuarioT
                {
                    NombreUsuario = nombretxt,
                    Apellido = apellidotxt,
                    Usuario = usertext,
                    Password = clavetxt,
                    TipoUser = TipoUsertxt,
                    FkCodCli = CodigoCliente,
                    Avatar = bImagenredimensionada,
                    CodigoTemplate = byte.Parse(ListThemes.SelectedValue)              
                });

                string ImagenDataURL64 = "data:image/jpg;base64," + Convert.ToBase64String(ImagenOriginal);

                ConsultarImagenTemplate();


                Response.Redirect("Admin1.aspx");
            }  
            else
            {
                Response.Write("<script> alert(" + "'El usuario ya ha sido creado. Por favor escoja otro usuario'" + ") </script>");

            }

        }

        private System.Drawing.Image redimensionarimagen(System.Drawing.Image ImagenOriginal, int Alto)
        {
            var Radio = (double)Alto / ImagenOriginal.Height;
            var NuevoAncho = (int)(ImagenOriginal.Width * Radio);
            var NuevoAlto = (int)(ImagenOriginal.Height * Radio);
            var NuevaImagenRedimensionada = new Bitmap(NuevoAncho, NuevoAlto);
            var g = Graphics.FromImage(NuevaImagenRedimensionada);
            g.DrawImage(ImagenOriginal, 0, 0, NuevoAncho, NuevoAlto);
            return NuevaImagenRedimensionada;
        }

        protected void ConsultarImagenTemplate()
        {
            DataTable TemplatesBD = new DataTable();
            SqlLogicDb DataBase = new SqlLogicDb();

            TemplatesBD = DataBase.ConsultarTemplate();

            var datos = TemplatesBD.AsEnumerable();

            foreach (DataRow row in datos)
            {

                string strBase64 = Convert.ToBase64String(row.Field<byte[]>(1));
                var strValue = row.Field<byte>(0).ToString();

                ListThemes.Items.Add(new ListItem(
                    $"<img class='size' src='data: image / jpg; base64,{strBase64}' />", 
                    strValue));
            }

            //byte[] bImagen = (byte[])TemplatesBD.Rows[0].ItemArray[1];

            

            //ListThemes.DataSource = TemplatesBD;
            //ListThemes.DataTextField = "TituloTemplate";
            //ListThemes.DataValueField = "CodigoTemplate";

        
            //ListThemes.DataBind();

        }
                      
        protected void ButtonCrear_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearCliente.aspx");
        }


    }
}