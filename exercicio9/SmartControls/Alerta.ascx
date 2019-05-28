<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Alerta.ascx.cs" Inherits="SmartShare.Web.TelaPadrao.SmartControls_Alerta" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<div>
<cc1:RoundedCornersExtender TargetControlID="Panel3" BorderColor="#CCCCCC" Color="#F4F4F4" Radius="8" ID="RoundedCornersExtender1" runat="server"></cc1:RoundedCornersExtender>
<asp:Panel ID="Panel1" runat="server" Style="display:none;">
	<asp:Panel ID="Panel3" runat="server" CssClass="modalPopup">
		<div class="alerta">
			<h2>Aviso!</h2>
			<p><asp:Label ID="lblMensagem" runat="server" Text="Aviso!"></asp:Label></p>
		</div>
		<div class="botoes">
			<asp:ImageButton CssClass="botao" ID="btnOk" runat="server" ImageUrl="~/SmartControls/Imagens/Botoes/btOk.gif" />
		</div>
	</asp:Panel>
</asp:Panel>
<asp:Button ID="Button1" runat="server" Text="Button" Style="display:none;" />
<cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="Panel1"
	BackgroundCssClass="modalBackground" TargetControlID="Button1" OkControlID="btnOk" />
</div>