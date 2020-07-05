<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="AddTemplateBD.aspx.cs" Inherits="AzPrueba.AddTemplateBD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <title>Agregar Estilos</title>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentD" runat="server">

     <div class="container">

        <div class="row">

            <div class="col-md-4 col-md-offset-4">
                Imagen Agregada:
                <br />
                <asp:Image ID="imgPreview" runat="server"  ImageUrl="../img/imagen.jpg" Width="200"/>
                <br />
                <br />
                Archivo:
                <asp:FileUpload ID="fuploadImagen" accept=".jpg" runat="server" CssClass="form-control"/>
                <br />
                Titulo de imagen:
                <asp:TextBox ID="titulotxt" runat="server"></asp:TextBox>
                <br />               
                <asp:Button ID="btnSubir" runat="server" Text="Adjuntar Imagen" CssClass="btn btn-success" OnClick="btnSubir_Click"/>
            </div>

        </div>

        <div class="row">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>

                </ItemTemplate>
            </asp:Repeater>

        </div>

    </div>

</asp:Content>
