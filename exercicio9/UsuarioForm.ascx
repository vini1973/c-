<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UsuarioForm.ascx.cs" Inherits="UsuarioForm" %>
<table class="tabelaFormulario">
	<thead>
		<tr class="cabecalho">
			<td colspan="2">
				&nbsp;
			</td>
		</tr>
	</thead>
	<tbody>
		<tr class="linhaClara">
			<td><h1>Nome:</h1></td>
			<td><asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
				&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNome"
					ErrorMessage="Este campo é requerido" EnableClientScript="True"></asp:RequiredFieldValidator></td>
		</tr>
		<tr class="linhaEscura">
			<td><h1>Email:</h1></td>
			<td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
				&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail"
					ErrorMessage="Este campo é requerido" EnableClientScript="True"></asp:RequiredFieldValidator></td>
		</tr>
		<tr class="linhaClara">
			<td><h1>Nascimento:</h1></td>
			<td>
				<asp:TextBox ID="txtDtNasc" runat="server"></asp:TextBox>
				&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDtNasc"
					ErrorMessage="Este campo é requerido" EnableClientScript="True"></asp:RequiredFieldValidator></td>
		</tr>
		<tr class="linhaEscura">
			<td><h1>Cidade Nascimento:</h1></td>
			<td>
				<asp:DropDownList ID="ddlCidadeNasc" runat="server"></asp:DropDownList>
				&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ddlCidadeNasc"
					ErrorMessage="Este campo é requerido" EnableClientScript="True"></asp:RequiredFieldValidator></td>
		</tr>
		<tr class="linhaClara">
			<td><h1>Ativo:</h1></td>
			<td>
				<asp:CheckBox ID="chkAtivo" runat="server" />
		</tr>
	</tbody>
</table>