using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mohmmadabas
{
    public partial class Site1 : System.Web.UI.MasterPage
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
                Comment.Visible = true;
                usertable.Visible = true;
                log = "<a class='nav-link'href='logout.aspx'>logout</a>";
            }
            else
            {
                Comment.Visible = false;
                usertable.Visible = false;
            }
        }
    }
}