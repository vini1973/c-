using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart.Database;

namespace Exercicio.Conexao
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
