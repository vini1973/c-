using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartShare.Web.TelaPadrao
{

	public partial class SmartControls_Confirmacao : System.Web.UI.UserControl
	{
		/// <summary>
		/// Texto que ser� mostrado para informar ao usu�rio o que deve confirmar
		/// </summary>
		public String FraseConfirmacao
		{
			get { return lblFraseConfirmacao.Text; }
			set { lblFraseConfirmacao.Text = value; }
		}

		/// <summary>
		/// ID do bot�o que ir� acionar a janela de confirma��o
		/// </summary>
		public String ConfirmButtonID
		{
			get { return ModalPopupExtender1.TargetControlID; }
			set { ModalPopupExtender1.TargetControlID = value; }
		}
		/// <summary>
		/// Evento do bot�o OK
		/// </summary>
		public event ImageClickEventHandler BtnOk_Click
		{
			add { btnOk.Click += new ImageClickEventHandler(value); }
			remove { btnOk.Click -= new ImageClickEventHandler(value); }
		}

		/// <summary>
		/// For�a a janela de confirma��o a ser mostrada sem necessitar do clique em um bot�o
		/// </summary>
		public void Mostrar()
		{
			ModalPopupExtender1.Show();
		}
		/// <summary>
		/// Fecha a janela de confirma��o
		/// </summary>
		public void Esconder()
		{
			ModalPopupExtender1.Hide();
		}
	}
}