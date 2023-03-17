using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MealOfTheDay : System.Web.UI.Page
{ 
    SQLClass conn = new SQLClass();
    protected void Page_Load(object sender, EventArgs e)
    {
       
        
            SqlCommand comm = new SqlCommand("Select Top 1 * from TBL_Food where Situation=1", conn.connect());
            SqlDataReader reader = comm.ExecuteReader();
            DataList2.DataSource = reader;
            DataList2.DataBind();
        
    }

    protected void DataList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}