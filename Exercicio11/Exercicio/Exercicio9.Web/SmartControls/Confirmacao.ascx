<%@ Control	Language="C#" AutoEventWireup="true" CodeFile="Confirmacao.ascx.cs"
	Inherits="SmartShare.Web.TelaPadrao.SmartControls_Confirmacao" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<cc1:RoundedCornersExtender TargetControlID="Panel3" BorderColor="#CCCCCC" Color="#F4F4F4" Radius="8" ID="RoundedCornersExtender1" runat="server"></cc1:RoundedCornersExtender>
<asp:Panel ID="Panel1" runat="server" Style="display:none;">
	<asp:Panel ID="Panel3" runat="server" CssClass="modalPopup">
		<div class="confirmacao">
			<h2>Confirmação!</h2>
			<p><asp:Label ID="lblFraseConfirmacao" runat="server" Text=""></asp:Label></p>
		</div>
		<div class="botoes">
			<asp:UpdatePanel ID="UpdatePanel1" runat="server">
				<Triggers>
					<asp:PostBackTrigger ControlID="btnCancelar" />
				</Triggers>
				<ContentTemplate>
					<asp:ImageButton CssClass="botao" ID="btnOk" runat="server" ImageUrl="~/SmartControls/Imagens/Botoes/btConfirmar.gif" />
					<asp:ImageButton CssClass="botao" ID="btnCancelar" runat="server" ImageUrl="~/SmartControls/Imagens/Botoes/btCancelar.gif" CausesValidation="false" />					
				</ContentTemplate>
			</asp:UpdatePanel>
		</div>
	</asp:Panel>
</asp:Panel>
<asp:Button ID="Button1" runat="server" Text="Button" Style="display:none;" />
<cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="Panel1"
	BackgroundCssClass="modalBackground" TargetControlID="Button1"
	CancelControlID="btnCancelar" />