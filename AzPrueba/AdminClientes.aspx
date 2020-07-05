<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="AdminClientes.aspx.cs" Inherits="AzPrueba.AdminClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="stylesheet" type="text/css" href="Otherstyles.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentD" runat="server">

     <section class="margen">
      <h1>
        Clientes
    </h1>

    <br /> 

    <p class="hola" style="background-color:#eff1f4; border-radius:1em;">Recuerde que para Eliminar un Cliente debe primero eliminar todos los Usuarios que tenga ese Cliente.</p>


                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="NombreCliente" HorizontalAlign="Center">
                    <Columns>

                        <asp:BoundField DataField="NombreCliente" HeaderText="Cliente" />
                        <asp:BoundField DataField="RepreLegal" HeaderText="Representante Legal" />
                        <asp:BoundField DataField="Direccion" HeaderText="Dirección" ReadOnly="true" />
                        <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                        <asp:BoundField DataField="CedulaCiu" HeaderText="Cedula de Ciudadania" />
                        <asp:BoundField DataField="Nit" HeaderText="Nit" />
                        <asp:BoundField DataField="Correo" HeaderText="Correo" />

                        <asp:TemplateField HeaderText="Editar/Eliminar">
                            <ItemTemplate>
                                <center><a id="redirect" href="EditCliente.aspx?Cliente=<%# Eval("NombreCliente")%>"><img src="../img/edit.png" /></a></center>
                            </ItemTemplate>
                        </asp:TemplateField>


                    </Columns>
                </asp:GridView>


    <div class="new">

        <asp:Button ID="ButtonC" runat="server" Text="Crear Nuevo Cliente" OnClick="ButtonC_Click1"/>
    
    </div>
        <br />
         <div>
            <asp:Button ID="Todos" runat="server" Text="Volver a Usuarios" OnClick="Todos_Click"/>
        </div>


         </section>
</asp:Content>
