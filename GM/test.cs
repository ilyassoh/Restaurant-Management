using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.VisualBasic.ApplicationServices;

namespace GM
{
    class test
    {
        //hello form ilyass
        // hello from oumaima
       //public static readonly con_string = "server=localhost;database=gestion_magasin;uid=root;pwd=;";
        public static string con_string = "Data Source=MouadPC; Initial Catalog=GM;Persist Security Info-True; User ID=e; Password=123;";
        public static SqlConnection con = new SqlConnection(con_string);

        public static bool IsValide(string user, string pass)
        {
            bool isValide = false;
            con.Open();
            string query = @"select * from login where username='" + user + "' and password='" + pass + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                isValide = true;
            con.Close();
            return isValide;
        }

        /*con.Open();
string query = "select * from login where username='" + user + "' and password='" + pass + "'";
        SqlCommand cmd = new SqlCommand(query, con);
        SqlDataReader dr = cmd.ExecuteReader();
if (dr.Read())
{
    con.Close();
    return true;
}
else
{
    con.Close();
    return false;
}*/

    }
}