using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartShare.Web.TelaPadrao
{

	public partial class SmartControls_Confirmacao : System.Web.UI.UserControl
	{
		/// <summary>
		/// Texto que será mostrado para informar ao usuário o que deve confirmar
		/// </summary>
		public String FraseConfirmacao
		{
			get { return lblFraseConfirmacao.Text; }
			set { lblFraseConfirmacao.Text = value; }
		}

		/// <summary>
		/// ID do botão que irá acionar a janela de confirmação
		/// </summary>
		public String ConfirmButtonID
		{
			get { return ModalPopupExtender1.TargetControlID; }
			set { ModalPopupExtender1.TargetControlID = value; }
		}
		/// <summary>
		/// Evento do botão OK
		/// </summary>
		public event ImageClickEventHandler BtnOk_Click
		{
			add { btnOk.Click += new ImageClickEventHandler(value); }
			remove { btnOk.Click -= new ImageClickEventHandler(value); }
		}

		/// <summary>
		/// Força a janela de confirmação a ser mostrada sem necessitar do clique em um botão
		/// </summary>
		public void Mostrar()
		{
			ModalPopupExtender1.Show();
		}
		/// <summary>
		/// Fecha a janela de confirmação
		/// </summary>
		public void Esconder()
		{
			ModalPopupExtender1.Hide();
		}
	}
}