using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UsuarioForm : System.Web.UI.UserControl
{
    protected void vericam()
    {
        if (nomeid.Text == "")
        {
            lblAvisoNome.Visible = true;
            //aviso1.Text = "Campo Obrigatório";
        }
        else
        {
        }
    }
    public String Nome
    {
        //vericam(nomeid.Text);
        get { return nomeid.Text; }
        set { nomeid.Text = value; }
    }

    public String Email
    {
        get { return emailid.Text; }
        set { emailid.Text = value; }
    }
    public DateTime Nasc
    {
        get { return Convert.ToDateTime(nasciid.DbSelectedDate); }
        set { nasciid.SelectedDate = value; }
    }
    public String Cpf
    {
        get { return cpfid.Text; }
        set { cpfid.Text = value; }
    }
    public String Sexo
    {
        get { return sexoid.Text; }
        set { sexoid.Text = value; }
    }
    public int Estado
    {
        get { return Convert.ToInt32(estadoid.SelectedValue); }
        set { estadoid.SelectedValue = value.ToString(); }
    }
    public String Cidade
    {
        get { return cidadeid.Text; }
        set { cidadeid.Text = value; }
    }
    public String endereco
    {
        get { return enderecoid.Text; }
        set { enderecoid.Text = value; }
    }

    public Label AvisoNome
    {
        get { return lblAvisoNome; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    public void clear()
    {

        nasciid.Clear();
        emailid.Text = string.Empty;
        nomeid.Text = string.Empty;
        cpfid.Text = string.Empty;
        sexoid.SelectedIndex = 0;
        cidadeid.Text = string.Empty;
        estadoid.SelectedIndex = 0;
        enderecoid.Text = string.Empty;
    }


}