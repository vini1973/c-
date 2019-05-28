<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UsuarioForm.ascx.cs" Inherits="UsuarioForm" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<table class="tabelaFormulario">
	<thead>
		<tr class="cabecalho">
			
		</tr>
	</thead>
	<tbody>
		<tr class="linhaClara">
			<td style="width: 100px;"><h1>Nome:</h1></td>
			<td>
                <telerik:RadTextBox ID="nomeid" runat="server" placeholder="junior dos Santos"> </telerik:RadTextBox>
                <asp:Label ID="lblAvisoNome" runat="server" Text="Campo de preenchimento obrigatorio" Visible="false"></asp:Label>
              
                </td>
		</tr>
		<tr class="linhaEscura">
			<td><h1>Email:</h1></td>
			<td><telerik:RadTextBox ID="emailid" runat="server" placeholder="junior.santos@gmail.com" ></telerik:RadTextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="emailid"
					ErrorMessage="Este campo é requerido" EnableClientScript="True"></asp:RequiredFieldValidator></td>
		</tr>
		<tr class="linhaClara">
			<td><h1>Nascimento:</h1></td>
			<td>
                
				<telerik:RadDatePicker ID="nasciid" runat="server" Width="140px" AutoPostBack="true"
                        DateInput-EmptyMessage="MinDate" MinDate="01/01/1000" MaxDate="01/01/3000">
                        <Calendar>
                            <SpecialDays>
                                <telerik:RadCalendarDay Repeatable="Today" ItemStyle-CssClass="rcToday" />
                            </SpecialDays>
                        </Calendar>
                    </telerik:RadDatePicker>

			</td>
		</tr>
        <tr class="linhaEscura">
			<td><h1>CPF:</h1></td>
			<td>
				<telerik:RadTextBox ID="cpfid" runat="server" placeholder="104.089.264-52" ></telerik:RadTextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="cpfid"
                    EnableClientScript="True" ErrorMessage="Este campo é reque8/21/1998rido"></asp:RequiredFieldValidator></td>
		</tr>
		<tr class="linhaClara">
			<td><h1>Sexo:</h1></td>
			<td>
				<telerik:RadComboBox ID="sexoid" runat="server">
                    <Items>
                        <telerik:RadComboBoxItem Text="Masculino" Value="Masculino"></telerik:RadComboBoxItem>
                        <telerik:RadComboBoxItem Text="Feminino" Value="Feminino"></telerik:RadComboBoxItem>
                    </Items>
                </telerik:RadComboBox>
		</tr>
        <tr class="linhaEscura">
			<td><h1>Estado:</h1></td>
			<td>
				<telerik:RadComboBox ID="estadoid" runat="server">
                    <Items>
                    <telerik:RadComboBoxItem  text="AC" Value="1"></telerik:RadComboBoxItem>
                    <telerik:RadComboBoxItem text="AL" Value="2"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="AM" Value="3"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="AP" Value="4"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="BA" Value="5"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="CE" Value="6"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="DF" Value="7"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="ES" Value="8"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="GO" Value="9"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="MA" Value="10"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="MG" Value="11"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="MS" Value="12"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="MT" Value="13"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="PA" Value="14"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="PB" Value="15"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="PE" Value="16"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="PI" Value="17"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="PR" Value="18"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="RJ" Value="19"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="RN" Value="20"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="RO" Value="21"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="RR" Value="22"></telerik:RadComboBoxItem>    
                    <telerik:RadComboBoxItem text="RS" Value="23"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="SC" Value="24"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="SE" Value="25"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="SP" Value="26"></telerik:RadComboBoxItem>  
                    <telerik:RadComboBoxItem text="TO" Value="27"></telerik:RadComboBoxItem>  
                        </Items>
                </telerik:RadComboBox>
		</tr>
        <tr class="linhaClara">
			<td><h1>Cidade:</h1></td>
			<td>
				 <telerik:RadTextBox ID="cidadeid" runat="server" placeholder="Joinville" ></telerik:RadTextBox>
              </td>
		</tr>
        <tr class="linhaEscura">
			<td><h1>Endereco:</h1></td>
			<td>
				  <telerik:RadTextBox ID="enderecoid" runat="server"  TextMode="MultiLine" Rows="5"
                    LabelCssClass="MyLabelMultiline" LabelWidth="0" Columns="5"
                    EmptyMessage="Rua santa maria 413" Height="110px" Width="170px" TabIndex="5"></telerik:RadTextBox>
		</tr>
	</tbody>
</table>