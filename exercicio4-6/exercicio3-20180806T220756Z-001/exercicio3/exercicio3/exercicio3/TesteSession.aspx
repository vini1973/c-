<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TesteSession.aspx.cs" Inherits="exercicio3.TesteSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TxtConteudo" runat="server"></asp:TextBox>
        
        <asp:TextBox ID="TxtResultado" runat="server"></asp:TextBox>
        
        <asp:Button ID="Button1" runat="server" Text="Escrever" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Ler" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
