<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastro.aspx.cs" Inherits="exercicio3.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>cadastro</title>
    <style type="text/css">
        #adicionarBotao {
            width: 55px;
        }
        #nomeid {
            margin-bottom: 0px;
        }
        </style>
</head>
<body>
 
        <form id="form1" runat="server">
 
        <h1>&nbsp;<asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            Cadastro do site</h1>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
            <div>
                <asp:Label ID="nome" runat="server" text="Nome: "></asp:Label>
                <asp:TextBox ID="nomeid" runat="server" placeholder="Junior Santos"></asp:TextBox>
                <asp:Label ID="aviso1" runat="server" Text="Campo de preenchimento obrigatorio" Visible="False"></asp:Label>
             </div><br />
            <div>
                <asp:Label ID="email" runat="server" text="Email: "></asp:Label>
                <asp:TextBox ID="emailid" runat="server" placeholder="junior.santos@gmail.com"></asp:TextBox>
                <asp:Label ID="aviso2" runat="server" Text="Campo de preenchimento obrigatorio" Visible="False"></asp:Label>
             </div><br />
             <div>
                <asp:Label ID="date" runat="server" text="Data de Nascimento: "></asp:Label>
                <asp:TextBox ID="nasciid" runat="server" placeholder="21/09/1994"></asp:TextBox>
                 <asp:Label ID="aviso3" runat="server" Text="Campo de preenchimento obrigatorio" Visible="False"></asp:Label>
             </div><br />
            <div>
                <asp:Label ID="cpf" runat="server" text="CPF: "></asp:Label>
                <asp:TextBox ID="cpfid" runat="server" placeholder="10408589254"></asp:TextBox>
                 <asp:Label ID="aviso4" runat="server" Text="Campo de preenchimento obrigatorio" Visible="False"></asp:Label>
             </div><br />
            <div>
                <asp:Label ID="Label1" runat="server" text="Sexo"></asp:Label>
                <asp:DropDownList ID="sexoid" runat="server">
                    <asp:ListItem Text="Masculino" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Feminino" Value="2"></asp:ListItem>
                </asp:DropDownList>
            </div><br />
            <div>
                <asp:Label ID="estado" runat="server" text="estado: "></asp:Label>
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



             </div><br />
            <div>
                <asp:Label ID="cidade" runat="server" text="Cidade "></asp:Label>
                <asp:TextBox ID="cidadeid" runat="server" placeholder="joinville"></asp:TextBox>
             </div><br />
            <div>
                <asp:Label ID="endereco" runat="server" text="Endereço: "></asp:Label>
                <asp:TextBox ID="enderecoid" runat="server" placeholder="rua santa maria numero 413" Height="102px" Width="217px"></asp:TextBox>
             </div>
            <div>
                <asp:Button ID="btsalvar" runat="server" Text="salvar" OnClick="adicionarItem" />
            &nbsp;
                <asp:Button ID="limparForumulario" runat="server" OnClick="button_clear" Text="limpar formulario" Width="116px" />

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" OnClick="button_removeAll" Text="Apagar todos os registros" />





            </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            
            
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
     <asp:Table ID="tabelaid" runat="server" BorderWidth="1">
            <asp:TableRow ID="TableRow1" runat="server">
                <asp:TableCell BorderWidth="1" width="101" height="40" bgcolor="#666666" ID="TableCell8" runat="server">Ação</asp:TableCell>
                <asp:TableCell BorderWidth="1" width="101" height="40" bgcolor="#666666" ID="TableCell1" runat="server">Nome</asp:TableCell>
                <asp:TableCell width="101" height="40" bgcolor="#666666" ID="TableCell2" runat="server">Email</asp:TableCell>
                <asp:TableCell width="101" height="40" bgcolor="#666666" ID="TableCell9" runat="server">Data de Nascimento</asp:TableCell>
                <asp:TableCell width="101" height="40" bgcolor="#666666" ID="TableCell3" runat="server">CPF</asp:TableCell>
                <asp:TableCell width="101" height="40" bgcolor="#666666" ID="TableCell4" runat="server">Sexo</asp:TableCell>
                <asp:TableCell width="101" height="40" bgcolor="#666666" ID="TableCell5" runat="server">Estado</asp:TableCell>
                <asp:TableCell width="101" height="40" bgcolor="#666666" ID="TableCell6" runat="server">cidade</asp:TableCell>
                <asp:TableCell width="101" height="40" bgcolor="#666666" ID="TableCell7" runat="server">Endereco</asp:TableCell>
            </asp:TableRow>
       
        </asp:Table>
        <asp:HiddenField ID ="codigo" runat="server" />
                     </ContentTemplate>
                </asp:UpdatePanel>
            
      </form>

     
      </body>
</html>
