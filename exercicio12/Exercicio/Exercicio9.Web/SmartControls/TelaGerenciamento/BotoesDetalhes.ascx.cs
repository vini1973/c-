using System;
using System.Web.UI;

namespace SmartShare.Web.TelaPadrao.Gerenciamento
{
	public partial class SmartControls_BotoesDetalhes : BotoesDetalhes
	{
		public override event ImageClickEventHandler BtnSalvar_Click
		{
			add { btnSalvar.Click += new ImageClickEventHandler(value); }
			remove { btnSalvar.Click -= new ImageClickEventHandler(value); }
		}
		public override event ImageClickEventHandler BtnCancelar_Click
		{
			add { btnCancelar.Click += new ImageClickEventHandler(value); }
			remove { btnCancelar.Click -= new ImageClickEventHandler(value); }
		}
		public override event ImageClickEventHandler BtnExcluir_Click
		{
			add { btnExcluir.Click += new ImageClickEventHandler(value); }
			remove { btnExcluir.Click -= new ImageClickEventHandler(value); }
		}
		public override event ImageClickEventHandler BtnProximo_Click
		{
			add { btnProximo.Click += new ImageClickEventHandler(value); }
			remove { btnProximo.Click -= new ImageClickEventHandler(value); }
		}
		public override event ImageClickEventHandler BtnAnterior_Click
		{
			add { btnAnterior.Click += new ImageClickEventHandler(value); }
			remove { btnAnterior.Click -= new ImageClickEventHandler(value); }
		}
		public override event ImageClickEventHandler BtnPrimeiro_Click
		{
			add { btnPrimeiro.Click += new ImageClickEventHandler(value); }
			remove { btnPrimeiro.Click -= new ImageClickEventHandler(value); }
		}
		public override event ImageClickEventHandler BtnUltimo_Click
		{
			add { btnUltimo.Click += new ImageClickEventHandler(value); }
			remove { btnUltimo.Click -= new ImageClickEventHandler(value); }
		}
		protected void Page_Load(object sender, EventArgs e)
		{
			confirmacao1.ConfirmButtonID = btnExcluir.ID;
			confirmacao1.FraseConfirmacao = "Confirma a exclusão deste registro?";
		}
		public override void MostrarConfirmacaoExclusao()
		{
			confirmacao1.Mostrar();
		}
		public override event ImageClickEventHandler BtnOkConfirmacao_Click
		{
			add { confirmacao1.BtnOk_Click += value;}
			remove { confirmacao1.BtnOk_Click -= value;}
		}

		/// <summary>
		/// Mostra o índice do registro atual
		/// </summary>
		public override int RegistroAtual
		{
			get
			{
				return int.Parse(lblRegistroAtual.Text);
			}
			set
			{
				lblRegistroAtual.Text = value.ToString();
			}
		}
		/// <summary>
		/// Mostra o total de registros
		/// </summary>
		public override int TotalRegistros
		{
			get
			{
				return int.Parse(lblTotalRegistros.Text);
			}
			set
			{
				lblTotalRegistros.Text = value.ToString();
			}
		}

		public String BtnSalvarOnClientClick
		{
			get
			{
				return btnSalvar.OnClientClick;
			}
			set
			{
				btnSalvar.OnClientClick = value;
			}
		}

		public String BtnExcluirOnClientClick
		{
			get
			{
				return btnExcluir.OnClientClick;
			}
			set
			{
				btnExcluir.OnClientClick = value;
			}
		}

		public override string BtnExcluirClientID
		{
			get { return this.btnExcluir.ClientID; }
		}
	}
}