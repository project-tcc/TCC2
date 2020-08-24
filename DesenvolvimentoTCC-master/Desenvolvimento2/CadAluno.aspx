<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadAluno.aspx.cs" Inherits="Desenvolvimento2.CadAluno1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Cadastro de Alunos</title>

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
        .auto-style5 {
            height: 1465px;
        }
        .auto-style6 {
            width: 169px;
        }
        </style>
</head>
<body>


    <div class="auto-style1" style="margin-top: 50px">
        <label for="name">CADASTRO ALUNOS</label>
        <br />
        <form id="form2" runat="server" class="auto-style5">
            <div class="form-group">
                ID<br />
                <br />
                <asp:Label ID="RA" runat="server" Text="RA"></asp:Label>
                <asp:TextBox ID="txt_RA" runat="server" class="form-control" Width="209px"></asp:TextBox>
                <br />
                <asp:Label ID="Curso" runat="server" Text="Curso"></asp:Label>
           

                <br />
                


                <asp:DropDownList ID="ddlCursos" runat="server">
                </asp:DropDownList>
                


                <br />
                <asp:Label ID="Data_Ingresso" runat="server" Text="Data de Ingressão"></asp:Label>
                <asp:TextBox ID="txtDataIngressao" runat="server" class="form-control"></asp:TextBox>
                
                <br />
                <asp:Label ID="lbl_NomeCompleto" runat="server" Text="Nome Completo"></asp:Label>
&nbsp;<asp:TextBox ID="txtNomeCompleto" runat="server" class="form-control"></asp:TextBox>
                <label for="name">
                <asp:Label ID="lbl_RG" runat="server" Text="RG"></asp:Label>
                </label>
                <asp:TextBox ID="txtRG" runat="server" class="form-control"></asp:TextBox>
                <label for="name">
                <asp:Label ID="lbl_CPF" runat="server" Text="CPF"></asp:Label>
                </label>
                <asp:TextBox ID="txtcpf" runat="server" class="form-control"></asp:TextBox>

                <asp:Label ID="lbl_Tel_Telefone" runat="server" Text="Telefone"></asp:Label>
&nbsp;
                <asp:TextBox ID="txtTelefone" runat="server" class="form-control"></asp:TextBox>

                
            </div>

            <div class="form-group">
                <asp:Label ID="lbl_Tel_Celular" runat="server" Text="Celular"></asp:Label>
&nbsp;<asp:TextBox ID="txtCelular" runat="server" class="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lbl_nacionalidade" runat="server" Text="Nacionalidade"></asp:Label>
            </div>

            <div class="form-group">
                <asp:DropDownList ID="ddlPaises" runat="server">
                </asp:DropDownList>
                <br />
                <asp:Label ID="lbl_Nome_Pai" runat="server" Text="Nome do Pai"></asp:Label>
                <asp:TextBox ID="txt_nome_pai" runat="server" class="form-control"></asp:TextBox>
                <asp:Label ID="lbl_Nome_Mae" runat="server" Text="Nome da Mãe"></asp:Label>
                <asp:TextBox ID="txt_nome_mae" runat="server" class="form-control"></asp:TextBox>
                <asp:Label ID="lbl_CEP" runat="server" Text="CEP"></asp:Label>
                <asp:TextBox ID="txtCEP" runat="server" class="form-control" Width="161px"></asp:TextBox>
                <br />
                <asp:Button ID="btn_buscar" runat="server" Text="Buscar" />
                <br />
                <br />
                <asp:Label ID="END_COMPLEMENTO" runat="server" Text="Complemento"></asp:Label>
                <asp:TextBox ID="txt_complemento" runat="server" class="form-control"></asp:TextBox>
                <asp:Label ID="END_BAIRRO" runat="server" Text="Bairro"></asp:Label>
                <asp:TextBox ID="txt_bairro" runat="server" class="form-control"></asp:TextBox>
                <asp:Label ID="END_CIDADE" runat="server" Text="Cidade"></asp:Label>
                <asp:TextBox ID="txt_cidade" runat="server" class="form-control"></asp:TextBox>
                <asp:Label ID="TIPO_LOGRADOURO" runat="server" Text="Tipo de Logradouro"></asp:Label>
                <asp:TextBox ID="txt_tipo_logradouro" runat="server" class="form-control"></asp:TextBox>
                <asp:Label ID="lbl_END" runat="server" Text="Endereço"></asp:Label>
                <asp:TextBox ID="txtEnd" runat="server" class="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lbl_Tel_Emergencia" runat="server" Text="Telefone (EMERGÊNCIA)"></asp:Label>
                &nbsp;<asp:TextBox ID="txt_tel_emerg" runat="server" class="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="name">Data de Nascimento</label>
                <asp:TextBox ID="txtDTNascimento" runat="server" class="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="name">E-mail</label>
                <asp:TextBox ID="txtEmail" runat="server" class="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                &nbsp;</div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="lblSexo" runat="server" Text="Sexo"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblStatus" runat="server" Text="Status"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblTipo" runat="server" Text="Tipo"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:DropDownList ID="ddlSexo" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlStatus" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlTipo" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />


            <asp:Label ID="lbl_data_inclusao" runat="server" Text="Data Inclusão"></asp:Label>
            







                <asp:TextBox ID="txt_dt_inclusao" runat="server" class="form-control" OnTextChanged="txt_dt_inclusao_TextChanged"></asp:TextBox>
                    






            <br />
            <asp:Label ID="lbl_data_alteracao" runat="server" Text="Data de Alteração do Cadastro"></asp:Label>
                <asp:TextBox ID="txt_dt_alteracao" runat="server" class="form-control"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_salvar" runat="server" Text="Salvar" OnClick="btn_salvar_Click" />

            <br />
            <br />
            <label for="TxtCodigo">
            <asp:Label ID="lblMSG" runat="server" Font-Bold="True" ForeColor="Purple"></asp:Label>
            </label>

            <br />
        </form>
         </div>
</body>
</html>
