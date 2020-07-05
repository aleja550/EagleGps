using System;
using LogicLayer;
using Entities;
using System.Data;
using System.Web.UI.WebControls;
using System.Drawing;

namespace AzPrueba
{
    public partial class EditProfileAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BringUser();
                GetTemplates();
            }

        }


        protected void ButtonB_Click(object sender, EventArgs e)
        {
            byte codigo = byte.Parse(DdlTema.SelectedValue);

            SqlLogicDb DataBase = new SqlLogicDb();
            DataTable TemplatesBD = DataBase.ConsultarTemplatebyid(codigo);

            repeater1.DataSource = TemplatesBD;
            repeater1.DataBind();
            
        }

        protected void BringUser()
        {
            int id = Convert.ToInt32(Session["CodUsuario"]);

            SqlLogicDb DataBase = new SqlLogicDb();
            DataTable Tabla = DataBase.ConsultaUser(id);

            txtNombre.Text = Tabla.Rows[0]["NombreUsuario"].ToString();
            txtApellido.Text = Tabla.Rows[0]["Apellido"].ToString();
            txtUsuario.Text = Tabla.Rows[0]["Usuario"].ToString();
            txtPass.Text = Tabla.Rows[0]["Contraseña"].ToString();
            CodClitext.Text = Tabla.Rows[0]["NombreCliente"].ToString();
        }

        public void GetTemplates()
        {
            SqlLogicDb DataBase = new SqlLogicDb();
            DataTable Tabla = new DataTable();
            Tabla = DataBase.ConsultarTemplate();

            DdlTema.DataSource = Tabla;
            DdlTema.DataTextField = "TituloTemplate";
            DdlTema.DataValueField = "CodigoTemplate";
            DdlTema.DataBind();

        }

        protected void ButtonS_Click1(object sender, EventArgs e)
        {
            int CodUsuario = Convert.ToInt32(Session["CodUsuario"]);
            SqlLogicDb DataBase = new SqlLogicDb();

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

            bool TablaUsuario;

            TablaUsuario = DataBase.EditarUsuario(new UsuarioT
            {
                NombreUsuario = txtNombre.Text,
                Apellido = txtApellido.Text,
                Password = txtPass.Text,
                CodUsuario = CodUsuario,
                Avatar = ImagenOriginal,
                CodigoTemplate =  byte.Parse(DdlTema.SelectedValue)           
            });

            string ImagenDataURL64 = "data:image/jpg;base64," + Convert.ToBase64String(bImagenredimensionada);


            Response.Redirect("ProfileAdmin.aspx");
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


    }
}