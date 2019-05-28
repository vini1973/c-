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

namespace SmartShare.Web.TelaPadrao
{
	public partial class SmartControls_Alerta : System.Web.UI.UserControl
	{
		public String Mensagem
		{
			get 
			{
				return lblMensagem.Text; 
			}
			set 
			{ 
				lblMensagem.Text = value; 
			}
		}

		public void Mostrar()
		{
			ModalPopupExtender1.Show();
		}
		public void Mostrar(String strMensagem)
		{
			this.Mensagem = strMensagem;
			this.Mostrar();
		}
		public String OkScript
		{
			get 
			{
				return ModalPopupExtender1.OnOkScript; 
			}
			set 
			{ 
				ModalPopupExtender1.OnOkScript = value; 
			}
		}

		/// <summary>
		/// Retonará uma função js ativando o comando "Mostrar" do Alerta
		/// </summary>
		public String MostrarPorJSScript
		{
			get
			{
				return "$find('" + ModalPopupExtender1.ClientID + "').show();";
			}
		}
	}
}