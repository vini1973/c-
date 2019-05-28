using System;
using System.Web.UI;

namespace SmartShare.Web.TelaPadrao.Gerenciamento
{
	public partial class SmartControls_BotoesNovo : BotoesNovo
	{
		public override event ImageClickEventHandler BtnConfirmar_Click
		{
			add { btnConfirmar.Click += new ImageClickEventHandler(value); }
			remove { btnConfirmar.Click -= new ImageClickEventHandler(value); }
		}
		public override event ImageClickEventHandler BtnCancelar_Click
		{
			add { btnCancelar.Click += new ImageClickEventHandler(value); }
			remove { btnCancelar.Click -= new ImageClickEventHandler(value); }
		}
		public String BtnConfirmarOnClientClick
		{
			get
			{
				return btnConfirmar.OnClientClick;
			}
			set
			{
				btnConfirmar.OnClientClick = value;
			}
		}
	}
}