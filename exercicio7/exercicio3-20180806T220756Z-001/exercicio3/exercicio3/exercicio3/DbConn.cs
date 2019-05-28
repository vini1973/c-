using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicio3
{
    public class DbConn : Smart.Database.DbConn
    {
        public override string BuildConnString()
        {
            this.ProviderName = "System.Data.SqlClient";

            return "Data Source=STD2012X64R2-18\\DESENVOLVIMENTO;initial catalog=bdGerenCont;User ID=squadnasa;password=selbricoh";
        }
    }
}
