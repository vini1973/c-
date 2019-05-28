<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="teste1.aspx.cs" Inherits="exercicio3.teste1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

  <asp:GridView ID="GridView1" runat="server">

  </asp:GridView>

  <div>

      <br />

      <asp:Button ID="btnGerarPDF" runat="server" OnClick="btnGerarPDF_Click" Text="PDF" />

  </div>

  </form>

 
</body>
</html>
