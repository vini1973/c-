using System;
using System.Web.UI;
using System.Collections;
using System.Web.UI.WebControls;

namespace SmartShare.Web.TelaPadrao.Zoom
{
	public partial class SmartControls_ZoomPopUp : SmartShare.Web.TelaPadrao.Zoom.ZoomPopUpMasterBase
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			System.Text.StringBuilder b = new System.Text.StringBuilder();
			b.Append("function _Selecionar(id){var ds = $get(\"ds\"+id).innerHTML;");

			b.Append("while(ds.search(\"&amp;\")>=0) {");
			b.Append("	ds = ds.replace(\"&amp;\", \"&\"); }");

			b.Append("window.opener.").Append(Request.QueryString["cbfn"]).Append("(id, ds);");
			b.Append("window.close();}");
			Page.ClientScript.RegisterStartupScript(typeof(String), "selecionar", b.ToString(), true);
		}

		protected override void OnInit(EventArgs e)
		{
			base.OnInit(e);
			//cbfn = Call Back Function Name. Nome da função localizada no window.opener que será executada quando for selecionado um registro
			if ((Request.QueryString["cbfn"] == null) || (Request.QueryString["cbfn"].ToString() == String.Empty))
			{
				throw new Exception("Parâmetro cbfn inválido!");
			}
		}

		public override HeaderUCBase Header
		{
			get { return header1; }
		}
	}
}