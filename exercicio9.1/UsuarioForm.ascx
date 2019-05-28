<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UsuarioForm.ascx.cs" Inherits="UsuarioForm" %>
<table class="tabelaFormulario">
	<thead>
		<tr class="cabecalho">
			
		</tr>
	</thead>
	<tbody>
		<tr class="linhaClara">
			<td style="width: 100px;"><h1>Nome:</h1></td>
			<td><asp:TextBox ID="nomeid" runat="server" placeholder="Junior Santos"> </asp:TextBox>
				&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nomeid"
					ErrorMessage="Este campo é requerido" EnableClientScript="True"></asp:RequiredFieldValidator></td>
		</tr>
		<tr class="linhaEscura">
			<td><h1>Email:</h1></td>
			<td><asp:TextBox ID="emailid" runat="server" placeholder="junior.santos@gmail.com"></asp:TextBox>
				&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="emailid"
					ErrorMessage="Este campo é requerido" EnableClientScript="True"></asp:RequiredFieldValidator></td>
		</tr>
		<tr class="linhaClara">
			<td><h1>Nascimento:</h1></td>
			<td>
				<asp:TextBox ID="nasciid" runat="server" placeholder="21/09/1994"></asp:TextBox>
				&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="nasciid"
					ErrorMessage="Este campo é requerido" EnableClientScript="True"></asp:RequiredFieldValidator></td>
		</tr>
        <tr class="linhaEscura">
			<td><h1>CPF:</h1></td>
			<td>
				<asp:TextBox ID="cpfid" runat="server" placeholder="10408589254"></asp:TextBox>
				&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="cpfid"
					ErrorMessage="Este campo é requerido" EnableClientScript="True"></asp:RequiredFieldValidator></td>
		</tr>
		<tr class="linhaClara">
			<td><h1>Sexo:</h1></td>
			<td>
				<asp:DropDownList ID="sexoid" runat="server">
                    <asp:ListItem Text="Masculino" Value="Masculino"></asp:ListItem>
                    <asp:ListItem Text="Feminino" Value="Feminino"></asp:ListItem>
                </asp:DropDownList>
		</tr>
        <tr class="linhaEscura">
			<td><h1>Estado:</h1></td>
			<td>
				<asp:DropDownList ID="estadoid" runat="server">
                    <asp:ListItem text="AC" Value="1"></asp:ListItem>
                    <asp:ListItem text="AL" Value="2"></asp:ListItem>  
                    <asp:ListItem text="AM" Value="3"></asp:ListItem>  
                    <asp:ListItem text="AP" Value="4"></asp:ListItem>  
                    <asp:ListItem text="BA" Value="5"></asp:ListItem>  
                    <asp:ListItem text="CE" Value="6"></asp:ListItem>  
                    <asp:ListItem text="DF" Value="7"></asp:ListItem>  
                    <asp:ListItem text="ES" Value="8"></asp:ListItem>  
                    <asp:ListItem text="GO" Value="9"></asp:ListItem>  
                    <asp:ListItem text="MA" Value="10"></asp:ListItem>  
                    <asp:ListItem text="MG" Value="11"></asp:ListItem>  
                    <asp:ListItem text="MS" Value="12"></asp:ListItem>  
                    <asp:ListItem text="MT" Value="13"></asp:ListItem>  
                    <asp:ListItem text="PA" Value="14"></asp:ListItem>  
                    <asp:ListItem text="PB" Value="15"></asp:ListItem>  
                    <asp:ListItem text="PE" Value="16"></asp:ListItem>  
                    <asp:ListItem text="PI" Value="17"></asp:ListItem>  
                    <asp:ListItem text="PR" Value="18"></asp:ListItem>  
                    <asp:ListItem text="RJ" Value="19"></asp:ListItem>  
                    <asp:ListItem text="RN" Value="20"></asp:ListItem>  
                    <asp:ListItem text="RO" Value="21"></asp:ListItem>  
                    <asp:ListItem text="RR" Value="22"></asp:ListItem>    
                    <asp:ListItem text="RS" Value="23"></asp:ListItem>  
                    <asp:ListItem text="SC" Value="24"></asp:ListItem>  
                    <asp:ListItem text="SE" Value="25"></asp:ListItem>  
                    <asp:ListItem text="SP" Value="26"></asp:ListItem>  
                    <asp:ListItem text="TO" Value="27"></asp:ListItem>  
                </asp:DropDownList>
		</tr>
        <tr class="linhaClara">
			<td><h1>Cidade:</h1></td>
			<td>
				 <asp:TextBox ID="cidadeid" runat="server" placeholder="joinville"></asp:TextBox>
		</tr>
        <tr class="linhaEscura">
			<td><h1>Endereco:</h1></td>
			<td>
				  <asp:TextBox ID="enderecoid" runat="server" placeholder="rua santa maria numero 413" Height="50px" Width="200px"></asp:TextBox>
		</tr>
	</tbody>
</table>