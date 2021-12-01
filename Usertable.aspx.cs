using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mohmmadabas
{
    public partial class Usertable : System.Web.UI.Page
    {
        public static string st = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] == "true")
            {
                try
                {
                    loginlogic loginlogic = new loginlogic();
                    st = loginlogic.GetDBAsString();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}