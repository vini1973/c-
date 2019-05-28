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
                    
                    ArrayList arraypage = new ArrayList();
                    arraypage = (ArrayList)Session["Conteudo"];

                    for (int i = 0; i < arraypage.Count; i++)
                    {

                        contratoinfo ites = (contratoinfo)arraypage[i];
                        TableRow tRow1 = new TableRow();

                        TableCell tCell = new TableCell();
                        Button btn1 = new Button();
                        btn1.Text = "Editar";
                        btn1.CommandArgument = arraypage.Count.ToString();
                        btn1.Click += btn1_Click;
                        tCell.Controls.Add(btn1);
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


                /*   Button btnTeste = new Button();
                   btnTeste.ID = "btnTeste";
                   btnTeste.Text = "Botao de teste";

                   btnTeste.Click += btnTeste_Click;
                   pnlTeste.Controls.Add(btnTeste);*/


            }
        }
        void btnTeste_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
        }

        protected void adicionarItem(object sender, EventArgs e)
        {
            if (btsalvar.Text=="salvar")
            {

                if (Session["Conteudo"] == null)
                {

                    ArrayList arrayList = new ArrayList();

                    contratoinfo contr = new contratoinfo();
                    contr.acao =
                    contr.nome = nomeid.Text;
                    contr.email = emailid.Text;
                    contr.nasci = nasciid.Text;
                    contr.sexo = sexoid.Text;
                    contr.estado = estadoid.Text;
                    contr.cidade = cidadeid.Text;
                    contr.endereco = enderecoid.Text;
                    arrayList.Add(contr);

                    Session["Conteudo"] = arrayList;
                    for (int i = 0; i < arrayList.Count; i++)
                    {

                        contratoinfo ites = (contratoinfo)arrayList[i];
                        TableRow tRow1 = new TableRow();
                        
                        TableCell tCell = new TableCell();
                        Button btn1 = new Button();
                        btn1.Text = "Editar";
                        btn1.Click += btn1_Click;
                        btn1.CommandArgument = arrayList.Count.ToString();
                        tCell.Controls.Add(btn1);
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

                    nomeid.Text = "";
                    emailid.Text = "";
                }
                else
                {

                    ArrayList arrsesson = (ArrayList)Session["Conteudo"];
                    contratoinfo contr = new contratoinfo();
                    contr.acao =
                    contr.nome = nomeid.Text;
                    contr.email = emailid.Text;
                    contr.nasci = nasciid.Text;
                    contr.sexo = sexoid.Text;
                    contr.estado = estadoid.Text;
                    contr.cidade = cidadeid.Text;
                    contr.endereco = enderecoid.Text;
                    arrsesson.Add(contr);
                    Session["Conteudo"] = arrsesson;
                    int valor = arrsesson.Count;
                    for (int i = 0; i < arrsesson.Count; i++)
                    {
                        contratoinfo ites = (contratoinfo)arrsesson[i];
                        TableRow tRow1  = new TableRow();
                        //tRow1.ID= "1";
                        TableCell tCell = new TableCell();
                        Button btn1 = new Button() ;
                        btn1.Text = "Editar";

                        btn1.CommandArgument = arrsesson.Count.ToString();
                        btn1.Click += btn1_Click ;
                        
                        tCell.Controls.Add(btn1);
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
                    nomeid.Text = "";
                    emailid.Text = "";
                }
            }
            else {
                ArrayList arr = (ArrayList)Session["conteudo"];
                contratoinfo dd = (contratoinfo)arr[0];

                dd.nome = nomeid.Text;
                dd.email = emailid.Text;

                btsalvar.Text = "salvar";
                nomeid.Text = "";
                emailid.Text = "";
            }
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            Button btnClicado = (Button)sender;
            int valor1 = Int32.Parse(btnClicado.CommandArgument);
            ArrayList arr = (ArrayList)Session["Conteudo"];
            contratoinfo dd = (contratoinfo)arr[valor1-1];
            nomeid.Text = dd.nome;
            emailid.Text = dd.email;
            btsalvar.Text = "salvar alteração";
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

        public void editar()
        { 
           ArrayList arr = (ArrayList)Session["Conteudo"];
           contratoinfo dd = (contratoinfo)arr[0];
           nomeid.Text = dd.nome;
           emailid.Text = dd.email;
           btsalvar.Text = "salvar alteração"; 
           
           }

        protected void Button4_Click(object sender, EventArgs e)
        {
            ArrayList arr = (ArrayList)Session["Conteudo"];
            contratoinfo dd = (contratoinfo)arr[0];
            nomeid.Text = dd.nome;
            emailid.Text = dd.email;
            btsalvar.Text = "salvar alteração"; 
        }

        }
           
    }

    
