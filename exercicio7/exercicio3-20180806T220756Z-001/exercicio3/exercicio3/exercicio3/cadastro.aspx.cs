using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Smart.Database.SQL;
using System.Web.UI.WebControls;
using System.Data;
using Exercicio3.Camadas;

namespace exercicio3
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             //if (Page.IsPostBack)
             //  { 
             //    recriartb();
                   
             //  }

            recriartb();
        }
        protected void adicionarItem(object sender, EventArgs e)
        {
            vericam();
            validarCPF(cpfid.Text);
            if (aviso1.Text != "Campo Obrigatório" && aviso2.Text != "Campo Obrigatório" && aviso3.Text != "Campo Obrigatório" && aviso4.Visible == false)
            {
                if (btsalvar.Text == "salvar")
                {
                    DbConn dbHnd = new DbConn();
                    try
                    {
                        //Abrir Conexão
                        dbHnd.OpenConnection();

                        contratoinfo contr = new contratoinfo();
                        contr.acao =
                        contr.nome = nomeid.Text;
                        contr.email = emailid.Text;
                        contr.nasci = nasciid.Text;
                        contr.cpf = cpfid.Text;
                        contr.sexo = sexoid.Text;
                        contr.estado = Int32.Parse(estadoid.SelectedValue);
                        contr.cidade = cidadeid.Text;
                        contr.endereco = enderecoid.Text;

                        dbHnd.AddParameter("nome", contr.nome);
                        dbHnd.AddParameter("email", contr.email);
                        dbHnd.AddParameter("nasci", contr.nasci);
                        dbHnd.AddParameter("cpf", contr.cpf);
                        dbHnd.AddParameter("sexo", contr.sexo);
                        dbHnd.AddParameter("estado", contr.estado);
                        dbHnd.AddParameter("cidade", contr.cidade);
                        dbHnd.AddParameter("endereco", contr.endereco);
                        dbHnd.ExecuteNonQuery("INSERT INTO CONTATO(ds_nome,ds_email,dt_nasci,ds_cpf,ds_sexo,cd_estado,ds_cidade,ds_endereco)values(" + dbHnd.GetSqlParam("nome") + ","
                                                + "" + dbHnd.GetSqlParam("email") + "," + dbHnd.GetSqlParam("nasci") + "," + dbHnd.GetSqlParam("cpf") + "," + dbHnd.GetSqlParam("sexo") + ","
                                                + "" + dbHnd.GetSqlParam("estado") + "," + dbHnd.GetSqlParam("cidade") + "," + dbHnd.GetSqlParam("endereco") + ")");

                        //Fechar Conexão
                        dbHnd.CloseConnection();

                    }
                    finally
                    {
                        //matar a conexão
                        dbHnd.Dispose();
                    }
                    clear();
                }
                else
                {
                    DbConn dbHnd = new DbConn();
                    try
                    {
                        //Abrir Conexão
                        dbHnd.OpenConnection();

                        ContatoInfo cInfo = new ContatoInfo();
                        cInfo.DsContato = nomeid.Text;

                        contratoinfo dd = new contratoinfo();
                        dd.nome = nomeid.Text;
                        dd.email = emailid.Text;
                        dd.nasci = nasciid.Text;
                        dd.cpf = cpfid.Text;
                        dd.sexo = sexoid.Text;
                        dd.cidade = cidadeid.Text;
                        dd.estado = Int32.Parse(estadoid.SelectedValue);
                        dd.endereco = enderecoid.Text;

                        dbHnd.AddParameter("nome", dd.nome);
                        dbHnd.AddParameter("email", dd.email);
                        dbHnd.AddParameter("nasci", dd.nasci);
                        dbHnd.AddParameter("cpf", dd.cpf);
                        dbHnd.AddParameter("sexo", dd.sexo);
                        dbHnd.AddParameter("estado", dd.estado);
                        dbHnd.AddParameter("cidade", dd.cidade);
                        dbHnd.AddParameter("endereco", dd.endereco);
                        dbHnd.AddParameter("codigo", codigo.Value);
                        btsalvar.Text = "salvar";


                        dbHnd.ExecuteNonQuery("UPDATE CONTATO SET ds_nome=" + dbHnd.GetSqlParam("nome") 
                                                                + ",ds_email=" + dbHnd.GetSqlParam("email") 
                                                                + ",dt_nasci=" + dbHnd.GetSqlParam("nasci")
                                                                + ",ds_cpf=" + dbHnd.GetSqlParam("cpf") 
                                                                + ",ds_sexo=" + dbHnd.GetSqlParam("sexo") 
                                                                + ",cd_estado=" + dbHnd.GetSqlParam("estado") 
                                                                + ",ds_cidade="+ dbHnd.GetSqlParam("cidade") 
                                                                + ",ds_endereco=" + dbHnd.GetSqlParam("endereco") 
                                                                + " WHERE cd_contato=" + dbHnd.GetSqlParam("codigo"));

                        //Fechar Conexão
                        dbHnd.CloseConnection();

                    }
                    finally
                    {
                        //matar a conexão
                        dbHnd.Dispose();
                    }
                    clear();
                }


                recriartb();
            }   
        }
        protected void button_editar(object sender, EventArgs e)
        {
            DbConn dbHnd = new DbConn();
            try
            {
                //Abrir Conexão
                dbHnd.OpenConnection();
                Button btnClicado = (Button)sender;
                int valor1 = Int32.Parse(btnClicado.CommandArgument);
                dbHnd.AddParameter("codigo", valor1);
                DataRow dRowLinha = dbHnd.FillDataRow("SELECT cd_contato, ds_nome,ds_email,dt_nasci,ds_cpf,ds_sexo,ds_cidade,ds_endereco,cd_estado FROM CONTATO where cd_contato=" + dbHnd.GetSqlParam("codigo"));

                if (dRowLinha != null)
                {
                    nomeid.Text = dRowLinha["ds_nome"].ToString();
                    emailid.Text = dRowLinha["ds_email"].ToString();
                    nasciid.Text = dRowLinha["dt_nasci"].ToString();
                    cpfid.Text = dRowLinha["ds_cpf"].ToString();
                    sexoid.Text = dRowLinha["ds_sexo"].ToString();
                    estadoid.SelectedValue = dRowLinha["cd_estado"].ToString();
                    cidadeid.Text = dRowLinha["ds_cidade"].ToString();
                    enderecoid.Text = dRowLinha["ds_endereco"].ToString();
                    codigo.Value = valor1.ToString();
                    btsalvar.Text = "salvar alteração";
                }

                //Fechar Conexão
                dbHnd.CloseConnection();
            }
            finally
            {
                //matar conexão
                dbHnd.Dispose();
            }
            UpdatePanel2.Update();
        }
        protected void button_remove(object sender, EventArgs e)
        {
            Button btnClicado = (Button)sender;
            if (btsalvar.Text == "salvar")
            {
                DbConn dbHnd = new DbConn();
                try
                {
                    //Abrir Conexão
                    dbHnd.OpenConnection();
                    int valor1 = Int32.Parse(btnClicado.CommandArgument);
                    dbHnd.AddParameter("codigo", valor1);
                    dbHnd.ExecuteNonQuery("DELETE FROM CONTATO WHERE cd_contato = " + dbHnd.GetSqlParam("codigo"));

                    //Fechar Conexão
                    dbHnd.CloseConnection();
                }
                finally
                {
                    //matar conexão
                    dbHnd.Dispose();
                }
                recriartb();
            }
            else 
            {
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Você esta editado o registro, portando nao pode excluir, salve a alteração para excluir.')", true);
            }
        }
        protected void button_clear(object sender, EventArgs e)
        {
            clear();
            
        }
        protected void button_removeAll(object sender, EventArgs e)
        {
            UpdatePanel1.Update();
            DbConn dbHnd = new DbConn();
            try
            {
                //Abrir Conexão
                dbHnd.OpenConnection();
               
                dbHnd.ExecuteNonQuery("DELETE FROM CONTATO");

                //Fechar Conexão
                dbHnd.CloseConnection();
            }
            finally
            {
                //Sempre utilizar finally e Dispose para "matar" a conexão
                dbHnd.Dispose();
            }

            recriartb();
        }
        protected void recriartb()
        {
            DbConn dbHnd = new DbConn();
            try
            {
                //Abrir Conexão
                dbHnd.OpenConnection();
                DataSet ds = dbHnd.FillDataSet("SELECT cd_contato, ds_nome,ds_email,dt_nasci,ds_cpf,ds_sexo,ds_cidade,ds_endereco, ESTADO.cd_estado, ESTADO.uf_estado FROM CONTATO"
                                            + " INNER JOIN ESTADO ON ESTADO.cd_estado = CONTATO.cd_estado");

                int teste = tabelaid.Rows.Count;
                for (int i = 1; i < teste; i++)
                {
                    tabelaid.Rows.RemoveAt(1);
                }
                foreach (DataRow dRow in ds.Tables[0].Rows)
                {
                    int codigo = int.Parse(dRow["cd_contato"].ToString());
                    String nome = dRow["ds_nome"].ToString();
                    String email = dRow["ds_email"].ToString();
                    String nasci = dRow["dt_nasci"].ToString();
                    String cpf = dRow["ds_cpf"].ToString();
                    String sexo = dRow["ds_sexo"].ToString();
                    String cidade = dRow["ds_cidade"].ToString();
                    String endereco = dRow["ds_endereco"].ToString();
                    String estado = dRow["uf_estado"].ToString();
                    TableRow tRow1 = new TableRow();
                    TableCell tCell = new TableCell();
                    Button btn1 = new Button();
                    btn1.Text = "Editar";
                    btn1.CommandArgument = String.Format("{0}", (codigo));
                    btn1.Click += button_editar;
                    tCell.Controls.Add(btn1);
                    tRow1.Cells.Add(tCell);
                    Button btn2 = new Button();
                    btn2.Text = "Deletar";
                    btn2.Click += button_remove;
                    btn2.CommandArgument = String.Format("{0}", (codigo));
                    tCell.Controls.Add(btn2);
                    tRow1.Cells.Add(tCell);
                    TableCell tCell0 = new TableCell();
                    tCell0.Text = nome;
                    tRow1.Cells.Add(tCell0);
                    TableCell tCell1 = new TableCell();
                    tCell1.Text = email;
                    tRow1.Cells.Add(tCell1);
                    TableCell tCell2 = new TableCell();
                    tCell2.Text = nasci;
                    tRow1.Cells.Add(tCell2);
                    TableCell tCell00 = new TableCell();
                    tCell00.Text = cpf;
                    tRow1.Cells.Add(tCell00);
                    TableCell tCell3 = new TableCell();
                    tCell3.Text = sexo;
                    tRow1.Cells.Add(tCell3);
                    TableCell tCell4 = new TableCell();
                    tCell4.Text = estado;
                    tRow1.Cells.Add(tCell4);
                    TableCell tCell5 = new TableCell();
                    tCell5.Text = cidade;
                    tRow1.Cells.Add(tCell5);
                    TableCell tCell6 = new TableCell();
                    tCell6.Text = endereco;
                    tRow1.Cells.Add(tCell6);
                    tabelaid.Rows.Add(tRow1);
                }
                //Fechar Conexão
                dbHnd.CloseConnection();
            }
            finally
            {
                //matar conexão
                dbHnd.Dispose();
            }
            UpdatePanel1.Update();
        }
        protected void clear()
        {
            UpdatePanel2.Update();
            nomeid.Text = "";
            emailid.Text = "";
            nasciid.Text = "";
            cpfid.Text = "";
            sexoid.SelectedValue = "1";
            estadoid.SelectedValue = "1";
            cidadeid.Text = "";
            enderecoid.Text = "";
        }
        protected void vericam()
        {
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