<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Desenvolvimento2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            width: 50%;
            max-width: 1140px;
            min-width: 992px;
            margin-left: auto;
            margin-right: auto;
            padding-left: 15px;
            padding-right: 15px;
            height: 653px;
        }
        </style>
</head>



<body style="height: 668px">
    <form id="form1" runat="server">
    <div class="auto-style1" style="margin-top: 50px">
        <asp:Label ID="lbl_boasvindas" runat="server" Text="Olá, seja bem vindo!"></asp:Label>
        &nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbl_titulo" runat="server" Text="Aqui quero colocar a data e hora"></asp:Label>
   
        <br />
        <br />
        <br />
        <asp:Label ID="lblTitle" runat="server" Text="Você é um:"></asp:Label>
&nbsp;<br />
        <asp:DropDownList ID="ddltipo_pessoa" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Label ID="lbl_codigo_acesso" runat="server" Text="Informe seu código de acesso:"></asp:Label>
        <br />
        <asp:TextBox ID="txt_codigo_acesso" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lbl_senha_acesso" runat="server" Text="Informe sua senha de acesso:"></asp:Label>
        <br />
        <asp:TextBox ID="txt_senha_acesso" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Button ID="btn_entrar" runat="server" Text="Entrar" />
   
        </div>
        </form>

</body>35
</html>
