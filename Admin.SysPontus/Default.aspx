<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Admin.SysPontus.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background-color:darkviolet" class="text-white">
    <link rel="stylesheet" href="Content/bootstrap.css" type="text/css" />
    <form id="form1" runat="server">
        <div>
            <br />
            <center><h1 class="well display-2"><strong>Administração SysPontus</strong></h1></center>
        </div>
        <br /> <br />
        <div class="p-2 m-4">
            <br />
            <center><h3><b>Selecione a sua opção:</b></h3></center>
            <br />
            <center><a  href="Pages/CadastroFuncionarios.aspx" class="btn btn-primary">Cadastrar Funcionário</a></center>

        </div>
    </form>
   <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.4.1.min.js"></script>
</body>
</html>
