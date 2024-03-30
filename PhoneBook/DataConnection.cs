using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class DataConnection
    {
        public static int AdminID;
        public static SqlConnection dataConn = new SqlConnection("Data Source=DESKTOP-LQOAMHU\\SQLEXPRESS;Initial Catalog=PhoneBook;Integrated Security=True");
    }
}
