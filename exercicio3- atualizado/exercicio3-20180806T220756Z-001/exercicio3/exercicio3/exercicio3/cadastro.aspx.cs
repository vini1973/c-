using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercicio3
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                if (Session["Conteudo"] != null)
                {
                    retb();
                }
            }
        }
        void btnTeste_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
        }

        protected void adicionarItem(object sender, EventArgs e)
        {
            vericam();
            validarCPF(cpfid.Text);
            if (aviso1.Text != "Campo Obrigatório" && aviso2.Text != "Campo Obrigatório" && aviso3.Text != "Campo Obrigatório" && aviso4.Visible == false)
            {
                if (btsalvar.Text == "salvar")
                    {
                        if (Session["Conteudo"] == null)
                        {

                            ArrayList arrayList = new ArrayList();
                            contratoinfo contr = new contratoinfo();
                            contr.nome = nomeid.Text;
                            contr.email = emailid.Text;
                            contr.nasci = nasciid.Text;
                            contr.cpf = cpfid.Text;
                            contr.sexo = sexoid.Text;
                            contr.estado = estadoid.Text;
                            contr.cidade = cidadeid.Text;
                            contr.endereco = enderecoid.Text;
                            arrayList.Add(contr);
                            Session["Conteudo"] = arrayList;
                            clear();
                        }
                        else
                        {
                            vericam();
                            validarCPF(cpfid.Text);
                            if (aviso1.Text == "Campo Obrigatório")
                            { }
                            if (aviso2.Text == "Campo Obrigatório")
                            { }
                            if (aviso3.Text == "Campo Obrigatório")
                            { }
                            if (aviso4.Text == "Campo Obrigatório")
                            { }
                            if (aviso4.Visible == true)
                            { }

                            else
                            {

                                ArrayList arrsesson = (ArrayList)Session["Conteudo"];
                                contratoinfo contr = new contratoinfo();
                                contr.nome = nomeid.Text;
                                contr.email = emailid.Text;
                                contr.nasci = nasciid.Text;
                                contr.cpf = cpfid.Text;
                                contr.sexo = sexoid.Text;
                                contr.estado = estadoid.Text;
                                contr.cidade = cidadeid.Text;
                                contr.endereco = enderecoid.Text;
                                arrsesson.Add(contr);
                                Session["Conteudo"] = arrsesson;
                                clear();
                            }
                        }
                        
                    }
                    else
                    {
                        vericam();
                        if (aviso1.Text == "Campo Obrigatório")
                        { }
                        if (aviso2.Text == "Campo Obrigatório")
                        { }
                        if (aviso3.Text == "Campo Obrigatório")
                        { }
                        if (aviso4.Text == "Campo Obrigatório")
                        { }
                        if (aviso4.Visible == true)
                        {}
                        
                        else 
                        { 
                                ArrayList arr = (ArrayList)Session["conteudo"];
                                contratoinfo dd = (contratoinfo)arr[Int32.Parse(codigo.Value)];
                                dd.nome = nomeid.Text;
                                dd.email = emailid.Text;
                                dd.nasci = nasciid.Text;
                                dd.cpf = cpfid.Text;
                                dd.sexo = sexoid.Text;
                                dd.estado = estadoid.Text;
                                dd.endereco = enderecoid.Text;
                                btsalvar.Text = "salvar";
                                clear();
                        }
                }
                retb();
            }
        }
        protected void btn1_Click(object sender, EventArgs e)
        {
            Button btnClicado = (Button)sender;
            int valor1 = Int32.Parse(btnClicado.CommandArgument);
            ArrayList arr = (ArrayList)Session["Conteudo"];
            contratoinfo dd = (contratoinfo)arr[valor1];
            nomeid.Text = dd.nome;
            emailid.Text = dd.email;
            nasciid.Text = dd.nasci;
            cpfid.Text = dd.cpf;
            sexoid.Text = dd.sexo;
            estadoid.Text = dd.estado;
            cidadeid.Text = dd.cidade;
            enderecoid.Text = dd.endereco;
            codigo.Value = valor1.ToString();
            btsalvar.Text = "salvar alteração";
        }
        protected void btn2_Click(object sender, EventArgs e)
        {
            Button btnClicado = (Button)sender;
            //btnClicado.Attributes.Add("onclick", "return confirm('tem certeza que deseja excluir o registro?');");
            if (btsalvar.Text == "salvar")
            {
                int valor1 = Int32.Parse(btnClicado.CommandArgument);
                ArrayList arr = (ArrayList)Session["Conteudo"];
                arr.RemoveAt(valor1);
                retb();
            }
            else {

                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Você esta editado o registro, portando nao pode excluir, salve a alteração para excluir.')", true);
                
               // Response.Write("Você esta editado o registro, portando nao pode excluir, salve a alteração para excluir.");
            }
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            nomeid.Text = "";
            emailid.Text = "";
            nasciid.Text = "";
            sexoid.Text = "";
            estadoid.Text = "";
            cidadeid.Text = "";
            enderecoid.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["Conteudo"] = null;
        }


        protected void retb()
        {   
            ArrayList arraypage = new ArrayList();
            arraypage = (ArrayList)Session["Conteudo"];

            int teste = tabelaid.Rows.Count;
            for (int i = 1; i < teste; i++)
            {
                tabelaid.Rows.RemoveAt(1);
            }

            for (int i = 0; i < arraypage.Count; i++)
            {
                contratoinfo ites = (contratoinfo)arraypage[i];
                TableRow tRow1 = new TableRow();
                TableCell tCell = new TableCell();
                Button btn1 = new Button();
                btn1.Text = "Editar";
                btn1.CommandArgument = String.Format("{0}", (i));
                btn1.Click += btn1_Click;
                tCell.Controls.Add(btn1);
                tRow1.Cells.Add(tCell);
                Button btn2 = new Button();
                btn2.Text = "Deletar";
                btn2.Click += btn2_Click;
                btn2.CommandArgument = String.Format("{0}", (i));
                tCell.Controls.Add(btn2);
                tRow1.Cells.Add(tCell);
                TableCell tCell0 = new TableCell();
                tCell0.Text = ites.nome;
                tRow1.Cells.Add(tCell0);
                TableCell tCell1 = new TableCell();
                tCell1.Text = ites.email;
                tRow1.Cells.Add(tCell1);
                TableCell tCell2 = new TableCell();
                tCell2.Text = ites.nasci;
                tRow1.Cells.Add(tCell2);
                TableCell tCell00 = new TableCell();
                tCell00.Text = ites.cpf;
                tRow1.Cells.Add(tCell00);
                TableCell tCell3 = new TableCell();
                tCell3.Text = ites.sexo;
                tRow1.Cells.Add(tCell3);
                TableCell tCell4 = new TableCell();
                tCell4.Text = ites.estado;
                tRow1.Cells.Add(tCell4);
                TableCell tCell5 = new TableCell();
                tCell5.Text = ites.cidade;
                tRow1.Cells.Add(tCell5);
                TableCell tCell6 = new TableCell();
                tCell6.Text = ites.endereco;
                tRow1.Cells.Add(tCell6);
                tabelaid.Rows.Add(tRow1);
            }
        }
        protected void clear()
        {
            nomeid.Text = "";
            emailid.Text = "";
            nasciid.Text = "";
            cpfid.Text = "";
            sexoid.Text = "";
            estadoid.Text = "";
            cidadeid.Text = "";
            enderecoid.Text = "";
        }
        protected void vericam()
        {//nome email nasci cpf 
            if (nomeid.Text == "")
            {
                aviso1.Visible = true;
                aviso1.Text = "Campo Obrigatório";
            }

            if (emailid.Text == "")
            {
                aviso2.Visible = true;
                aviso2.Text = "Campo Obrigatório";
            }
            if (nasciid.Text == "")
            {
                aviso3.Visible = true;
                aviso3.Text = "Campo Obrigatório";
            }
            if (cpfid.Text == "")
            {
                aviso4.Visible = true;
                aviso4.Text = "Campo Obrigatório";
            } 
            if (nomeid.Text != "")
            {
                aviso1.Visible = false;
                aviso1.Text = "";
            }
            if (emailid.Text != "")
            {
                aviso2.Visible = false;
                aviso2.Text = "";
            }
            if (nasciid.Text != "")
            {
                aviso3.Visible = false;
                aviso3.Text = "";
            }
            if (cpfid.Text != "")
            {
                aviso4.Visible = false;
                aviso4.Text = "";
            }
        }
        protected void validarCPF(string CPF)
        {
            int[] mt1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mt2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string TempCPF;
            string Digito;
            int soma;
            int resto;

            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "").Replace("-", "");

            if (CPF.Length != 11)
            {
                aviso4.Visible = true; aviso4.Text = "cpf invalido";
            }
            else
            {
                TempCPF = CPF.Substring(0, 9);
                soma = 0;
                for (int i = 0; i < 9; i++)
                    soma += int.Parse(TempCPF[i].ToString()) * mt1[i];

                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                Digito = resto.ToString();
                TempCPF = TempCPF + Digito;
                soma = 0;

                for (int i = 0; i < 10; i++)
                    soma += int.Parse(TempCPF[i].ToString()) * mt2[i];

                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                Digito = Digito + resto.ToString();

                cpfid.Text = CPF;
                aviso4.Visible = false;
            }
        }

    }
}