<%@ Control Language="C#" AutoEventWireup="true" CodeFile="FooterLista.ascx.cs" Inherits="SmartShare.Web.TelaPadrao.Gerenciamento.SmartControls_FooterLista" %>

<script type="text/javascript">
	function checkChanged(objChk)
	{
		var idRegistro = objChk.value;
		var objHid = $get("hidIds");
		if(objHid==null)
		{
			alert("Erro: Não foi encontrado o objeto 'hidIds'");
			return;
		}

		var strIds = objHid.value;
		var arrIds;
		if(strIds.length==0)
			arrIds = new Array();
		else arrIds = strIds.split(",");

		if(objChk.checked)
		{
			var checkedIds = new Array();
			arrIds[arrIds.length] = objChk.value;
			objHid.value = arrIds.join(",");
		}
		else
		{
			var newCheckedIds = new Array();
			for(var id in arrIds)
			{
				if(arrIds[id]!=idRegistro)
				{
					newCheckedIds[newCheckedIds.length] = arrIds[id];
				}
			}
			objHid.value = newCheckedIds.join(",");
		}
	}
	
	function checkAll(objChk, objTBody)
	{
		var tbl = objTBody;
		if(tbl==null)
		{
			alert("Erro: Não foi encontrado o objeto 'tblRegistros'");
			return;
		}

		var chks = tbl.getElementsByTagName("INPUT");
		if(chks.length!=null) //Há mais de um
		{
			for(var i in chks)
			{
				if((i.toLowerCase()!="length") && (chks[i].type.toUpperCase()=="CHECKBOX") && (chks[i].id!=objChk.id))
				{
					chks[i].checked = objChk.checked;
					checkChanged(chks[i]);
				}
			}
		}
		else //Há apenas um objeto do tipo INPUT
		{
			if((chks.type.toUpperCase()=="CHECKBOX") && (chks.id!=objChk.id))
			{
				chks.checked = objChk.checked;
				checkChanged(chks);
			}
		}
	}
	
	function verifyChecked()
	{
		if($get("hidIds").value.length>0)
		{
			return true;
		}
		else 
		{
			return false;
		}
	}
</script>

<div class="contemBase">
	<div class="contemBotoesAcoes">
		<asp:UpdatePanel ID="UpdatePanel2" runat="server">
			<ContentTemplate>
				<asp:LinkButton CssClass="botaoExcluirSelecionados" ID="btnExcluir" runat="server" ></asp:LinkButton>
				<sshare:confirmacao ID="confirmacao1" runat="server" />
			</ContentTemplate>
		</asp:UpdatePanel>
		<asp:ImageButton ID="btnExportar" runat="server" ImageUrl="" Visible="False" />
		<asp:ImageButton ID="btnImprimir" runat="server" ImageUrl="" Visible="False" />
	</div>
	<div class="contenedorPaginacao">
		<div class="contemPaginacao cpLista">
			<asp:UpdatePanel ID="UpdatePanel3" runat="server">
				<ContentTemplate>
					<p>
						<asp:ImageButton ID="btnPrimeiraPagina" runat="server" ImageUrl="~/SmartControls/Imagens/Botoes/btPrimeiro.gif"
							ToolTip="Primeira Página" ImageAlign="AbsMiddle" CausesValidation="False" OnClick="btnPrimeiraPagina_Click" />
						<asp:ImageButton ID="btnPaginaAnterior" runat="server" ImageUrl="~/SmartControls/Imagens/Botoes/btAnterior.gif"
							ToolTip="Página Anterior" ImageAlign="AbsMiddle" CausesValidation="False" OnClick="btnPaginaAnterior_Click" />
					</p>
				</ContentTemplate>
			</asp:UpdatePanel>
			<asp:UpdatePanel ID="UpdatePanel4" runat="server">
				<ContentTemplate>
					<rad:RadComboBox ID="ddlPaginaAtual" Style="float:left; margin:-3px 5px 0px 5px;" runat="server" AutoPostBack="True" Width="20px"></rad:RadComboBox>
				</ContentTemplate>
			</asp:UpdatePanel>
			<asp:UpdatePanel ID="UpdatePanel5" runat="server">
				<ContentTemplate>
					<p>
						<asp:ImageButton ID="btnProximaPagina" runat="server" ImageUrl="~/SmartControls/Imagens/Botoes/btProximo.gif"
							ToolTip="Próxima Página" ImageAlign="AbsMiddle" CausesValidation="False" OnClick="btnProximaPagina_Click" />
						<asp:ImageButton ID="btnUltimaPagina" runat="server" ImageUrl="~/SmartControls/Imagens/Botoes/btUltimo.gif"
							ToolTip="Última Página" ImageAlign="AbsMiddle" CausesValidation="False" OnClick="btnUltimaPagina_Click" />
					</p>
				</ContentTemplate>
			</asp:UpdatePanel>
		</div>
	</div>
	<div class="contemQtdRegistros">
		<asp:UpdatePanel ID="UpdatePanel1" runat="server">
			<ContentTemplate>
				Exibir
				<rad:RadComboBox ID="ddlRegistrosPorPagina" Style="vertical-align:2px;" runat="server" AutoPostBack="True" Width="20px"></rad:RadComboBox>
				registros por página. Total de registros:
				<asp:Label ID="lblTotalRegistros" runat="server"></asp:Label>.
			</ContentTemplate>
		</asp:UpdatePanel>
		&nbsp;
	</div>
</div>
