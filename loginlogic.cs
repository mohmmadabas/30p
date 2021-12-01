using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;

namespace mohmmadabas
{
    public class loginlogic
    {
        public static string GetAllTableComment(DataTable dt)
        {
            string st = "";

            int length = dt.Rows.Count;

            try
            {
                if (length == 0)
                    return "No Data";
                else
                {

                    st += " <tbody>";
                    st += "<tr>";
                    st += "<td>Delete</td><td>Id</td><td>Comment</td><td>Email</td><td>Comment Time</td>";
                    st += "</tr>";
                    for (int i = 0; i < length; i++)
                    {
                        st += "<tr>";
                        st += "<td><a href='delete.aspx?Id=" + dt.Rows[i][0] + "' >" + "Delete" + "</a></td>";

                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            st += "<td>" + dt.Rows[i][j] + "</td>";
                        }

                        st += "</tr>";
                    }

                    st += "<tr>";
                    st += "<td>Comments Number:</td><td>" + length.ToString() + "</td>";
                    st += "</tr>";
                    st += " </tbody>";
                    return st;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string GetComment()
        {
            Helper.setcon(ConfigurationManager.AppSettings["con3"]);
            string filename = "Comment.mdf";
            string getcommentsql = "select *from comment";
            try
            {
                DataTable dt = Helper.ExecuteDataTable(filename, getcommentsql);
                return GetAllTableComment(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void addcomment(string comment , string email)
        {
            Helper.setcon(ConfigurationManager.AppSettings["con3"]);
            string filename = "Comment.mdf";            
            string addcommentsql = "insert into comment(Comment,Email)values('" + comment + "','" + email + "');";
            Helper.DoQuery(filename, addcommentsql);
        }
        public static void DeleteUserById(string id)
        {
            string filename = "User.mdf";
            string sqldelete = "delete from users where Id=" + id + "" +"and not IsAdmin="+1;
            Helper.setcon(ConfigurationManager.AppSettings["con1"]);
            Helper.DoQuery(filename, sqldelete);
        }
        public string GetDBAsString()
        {
            string fileName = "User.mdf";
            string tableName = "users";
            string sqlSelect = "SELECT * FROM  " + tableName;
            Helper.setcon(ConfigurationManager.AppSettings["con1"]);
            try
            {
                DataTable dt = Helper.ExecuteDataTable(fileName, sqlSelect);
                return GetAllTableData(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string GetAllTableData(DataTable dt)
        {
            string st = "";

            int length = dt.Rows.Count;

            try
            {
                if (length == 0)
                    return "No Data";
                else
                {

                    st += " <tbody>";
                    st += "<tr>";
                    st += "<td>Delete</td><td>Id</td><td>Email</td><td>First Name</td><td>Last Name</td><td>Password</td><td>IsAdmin</td>";
                    st += "</tr>";
                    for (int i = 0; i < length; i++)
                    {
                        st += "<tr>";
                        st += "<td><a href='delete.aspx?Id=" + dt.Rows[i][0] + "' >" + "Delete" + "</a></td>";

                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            st += "<td>" + dt.Rows[i][j] + "</td>";
                        }

                        st += "</tr>";
                    }

                    st += "<tr>";
                    st += "<td>User Number:</td><td>" + length.ToString() + "</td>";
                    st += "</tr>";
                    st += " </tbody>";
                    return st;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool checkadmin(string email, string password)
        {
            string filename = "User.mdf";
            string sql = "select *from users where Email='" + email + "'" + "and password=" + "'" + password + "'" + "and IsAdmin=" + "'" + 1 + "'";
            Helper.setcon(ConfigurationManager.AppSettings["con1"]);
            DataTable dt = Helper.ExecuteDataTable(filename, sql);
            if (dt.Rows.Count == 1)
                return true;
            else
                return false;
        }
        Helper helper1 = new Helper();
        public static void adduser(string email, string firstname, string lastname, string password)
        {
            string filename = "User.mdf";
            string sql = "INSERT INTO users(Email,Firstname,Lastname,Password,IsAdmin) " +
                "VALUES('" + email + "','" + firstname + "','" + lastname + "','" + password + "',0)";
            Helper.setcon(ConfigurationManager.AppSettings["con1"]);
            Helper.DoQuery(filename, sql);

        }
        public bool chekuser(string email, string password)
        {
            string filename = "User.mdf";
            string sql = "select *from users where Email='" + email + "'" + "and password=" + "'" + password + "'";
            Helper.setcon(ConfigurationManager.AppSettings["con1"]);
            DataTable dt = Helper.ExecuteDataTable(filename, sql);
            if (dt.Rows.Count == 1)
                return true;
            else
                return false;
        }

    }
}