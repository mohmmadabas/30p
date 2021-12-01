using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mohmmadabas
{
    public partial class login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["logedin"] = "false";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            loginlogic t1 = new loginlogic();
            loginlogic t2 = new loginlogic();
            bool x = t2.checkadmin(email.Text, password.Text);
            if(x==true)
            {
                Session["Email"] = email.Text;
                Session["Admin"] = "true";
                Response.Redirect("Home.aspx");
            }
            bool t = t1.chekuser(email.Text, password.Text);
            if (t == true)
            {
                Session["Email"] = email.Text;
                Session["logedin"] = "true";
                Response.Redirect("Home.aspx");
            }

        }
    }
}