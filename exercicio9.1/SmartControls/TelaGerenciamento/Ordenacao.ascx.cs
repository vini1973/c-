using System;
using System.Collections;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Smart.Model;

namespace SmartShare.Web.TelaPadrao.Gerenciamento
{
	public partial class SmartControls_Ordenacao : OrdenacaoControl
	{
		private ArrayList _arlBotoes = new ArrayList();
		private String _ASCImgClassName = "imgBgOrdenacaoCima";
		private String _DESCImgClassName = "imgBgOrdenacaoBaixo";
		public const UInt16 NrColunasPadrao = 2;

		public override event OrdenacaoListaChanged OrdenacaoChanged;
		public override BotaoOrdenacao _botaoOrdenado
		{
			get
			{
				return (BotaoOrdenacao)_arlBotoes[int.Parse(ViewState["_indiceBotaoOrdenado"].ToString())];
			}
			set
			{
				ViewState["_indiceBotaoOrdenado"] = value.LnkButton.CommandArgument;
			}
		}
		public override OrderDirection Direcao
		{
			get
			{
				return (OrderDirection)ViewState["_Direcao"];
			}
			set
			{
				ViewState["_Direcao"] = value;
			}
		}
		public override DbField Campo
		{
			get
			{
				return _botaoOrdenado.Campo;
			}
		}

		public override void Adicionar(String strTexto)
		{
			Label link = new Label();
			link.Style.Add("color", "#996633");
			link.ID = "linkOrdenacao" + _arlBotoes.Count.ToString();
			link.Text = strTexto;

			BotaoOrdenacao bt = new BotaoOrdenacao(new LinkButton(), new DbField(), strTexto);
			_arlBotoes.Add(bt);

			System.Web.UI.HtmlControls.HtmlTableCell td = new HtmlTableCell("td");
			td.Controls.Add(link);
			plhLinks.Controls.Add(td);
		}
		public override void Adicionar(String strTexto, DbField campo)
		{
			LinkButton link = this._makeLink(strTexto);

			BotaoOrdenacao bt = new BotaoOrdenacao(link, campo, strTexto);

			System.Web.UI.HtmlControls.HtmlTableCell td = new HtmlTableCell("td");
			Adicionar_(link, bt, td);
		}
		public override void Adicionar(String strTexto, DbField campo, int intLargura)
		{
			LinkButton link = this._makeLink(strTexto);

			BotaoOrdenacao bt = new BotaoOrdenacao(link, campo, strTexto);

			System.Web.UI.HtmlControls.HtmlTableCell td = new HtmlTableCell("td");
			td.Style.Add("width", intLargura.ToString() + "px");
			Adicionar_(link, bt, td);
		}
		public override void Adicionar(String strTexto, DbField campo, AlinhamentoHorizontal alinhamento)
		{
			LinkButton link = this._makeLink(strTexto);

			BotaoOrdenacao bt = new BotaoOrdenacao(link, campo, strTexto);

			System.Web.UI.HtmlControls.HtmlTableCell td = new HtmlTableCell("td");
			switch (alinhamento)
			{
				case AlinhamentoHorizontal.Centro:
					{
						td.Attributes.Add("class", "alinharCentro");
					}
					break;
				case AlinhamentoHorizontal.Direita:
					{
						td.Attributes.Add("class", "alinharDireita");
					}
					break;
				case AlinhamentoHorizontal.Esquerda:
					{
						td.Attributes.Add("class", "alinharEsquerda");
					}
					break;
			}
			Adicionar_(link, bt, td);
		}
		public override void Adicionar(String strTexto, DbField campo, int intLargura, AlinhamentoHorizontal alinhamento)
		{
			LinkButton link = this._makeLink(strTexto);

			BotaoOrdenacao bt = new BotaoOrdenacao(link, campo, strTexto);

			System.Web.UI.HtmlControls.HtmlTableCell td = new HtmlTableCell("td");
			td.Style.Add("width", intLargura.ToString() + "px");
			switch(alinhamento)
			{
				case AlinhamentoHorizontal.Centro:
				{
					td.Attributes.Add("class", "alinharCentro");
				}
				break;
				case AlinhamentoHorizontal.Direita:
				{
					td.Attributes.Add("class", "alinharDireita");
				} 
				break;
				case AlinhamentoHorizontal.Esquerda:
				{
					td.Attributes.Add("class", "alinharEsquerda");
				}
				break;
			}
			Adicionar_(link, bt, td);
		}
		private void Adicionar_(LinkButton lnk, BotaoOrdenacao btOrd, HtmlTableCell td)
		{
			_arlBotoes.Add(btOrd);
			td.Controls.Add(lnk);
			plhLinks.Controls.Add(td);
		}
		private LinkButton _makeLink(String strTexto)
		{
			LinkButton link = new LinkButton();
			link.ID = "linkOrdenacao" + _arlBotoes.Count.ToString();
			link.Command += new CommandEventHandler(LnkButton_Command);
			link.CommandArgument = _arlBotoes.Count.ToString();
			link.Text = strTexto;
			return link;
		}

		public override void LnkButton_Command(object sender, CommandEventArgs e)
		{
			if (_botaoOrdenado.LnkButton.CommandArgument == e.CommandArgument.ToString())
			{
				if (Direcao == OrderDirection.ASC)
					Direcao = OrderDirection.DESC;
				else Direcao = OrderDirection.ASC;
			}

			foreach (object objBtn in _arlBotoes)
			{
				BotaoOrdenacao boBtn = (BotaoOrdenacao)objBtn;
				boBtn.LnkButton.Text = boBtn.Texto;
				if (boBtn.LnkButton.CommandArgument == e.CommandArgument.ToString())
				{
					this.DefinirOrdenacao(boBtn, Direcao);
				}
			}
			OrdenacaoChanged(new OrdenacaoListaChangedArgs(this.Direcao.ToString(), this.Campo));
		}

		public override void DefinirOrdenacao(BotaoOrdenacao btn, OrderDirection direcao)
		{
			this._DefinirOrdenacao(btn, direcao);
		}
		public override void DefinirOrdenacao(int indice, OrderDirection direcao)
		{
			this._DefinirOrdenacao((BotaoOrdenacao)_arlBotoes[indice], direcao);
		}
		private void _DefinirOrdenacao(BotaoOrdenacao btn, OrderDirection direcao)
		{
			Direcao = direcao;
			_botaoOrdenado = btn;

			if (this.Direcao == OrderDirection.ASC)
				btn.LnkButton.Text += " <span class='" + _ASCImgClassName + "'>&nbsp;&nbsp;&nbsp;</span>";
			else btn.LnkButton.Text += " <span class='" + _DESCImgClassName + "'>&nbsp;&nbsp;&nbsp;</span>";
        }

		private UInt16 _nrColunasAdicionais = 0;
		public UInt16 NrColunasAdicionais
		{
			get
			{
				return _nrColunasAdicionais;
			}
			set
			{
				tdAcoes.ColSpan = value + NrColunasPadrao;
				_nrColunasAdicionais = value;
			}
		}
	}
}