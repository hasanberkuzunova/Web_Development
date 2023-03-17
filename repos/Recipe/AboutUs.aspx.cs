using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class AboutUs : System.Web.UI.Page
{
    SQLClass connect = new SQLClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand comm = new SqlCommand("Select * from TBL_AboutUs",connect.connect());
        SqlDataReader dr= comm.ExecuteReader();
        DataList2.DataSource=dr;
        DataList2.DataBind();
    }
}