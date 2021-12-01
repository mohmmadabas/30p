
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for Helper
/// </summary>
/// 


public class Helper
{
    public static string conn_string1 = "";
    public static void setcon(string con)
    {
        conn_string1 = con;
    }
    public static SqlConnection ConnectToDb(string fileName)
    {

        try
        {
            string path = HttpContext.Current.Server.MapPath("App_Data/") + fileName;
            string connString = @"Data Source=.\SQLEXPRESS;AttachDbFileName=" + path + ";Integrated Security=True;User Instance=True";

            //string conn_string1 = ConfigurationManager.AppSettings["con1"];
            //string conn_string2 = ConfigurationManager.AppSettings["con2"];
            SqlConnection conn = new SqlConnection(conn_string1);
            return conn;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static void DoQuery(string fileName, string sql)
    {
        try
        {
            SqlConnection conn = ConnectToDb(fileName);
            conn.Open();
            SqlCommand com = new SqlCommand(sql, conn);
            com.ExecuteNonQuery();
            conn.Close();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public static bool IsExist(string fileName, string sql)
    {
        try
        {
            SqlConnection conn = ConnectToDb(fileName);
            conn.Open();
            SqlCommand com = new SqlCommand(sql, conn);
            SqlDataReader data = com.ExecuteReader();

            bool found = Convert.ToBoolean(data.Read());
            conn.Close();
            return found;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public static DataTable ExecuteDataTable(string fileName, string sql)
    {

        try
        {
            SqlConnection conn = ConnectToDb(fileName);
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter tableAdapter = new SqlDataAdapter(sql, conn);
            tableAdapter.Fill(dt);

            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

}
