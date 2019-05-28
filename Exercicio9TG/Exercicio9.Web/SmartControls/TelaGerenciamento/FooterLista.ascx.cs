using System;
using System.Web.UI;

using Telerik.WebControls;

namespace SmartShare.Web.TelaPadrao.Gerenciamento
{
	public partial class SmartControls_FooterLista : FooterLista
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			confirmacao1.ConfirmButtonID = btnExcluir.ID;
			confirmacao1.FraseConfirmacao = "Confirmar a exclusão?";
		}

		#region Botões Lista
		public override event ImageClickEventHandler BtnExportar_Click
		{
			add { btnExportar.Click += value; }
			remove { btnExportar.Click -= value; }
		}
		public override event ImageClickEventHandler BtnImprimir_Click
		{
			add { btnImprimir.Click += value; }
			remove { btnImprimir.Click -= value; }
		}
		public override event ImageClickEventHandler BtnConfirmacaoOk_Click
		{
			add { confirmacao1.BtnOk_Click += value; }
			remove { confirmacao1.BtnOk_Click -= value; }
		}
		#endregion

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
		/// Array de valores que serão mostrados no DropdownList de Quantidade Registros Por Página
		/// </summary>
		public override int[] ArrRegistrosPorPagina
		{
			set
			{
				ddlRegistrosPorPagina.Items.Clear();
				foreach (int i in value)
				{
					ddlRegistrosPorPagina.Items.Add(new Telerik.WebControls.RadComboBoxItem(i.ToString(), i.ToString()));
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
					this.TotalDePaginas = (int)Math.Ceiling((decimal)value / this.RegistrosPorPagina);
				else this.TotalDePaginas = 1;
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
					TotalDePaginas = value;
				}
				ddlPaginaAtual.SelectedIndex = value - 1;
			}
		}
		/// <summary>
		/// Quantidade total de páginas
		/// </summary>
		public override int TotalDePaginas
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

		#region Propriedades com os eventos
		public override event ImageClickEventHandler BtnPaginaAnterior_Click
		{
			add { btnPaginaAnterior.Click += value; }
			remove { btnPaginaAnterior.Click -= value; }
		}
		public override event ImageClickEventHandler BtnPrimeiraPagina_Click
		{
			add { btnPrimeiraPagina.Click += value; }
			remove { btnPrimeiraPagina.Click -= value; }
		}
		public override event ImageClickEventHandler BtnProximaPagina_Click
		{
			add { btnProximaPagina.Click += value; }
			remove { btnProximaPagina.Click -= value; }
		}
		public override event ImageClickEventHandler BtnUltimaPagina_Click
		{
			add { btnUltimaPagina.Click += value; }
			remove { btnUltimaPagina.Click -= value; }
		}
		/// <summary>
		/// Evento "SelectedIndexChanged" do objeto ddlRegistrosPorPagina
		/// </summary>
		public override event RadComboBoxSelectedIndexChangedEventHandler DdlRegistrosPorPagina_SelectedIndexChanged
		{
			add { ddlRegistrosPorPagina.SelectedIndexChanged += value; }
			remove { ddlRegistrosPorPagina.SelectedIndexChanged -= value; }
		}
		public override event RadComboBoxSelectedIndexChangedEventHandler DdlTotalPaginas_SelectedIndexChanged
		{
			add { ddlPaginaAtual.SelectedIndexChanged += value; }
			remove { ddlPaginaAtual.SelectedIndexChanged -= value; }
		}
		#endregion

		#region Eventos
		public override void btnPrimeiraPagina_Click(object sender, ImageClickEventArgs e)
		{
			if (this.PaginaAtual != 1)
				this.PaginaAtual = 1;
		}
		public override void btnPaginaAnterior_Click(object sender, ImageClickEventArgs e)
		{
			if (this.PaginaAtual > 1)
				this.PaginaAtual -= 1;
		}
		public override void btnProximaPagina_Click(object sender, ImageClickEventArgs e)
		{
			if (this.PaginaAtual < this.TotalDePaginas)
				this.PaginaAtual += 1;
		}
		public override void btnUltimaPagina_Click(object sender, ImageClickEventArgs e)
		{
			if (this.PaginaAtual != this.TotalDePaginas)
				this.PaginaAtual = this.TotalDePaginas;
		}
		#endregion
	}
}