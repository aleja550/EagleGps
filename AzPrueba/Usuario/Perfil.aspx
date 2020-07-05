<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/SiteUsuario.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="AzPrueba.Usuario.Perfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" href="../CreateUser.css" />
    <script src="../validar.js" type="text/javascript"></script>


</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentD" runat="server">

    <asp:Label ID="Label1" runat="server" Font-Bold="true" Font-Size="Large" ></asp:Label>

     <asp:Label ID="Label2" runat="server" Font-Bold="true" Font-Size="Large" ></asp:Label>
    
    <br />

    <p>Estos son sus datos: </p>

    <section runat="server" >
        <asp:Label ID="lblResult" runat="server" ForeColor="Green"></asp:Label>

        <asp:ScriptManager ID="scrip" runat="server">
        </asp:ScriptManager>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>


                <div>
                    <asp:Label ID="CodCli" Text="Cliente: " AssociatedControlID="CodClitext" runat="server"></asp:Label>
                    <asp:Label ID="CodClitext" runat="server"></asp:Label>
                </div>
                <div>

                    <asp:Label ID="TipoUser" Text="Tipo Usuario: " AssociatedControlID="DdlUserType" runat="server"></asp:Label>
                    <asp:Label ID="DdlUserType" runat="server"> </asp:Label>

                </div>

                <div>
                    <asp:Label ID="Nombre" Text="Nombre:" AssociatedControlID="txtNombre" runat="server"></asp:Label>
                    <asp:Label ID="txtNombre" runat="server" placeholder="Nombre"></asp:Label>
                </div>

                <div>
                    <asp:Label ID="Apellido" Text="Apellido:" AssociatedControlID="txtApellido" runat="server"></asp:Label>
                    <asp:Label ID="txtApellido" runat="server" placeholder="Apellido"></asp:Label>
                </div>

                <div>
                    <asp:Label ID="Usuario" Text="Usuario: " AssociatedControlID="txtUsuario" runat="server"></asp:Label>
                    <asp:Label ID="txtUsuario" runat="server"></asp:Label>
                </div>

                <div>
                    <asp:Label ID="Avatar" Text="Avatar: " runat="server" Font-Bold="true"></asp:Label>
                    <img class="img-circle" src="data:image/png;base64,<%=Session["Avatar"]%>"/>
                </div>
            </ContentTemplate>

        </asp:UpdatePanel>

    </section>

</asp:Content>
