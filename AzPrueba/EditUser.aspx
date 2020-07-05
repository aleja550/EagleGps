<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="AzPrueba.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" href="CreateUser.css" />
    <script src="validar.js" type="text/javascript"></script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentD" runat="server">


    <h1>Actualización Usuario </h1>

    <p>LLene por favor los siguientes campos: </p>

    <section runat="server">
        <asp:Label ID="lblResult" runat="server" ForeColor="Green"></asp:Label>

        <asp:ScriptManager ID="scrip" runat="server">
        </asp:ScriptManager>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>

                <div>
                    <asp:Label ID="Usuarios" Text="Lista de Usuarios" AssociatedControlID="DdlUsuario" runat="server"></asp:Label>
                    <asp:DropDownList ID="DdlUsuario" runat="server" OnSelectedIndexChanged="ButtonB_Click" AutoPostBack="true"></asp:DropDownList>
                </div>
                <hr />
                <div>
                    <asp:Label ID="CodCli" Text="Cliente: " AssociatedControlID="CodClitext" runat="server"></asp:Label>
                    <asp:Label ID="CodClitext" runat="server"></asp:Label>
                </div>
                <div>

                    <asp:Label ID="TipoUser" Text="Tipo Usuario " AssociatedControlID="DdlUserType" runat="server"></asp:Label>
                    <asp:DropDownList ID="DdlUserType" runat="server">

                        <asp:ListItem Selected="True" Value="Select">Seleccione</asp:ListItem>
                        <asp:ListItem Value="0">Administrador</asp:ListItem>
                        <asp:ListItem Value="1">Común</asp:ListItem>

                    </asp:DropDownList>

                </div>

                <div>
                    <asp:Label ID="Nombre" Text="Nombre:" AssociatedControlID="txtNombre" runat="server"></asp:Label>
                    <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre"></asp:TextBox>
                </div>

                <div>
                    <asp:Label ID="Apellido" Text="Apellido:" AssociatedControlID="txtApellido" runat="server"></asp:Label>
                    <asp:TextBox ID="txtApellido" runat="server" placeholder="Apellido"></asp:TextBox>
                </div>

                <div>
                    <asp:Label ID="Usuario" Text="Usuario: " AssociatedControlID="txtUsuario" runat="server"></asp:Label>
                    <asp:Label ID="txtUsuario" runat="server"></asp:Label>
                </div>

                <div>
                    <asp:Label ID="Pass" Text="Contraseña: " AssociatedControlID="txtPass" runat="server"></asp:Label>
                    <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
                </div>


            </ContentTemplate>

        </asp:UpdatePanel>

        <div class="button">

            <asp:Button ID="ButtonS" type="submit" runat="server" Text="Actualizar" OnClientClick="return edituserValid();" OnClick="ButtonS_Click1" />

            <asp:Button ID="ButtonDelete" type="submit" runat="server" Text="Eliminar" OnClick="ButtonDelete_Click" />

        </div>
    </section>

</asp:Content>
