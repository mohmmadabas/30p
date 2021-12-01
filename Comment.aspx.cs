using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mohmmadabas
{
    public partial class favorite : System.Web.UI.Page
    {
        public static string st = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] == "true")
            {
                try
                {
                    loginlogic loginlogic = new loginlogic();
                    st = loginlogic.GetComment();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["logedin"] == "true")
            {
                string c = Session["Email"].ToString();
                string comment = TextBox1.Text;
                loginlogic loginlogic = new loginlogic();
                loginlogic.addcomment(comment, c);
                Response.Redirect("Comment.aspx");
            }
            else
                Response.Redirect("Home.aspx");
        }
    }
}