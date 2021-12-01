using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mohmmadabas
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Session["logedin"] = "false";
            Session["Admin"] = "false";
            Response.Redirect("login.aspx");
        }
    }
}