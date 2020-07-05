<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="EditCliente.aspx.cs" Inherits="AzPrueba.EditCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" href="CreateUser.css" />
    <script src="validar.js" type="text/javascript"></script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentD" runat="server">
    <h1>Actualización Cliente: 
    </h1>
    <br />
    <section runat="server">

        <div>
            <asp:Label ID="IdLabel" Text="Identificación" AssociatedControlID="Idtxt" runat="server"></asp:Label>
            <asp:Label ID="idtxt" runat="server"></asp:Label>
        </div>


        <div>
            <asp:Label ID="NombreCli" Text="Cliente" AssociatedControlID="txtCliente" runat="server"></asp:Label>
            <asp:TextBox ID="txtCliente" runat="server" placeholder="Cliente"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Repre" Text="Representante Legal: " AssociatedControlID="txtlegal" runat="server"></asp:Label>
            <asp:TextBox ID="txtlegal" runat="server" placeholder="Representante"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Dire" Text="Direccion: " AssociatedControlID="txtdire" runat="server"></asp:Label>
            <asp:TextBox ID="txtdire" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Tel" Text="Telefono " AssociatedControlID="txttelefono" runat="server"></asp:Label>
            <asp:TextBox ID="txttelefono" runat="server"></asp:TextBox>
        </div>


        <div>
            <asp:Label ID="Correo" Text="Correo: " AssociatedControlID="txtcorreo" runat="server"></asp:Label>
            <asp:TextBox ID="txtcorreo" runat="server"></asp:TextBox>
        </div>



        <div class="button">
            <asp:ImageButton ID="ButtonUpdate" runat="server" OnClientClick="return EditClientValidate();" OnClick="ButtonUpdate_Click" ImageUrl="../img/Editar.png" ToolTip="Actualizar Cliente" Width="50px" Height="50px" />
            <asp:ImageButton ID="ButtonDelete" runat="server" OnClick="ButtonDelete_Click" ImageUrl="../img/deletebutton.png" ToolTip="Actualizar Cliente" Width="70px" Height="50px" />
        </div>





    </section>

</asp:Content>
