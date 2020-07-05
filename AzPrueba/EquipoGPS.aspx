<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="EquipoGPS.aspx.cs" Inherits="AzPrueba.EquipoGPS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

     <link rel="stylesheet" type="text/css" href="Otherstyles.css" />
     <script src="validar.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentD" runat="server">

      <section class="margen">

        <h1>Equipos GPS
        </h1>

        <br />

            <div>
                <asp:Button ID="Todos" runat="server" Text="Consultar Clientes" OnClick="Todos_Click" />
            </div>

            <br />         
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="Imei" HorizontalAlign="Center">
                        <Columns> 
                            
                           <asp:BoundField DataField="NombreCliente" HeaderText="Cliente" />
                            <asp:BoundField DataField="Imei" HeaderText="IMEI" />
                            <asp:BoundField DataField="Serial" HeaderText="Serial" />    
                            <asp:BoundField DataField="NumSim" HeaderText="Numero SimCard"/>

                            <asp:TemplateField HeaderText="Editar/Eliminar">
                                <ItemTemplate>
                                    <center><a id="redirect" href="EditEquipoGps.aspx?EquipoGps=<%# Eval("Imei")%>"><img src="../img/edit.png" /></a></center>
                                </ItemTemplate>
                            </asp:TemplateField>                         

                        </Columns>
                    </asp:GridView>


            <br />

            <div class="new">

                <asp:Button ID="ButtonC" runat="server" Text="Crear Nuevo EquipoGps" OnClick="ButtonC_Click1" />            
            </div>



    </section>



</asp:Content>
