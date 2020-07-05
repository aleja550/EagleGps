<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="CrearCliente.aspx.cs" Inherits="AzPrueba.CrearCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" href="CreateUser.css" />
    <script src="validar.js" type="text/javascript"></script>
    <script src="index.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentD" runat="server">

    <h1>Creación Nuevo Cliente </h1>

    <p>LLene por favor los siguientes campos: </p>



    <section id="form" runat="server">

        <%--<%= Telefono.ClientID %>--%>

        <div>

            <asp:Label ID="Id" Text="Tipo de Identificación" AssociatedControlID="DdlID" runat="server"></asp:Label>
            <asp:DropDownList ID="DdlID" runat="server">

                <asp:ListItem Selected="True" Value="Select">Seleccione</asp:ListItem>
                <asp:ListItem Value="0">Nit</asp:ListItem>
                <asp:ListItem Value="1">Cedula de Ciudadania</asp:ListItem>

            </asp:DropDownList>
        </div>

        <div>
            <asp:Label ID="IdLabel" Text="Nit/Cedula" AssociatedControlID="Idtxt" runat="server"></asp:Label>
            <asp:TextBox ID="idtxt" runat="server"></asp:TextBox>
       
        </div>

        <div>
            <asp:Label ID="Nombre" Text="Nombre: " AssociatedControlID="txtNombre" runat="server"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>

        </div>

        <div>
            <asp:Label ID="RepreLegal" Text="Representante Legal: " AssociatedControlID="txtRepresentante" runat="server"></asp:Label>

            <asp:TextBox ID="txtRepresentante" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Direccion" Text="Dirección:" AssociatedControlID="txtDireccion" runat="server"></asp:Label>
            <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Telefono" Text="Telefono: " AssociatedControlID="txtTel" runat="server"></asp:Label>
            <asp:TextBox ID="txtTel" runat="server" MaxLength="10" AutoCompleteType="Cellular"></asp:TextBox>
           
        <asp:RegularExpressionValidator runat="server" ErrorMessage="* Ingrese solo números" ForeColor="Red" ID="ValidateNum" ControlToValidate="txtTel" ValidationExpression="^[0-9]{10}$">

        </asp:RegularExpressionValidator>

        </div>


        <div>
            <asp:Label ID="Correo" Text="Correo: " AssociatedControlID="txtTel" runat="server"></asp:Label>
            <asp:TextBox ID="txtCorreo" runat="server" inputtype="number"></asp:TextBox>
        </div>

        <div class="button">

            <asp:Button ID="ButtonGuardar" runat="server" Text="Guardar" OnClientClick="return createClienteValidate();" OnClick="ButtonGuardar_Click" />

        </div>

        <%--    Javascript--%>


        <script type="text/javascript">
            $('#<%= DdlID.ClientID %>').change(function () {
                if (this.value == 0) {
                    $('#<%= txtRepresentante.ClientID %>').css('display', 'block');
            }
            else {
                $('#<%= txtRepresentante.ClientID %>').css('display', 'none');
                }
            });
        </script>

        <script type="text/javascript">
            $('#<%= DdlID.ClientID %>').change(function () {
                if (this.value == 0) {
                    $('#<%= RepreLegal.ClientID %>').css('display', 'block');
            }
            else {
                $('#<%= RepreLegal.ClientID %>').css('display', 'none');
                }
            });
        </script>

        <br />
    </section>




</asp:Content>
