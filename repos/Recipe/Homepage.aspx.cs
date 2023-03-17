using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Homepage : System.Web.UI.Page
{
    SQLClass conn= new SQLClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand command= new SqlCommand("Select * From TBL_Food",conn.connect());
        SqlDataReader dr=command.ExecuteReader();
        DataList2.DataSource=dr;
        DataList2.DataBind();
    }
}