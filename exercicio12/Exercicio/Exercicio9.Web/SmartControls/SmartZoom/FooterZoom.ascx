<%@ Control Language="C#" AutoEventWireup="true" CodeFile="FooterZoom.ascx.cs" Inherits="SmartControls_SmartZoom_FooterZoom" %>
<div class="contemBase">
	
<div class="contenedorPaginacao">	
	<div class="contemPaginacao">
		<p>
			<asp:ImageButton ID="btnPrimeiraPagina" runat="server" ImageUrl="~/SmartControls/Imagens/Botoes/btPrimeiro.gif"
				ToolTip="Primeira Página" ImageAlign="AbsMiddle" CausesValidation="False" OnClick="btnPrimeiraPagina_Click" />
			<asp:ImageButton ID="btnPaginaAnterior" runat="server" ImageUrl="~/SmartControls/Imagens/Botoes/btAnterior.gif"
				ToolTip="Página Anterior" ImageAlign="AbsMiddle" CausesValidation="False" OnClick="btnPaginaAnterior_Click" />
		</p>
		<dfn>Página: </dfn>
		
		<rad:RadComboBox ID="ddlPaginaAtual" Style="float:left; margin:-3px 5px 0px 5px;" runat="server" AutoPostBack="True" Width="20px" OnSelectedIndexChanged="ddlPaginaAtual_SelectedIndexChanged"></rad:RadComboBox>
		<p>
			<asp:ImageButton ID="btnProximaPagina" runat="server" ImageUrl="~/SmartControls/Imagens/Botoes/btProximo.gif"
				ToolTip="Próxima Página" ImageAlign="AbsMiddle" CausesValidation="False" OnClick="btnProximaPagina_Click" />
			<asp:ImageButton ID="btnUltimaPagina" runat="server" ImageUrl="~/SmartControls/Imagens/Botoes/btUltimo.gif"
				ToolTip="Última Página" ImageAlign="AbsMiddle" CausesValidation="False" OnClick="btnUltimaPagina_Click" />
		</p>
	</div>
</div>
<div class="contemQtdRegistros">
		Exibindo
		<rad:RadComboBox ID="ddlRegistrosPorPagina" Style="vertical-align:2px;" runat="server" AutoPostBack="True" Width="20px" OnSelectedIndexChanged="ddlRegistrosPorPagina_SelectedIndexChanged"></rad:RadComboBox>
		registros/página. Total:
		<asp:Label ID="lblTotalRegistros" runat="server"></asp:Label>.
</div>
</div>