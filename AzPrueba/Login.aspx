﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AzPrueba.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>

    <title>Eagle GPS</title>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0" />
    <link rel="shortcut icon" type="image/x-icon" href="img/eagle.ico"/>
    <link rel="stylesheet" type="text/css" href="LoginStyle.css"/>
    <script src="validar.js" type="text/javascript"></script>

</head>
<body>

    <form id="form1" runat="server">
        
        <div class="login">
            <img src="img/small.png" />
            <h2>Inicio Sesión</h2>


            <div class="heading">
      

                    <asp:TextBox ID="txtUsuario" runat="server" CssClass="UText" placeholder="Usuario"></asp:TextBox>

 

                    <asp:TextBox ID="txtClave" name="txtClave" type="password" runat="server" TextMode="Password" placeholder="Contraseña "> </asp:TextBox>
            
            </div>

       </div>

        <div class ="log">
            
                <asp:Button ID="Button1" runat="server" Text="Entrar" OnClientClick="return LoginValidate();" OnClick="Button1_Click1" PostBackURL="~/Login.aspx" />
         
                <asp:Label ID="Label1" runat="server"></asp:Label>  

        </div>

        <script src="js/jqueryt.min.js"></script>
        <script src="js/bootstrap.min.js"></script>
        <script src="js/index.js"></script>

                         

    </form>
  

</body>


</html>

