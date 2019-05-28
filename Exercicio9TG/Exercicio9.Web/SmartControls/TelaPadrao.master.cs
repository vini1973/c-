using System;
using System.Web.UI;
using System.Collections;
using System.Web.UI.WebControls;

using SmartShare.Web.TelaPadrao;

namespace SmartShare.Web.TelaPadrao.Gerenciamento
{
	public partial class SmartControls_TelaPadrao : SmartShare.Web.TelaPadrao.TelaMasterBase
	{
		public override HeaderUCBase Header
		{
			get { return Header1; }
		}
	}
}