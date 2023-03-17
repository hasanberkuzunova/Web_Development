using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class CategoryDetail : System.Web.UI.Page
{
    SQLClass conn= new SQLClass();
    string categoryId=string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        categoryId = Request.QueryString["categoryId"];
        SqlCommand command= new SqlCommand("Select * from TBL_Food where CategoryId=@p1",conn.connect());
        command.Parameters.AddWithValue("@p1", categoryId);
        SqlDataReader dr= command.ExecuteReader();
        DataList2.DataSource = dr;
        DataList2.DataBind();
    }
}