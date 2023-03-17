using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class AdminFoodOfTheDay : System.Web.UI.Page

{
    SQLClass conn = new SQLClass();
    protected void Page_Load(object sender, EventArgs e)
    {

        Panel2.Visible = false;
        SqlCommand cmd = new SqlCommand("Select * from TBL_Food", conn.connect());
        SqlDataReader reader = cmd.ExecuteReader();
        DataList1.DataSource = reader;
        DataList1.DataBind();

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel2.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel2.Visible = true;
    }
}
