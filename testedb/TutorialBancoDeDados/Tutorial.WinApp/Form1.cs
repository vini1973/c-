using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Smart.Database.SQL;
using Tutorial.DbConnection;

namespace Tutorial.WinApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnInicio_Click(object sender, EventArgs e)
		{
			//Instanciar nova conexão
			DbConn dbHnd = new DbConn();
			try
			{
				//Abrir Conexão
				dbHnd.OpenConnection();

				//Fechar Conexão
				dbHnd.CloseConnection();

				dbHnd.OpenConnection();

				dbHnd.ExecuteNonQuery("INSERT");
				dbHnd.ExecuteNonQuery("UPDATE");
				dbHnd.ExecuteNonQuery("DELETE");

				int resultInt = dbHnd.InsertGetInt32Key("INSERT", "cd_campo");

				long resultLong = dbHnd.InsertGetKey("INSERT", "cd_campo");

				dbHnd.AddParameter("DsChave", "Teste da Chave");
				dbHnd.ExecuteNonQuery("INSERT INTO CHAVE (ds_chave) VALUES (" + dbHnd.GetSqlParam("DsChave") + ")");

				try
				{
					dbHnd.BeginTransaction();

					dbHnd.ExecuteNonQuery("INSERT");
					dbHnd.ExecuteNonQuery("INSERT");
					dbHnd.ExecuteNonQuery("INSERT");

					dbHnd.Commit();
				}
				catch
				{
					dbHnd.Rollback();
				}

				//Tempo em segundos
				dbHnd.CommandTimeout = 60;
				dbHnd.ExecuteNonQuery("INSERT");

				DbDataReader dbReader = dbHnd.ExecuteReader("SELECT");
				while (dbReader.Read())
				{
					int codigo = int.Parse(dbReader["cd_contato"].ToString());
					String nome = dbReader["ds_contato"].ToString();

					//NÃO PERMITIDO, trabalha conectado com o banco
					//dbHnd.ExecuteNonQuery("INSERT");
				}
				dbReader.Dispose();

				DataSet ds = dbHnd.FillDataSet("SELECT");
				foreach (DataRow dRow in ds.Tables[0].Rows)
				{
					int codigo = int.Parse(dRow["cd_contato"].ToString());
					String nome = dRow["ds_contato"].ToString();

					//Permitido, trabalha desconectado do banco
					dbHnd.ExecuteNonQuery("INSERT");
				}

				DataRow dRowLinha = dbHnd.FillDataRow("SELECT cd_contato, ds_contato FROM CONTATO WHERE cd_contato = 1");
				if(dRowLinha != null)
				{
					int codigo = int.Parse(dRowLinha["cd_contato"].ToString());
					String nome = dRowLinha["ds_contato"].ToString();
				}

				object objNomeContato = dbHnd.ExecuteScalar("SELECT ds_contato FROM CONTATO WHERE cd_contato = 1");
				if (objNomeContato != null)
				{
					String nome = objNomeContato.ToString();
				}

				dbHnd.CloseConnection();
			}
			finally
			{
				//Sempre utilizar finally e Dispose para "matar" a conexão
				dbHnd.Dispose();
			}
		}
	}
}
