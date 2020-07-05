<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="AzPrueba.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

      <link rel="stylesheet" type="text/css" href="CreateUser.css"/>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentD" runat="server">

    <h1>
         Más Información sobre el Cliente: 
    </h1>
   <br />
    <section runat="server">

      
        <div>
            <asp:Label ID="UsuarioN" Text="Usuario: " AssociatedControlID="Usertxt" runat="server"></asp:Label>  

            <asp:Label ID="Usertxt" runat="server"></asp:Label>               
        </div>             


        <div>
            <asp:Label ID="NombreCli" Text="Cliente:" AssociatedControlID="txtCliente" runat="server"></asp:Label> 
            <asp:Label ID="txtCodCli" runat="server"  placeholder="Cliente" ForeColor="White"></asp:Label> 
            <asp:Label ID="txtCliente" runat="server"  placeholder="Cliente"></asp:Label> 
        </div>

        <div>
            <asp:Label ID="Repre" Text="Representante Legal: " AssociatedControlID="txtlegal" runat="server"></asp:Label> 
            <asp:Label ID="txtlegal" runat="server"  placeholder="Representante"></asp:Label>         
        </div>

        <div>
            <asp:Label ID="Dire" Text="Direccion: " AssociatedControlID="txtdire" runat="server"></asp:Label> 
            <asp:Label ID="txtdire" runat="server"></asp:Label>
        </div>

        <div>
            <asp:Label ID="Tel" Text="Telefono " AssociatedControlID="txttelefono" runat="server" ></asp:Label> 
            <asp:Label ID="txttelefono" runat="server" ></asp:Label>
        </div>

        <div>
            <asp:Label ID="Cedula" Text="Cedula" AssociatedControlID="txtcedula" runat="server" ></asp:Label> 
            <asp:Label ID="txtcedula" runat="server" ></asp:Label>
        </div>
         <div>
            <asp:Label ID="Nit" Text="Nit: " AssociatedControlID="txtnit" runat="server" ></asp:Label> 
            <asp:Label ID="txtnit" runat="server" ></asp:Label>
        </div>
       <div>
            <asp:Label ID="Correo" Text="Correo: " AssociatedControlID="txtcorreo" runat="server" ></asp:Label> 
            <asp:Label ID="txtcorreo" runat="server" ></asp:Label>
        </div>

    </section>
</asp:Content>
