<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BotoesNovo.ascx.cs" Inherits=" SmartShare.Web.TelaPadrao.Gerenciamento.SmartControls_BotoesNovo" %>
<div class="contemBase">
    <div class="contemBotoesAcoes cbaNovo">
		<asp:UpdatePanel ID="UpdatePanel2" runat="server">
			<ContentTemplate>
				<asp:ImageButton ID="btnConfirmar" runat="server" ImageUrl="~/SmartControls/Imagens/Botoes/btSalvar.gif" />
			</ContentTemplate>
		</asp:UpdatePanel>
		<asp:ImageButton ID="btnCancelar" runat="server" ImageUrl="~/SmartControls/Imagens/Botoes/btCancelar.gif" CausesValidation="false" />
    </div>
</div>