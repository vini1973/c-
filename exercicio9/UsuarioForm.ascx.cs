using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TGSmartControls.BLL;
using TGSmartControls.Model;

public partial class UsuarioForm : System.Web.UI.UserControl
{
    public int CdCidadeNasc
    {
        get { return Convert.ToInt32(ddlCidadeNasc.SelectedValue); }
        set { ddlCidadeNasc.SelectedValue = value.ToString(); }
    }

    public DateTime DtNasc
    {
        get { return Convert.ToDateTime(txtDtNasc.Text); }
        set { txtDtNasc.Text = value.ToShortDateString(); }
    }

    public String Nome
    {
        get { return txtNome.Text; }
        set { txtNome.Text = value; }
    }

    public String Email
    {
        get { return txtEmail.Text; }
        set { txtEmail.Text = value; }
    }

    public bool Ativo
    {
        get { return chkAtivo.Checked; }
        set { chkAtivo.Checked = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlCidadeNasc.Items.Add(new ListItem("SELECIONE"));
            CidadeBLL bll = new CidadeBLL();
            foreach (CidadeInfo info in bll.Listar())
            {
                ddlCidadeNasc.Items.Add(new ListItem(info.DsNome.Value, info.CdCidade.Value.ToString()));
            }
        }
    }

    public void LimparFormulario()
    {
        txtDtNasc.Text = string.Empty;
        txtEmail.Text = string.Empty;
        txtNome.Text = string.Empty;
        chkAtivo.Checked = false;
        ddlCidadeNasc.SelectedIndex = -1;
    }
}