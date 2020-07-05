<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="EditProfileAdmin.aspx.cs" Inherits="AzPrueba.EditProfileAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" href="CreateUser.css" />
    <script src="validar.js" type="text/javascript"></script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentD" runat="server">

      <asp:Label ID="Label1" runat="server" Font-Bold="true" Font-Size="Large" ></asp:Label>

    <p>LLene por favor los siguientes campos: </p>

    <section runat="server">
        <asp:Label ID="lblResult" runat="server" ForeColor="Green"></asp:Label>

     

                <div>
                    <asp:Label ID="CodCli" Text="Cliente: " AssociatedControlID="CodClitext" runat="server"></asp:Label>
                    <asp:Label ID="CodClitext" runat="server"></asp:Label>
                </div>
                <div>

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

               <div class="row">

             <div>

                 <asp:Label ID="Avatar" Text="Avatar: " runat="server" Font-Bold="true"></asp:Label>
         
                  <asp:FileUpload ID="fuploadImagen" accept=".jpg" runat="server" CssClass="form-control"/>
                  <br />
                  <br />              
            </div>
                </div>

           <asp:ScriptManager ID="scrip" runat="server">
        </asp:ScriptManager>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>

                <div>
                    <asp:Label ID="TemaLabel" Text="Tema: " runat="server"></asp:Label>
                    <asp:DropDownList ID="DdlTema" runat="server" OnSelectedIndexChanged="ButtonB_Click" AutoPostBack="true"></asp:DropDownList>        
                </div>

                <div>
                   
                    <asp:Repeater ID="repeater1" runat="server">
                        <ItemTemplate>
                            <img class="img-tema" src="data:image/png;base64,<%# Convert.ToBase64String((byte[])DataBinder.Eval(Container.DataItem,"ImagenTemplate"))%>"/>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>

            </ContentTemplate>

        </asp:UpdatePanel>

        <div class="button">

            <asp:Button ID="ButtonS" type="submit" runat="server" Text="Actualizar" OnClientClick="return edituserValid();" OnClick="ButtonS_Click1" />

        </div>

    </section>

</asp:Content>
