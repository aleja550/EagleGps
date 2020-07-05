<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="SimCards.aspx.cs" Inherits="AzPrueba.SimCards" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

        <link rel="stylesheet" type="text/css" href="Otherstyles.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentD" runat="server">

      <section class="margen">

        <h1>SimCards
        </h1>

        <br />


         
            <div>
                <asp:Button ID="Todos" runat="server" Text="Consultar Clientes" OnClick="Todos_Click" />
            </div>

            <br />         
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="NumSim" HorizontalAlign="Center">
                        <Columns> 
                            
                            <asp:BoundField DataField="NombreCliente" HeaderText="Cliente" />
                            <asp:BoundField DataField="NumSim" HeaderText="Número SimCard" />
                            <asp:BoundField DataField="Operador" HeaderText="Operador"/>

                            <asp:TemplateField HeaderText="Editar/Eliminar">
                                <ItemTemplate>
                                    <center><a id="redirect" href="EditSim.aspx?SimCard=<%# Eval("NumSim")%>"><img src="../img/edit.png" /></a></center>
                                </ItemTemplate>
                            </asp:TemplateField>                         

                        </Columns>
                    </asp:GridView>


            <br />

            <div class="new">

                <asp:Button ID="ButtonC" runat="server" Text="Crear Nueva SimCard" OnClick="ButtonC_Click1" />            
            </div>


        </section>



</asp:Content>
