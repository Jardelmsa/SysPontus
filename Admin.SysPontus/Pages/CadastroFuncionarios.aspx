<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroFuncionarios.aspx.cs" Inherits="Admin.SysPontus.Pages.CadastroFuncionarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background-color:#dddddd" class="text-dark">
    <link rel="stylesheet" href="../Content/bootstrap.css" type="text/css" />
    <form id="form1" runat="server">
        <div>
            <br />
            <center><h1 class="display-4"><b>Cadastro de Funcionários</b></h1></center>
        </div>
        <br />
        
        <div class="p-2 m-4">
            <label>CPF ou CNPJ:</label>
            <asp:TextBox ID="txtCPF_CNPJ" runat="server" CssClass="form-control" Width="30%" PlacerHolder="Digite o CPF ou CNPJ..." />
            <label>Nome Completo:</label>
            <asp:TextBox ID="txtNomeCompleto" runat="server" CssClass="form-control" Width="50%" PlacerHolder="Digite o nome..." />
            <label>E-mail:</label>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Width="40%" PlacerHolder="Digite o Email..." />
            <label>Telefone:</label>
            <asp:TextBox ID="txtTelefone" runat="server" CssClass="form-control" Width="30%" PlacerHolder="Digite o telefone..." />
            <label>Sexo:</label>
            <asp:DropDownList ID="ddlSexo" runat="server" CssClass="form-control" Width="15%" PlacerHolder="Digite o CPF ou CNPJ..." >
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>M</asp:ListItem>
                <asp:ListItem Value="F"></asp:ListItem>
            </asp:DropDownList>
            <label>Login</label>
            <asp:TextBox ID="txtLogin" runat="server" CssClass="form-control" Width="30%" PlacerHolder="Digite o login..." />
            <label>Senha:</label>
            <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control" Width="30%" PlacerHolder="Digite a senha..." />
            <label>Digite o Cargo:</label>
            <asp:TextBox ID="txtCargo" runat="server" CssClass="form-control" Width="30%" PlacerHolder="Digite o Cargo..." />
            <label>Endereço:</label>
            <asp:TextBox ID="txtEndereço" runat="server" CssClass="form-control" Width="50%" PlacerHolder="Digite o Endereço..." Height="77px" TextMode="MultiLine" />
            <br />
            <asp:Label ID="lblMensagem" runat="server"  CssClass="text-danger"/>
            <br />
           <br />
            <center><asp:Button ID="btnCadastrar" runat ="server" CssClass="btn btn-success " Text="Cadastrar" OnClick="btnCadastrar_Click" /> &ensp; <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-danger" Text="Cancelar" OnClick="btnCancelar_Click" /></center>
        </div>
    </form>
     <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
</body>
</html>
