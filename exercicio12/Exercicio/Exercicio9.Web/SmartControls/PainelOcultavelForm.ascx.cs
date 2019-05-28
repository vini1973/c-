using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

	/// <summary>
	/// Estrutura para construir um componente que controla a exibi��o din�mica de elementos na tela.
	/// </summary>
	public partial class SmartControls_PainelOcultavelForm : System.Web.UI.UserControl
	{
		/// <summary>
		/// Seta a URL da imagem que indica Painel "Ativo".
		/// </summary>
		public String urlImagemAtiva
		{
			get { return RaizSite + "SmartControls/Imagens/Icones/icoPainelInativo.gif"; }
		}

		/// <summary>
		/// Seta a URL da imagem que indica Painel "Inativo".
		/// </summary>
		public String urlImagemInativa
		{
			get { return RaizSite + "SmartControls/Imagens/Icones/icoPainelAtivo.gif"; }
		}

		/// <summary>
		/// Identifica o estado inicial (visibilidade) do Painel controlado para:
		///		* Inicializ�-lo como "Visivel ou Invisivel";
		///		* Inicializar com a URL da Imagem "Ativa" ou "Inativa".
		/// </summary>
		private bool _visivel;
		public bool Visivel
		{
			get { return _visivel; }
			set
			{
				if (_painelOcultavel == null)
				{
					throw new Exception("PainelOcultavel deve ser diferente de nulo");
				}
				_visivel = value;
				if (value)
				{
					_painelOcultavel.Style.Add("display", "block");
					imgIcone.ImageUrl = urlImagemAtiva;
				}
				else
				{
					_painelOcultavel.Style.Add("display", "none");
					imgIcone.ImageUrl = urlImagemInativa;
				}
			}
		}

		/// <summary>
		/// Identifica o Painel que ser� manipulado "Exibido/Ocultado" pelo componente.
		/// </summary>
		private Panel _painelOcultavel;
		public Panel PainelOcultavel
		{
			get { return _painelOcultavel; }
			set { _painelOcultavel = value; }
		}

		/// <summary>
		/// N�mero do passo que complementa o T�tulo.
		/// OBS.: Por Padr�o, o componente que exibe este valor "n�o" est� Visivel, passando a ser somente quando esta propriedade for setada.
		/// </summary>
		public int NumeroPasso
		{
			get { return int.Parse(lblNumeroPasso.Text); }
			set
			{
				lblNumeroPasso.Visible = true;
				lblNumeroPasso.Text = value.ToString();
			}
		}

		/// <summary>
		/// T�tulo do campo que aciona o componente.
		/// </summary>
		public String Titulo
		{
			get { return lblTitulo.Text.ToString(); }
			set { lblTitulo.Text = value.ToString(); }
		}

		/// <summary>
		/// Texto para descri��o adicional quando o painel controlado for "Ativo".
		/// </summary>
		private String _descricaoAdicionalAtiva = "&nbsp;";
		public String DescricaoAdicionalAtiva
		{
			get { return _descricaoAdicionalAtiva; }
			set
			{
				if (_visivel)
				{
					lblDsAdicional.Text = value.ToString();
				}
				_descricaoAdicionalAtiva = value.ToString();
			}
		}

		/// <summary>
		/// Texto para descri��o adicional quando o painel controlado for "Inativo".
		/// </summary>
		private String _descricaoAdicionalInativa = "&nbsp;";
		public String DescricaoAdicionalInativa
		{
			get { return _descricaoAdicionalInativa; }
			set
			{
				if (!_visivel)
				{
					lblDsAdicional.Text = value.ToString();
				}
				_descricaoAdicionalInativa = value.ToString();
			}
		}

		/// <summary>
		/// Caminho para a Ra�z desta aplica��o web. Ex: /SmartShareCount/
		/// </summary>
		public String RaizSite
		{
			get { return this.Page.Request.ApplicationPath + "/"; }
		}
	}


