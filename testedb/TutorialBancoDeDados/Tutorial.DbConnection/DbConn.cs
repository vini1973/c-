using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial.DbConnection
{
	public class DbConn : Smart.Database.DbConn
	{
		public override string BuildConnString()
		{
			this.ProviderName = "System.Data.SqlClient";
			return "Data Source=vm-sql\\EXPRESS;Initial Catalog=Treinamento30;User ID=sa;password=selbricoh";
		}
	}
}
