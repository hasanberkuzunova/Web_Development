using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class MasterPage : System.Web.UI.MasterPage
{
    SQLClass conn = new SQLClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand comm=new SqlCommand("Select * from TBL_Category",conn.connect());
        SqlDataReader reader=comm.ExecuteReader();
        DataList1.DataSource= reader;
        DataList1.DataBind();
    }
}
