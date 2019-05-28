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
 
        <h1>&nbsp;Cadastro do site</h1>
        <form id="form1" runat="server">
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
                    <asp:ListItem Text="Masculino" Value="masculino"></asp:ListItem>
                    <asp:ListItem Text="Feminino" Value="feminino"></asp:ListItem>
                </asp:DropDownList>
            </div><br />
            <div>
                <asp:Label ID="estado" runat="server" text="estado: "></asp:Label>
                <asp:DropDownList ID="estadoid" runat="server">
                    <asp:ListItem text="AC" Value="AC"></asp:ListItem>
                    <asp:ListItem text="AL" Value="AL"></asp:ListItem>  
                    <asp:ListItem text="AP" Value="AP"></asp:ListItem>  
                    <asp:ListItem text="AM" Value="AM"></asp:ListItem>  
                    <asp:ListItem text="BA" Value="BA"></asp:ListItem>  
                    <asp:ListItem text="CE" Value="CE"></asp:ListItem>  
                    <asp:ListItem text="DF" Value="DF"></asp:ListItem>  
                    <asp:ListItem text="GO" Value="GO"></asp:ListItem>  
                    <asp:ListItem text="MA" Value="MA"></asp:ListItem>  
                    <asp:ListItem text="MT" Value="MT"></asp:ListItem>  
                    <asp:ListItem text="MS" Value="MS"></asp:ListItem>  
                    <asp:ListItem text="MG" Value="MG"></asp:ListItem>  
                    <asp:ListItem text="PA" Value="PA"></asp:ListItem>  
                    <asp:ListItem text="PB" Value="PB"></asp:ListItem>  
                    <asp:ListItem text="PR" Value="PR"></asp:ListItem>  
                    <asp:ListItem text="PE" Value="PE"></asp:ListItem>  
                    <asp:ListItem text="PI" Value="PI"></asp:ListItem>  
                    <asp:ListItem text="RJ" Value="RJ"></asp:ListItem>  
                    <asp:ListItem text="RN" Value="RN"></asp:ListItem>  
                    <asp:ListItem text="RS" Value="RS"></asp:ListItem>  
                    <asp:ListItem text="RO" Value="RO"></asp:ListItem>    
                    <asp:ListItem text="RR" Value="RR"></asp:ListItem>  
                    <asp:ListItem text="SC" Value="SC"></asp:ListItem>  
                    <asp:ListItem text="SP" Value="SP"></asp:ListItem>  
                    <asp:ListItem text="SE" Value="SE"></asp:ListItem>  
                    <asp:ListItem text="TO" Value="TO"></asp:ListItem>  
                    

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
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Atualizar Registros" Width="116px" />

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Apagar todos os registros" />





            </div>
            <asp:Panel ID="pnlTeste" runat="server"></asp:Panel>

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

            
      </form>

     
      </body>
</html>
