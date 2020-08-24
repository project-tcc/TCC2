<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadProfessor.aspx.cs" Inherits="Desenvolvimento2.CadAluno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
            height: 1202px;
        }
        .auto-style2 {
            height: 1313px;
        }
        .auto-style3 {
            width: 136px;
        }
        .auto-style4 {
            width: 112px;
        }
        .auto-style5 {
            width: 147px;
        }
        .auto-style6 {
            width: 99px;
        }
    </style>
</head>




<body>
    <div class="auto-style1" style="margin-top: 50px">
         <label for="name">CADASTRO DE PROFESSORES</label>
        <br />
    <form id="form1" runat="server" class="auto-style2">

       
        <asp:Label ID="nome_completo" runat="server" Text="Nome Completo"></asp:Label>
        <br />
        <asp:TextBox ID="txt_nome_completo" runat="server" class="form-control"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_RG" runat="server" Text="RG"></asp:Label>
        <br />
        <asp:TextBox ID="txt_rg" runat="server" class="form-control"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_CPF" runat="server" Text="CPF"></asp:Label>
        <br />
        <asp:TextBox ID="txt_CPF" runat="server" class="form-control"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_telefone_fixo" runat="server" Text="Telefone Fixo"></asp:Label>
        <br />
        <asp:TextBox ID="txt_telefone_fixo" runat="server" class="form-control"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_telefone_celular" runat="server" Text="Telefone Celular"></asp:Label>
        <br />
        <asp:TextBox ID="txt_telefone_celular" runat="server" class="form-control"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Telefone (EMERGÊNCIA)"></asp:Label>
                &nbsp;<asp:TextBox ID="txt_telefone_emergencial" runat="server" class="form-control"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_Nacionalidade" runat="server" Text="Nacionalidade"></asp:Label>
        <br />
        <asp:DropDownList ID="ddlPaises" runat="server">
        </asp:DropDownList>
        <br />
        <br />
                <asp:Label ID="lbl_CEP" runat="server" Text="CEP"></asp:Label>
                <asp:TextBox ID="txtCEP" runat="server" class="form-control" Width="161px"></asp:TextBox>
                <br />
                <asp:Button ID="btn_salvar_btn" runat="server" Text="Buscar" />
                <br />
                <br />
                <asp:Label ID="lbl_complemento" runat="server" Text="Complemento"></asp:Label>
                <asp:TextBox ID="txt_complemento" runat="server" class="form-control"></asp:TextBox>
                <asp:Label ID="lbl_bairro" runat="server" Text="Bairro"></asp:Label>
                <asp:TextBox ID="txt_bairro" runat="server" class="form-control"></asp:TextBox>
                <asp:Label ID="lbl_cidade" runat="server" Text="Cidade"></asp:Label>
                <asp:TextBox ID="txt_cidade" runat="server" class="form-control"></asp:TextBox>
                <asp:Label ID="lbl_tp_logradouro" runat="server" Text="Tipo de Logradouro"></asp:Label>
                <asp:TextBox ID="txt_tipo_logradouro" runat="server" class="form-control"></asp:TextBox>
                <asp:Label ID="lbl_rua" runat="server" Text="Nome da Rua"></asp:Label>
                <asp:TextBox ID="txtRua" runat="server" class="form-control"></asp:TextBox>    
                <asp:Label ID="lbl_numero_casa" runat="server" Text="Número da Residência"></asp:Label>
                <asp:TextBox ID="txtNumResidencia" runat="server" class="form-control"></asp:TextBox>     
                <asp:Label ID="lbl_formacao" runat="server" Text="Formação"></asp:Label>
                <asp:TextBox ID="txt_formacao" runat="server" class="form-control"></asp:TextBox>    
               
        
                <asp:Label ID="lbl_Titulo" runat="server" Text="Título"></asp:Label>
                <br />

                
                 <br />
                 <br />
                 <asp:Label ID="lbl_codigo_acesso" runat="server" Text="Código de Acesso"></asp:Label>

                
                 <br />
                 <asp:TextBox ID="txt_codigo_acesso" runat="server" class="form-control"></asp:TextBox>    
                 <asp:Label ID="lbl_senha_acesso" runat="server" Text="Senha de Acesso"></asp:Label>
                 <asp:TextBox ID="txt_senha_acesso" runat="server" class="form-control"></asp:TextBox>  
       

            <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="lbl_dt_inclusao" runat="server" Text="Data de Inclusão"></asp:Label>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td>
                    <asp:Label ID="lbl_dt_alteracao" runat="server" Text="Data de Alteração"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:TextBox ID="txt_dt_inclusao" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td>
                    <asp:TextBox ID="txt_dt_alteracao" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
       

            <asp:Label ID="lbl_data_Cadastro" runat="server" Text="Data de Admissão"></asp:Label>
                 <asp:TextBox ID="txt_data_admissao" runat="server" class="form-control"></asp:TextBox>    
       

            <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style3">
        <asp:Label ID="lbl_status" runat="server" Text="Status"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="lblSexo" runat="server" Text="Sexo"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblTipo" runat="server" Text="Tipo"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
     

                    <asp:DropDownList ID="ddlStatus" runat="server">
                    </asp:DropDownList>

       

                </td>
                <td class="auto-style4">
                    <asp:DropDownList ID="ddlSexo" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="ddlTipo" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />

       

            <asp:Button ID="btn_salvar" runat="server" Text="Salvar" OnClick="btn_salvar_Click" />

       

            <br />
        </form>
            </div>

</body>
</html>
