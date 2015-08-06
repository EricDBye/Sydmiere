using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace Sydmiere
{
    public class Database
    {
        public static bool SaveNotes(string notes)
        {
            SqlConnection conn = null;
            SqlDataReader rdr = null;

            conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Sydmiere"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SaveNotes", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@PlayerId", 1));
            cmd.Parameters.Add(new SqlParameter("@Notes", notes));

            rdr = cmd.ExecuteReader();
            return true;
        }
    }
}