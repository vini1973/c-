using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Smart.Database.SQL;
using System.Web.UI.WebControls;
using System.Data;
using Exercicio.View;
using Exercicio.BLL;
using Exercicio.Model;


namespace exercicio3
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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

                    ContatoInfo contr = new ContatoInfo();
                    contr.DsNome.Value = nomeid.Text;
                    contr.DsEmail.Value = emailid.Text;
                    contr.DtNasci.Value = Convert.ToDateTime(nasciid.Text);
                    contr.DsCpf.Value = cpfid.Text;
                    contr.DsSexo.Value = sexoid.Text;
                    contr.CdEstado.Value = Int32.Parse(estadoid.SelectedValue);
                    contr.DsCidade.Value = cidadeid.Text;
                    contr.DsEndereco.Value = enderecoid.Text;

                    using (ContatoBLL adicionar = new ContatoBLL())
                    {
                        adicionar.Inserir(contr);

                    }
                }
                else
                {
                   
                    ContatoInfo dd = new ContatoInfo();
                    dd.DsNome.Value = nomeid.Text;
                    dd.DsEmail.Value = emailid.Text;
                    dd.DtNasci.Value = Convert.ToDateTime(nasciid.Text);
                    dd.DsCpf.Value = cpfid.Text;
                    dd.DsSexo.Value = sexoid.Text;
                    dd.DsCidade.Value = cidadeid.Text;
                    dd.CdEstado.Value = Int32.Parse(estadoid.SelectedValue);
                    dd.DsEndereco.Value = enderecoid.Text;

                    using (ContatoBLL addEdicao = new ContatoBLL())
                    {
                        addEdicao.Atualizar(Int32.Parse(codigo.Value), dd);
                    }
                  }
                clear();
                btsalvar.Text = "salvar";
                recriartb();
                UpdatePanel2.Update();
            }
        }
        protected void button_editar(object sender, EventArgs e)
        {
            Button btnClicado = (Button)sender;
            int cdContato = Int32.Parse(btnClicado.CommandArgument);

            using (ContatoBLL contatoBll = new ContatoBLL())
            {
              ContatoInfo lstContato= contatoBll.Get(cdContato);

              String nome = lstContato.DsNome.Value;
              String email = lstContato.DsEmail.Value;
              String nasci = lstContato.DtNasci.Value.ToString();
              String cpf = lstContato.DsCpf.Value;
              String sexo = lstContato.DsSexo.Value;
              int estado = lstContato.CdEstado.Value;
              String cidade = lstContato.DsCidade.Value;
              String endereco = lstContato.DsEndereco.Value;

              nomeid.Text = nome;
              emailid.Text = email;
              nasciid.Text = nasci;
              cpfid.Text = cpf;
              sexoid.Text = sexo;
              estadoid.Text = estado.ToString();
              cidadeid.Text = cidade;
              enderecoid.Text = endereco;

              codigo.Value = cdContato.ToString();
            }

            UpdatePanel2.Update();
            btsalvar.Text = "salvar alteração";
        }
        protected void button_remove(object sender, EventArgs e)
        {
             Button btn1Clicado = (Button)sender;
             if (btsalvar.Text == "salvar")
             {   
                     int cdContato = Int32.Parse(btn1Clicado.CommandArgument);
                     ContatoBLL remove = new ContatoBLL();
                     remove.Deletar(cdContato);
              
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
            //ContatoBLL removeAll = new ContatoBLL();
            //removeAll.Deletar
             //recriartb();
        }
        protected void recriartb()
        {
            int teste = tabelaid.Rows.Count;
            for (int i = 1; i < teste; i++)
            {
                tabelaid.Rows.RemoveAt(1);
            }

            using (ContatoEstadoBLL contEstBll = new ContatoEstadoBLL())
            {
                List<ContatoEstadoView> listaContEst = contEstBll.listaContatoEstado();
                
                foreach (ContatoEstadoView info in listaContEst)
                {
                    int codigo = info.Contato.CdContato.Value;
                    String nome = info.Contato.DsNome.Value;
                    String email = info.Contato.DsEmail.Value;
                    String nasci = info.Contato.DtNasci.Value.ToString();
                    String cpf = info.Contato.DsCpf.Value;
                    String sexo = info.Contato.DsSexo.Value;
                    String estado = info.Estado.UfEstado.Value;
                    String cidade = info.Contato.DsCidade.Value;
                    String endereco = info.Contato.DsEndereco.Value;
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
            sexoid.SelectedValue = "Masculino";
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