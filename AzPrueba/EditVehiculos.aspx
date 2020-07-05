<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="EditVehiculos.aspx.cs" Inherits="AzPrueba.EditVehiculos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" href="CreateUser.css" />
    <script src="validar.js" type="text/javascript"></script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentD" runat="server">
    

    <h1>Actualización Vehiculos </h1>

    <p>LLene por favor los siguientes campos: </p>

    <section runat="server">

        <asp:ScriptManager ID="scrip" runat="server">
        </asp:ScriptManager>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <div>
                    <asp:Label ID="CodCli" Text="Cliente: " AssociatedControlID="Clientetxt" runat="server"></asp:Label>
                    <asp:Label ID="Clientetxt" runat="server"></asp:Label>
                </div>

                <div>
                    <asp:Label ID="UsuarioLabel" Text="Usuario: " AssociatedControlID="Usuariotxt" runat="server"></asp:Label>
                    <asp:Label ID="Usuariotxt" runat="server"></asp:Label>
                </div>

                <div>
                    <asp:Label ID="ImeiLabel" Text="EquipoGps: " AssociatedControlID="Imeitxt" runat="server"></asp:Label>
                    <asp:Label ID="Imeitxt" runat="server"></asp:Label>

                </div>

                <div>
                    <asp:Label ID="PlacaLabel" Text="Placa: " AssociatedControlID="Placatxt" runat="server"></asp:Label>
                    <asp:TextBox ID="Placatxt" runat="server"></asp:TextBox>
                    <asp:Label ID="VehiculoLabel" runat="server" Style="color: white"></asp:Label>
                </div>

                <div>
                    <asp:Label ID="MarcaLabel" Text="Marca: " AssociatedControlID="Marcatxt" runat="server"></asp:Label>
                    <asp:TextBox ID="Marcatxt" runat="server"></asp:TextBox>
                </div>

                <div>
                    <asp:Label ID="ColorLabel" Text="Color: " AssociatedControlID="Colortxt" runat="server"></asp:Label>
                    <asp:TextBox ID="Colortxt" runat="server"></asp:TextBox>
                </div>

                <div>
                    <asp:Label ID="ModeloLabel" Text="Modelo: " AssociatedControlID="Modelotxt" runat="server"></asp:Label>
                    <asp:TextBox ID="Modelotxt" runat="server"></asp:TextBox>
                </div>

                <div>
                    <asp:Label ID="CilindrajeLabel" Text="Cilindraje: " AssociatedControlID="Cilindrajetxt" runat="server"></asp:Label>
                    <asp:TextBox ID="Cilindrajetxt" runat="server"></asp:TextBox>
                </div>


            </ContentTemplate>

        </asp:UpdatePanel>

        <div class="button">

            <asp:Button ID="ButtonS" type="submit" runat="server" Text="Actualizar" OnClientClick="return EditCarValidate();" OnClick="ButtonS_Click1" />

            <asp:Button ID="ButtonDelete" type="submit" runat="server" Text="Eliminar" OnClick="ButtonDelete_Click" />

        </div>

    </section>

</asp:Content>
