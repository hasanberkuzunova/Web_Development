using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminComment : System.Web.UI.Page
{
    SQLClass conn= new SQLClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel2.Visible= false;
        Panel4.Visible = false;

      //Approved Comments
        SqlCommand cmd = new SqlCommand("select * from TBL_Comment where CommentApproval=1", conn.connect());
        SqlDataReader dr = cmd.ExecuteReader(); 
        DataList1.DataSource= dr;
        DataList1.DataBind();

        //Disapproved Comments
        SqlCommand cmd2 = new SqlCommand("select * from TBL_Comment where CommentApproval=0", conn.connect());
        SqlDataReader dr2 = cmd2.ExecuteReader();
        DataList2.DataSource = dr2;
        DataList2.DataBind();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel2.Visible= true;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel2.Visible = false;
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Panel4.Visible = true;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Panel4.Visible = false;
    }
}