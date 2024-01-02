using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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

        public static bool IsValidUser(string user, string pass)
        {
            bool IsValid = false;

            string query = @"Select * from users where username ='" + user + "' and upass ='" + pass + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                IsValid = true;
            }
       
                con.Close();

            return IsValid; 
        }
    }
}
