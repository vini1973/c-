<%@ Page Title="" Language="C#" MasterPageFile="~/SmartControls/TelaGerenciamento/TelaGerenciamentoMaster.master" AutoEventWireup="true" CodeFile="TgUsuario.aspx.cs" Inherits="TgUsuario" %>

<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=6.1.12.820, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>
<%@ Register Src="~/UsuarioForm.ascx" TagPrefix="usuarioForm" TagName="UsuarioForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
					<thead class="cabecalho">
                        <sshare:ordenacao ID="tgOrdenacao" runat="server" />
					</thead>
					<tbody>
						<asp:Repeater ID="rptLista" runat="server">
							<ItemTemplate>
								<tr class="linhaEscura">
									<td width="1%">
										<input id="chkIdRegistro" type="checkbox" name="chkIdRegistro" runat="server" value='<%# Eval("Contato.CdContato.Value") %>'
											onclick="checkChanged(this)" />
									</td>
									<td width="1%">
										<asp:LinkButton ToolTip="Detalhar Registro" CssClass="botaoDetalhar" ID="ibtDetalhar" runat="server" CommandArgument='<%# Eval("Contato.Cdcontato.Value") %>' CommandName="Detalhes"></asp:LinkButton>
									</td>
									<td width="1%">
										<asp:LinkButton ToolTip="Excluir Registro" CssClass="botaoExcluir" ID="ibtExcluir" runat="server" CommandArgument='<%# Eval("Contato.Cdcontato.Value") %>' CommandName="Excluir"></asp:LinkButton>
									</td>
									<td style="text-align:center"><%# Eval("Contato.CdContato.Value")%></td>
									<td><%# Eval("Contato.DsNome.Value")%></td>
									<td><%# Eval("Contato.DsEmail.Value")%></td>
                                    <td><%# Eval("Contato.DtNasci.Value")%></td>
                                    <td><%# Eval("Contato.DsCpf.Value")%></td>
                                    <td><%# Eval("Contato.DsSexo.Value")%></td>
                                    <td><%# Eval("Contato.DsCidade.Value")%></td>
								    <td><%# Eval("Estado.UfEstado.Value")%></td>
                                    <td><%# Eval("Contato.DsEndereco.Value")%></td>
                                </tr>
							</ItemTemplate>
							<AlternatingItemTemplate>
								<tr class="linhaClara">
									<td width="1%">
										<input id="chkIdRegistro" type="checkbox" name="chkIdRegistro" runat="server" value='<%# Eval("Contato.Cdcontato.Value") %>'
											onclick="checkChanged(this)" />
									</td>
									<td width="1%">
										<asp:LinkButton ToolTip="Detalhar Registro" CssClass="botaoDetalhar" ID="ibtDetalhar" runat="server" CommandArgument='<%# Eval("Contato.Cdcontato.Value") %>' CommandName="Detalhes"></asp:LinkButton>
									</td>
									
                                    <td width="1%">
										<asp:LinkButton ToolTip="Excluir Registro" CssClass="botaoExcluir" ID="ibtExcluir" runat="server" CommandArgument='<%# Eval("Contato.Cdcontato.Value") %>' CommandName="Excluir"></asp:LinkButton>
									</td>
									<td style="text-align:center"><%# Eval("Contato.CdContato.Value")%></td>
									<td><%# Eval("Contato.DsNome.Value")%></td>
									<td><%# Eval("Contato.DsEmail.Value")%></td>
                                    <td><%# Eval("Contato.DtNasci.Value")%></td>
                                    <td><%# Eval("Contato.DsCpf.Value")%></td>
                                    <td><%# Eval("Contato.DsSexo.Value")%></td>
                                    <td><%# Eval("Contato.DsCidade.Value")%></td>
								    <td><%# Eval("Estado.UfEstado.Value")%></td>
                                    <td><%# Eval("Contato.DsEndereco.Value")%></td>
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
				<usuarioForm:UsuarioForm runat="server" ID="formDetalhes" />
			</ContentTemplate>
		</asp:UpdatePanel>
		<sshare:BotoesDetalhes runat="server" id="tgBotoesDetalhes" />
	</asp:Panel>
	<asp:Panel ID="pnlIncluir" runat="server">
		<asp:UpdatePanel ID="UpdatePanel3" runat="server">
			<ContentTemplate>
				<usuarioForm:UsuarioForm runat="server" ID="formIncluir" />
			</ContentTemplate>
		</asp:UpdatePanel>
		<sshare:BotoesNovo runat="server" id="tgBotoesNovo" />
	</asp:Panel>
    <asp:Panel runat="server" ID="pnlRelatorio" Visible="false">
        <telerik:ReportViewer ID="ReportViewer1" runat="server"></telerik:ReportViewer>
    </asp:Panel>
    <asp:Panel runat="server" ID="pnlGrafico" Visible="false">
        <telerik:ReportViewer ID="ReportViewer2" runat="server"></telerik:ReportViewer>
    </asp:Panel>
</asp:Content>


