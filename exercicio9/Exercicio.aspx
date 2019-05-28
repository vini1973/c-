<%@ Page Title="" Language="C#" MasterPageFile="~/SmartControls/TelaGerenciamento/TelaGerenciamentoMaster.master" AutoEventWireup="true" CodeFile="Exercicio.aspx.cs" Inherits="Exercicio" %>


<%@ Register Src="~/UsuarioForm.ascx" TagPrefix="smarttg" TagName="UsuarioTGHelper2Form" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="contemQuadroBusca" id="divFormBusca" style="display: none;">
		<div class="semFundo">
			<div class="coluna01">
				<h1>Nome:</h1>
				<asp:TextBox ID="txtNome" runat="server" Style="width: 100%;"></asp:TextBox><br />
			</div>
			<div class="contemBotaoBuscar">
				<asp:UpdatePanel ID="UpdatePanel4" runat="server">
					<ContentTemplate>
						<asp:LinkButton ID="lnkBuscar" CssClass="botaoBuscar" runat="server" CausesValidation="false"></asp:LinkButton>
					</ContentTemplate>
				</asp:UpdatePanel>
			</div>
		</div>
	</div>

	<asp:Panel ID="pnlListar" runat="server">
		<asp:UpdatePanel ID="UpdatePanel1" runat="server">
			<ContentTemplate>
				<table id="tblRegistros" class="tabelaListar" cellspacing="0" cellpadding="5">
					<thead>
						<tr class="cabecalho">
							<sshare:ordenacao ID="tgOrdenacao" runat="server" />
						</tr>
					</thead>
					<tbody>
						<asp:Repeater ID="rptLista" runat="server">
							<ItemTemplate>
								<tr class="linhaEscura">
									<td width="1%">
										<input id="chkIdRegistro" type="checkbox" name="chkIdRegistro" runat="server" value='<%# Eval("Usuario.CdUsuario.Value") %>'
											onclick="checkChanged(this)" />
									</td>
									<td width="1%">
										<asp:LinkButton ToolTip="Detalhar Registro" CssClass="botaoDetalhar" ID="ibtDetalhar" runat="server" CommandArgument='<%# Eval("Usuario.CdUsuario.Value") %>' CommandName="Detalhes"></asp:LinkButton>
									</td>
									<td width="1%">
										<asp:LinkButton ToolTip="Excluir Registro" CssClass="botaoExcluir" ID="ibtExcluir" runat="server" CommandArgument='<%# Eval("Usuario.CdUsuario.Value") %>' CommandName="Excluir"></asp:LinkButton>
									</td>
									<td style="text-align:center"><%# Eval("Usuario.CdUsuario.Value")%></td>
									<td><%# Eval("Usuario.DsNome.Value")%></td>
									<td><%# Eval("Cidade.DsNome.Value")%></td>
								</tr>
							</ItemTemplate>
							<AlternatingItemTemplate>
								<tr class="linhaClara">
									<td width="1%">
										<input id="chkIdRegistro" type="checkbox" name="chkIdRegistro" runat="server" value='<%# Eval("Usuario.CdUsuario.Value") %>'
											onclick="checkChanged(this)" />
									</td>
									<td width="1%">
										<asp:LinkButton ToolTip="Detalhar Registro" CssClass="botaoDetalhar" ID="ibtDetalhar" runat="server" CommandArgument='<%# Eval("Usuario.CdUsuario.Value") %>' CommandName="Detalhes"></asp:LinkButton>
									</td>
									<td width="1%">
										<asp:LinkButton ToolTip="Excluir Registro" CssClass="botaoExcluir" ID="ibtExcluir" runat="server" CommandArgument='<%# Eval("Usuario.CdUsuario.Value") %>' CommandName="Excluir"></asp:LinkButton>
									</td>
									<td style="text-align:center"><%# Eval("Usuario.CdUsuario.Value")%></td>
									<td><%# Eval("Usuario.DsNome.Value")%></td>
									<td><%# Eval("Cidade.DsNome.Value")%></td>
								</tr>
							</AlternatingItemTemplate>
						</asp:Repeater>
					</tbody>
				</table>
				<sshare:SmartMsgNoRows ID="tgNoRows" runat="server" />
			</ContentTemplate>
			<Triggers>
				<asp:PostBackTrigger ControlID="rptLista"></asp:PostBackTrigger>
			</Triggers>
		</asp:UpdatePanel>
		<sshare:footerlista runat="server" ID="tgFooterLista" />
	</asp:Panel>
	<asp:Panel ID="pnlDetalhar" runat="server">
		<asp:UpdatePanel ID="UpdatePanel2" runat="server">
			<ContentTemplate>
				<smarttg:UsuarioTGHelper2Form runat="server" ID="formDetalhes" />
			</ContentTemplate>
		</asp:UpdatePanel>
		<sshare:BotoesDetalhes runat="server" id="tgBotoesDetalhes" />
	</asp:Panel>
	<asp:Panel ID="pnlIncluir" runat="server">
		<asp:UpdatePanel ID="UpdatePanel3" runat="server">
			<ContentTemplate>
				<smarttg:UsuarioTGHelper2Form runat="server" ID="formIncluir" />
			</ContentTemplate>
		</asp:UpdatePanel>
		<sshare:BotoesNovo runat="server" id="tgBotoesNovo" />
	</asp:Panel>
</asp:Content>
