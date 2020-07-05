<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="EditEquipoGps.aspx.cs" Inherits="AzPrueba.EditEquipoGps" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" href="CreateUser.css" />
    <script src="validar.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentD" runat="server">



    <h1>Actualización EquipoGps </h1>

    <p>LLene por favor los siguientes campos: </p>

    <section runat="server">

        <asp:ScriptManager ID="scrip" runat="server">
        </asp:ScriptManager>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>

                <div>

                    <asp:Label ID="CodCli" Text="Cliente: " AssociatedControlID="CodClitext" runat="server"></asp:Label>
                    <asp:Label ID="CodClitext" runat="server"></asp:Label>
                </div>

                 

                <div>
                    <asp:Label ID="NumSim" Text="Número SimCard: " AssociatedControlID="NumSimtxt" runat="server"></asp:Label>
                    <asp:Label ID="NumSimtxt" runat="server"></asp:Label>
                </div>

                <div>
                    <asp:Label ID="ImeiLabel" Text="IMEI: " AssociatedControlID="Imeitxt" runat="server"></asp:Label>
                    <asp:TextBox ID="Imeitxt" runat="server" placeholder="Número"></asp:TextBox>
                </div>

                <div>
                    <asp:Label ID="SerialLabel" Text="Serial: " AssociatedControlID="Serialtxt" runat="server"></asp:Label>
                    <asp:TextBox ID="Serialtxt" runat="server" placeholder="Número"></asp:TextBox>
                    <asp:HiddenField ID="CodigoGpstext" runat="server"></asp:HiddenField>
                </div>


            </ContentTemplate>

        </asp:UpdatePanel>


        <div class="button">

            <asp:Button ID="ButtonS" type="submit" runat="server" Text="Actualizar" OnClientClick="return EditGpsValidate();" OnClick="ButtonS_Click1" />

            <asp:Button ID="ButtonDelete" type="submit" runat="server" Text="Eliminar" OnClick="ButtonDelete_Click" />

        </div>
    </section>

</asp:Content>
