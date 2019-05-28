<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PainelOcultavelForm.ascx.cs" Inherits="SmartControls_PainelOcultavelForm" %>

<h1 onclick="javascript: componentePainelOcultavel('<% = this.PainelOcultavel.ClientID %>', '<% = this.lblDsAdicional.ClientID %>', '<% = this.imgIcone.ClientID %>', '<% = this.urlImagemAtiva %>', '<% = this.urlImagemInativa %>', '<% = this.DescricaoAdicionalAtiva %>', '<% = this.DescricaoAdicionalInativa %>');">
	<span class="titulo"> <asp:Label ID="lblNumeroPasso" Visible="false" runat="server"></asp:Label> <asp:Image ID="imgIcone" runat="server" /> <asp:Label ID="lblTitulo" runat="server"></asp:Label></span>
	<span class="compl"><asp:Label ID="lblDsAdicional" runat="server"></asp:Label></span>
</h1>