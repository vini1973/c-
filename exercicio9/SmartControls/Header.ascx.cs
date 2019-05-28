using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartShare.Web.TelaPadrao
{
	public partial class SmartControls_Header : SmartShare.Web.TelaPadrao.HeaderUCBase
	{
		private AbaManager _abas;

		public SmartControls_Header()
		{
			_abas = new AbaManager(this);
		}

		protected void Page_Load(object sender, EventArgs e)
		{
			if (IsPostBack)
			{
				this.Page.Title = ViewState["_PageTitle"].ToString();
			}
			//Verifica se foi ativado o método TrocarAbaComPostBack()
			if ((Request.Form["hidTrocarAbaKey"] != null) && (Request.Form["hidTrocarAbaKey"].ToString().Length > 0))
			{
				this.Abas.TrocarAba(int.Parse(Request.Form["hidTrocarAbaKey"].ToString()));
			}
			//Verifica se foi registrada mensagem para aparecer após o PostBack
			if ((Request.Form["hidRegMsg"] != null) && (Request.Form["hidRegMsg"].ToString().Length > 0))
			{
				RegistrarPlayMessage();
			}
		}

		public override AbaManager Abas
		{
			get { return _abas; }
		}
		/// <summary>
		/// Título da página
		/// </summary>
		public override String Titulo
		{
			get { return lblTitulo.Text; }
			set { lblTitulo.Text = value; }
		}
		/// <summary>
		/// Sub-título da página
		/// </summary>
		public override String SubTitulo
		{
			get { return lblSubTitulo.Text; }
			set { lblSubTitulo.Text = value; }
		}
		/// <summary>
		/// Título da Janela (Browser)
		/// </summary>
		public override String TituloJanela
		{
			get
			{
				return this.Page.Title;
			}
			set
			{
				ViewState["_PageTitle"] = value;
				this.Page.Title = value;
			}
		}

		public override Panel PanelAbas
		{
			get { return pnlAbas; }
		}

		#region Eventos Click
		/// <summary>
		/// 
		/// </summary>
		public override event ImageClickEventHandler BtnAjuda_Click
		{
			add { btnAjuda.Click += value; }
			remove { btnAjuda.Click -= value; }
		}
		#endregion

		private String _URIPaginaHelp;
		/// <summary>
		/// URI da página de help desta tela
		/// </summary>
		public override String URIPaginaHelp
		{
			get
			{
				return _URIPaginaHelp;
			}
			set
			{
				_URIPaginaHelp = value;
				if (value == null)
				{
					btnAjuda.Visible = false;
				}
				else
				{
					btnAjuda.Visible = true;
					btnAjuda.OnClientClick = "window.open('" + _URIPaginaHelp + "', '_blank');return false";
				}
			}
		}

		#region Abas
		/// <summary>
		/// Aba atualmente selecionada
		/// </summary>
		public override int AbaAtual
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
		#endregion
		/// <summary>
		/// Mostra uma mensagem no canto superior direito da tela
		/// </summary>
		/// <param name="strMensagem">Mensagem a ser mostrada</param>
		public override void MostrarAlerta(string strMensagem)
		{
			Panel1.CssClass = "alerta";
			lblMensagem.Text = strMensagem;
			RegistrarPlayMessage();
		}
		/// <summary>
		/// Mostra uma mensagem no canto superior direito da tela
		/// </summary>
		/// <param name="strMensagem">Mensagem a ser mostrada</param>
		/// <param name="booComPostBack">Indentifica se a mensagem deverá ser mostrada apenas no próximo PostBack</param>
		public override void MostrarAlerta(string strMensagem, bool booComPostBack)
		{
			if (booComPostBack)
			{
				Panel1.CssClass = "alerta";
				lblMensagem.Text = strMensagem;
				ScriptManager curSm = System.Web.UI.ScriptManager.GetCurrent(this.Page);
				if (!curSm.IsInAsyncPostBack)
				{
					Page.ClientScript.RegisterStartupScript(this.GetType(), "registerPlayExtender", "__RegistrarPlayMessage(1);", true);
				}
				else
				{
					System.Web.UI.ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "registerPlayExtender", "__RegistrarPlayMessage(1);", true);
				}
			}
			else
			{
				this.MostrarAlerta(strMensagem);
			}
		}
		/// <summary>
		/// Mostra uma mensagem de erro no canto superior direito da tela
		/// </summary>
		/// <param name="strMensagem">Mensagem a ser mostrada</param>
		public override void MostrarErro(string strMensagem)
		{
			Panel1.CssClass = "erro";
			lblMensagem.Text = strMensagem;
			RegistrarPlayMessage();
		}
		/// <summary>
		/// Mostra uma mensagem de erro no canto superior direito da tela
		/// </summary>
		/// <param name="strMensagem">Mensagem a ser mostrada</param>
		/// <param name="booComPostBack">Indentifica se a mensagem deverá ser mostrada apenas no próximo PostBack</param>
		public override void MostrarErro(string strMensagem, bool booComPostBack)
		{
			if (booComPostBack)
			{
				Panel1.CssClass = "erro";
				lblMensagem.Text = strMensagem;
				ScriptManager curSm = System.Web.UI.ScriptManager.GetCurrent(this.Page);
				if (!curSm.IsInAsyncPostBack)
				{
					Page.ClientScript.RegisterStartupScript(this.GetType(), "registerPlayExtender", "__RegistrarPlayMessage(2);", true);
				}
				else
				{
					System.Web.UI.ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "registerPlayExtender", "__RegistrarPlayMessage(2);", true);
				}
			}
			else
			{
				this.MostrarAlerta(strMensagem);
			}
		}
		/// <summary>
		/// Inicia o AnimationExtender da Mensagem
		/// </summary>
		private void RegistrarPlayMessage()
		{
			ScriptManager curSm = System.Web.UI.ScriptManager.GetCurrent(this.Page);
			if (!curSm.IsInAsyncPostBack)
			{
				Page.ClientScript.RegisterStartupScript(this.GetType(), "playExtender", "__PlayMessage(\"" + AnimationExtender1.BehaviorID + "\");", true);
			}
			else
			{
				System.Web.UI.ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "playExtender", "__PlayMessage(\"" + AnimationExtender1.BehaviorID + "\");", true);
			}
		}
	}
}