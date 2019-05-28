<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BotoesDetalhes.ascx.cs"
	Inherits="SmartShare.Web.TelaPadrao.Gerenciamento.SmartControls_BotoesDetalhes" %>
<div class="contemBase">
	<div class="contemBotoesAcoes cbaDetalhes">
		<asp:UpdatePanel ID="UpdatePanel1" runat="server">
			<ContentTemplate>
				<asp:ImageButton ID="btnSalvar" runat="server" ImageUrl="~/SmartControls/Imagens/Botoes/btSalvar.gif" />
			</ContentTemplate>
		</asp:UpdatePanel>
		<asp:ImageButton ID="btnCancelar" runat="server" ImageUrl="~/SmartControls/Imagens/Botoes/btCancelar.gif" CausesValidation="false" />
		<asp:UpdatePanel ID="UpdatePanel2" runat="server">
			<ContentTemplate>
				<asp:ImageButton ID="btnExcluir" runat="server" ImageUrl="~/SmartControls/Imagens/Botoes/btExcluir.gif" />
				<sshare:confirmacao ID="confirmacao1" runat="server" />
			</ContentTemplate>
		</asp:UpdatePanel>
	</div>	
	<div class="contenedorPaginacao">		
		<div class="contemPaginacao">
			<p>
				<asp:UpdatePanel ID="UpdatePanel4" runat="server">
					<ContentTemplate>
						<asp:ImageButton ToolTip="Próximo Registro" ID="btnProximo" runat="server" ImageUrl="~/SmartControls/Imagens/Botoes/btProximo.gif" CausesValidation="false" />
						<asp:ImageButton ToolTip="Último Registro" ID="btnUltimo" runat="server" ImageUrl="~/SmartControls/Imagens/Botoes/btUltimo.gif" CausesValidation="false" />
					</ContentTemplate>
				</asp:UpdatePanel>
			</p>
		</div>
		<div class="contemPaginacao">
			<p>
				<asp:UpdatePanel ID="UpdatePanel3" runat="server">
					<ContentTemplate>
						<asp:ImageButton ToolTip="Primeiro Registro" ID="btnPrimeiro" runat="server" ImageUrl="~/SmartControls/Imagens/Botoes/btPrimeiro.gif" CausesValidation="false" />
						<asp:ImageButton ToolTip="Registro Anterior" ID="btnAnterior" runat="server" ImageUrl="~/SmartControls/Imagens/Botoes/btAnterior.gif" CausesValidation="false" />
					</ContentTemplate>
				</asp:UpdatePanel>
			</p>
		</div>
	</div>
	<div class="contemMensagemRegistroAtual">
		<asp:UpdatePanel ID="UpdatePanel5" runat="server">
			<ContentTemplate>
				Registro <asp:Label ID="lblRegistroAtual" runat="server" Text="Label"></asp:Label> de <asp:Label ID="lblTotalRegistros" runat="server" Text="Label"></asp:Label>.
			</ContentTemplate>
		</asp:UpdatePanel>
	</div>	
</div>