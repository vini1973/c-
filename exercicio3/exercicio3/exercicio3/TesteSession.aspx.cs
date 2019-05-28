using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercicio3
{
    public partial class TesteSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           object objTexto = "texto";
            object objInteiro = 123;
            object objData = DateTime.Now;

            ArrayList arrList = new ArrayList();
            arrList.Add("Texto 1");
            arrList.Add(123);
            arrList.Add(DateTime.Now);

            object objArray = arrList;

            ///////////////////////////////

            String texto = objTexto.ToString();
            int valorInteiro = int.Parse(objInteiro.ToString());
            DateTime data = DateTime.Parse(objData.ToString());

            ArrayList arrValores = (ArrayList)objArray;

            arrValores.Add("dasdasdas");

            String valorStr = arrValores[0].ToString();
            String valorStr1 = (String)arrValores[0];

            int intValor = int.Parse(arrValores[1].ToString());
            int intValor1 = (int)arrValores[1];

            DateTime dtValor = DateTime.Parse(arrValores[2].ToString());

            List<string> st = new List<string>();
            st.Add("2");
            st.Add("1");


            Session["strs"] = st;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           
           Session["Conteudo"] = TxtConteudo.Text;
            
                

                object objresultado = TxtConteudo.Text;
                TxtResultado.Text = Session["Conteudo"].ToString();
            
            /*List<string> st= new List<string>();
            st = (List<string>)Session["strs"];
            string s = string.Empty;
            foreach (var item in st){
                s += item.ToString()+"<br>";
            }*/

            
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}