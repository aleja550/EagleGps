<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="CrearEquipoGps.aspx.cs" Inherits="AzPrueba.CrearEquipoGps" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" href="CreateUser.css" />
    <script src="validar.js" type="text/javascript"></script>

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentD" runat="server">

    <h1>Creación EquiposGps</h1>

    <p>LLene por favor los siguientes campos: </p>



    <section id="form" >

        <asp:ScriptManager ID="scrip" runat="server">
        </asp:ScriptManager>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>

                <div>
                    <asp:Label ID="CodCli" Text="Cliente" AssociatedControlID="DdlCliente" runat="server"></asp:Label>
                    <asp:DropDownList ID="DdlCliente" runat="server"  OnSelectedIndexChanged="ButtonB_Click" AutoPostBack="true">
                    </asp:DropDownList>
                </div>

                <div>
                    <asp:Label ID="NumSim" Text="Número SimCard" AssociatedControlID="DdlNumero" runat="server"></asp:Label>
                    <asp:DropDownList ID="DdlNumero" runat="server">
                    </asp:DropDownList>
                </div>

                <div>
                    <asp:Label ID="ImeiLabel" Text="IMEI: " AssociatedControlID="Imeitxt" runat="server"></asp:Label>
                    <asp:TextBox ID="Imeitxt" runat="server" placeholder="Número"></asp:TextBox>
                </div>

                <div>
                    <asp:Label ID="SerialLabel" Text="Serial: " AssociatedControlID="Serialtxt" runat="server"></asp:Label>
                    <asp:TextBox ID="Serialtxt" runat="server" placeholder="Número"></asp:TextBox>
                </div>


            </ContentTemplate>

        </asp:UpdatePanel>

        <div class="button">

            <asp:Button ID="ButtonS" runat="server" Text="Guardar" OnClientClick="return CreateGpsValidate();" OnClick="ButtonS_Click1" />

        </div>
    </section>

</asp:Content>
