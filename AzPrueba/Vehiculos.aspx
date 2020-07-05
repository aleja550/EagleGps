<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="Vehiculos.aspx.cs" Inherits="AzPrueba.Vehiculos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" href="Otherstyles.css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentD" runat="server">

    <section class="margen">

        <h1>Vehiculos
        </h1>

        <br />




            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="PlacaVehiculo" HorizontalAlign="Center">
                <Columns>

                    <asp:BoundField DataField="PlacaVehiculo" HeaderText="Placa" />
                    <asp:BoundField DataField="MarcaVehiculo" HeaderText="Marca" />
                    <asp:BoundField DataField="ColorVehiculo" HeaderText="Color" />
                    <asp:BoundField DataField="ModeloVehiculo" HeaderText="Modelo" />
                    <asp:BoundField DataField="CilindrajeVehiculo" HeaderText="Cilindraje" />
                    <asp:BoundField DataField="NombreCliente" HeaderText="Cliente" />
                    <asp:BoundField DataField="Usuario" HeaderText="Usuario" />
                    <asp:BoundField DataField="Imei" HeaderText="EquipoGps" />
                    

                    <asp:TemplateField HeaderText="Editar/Eliminar">
                        <ItemTemplate>
                            <center><a id="redirect" href="EditVehiculos.aspx?Vehiculos=<%# Eval("PlacaVehiculo")%>"><img src="../img/edit.png" /></a></center>
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>
            </asp:GridView>


            <br />

            <div class="new">

                <asp:Button ID="ButtonC" runat="server" Text="Crear Nuevo Vehiculo" OnClick="ButtonC_Click1" />
            </div>


        </section>



</asp:Content>
