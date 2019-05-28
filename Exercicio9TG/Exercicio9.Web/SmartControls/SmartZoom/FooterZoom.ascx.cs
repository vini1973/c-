using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SmartShare.Web.TelaPadrao;
using Telerik.WebControls;

public partial class SmartControls_SmartZoom_FooterZoom : SmartShare.Web.TelaPadrao.Zoom.FooterZoomUCBase
{
	public override event PaginacaoChanged Paginacao_Changed;

	#region Propriedades da paginação
	/// <summary>
	/// Quantidade de registros por página
	/// </summary>
	public override int RegistrosPorPagina
	{
		get { return int.Parse(ddlRegistrosPorPagina.SelectedValue); }
		set
		{
			for (int i = 0; i < ddlRegistrosPorPagina.Items.Count; i++)
			{
				if (ddlRegistrosPorPagina.Items[i].Value == value.ToString())
				{
					ddlRegistrosPorPagina.SelectedIndex = i;
					break;
				}
			}
		}
	}
	/// <summary>
	/// Quantidade total de registros
	/// </summary>
	public override int TotalRegistros
	{
		get { return int.Parse(lblTotalRegistros.Text); }
		set
		{
			lblTotalRegistros.Text = value.ToString();

			//Altera automaticamente a quantidade de páginas
			if (value > 0)
				this.TotalPaginas = (int)Math.Ceiling((decimal)value / this.RegistrosPorPagina);
			else this.TotalPaginas = 1;
		}
	}
	/// <summary>
	/// Número da página atual(Paginação)
	/// </summary>
	public override int PaginaAtual
	{
		get { return int.Parse(ddlPaginaAtual.SelectedValue); }
		set
		{
			if (ddlPaginaAtual.Items.Count < value)
			{
				this.TotalPaginas = value;
			}
			ddlPaginaAtual.SelectedIndex = value - 1;
		}
	}
	/// <summary>
	/// Quantidade total de páginas
	/// </summary>
	public override int TotalPaginas
	{
		get { return ddlPaginaAtual.Items.Count; }
		set
		{
			//Remonta o DropDownList com as páginas selecionáveis
			if (ddlPaginaAtual.Items.Count != value)
			{
				int intOldCount = ddlPaginaAtual.Items.Count;
				int intOldSelectedIndex = ddlPaginaAtual.SelectedIndex;

				ddlPaginaAtual.Items.Clear();
				for (int i = 1; i <= value; i++)
				{
					ddlPaginaAtual.Items.Add(new Telerik.WebControls.RadComboBoxItem(i.ToString(), i.ToString()));
				}

				//Se a página selecionada não existe mais no DropDownList, seleciona a última
				if (intOldSelectedIndex > (ddlPaginaAtual.Items.Count - 1))
				{
					ddlPaginaAtual.SelectedIndex = ddlPaginaAtual.Items.Count - 1;
				}
				else ddlPaginaAtual.SelectedIndex = intOldSelectedIndex;
			}
		}
	}
	#endregion

	#region Eventos
	public void btnPrimeiraPagina_Click(object sender, ImageClickEventArgs e)
	{
		if (this.PaginaAtual != 1)
			this.PaginaAtual = 1;
		Paginacao_Changed();
	}
	public void btnPaginaAnterior_Click(object sender, ImageClickEventArgs e)
	{
		if (this.PaginaAtual > 1)
			this.PaginaAtual -= 1;
		Paginacao_Changed();
	}
	public void btnProximaPagina_Click(object sender, ImageClickEventArgs e)
	{
		if (this.PaginaAtual < this.TotalPaginas)
			this.PaginaAtual += 1;
		Paginacao_Changed();
	}
	public void btnUltimaPagina_Click(object sender, ImageClickEventArgs e)
	{
		if (this.PaginaAtual != this.TotalPaginas)
			this.PaginaAtual = this.TotalPaginas;
		Paginacao_Changed();
	}
	protected void ddlPaginaAtual_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
	{
		Paginacao_Changed();
	}
	protected void ddlRegistrosPorPagina_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
	{
		Paginacao_Changed();
	}
	#endregion

	public override void PopularRegistrosPorPagina(int[] arrOpcoes)
	{
		foreach (int intOpcao in arrOpcoes)
		{
			ddlRegistrosPorPagina.Items.Add(new Telerik.WebControls.RadComboBoxItem(intOpcao.ToString(), intOpcao.ToString()));
		}
	}
}