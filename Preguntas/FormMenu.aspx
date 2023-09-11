<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormMenu.aspx.cs" Inherits="Preguntas.FormMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Menu Principal</h1>
    <form id="form1" runat="server">
              <div class="divmg">
     <asp:Button  style="margin:10px" ID="btnCrearCuestionario" runat="server" Text="Crear Cuestionario" OnClick="btnCrearCuestionario_Click" />
     <asp:Button  style="margin:10px" ID="btnVerCuestionario" runat="server" Text="Ver Cuestionario" OnClick="btnVerCuestionario_Click" />
  </div>
    </form>
</body>
</html>
<style>
    .divmg {
        margin:5px;
    }
</style>

