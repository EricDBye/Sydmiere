using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Sydmiere
{
    public class Database
    {
        public static bool SaveNotes(string notes, String Username)
        {
            SqlConnection conn = null;
            SqlCommand cmd;
            SqlDataAdapter sqlda = new SqlDataAdapter();

            conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Sydmiere"].ConnectionString);
            
            
            cmd = new SqlCommand("SaveNotes", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Username", Username));
            cmd.Parameters.Add(new SqlParameter("@Notes", notes));
            sqlda = new SqlDataAdapter(cmd);

            conn.Open();

            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            conn.Close();
            return true;
        }

        public static string getDBHash(string username)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataAdapter sqlda = new SqlDataAdapter();

            conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Sydmiere"].ConnectionString);
            cmd = new SqlCommand("GetHash", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Username", username));
            sqlda = new SqlDataAdapter(cmd);

            conn.Open();

            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            conn.Close();

            return ds.Tables[0].Rows[0]["Hash"].ToString();
        }

        public static bool existsUsername(string username)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataAdapter sqlda = new SqlDataAdapter();

            conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Sydmiere"].ConnectionString);
            cmd = new SqlCommand("ExistsUsername", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Username", username));
            sqlda = new SqlDataAdapter(cmd);

            conn.Open();

            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            conn.Close();

            if (ds.Tables[0].Rows.Count == 1)
                return true;
            else
                return false;
        }

        public static bool register(string username, string firstname, string lastname, string password)
        {
            String Hash = PasswordHash.CreateHash(password);
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataAdapter sqlda = new SqlDataAdapter();

            conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Sydmiere"].ConnectionString);
            cmd = new SqlCommand("Register", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Username", username));
            cmd.Parameters.Add(new SqlParameter("@FirstName", firstname));
            cmd.Parameters.Add(new SqlParameter("@LastName", lastname));
            cmd.Parameters.Add(new SqlParameter("@Password", Hash));
            sqlda = new SqlDataAdapter(cmd);

            conn.Open();

            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            conn.Close();
            
            
            return ds.Tables[0].Rows[0]["username"].ToString() == username;
        }

        public static bool getDate(DateTime date, String Username)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataAdapter sqlda = new SqlDataAdapter();

            conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Sydmiere"].ConnectionString);
            cmd = new SqlCommand("GetNoteDate", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Date", date));
            cmd.Parameters.Add(new SqlParameter("@Username", Username));
            sqlda = new SqlDataAdapter(cmd);

            conn.Open();

            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            conn.Close();

            if (ds.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;
        }
    }
}