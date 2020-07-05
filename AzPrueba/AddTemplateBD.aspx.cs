using System;
using System.Drawing;
using LogicLayer;
using Entities;

namespace AzPrueba
{
    public partial class AddTemplateBD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubir_Click(object sender, EventArgs e)
        {
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

            //Insertar en la base de datos
            int TablaUsuario;

            TablaUsuario = DataBase.CrearTemplate(new Template
            {
                ImagenTemplate = bImagenredimensionada,
                TituloTemplate = titulotxt.Text
            });


            string ImagenDataURL64 = "data:image/jpg;base64," + Convert.ToBase64String(bImagenredimensionada);
            imgPreview.ImageUrl = ImagenDataURL64;
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