using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        //{
        //    conn.Open();
        //    OleDbCommand cmd = new OleDbCommand("Select top 5 * from sliderresim order by resim_ad asc", conn);
        //    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    Repeater15.DataSource = dt;
        //    Repeater15.DataBind();
        //    conn.Close();
        //}
    }
}