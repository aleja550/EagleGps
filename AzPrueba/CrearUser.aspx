<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="CrearUser.aspx.cs" Inherits="AzPrueba.CrearUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <title>Crear Usuario</title>

    <link rel="stylesheet" type="text/css" href="CreateUser.css"/>
    <script src="validar.js" type="text/javascript"></script>
     <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentD" runat="server">


    <h1>Creación Nuevo Usuario </h1>

    <p>LLene por favor los siguientes campos: </p>



    <section id="form">

        

        <div>
            <asp:Label ID="CodCli" Text="Cliente: " AssociatedControlID="DdlCliente" runat="server"></asp:Label> 
            <asp:DropDownList ID="DdlCliente" runat="server" style="height: 27px" ToolTip="En caso de que no encuentre el cliente al cual quiere asignarle un usuario, puede crear un nuevo Cliente."> 
            </asp:DropDownList>                   
        </div>   

        <div class ="button">
        <asp:Button ID="ButtonCrear"  runat="server" Text="Nuevo Cliente" OnClick="ButtonCrear_Click" ToolTip="En caso de que no encuentre el cliente al cual quiere asignarle un usuario, puede crear un nuevo Cliente." />                        
        </div>


        <div>

            <asp:Label ID="TipoUser" Text="Tipo Usuario: " AssociatedControlID="DdlUserType" runat="server"></asp:Label> 
            <asp:DropDownList ID="DdlUserType" runat="server">

                <asp:ListItem Selected="True" Value="Select" >Seleccione</asp:ListItem>
                <asp:ListItem Value="0">Administrador</asp:ListItem>
                <asp:ListItem Value="1">Común</asp:ListItem>
        
            </asp:DropDownList>

        </div>             

        <div>
            <asp:Label ID="Nombrelabel" Text="Nombre:" AssociatedControlID="txtNombreUsuario" runat="server"></asp:Label> 
            <asp:TextBox ID="txtNombreUsuario" runat="server"  placeholder="Nombre"></asp:TextBox> 
        </div>

        <div>
            <asp:Label ID="Apellido" Text="Apellido:" AssociatedControlID="txtApellido" runat="server"></asp:Label> 
            <asp:TextBox ID="txtApellido" runat="server"  placeholder="Apellido"></asp:TextBox>         
        </div>

        <div>
            <asp:Label ID="Usuario" Text="Usuario:" AssociatedControlID="Usuariotxt" runat="server"></asp:Label> 
            <asp:TextBox ID="Usuariotxt" runat="server" ToolTip="El usuario puede contener letras, números y carácteres especiales." ></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Pass" Text="Contraseña: " AssociatedControlID="Passtxt" runat="server" ></asp:Label> 
            <asp:TextBox ID="Passtxt" runat="server" TextMode="Password" ToolTip="La contraseña puede contener letras, números y carácteres especiales."></asp:TextBox>
        </div>


      <div class="container">
        
         <div class="row">

             <div>

                 <asp:Label ID="Avatar" Text="Avatar: " runat="server" Font-Bold="true"></asp:Label>
         
                  <asp:FileUpload ID="fuploadImagen" accept=".jpg" runat="server" CssClass="form-control"/>
                  <br />
                  <br />              
            </div>

        </div>

     </div>
       
        <%--  //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////--%>

        <div>
            <asp:Label ID="TemplateDdl" Text="Temas: " AssociatedControlID="DdlCliente" runat="server"></asp:Label> 

        </div>

  
          <div class="align-items-md-start">
            <asp:RadioButtonList ID="ListThemes" runat="server">   

     
            </asp:RadioButtonList>
          </div>




        <div class ="button">

        <asp:Button ID="ButtonS" runat="server" Text="Guardar" OnClientClick="return crearuserValidate();" OnClick="ButtonS_Click1" />
                        
        </div>

        


           
    </section>

    <br />



    
    


</asp:Content>
