<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="EditSim.aspx.cs" Inherits="AzPrueba.EditSim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" href="CreateUser.css" />
    <script src="validar.js" type="text/javascript"></script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentD" runat="server">


    <h1>Actualización SimCard </h1>

    <p>LLene por favor los siguientes campos: </p>

    <section runat="server">

        <asp:ScriptManager ID="scrip" runat="server">
        </asp:ScriptManager>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>

                <div>

                    <asp:Label ID="CodCli" Text="Cliente: " AssociatedControlID="CodClitext" runat="server"></asp:Label>
                    <asp:Label ID="CodClitext" runat="server"></asp:Label>
                    <asp:Label ID="CodSimtext" runat="server" Style="color: white"></asp:Label>

                </div>

                <div>
                    <asp:Label ID="NumeroSim" Text="Número de la SimCard: " AssociatedControlID="txtNumeroSimCard" runat="server"></asp:Label>
                    <asp:TextBox ID="txtNumeroSimCard" runat="server" placeholder="Número"></asp:TextBox>
                </div>


                <div>

                    <asp:Label ID="TipoOperador" Text="Operador: " AssociatedControlID="DdlSimType" runat="server"></asp:Label>
                    <asp:DropDownList ID="DdlSimType" runat="server">

                        <asp:ListItem Selected="True" Value="0">Seleccione</asp:ListItem>
                        <asp:ListItem Value="1">Movistar</asp:ListItem>
                        <asp:ListItem Value="2">Claro</asp:ListItem>

                    </asp:DropDownList>

                </div>

            </ContentTemplate>

        </asp:UpdatePanel>




        <div class="button">

            <asp:Button ID="ButtonS" type="submit" runat="server" Text="Actualizar" OnClientClick="return EditSimValidate();" OnClick="ButtonS_Click1" />

            <asp:Button ID="ButtonDelete" type="submit" runat="server" Text="Eliminar" OnClick="ButtonDelete_Click" />

        </div>
    </section>

</asp:Content>
