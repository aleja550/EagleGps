<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="CreateVehiculo.aspx.cs" Inherits="AzPrueba.CreateVehiculo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" href="CreateUser.css" />
    <script src="validar.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentD" runat="server">


    <h1>Creación Vehículo</h1>

    <p>LLene por favor los siguientes campos: </p>



    <section id="form">

        <asp:ScriptManager ID="scrip" runat="server">
        </asp:ScriptManager>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>



                <div>
                    <asp:Label ID="CodCli" Text="Cliente: " AssociatedControlID="DdlCliente" runat="server"></asp:Label>
                    <asp:DropDownList ID="DdlCliente" runat="server" OnSelectedIndexChanged="ButtonB_Click" AutoPostBack="true">
                    </asp:DropDownList>
                </div>

                <div>
                    <asp:Label ID="UsuarioLabel" Text="Usuario: " AssociatedControlID="DdlUsuario" runat="server"></asp:Label>
                    <asp:DropDownList ID="DdlUsuario" runat="server" OnSelectedIndexChanged="ButtonO_Click" AutoPostBack="true">
                    </asp:DropDownList>
                </div>

                <div>
                    <asp:Label ID="ImeiLabel" Text="EquipoGps: " AssociatedControlID="DdlImei" runat="server"></asp:Label>
                    <asp:DropDownList ID="DdlImei" runat="server">
                    </asp:DropDownList>

                </div>

                <div>
                    <asp:Label ID="PlacaLabel" Text="Placa: " AssociatedControlID="Placatxt" runat="server"></asp:Label>
                    <asp:TextBox ID="Placatxt" runat="server"></asp:TextBox>
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

            <asp:Button ID="ButtonS" runat="server" Text="Guardar" OnClientClick="return VehiculoValid();" OnClick="ButtonS_Click1" Style="height: 26px" />

        </div>

    </section>

</asp:Content>
