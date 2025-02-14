using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    internal class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            conStr = " Data Source = QUIEZ; Initial Catalog = QLBangiay; Integrated Security = true";
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(conStr);   
        }
    }
}
