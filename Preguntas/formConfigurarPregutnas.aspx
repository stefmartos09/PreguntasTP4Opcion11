<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formConfigurarPregutnas.aspx.cs" Inherits="Preguntas.formConfigurarPregutnas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Configuración de Preguntas</h1>
    <form id="form1" runat="server">
        <div class="divmg">
            <asp:Label ID="Label1" runat="server" Text="Primera Pregunta:"></asp:Label>
            <asp:TextBox  style="width:400px" ID="txtpregunta1"  required="true" runat="server"></asp:TextBox>
        </div>
          <div class="divmg">
      <asp:Label ID="Label2" runat="server" Text="Ingrese las respuestas y marque la correcta."></asp:Label>
     </div>
              <div class="divmg">
                  <asp:RadioButton ID="rbRpta1P1" runat="server" GroupName="PrimeraPregunta" />
                  <asp:TextBox  style="width:300px" ID="txtrespuestaP1R1" runat="server" required="true"> </asp:TextBox>
                   <asp:RadioButton ID="rbRpta2P1" runat="server" GroupName="PrimeraPregunta" />
 <asp:TextBox ID="txtrespuestaP1R2" style="width:300px" runat="server" required="true"></asp:TextBox>
                <asp:RadioButton ID="rbRpta3P1" runat="server" GroupName="PrimeraPregunta" />
                 <asp:TextBox ID="txtrespuestaP1R3" style="width:300px" runat="server" required="true"></asp:TextBox>
      </div>
        <hr />
               <div class="divmg">
           <asp:Label ID="Label3" runat="server" Text="Segunda Pregunta:"></asp:Label>
           <asp:TextBox style="width:400px" ID="txtpregunta2"  required="true" runat="server"></asp:TextBox>
       </div>
         <div class="divmg">
     <asp:Label ID="Label4" runat="server" Text="Ingrese las respuestas y marque la/las correcta/s."></asp:Label>
    </div>
             <div class="divmg">
                 <asp:CheckBox ID="chkRpta1P2" runat="server" />
                 <asp:TextBox  style="width:300px"  ID="txtrespuestaP2R1" runat="server" required="true"> </asp:TextBox>
                 <asp:CheckBox ID="chkRpta2P2" runat="server" />
<asp:TextBox ID="txtrespuestaP2R2" style="width:300px"  runat="server" required="true"></asp:TextBox>
                    <asp:CheckBox ID="chkRpta3P2" runat="server" />
                <asp:TextBox ID="txtrespuestaP2R3" style="width:300px"  runat="server" required="true"></asp:TextBox>
     </div>
                        <div class="divmg">
                            <asp:Label ID="lblRespuesta" runat="server" Text=""></asp:Label>
</div>
                <div class="divmg">
                    <asp:Button  style="margin:10px" ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
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
