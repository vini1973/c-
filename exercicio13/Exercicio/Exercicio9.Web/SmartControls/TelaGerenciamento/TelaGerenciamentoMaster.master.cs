using System;
using System.Web.UI;
using System.Collections;
using System.Web.UI.WebControls;

using SmartShare.Web.TelaPadrao;

namespace SmartShare.Web.TelaPadrao.Gerenciamento
{
	public partial class TelaGerenciamentoBase : SmartShare.Web.TelaPadrao.Gerenciamento.TelaGerenciamentoMasterBase
	{
		private AbaManager _abas;

		public TelaGerenciamentoBase()
		{
			
		}

		protected override void OnInit(EventArgs e)
		{
			base.OnInit(e);
			_abas = header1.Abas;
			this.StrRegistrosSelecionados = Request.Form["hidIds"];
			
		}

		/// <summary>
		/// Controla as propriedades da página
		/// </summary>
		public override HeaderUCBase Header
		{
			get
			{
				return this.header1;
			}
		}

		/// <summary>
		/// [OBSOLETO. Acessar do componente Header] Gerencia as abas da página atual
		/// </summary>
		public AbaManager Abas
		{
			get { return _abas; }
		}
		/// <summary>
		/// [OBSOLETO. Acessar do componente Header] Título da página
		/// </summary>
		public String Titulo
		{
			get { return header1.Titulo; }
			set { header1.Titulo =  value; }
		}
		/// <summary>
		/// [OBSOLETO. Acessar do componente Header] Sub-título da página
		/// </summary>
		public String SubTitulo
		{
			get { return header1.SubTitulo; }
			set { header1.SubTitulo = value; }
		}
		/// <summary>
		/// [OBSOLETO. Acessar do componente Header] Título da Janela (Browser)
		/// </summary>
		public String TituloJanela
		{
			get
			{
				return header1.TituloJanela;
			}
			set
			{
				header1.TituloJanela = value;
			}
		}
		/// <summary>
		/// [OBSOLETO. Acessar do componente Header] Referência ao Panel que contém as abas
		/// </summary>
		public Panel PanelAbas
		{
			get { return header1.PanelAbas; }
		}
		/// <summary>
		/// [OBSOLETO. Acessar do componente Header] Aba atualmente selecionada
		/// </summary>
		public int AbaAtual
		{
			get
			{
				return int.Parse(ViewState["_AbaAtual"].ToString());
			}
			set
			{
				ViewState["_AbaAtual"] = value;
			}
		}
		/// <summary>
		/// [OBSOLETO. Acessar do componente Header] Mostra uma mensagem no canto superior direito da tela
		/// </summary>
		/// <param name="strMensagem">Mensagem a ser mostrada</param>
		public void MostrarAlerta(string strMensagem)
		{
			header1.MostrarAlerta(strMensagem);
		}
		/// <summary>
		/// [OBSOLETO. Acessar do componente Header] Mostra uma mensagem no canto superior direito da tela
		/// </summary>
		/// <param name="strMensagem">Mensagem a ser mostrada</param>
		/// <param name="booComPostBack">Indentifica se a mensagem deverá ser mostrada apenas no próximo PostBack</param>
		public void MostrarAlerta(string strMensagem, bool booComPostBack)
		{
			header1.MostrarAlerta(strMensagem, booComPostBack);
		}
		/// <summary>
		/// [OBSOLETO. Acessar do componente Header] Mostra uma mensagem de erro no canto superior direito da tela
		/// </summary>
		/// <param name="strMensagem">Mensagem a ser mostrada</param>
		public void MostrarErro(string strMensagem)
		{
			header1.MostrarErro(strMensagem);
		}
		/// <summary>
		/// [OBSOLETO. Acessar do componente Header] Mostra uma mensagem de erro no canto superior direito da tela
		/// </summary>
		/// <param name="strMensagem">Mensagem a ser mostrada</param>
		/// <param name="booComPostBack">Indentifica se a mensagem deverá ser mostrada apenas no próximo PostBack</param>
		public void MostrarErro(string strMensagem, bool booComPostBack)
		{
			header1.MostrarErro(strMensagem, booComPostBack);
		}
	}
}