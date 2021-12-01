using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mohmmadabas
{
    public partial class test : System.Web.UI.Page
    {
        public static string log = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            log = "<a class='nav-link'href='login.aspx'>login</a>";

            if (Session["logedin"] == "true")
            {
                log = "<a class='nav-link'href='logout.aspx'>logout</a>";
            }
            if (Session["Admin"] == "true")
            {
                usertable.Visible = true;
                log = "<a class='nav-link'href='logout.aspx'>logout</a>";
            }
            else
            {
                usertable.Visible = false;
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            loginlogic.adduser(email.Text, firstname.Text, lastname.Text, password.Text);
            Response.Redirect("Home.aspx");
        }
    }
}