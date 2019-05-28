<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Header.ascx.cs" Inherits="SmartShare.Web.TelaPadrao.SmartControls_Header" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<script type="text/javascript" language="javascript">
		function __TrocarAbaComPostBack(intKey)
		{
			document.getElementById("hidTrocarAbaKey").value = intKey;
			__doPostBack("", "");
		}

		function __RegistrarPlayMessage(intType)
		{
			document.getElementById("hidRegMsg").value = intType;
		}

		function __PlayMessage()
		{
			var obj = $find("AnimationBehavior1");
			if(obj==null)
			{
				window.setTimeout("__PlayMessage()", 500);
			}
			else
			{
				obj.OnClick();
			}
		}
	</script>
<input type="hidden" id="hidTrocarAbaKey" name="hidTrocarAbaKey" value="" />
		<input type="hidden" id="hidRegMsg" name="hidRegMsg" value="" />
	<input type="image" src="Imagens/Estrutura/null.gif" style="border-width:0px;width:0.0em;height:0.0em;float:right;position:absolute;" value="" name="" />
<div class="contemTopo">
	<b class="cantoArredondadoSuperiorPrincipal"><b class="canto1"><b></b></b><b class="canto2">
		<b></b></b><b class="canto3"></b><b class="canto4"></b><b class="canto5"></b></b>
	<asp:UpdateProgress ID="UpdateProgress1" runat="server" DisplayAfter="0">
		<ProgressTemplate>
			<div class="mensagemCarregando">
				Aguarde</div>
		</ProgressTemplate>
	</asp:UpdateProgress>
	<div class="logo">
	</div>
	<h1>
	</h1>
	<div class="infoGeralTela">
		<h2>
			<asp:Label ID="lblTitulo" runat="server" Text="lblTitulo"></asp:Label></h2>
		<cite>
			<asp:Label ID="lblSubTitulo" runat="server"></asp:Label></cite>
	</div>
	<div class="botoes">
		<asp:ImageButton ID="btnAjuda" runat="server" ImageUrl="~/SmartControls/Imagens/Botoes/btHelp.gif"
			CausesValidation="False" Visible="false" ToolTip="Ajuda" />
		<asp:ImageButton ID="btnFechar" runat="server" ImageUrl="~/SmartControls/Imagens/Botoes/btFecharJanela.gif"
			OnClientClick="window.close(); return false;" ToolTip="Fechar" CausesValidation="False" />
	</div>
	<asp:UpdatePanel ID="UpdatePanel2" runat="server">
		<ContentTemplate>
			<cc1:RoundedCornersExtender Radius="5" TargetControlID="Panel1" BorderColor="#FFE6B3"
				ID="RoundedCornersExtender1" runat="server">
			</cc1:RoundedCornersExtender>
			<asp:Button ID="Button1" runat="server" Text="Button" OnClientClick="return false"
				Style="display: none;" />
			<div class="contemMensagemAlertaTopo" id="divPnlMensagem">
				<asp:Panel CssClass="erro" ID="Panel1" Style="background: #FFFFCC;" runat="server">
					<div class="iconeMensagemAlerta">
					</div>
					<asp:Label ID="lblMensagem" runat="server" Text="Label"></asp:Label>
				</asp:Panel>
			</div>
			<cc1:AnimationExtender ID="AnimationExtender1" runat="server" TargetControlID="Button1"
				BehaviorID="AnimationBehavior1">
				<Animations>
			        <OnClick>
				        <Sequence>
					        <EnableAction Enabled="false" />
					        <FadeIn AnimationTarget="divPnlMensagem"
						        Duration=".5" Fps="20" />
					        <EnableAction Enabled="false" Duration="2" />
					        <FadeOut AnimationTarget="divPnlMensagem"
						        Duration=".5" Fps="20" />
					        <EnableAction Enabled="true" />
				        </Sequence>
			        </OnClick>
				</Animations>
			</cc1:AnimationExtender>
		</ContentTemplate>
	</asp:UpdatePanel>
	<div class="contemMenu">
		<asp:Panel ID="pnlAbas" runat="server">
		</asp:Panel>
	</div>
</div>
