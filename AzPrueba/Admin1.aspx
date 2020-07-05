<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="Admin1.aspx.cs" Inherits="AzPrueba.Admin1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Otherstyles.css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentD" runat="server">

    <section class="margen">

        <h1>Usuarios 
        </h1>

        <br />


            <div>

                <asp:Label ID="Label1" runat="server" Text="Ingrese el nombre del Usuario que desea buscar: "></asp:Label>
                <asp:TextBox ID="Buscartxt" runat="server"></asp:TextBox>

                <asp:Button ID="ButtonB" runat="server" Text="Buscar" OnClick="ButtonB_Click" />
            </div>

            <div>
                <asp:Button ID="Todos" runat="server" Text="Consultar Clientes" OnClick="Todos_Click" />
            </div>

            <br />


            <asp:ScriptManager ID="scrip" runat="server">
            </asp:ScriptManager>

            <asp:UpdatePanel ID="Usuario" runat="server">
                <ContentTemplate>

                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="CodUsuario" HorizontalAlign="Center">
                        <Columns>
                            <asp:BoundField DataField="CodUsuario" HeaderText="Código" ReadOnly="True" />
                            <asp:BoundField DataField="NombreUsuario" HeaderText="Nombre Usuario" />
                            <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                            <asp:BoundField DataField="Usuario" HeaderText="Usuario" ReadOnly="true" />
                            <asp:BoundField DataField="Contraseña" HeaderText="Contraseña" />
                            <asp:BoundField DataField="TipoUser" HeaderText="Tipo Usuario"/>


                            <asp:BoundField DataField="NombreCliente" HeaderText="Cliente" />
                            <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                            <asp:BoundField DataField="Correo" HeaderText="Correo" />

                            <asp:TemplateField HeaderText="Editar/Eliminar">
                                <ItemTemplate>
                                    <center><a id="redirect" href="EditUser.aspx?CodUsuario=<%# Eval("CodUsuario")%>"><img src="../img/edit.png" /></a></center>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Más Información">
                                <ItemTemplate>
                                    <center><a id="redirect2" href="Details.aspx?CodUsuario=<%# Eval("CodUsuario")%>">Detalles</a></center>
                                </ItemTemplate>
                            </asp:TemplateField>

                        </Columns>
                    </asp:GridView>


                </ContentTemplate>
                <Triggers>
                 <asp:AsyncPostBackTrigger ControlID="ButtonB" EventName="Click" />

                </Triggers>
            </asp:UpdatePanel>

            <br />

            <div class="new">

                <asp:Button ID="ButtonC" runat="server" Text="Crear Nuevo Usuario" OnClick="ButtonC_Click1" />            
            </div>

         



    </section>


</asp:Content>
