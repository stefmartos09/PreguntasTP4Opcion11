<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formCuestionario.aspx.cs" Inherits="Preguntas.formCuestionario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Cuestionario</h1>
    <form id="form1" runat="server">
        <div class="divmg">
            <asp:Label ID="lblPregunta1" runat="server" Text=""></asp:Label>
        </div>
              <div class="divmg">
    <asp:RadioButton ID="rbRpta1P1" runat="server" GroupName="PrimeraPregunta" />
    <asp:Label ID="lblRpta1P1" runat="server" Text=""></asp:Label>
    <asp:RadioButton ID="rbRpta2P1" runat="server" GroupName="PrimeraPregunta" />
   <asp:Label ID="lblRpta2P1" runat="server" Text=""></asp:Label>
    <asp:RadioButton ID="rbRpta3P1" runat="server" GroupName="PrimeraPregunta" />
   <asp:Label ID="lblRpta3P1" runat="server" Text=""></asp:Label>
      </div>

              <div class="divmg">
          <asp:Label ID="lblRptaPregunta1" runat="server" Text=""></asp:Label>
      </div>
                  <hr />
            <div class="divmg">
         <asp:Label ID="lblPregunta2" runat="server" Text=""></asp:Label>
     </div>
               <div class="divmg">
                   <asp:CheckBoxList ID="chkListRptas2" runat="server"></asp:CheckBoxList>
</div>
                   <div class="divmg">
       <asp:Label ID="lblRptaPregunta2" runat="server" Text=""></asp:Label>
   </div>
        <hr />
          <div class="divmg">
     <asp:Button  style="margin:10px" ID="btnEnviar" runat="server" Text="Enviar Cuestionario" OnClick="btnEnviar_Click" />
                <asp:Button  style="margin:10px" ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click"  />
  </div>
    </form>
</body>
</html>
<style>
    .divmg {
        margin:5px;
    }
</style>
