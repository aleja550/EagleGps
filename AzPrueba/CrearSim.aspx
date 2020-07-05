<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="CrearSim.aspx.cs" Inherits="AzPrueba.CrearSim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" href="CreateUser.css"/>
    <script src="validar.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentD" runat="server">

    
        <h1>Creación SimCards</h1>

    <p>LLene por favor los siguientes campos: </p>



    <section id="form" >

       
        <div>
            <asp:Label ID="CodCli" Text="Cliente" AssociatedControlID="DdlCliente" runat="server"></asp:Label> 
            <asp:DropDownList ID="DdlCliente" runat="server"> 
            </asp:DropDownList>                   
        </div>   

        <div>
            <asp:Label ID="NumeroSim" Text="Número de la SimCard" AssociatedControlID="txtNumeroSimCard" runat="server"></asp:Label> 
            <asp:TextBox ID="txtNumeroSimCard" runat="server"  placeholder="Número"></asp:TextBox> 
        </div>


        <div>

            <asp:Label ID="TipoOperador" Text="Operador" AssociatedControlID="DdlSimType" runat="server"></asp:Label> 
            <asp:DropDownList ID="DdlSimType" runat="server">

                <asp:ListItem Selected="True" Value="0" >Seleccione</asp:ListItem>
                <asp:ListItem Value="1">Movistar</asp:ListItem>
                <asp:ListItem Value="2">Claro</asp:ListItem>
        
            </asp:DropDownList>

        </div>             

      
        <div class ="button">

        <asp:Button ID="ButtonS" runat="server" Text="Guardar" OnClientClick="return SimValidate();" OnClick="ButtonS_Click1" />
                        
        </div>                 
    </section>

</asp:Content>
