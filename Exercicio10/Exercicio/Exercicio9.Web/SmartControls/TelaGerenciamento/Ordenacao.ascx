<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Ordenacao.ascx.cs" Inherits="SmartShare.Web.TelaPadrao.Gerenciamento.SmartControls_Ordenacao" %>
<td><input id="Checkbox1" type="checkbox" onclick="checkAll(this, this.parentNode.parentNode.parentNode.parentNode.childNodes[1])" /></td>
<td runat="server" class="alinharCentro" id="tdAcoes" colspan="2">Ações</td>
<asp:PlaceHolder ID="plhLinks" runat="server">
</asp:PlaceHolder>