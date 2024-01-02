using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GM
{
    internal class MainClass
    {
        public static readonly string con_string = " Data Source=L-yes\\SQLEXPRESS;Initial Catalog=GM;User ID=sa;Password=123;";
        public static SqlConnection con = new SqlConnection(con_string) ;
    }
}
