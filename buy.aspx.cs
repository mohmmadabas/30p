using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;

namespace mohmmadabas
{
    public partial class buy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filename = "Houses.mdf";
            string tablename = "BuyHouse";
            string sql = "select [City],[Price],[Bedroom],[Bathroom],[Landsize] from " + tablename;
            Helper.setcon(ConfigurationManager.AppSettings["con2"]);
            DataTable dt = Helper.ExecuteDataTable(filename, sql);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}