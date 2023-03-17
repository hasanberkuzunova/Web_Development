using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CategoryAdminDetails : System.Web.UI.Page
{
  SQLClass conn = new SQLClass();
    string id;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        id=Request.QueryString["CategoryId"];
        if (Page.IsPostBack == false) { 
     //   id = Request.QueryString["CategoryId"];
        SqlCommand cmd = new SqlCommand("Select * from TBL_Category where CategoryId=@p1", conn.connect());
        cmd.Parameters.AddWithValue("@p1", id);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            TextBox1.Text = dr[1].ToString();
            TextBox2.Text = dr[2].ToString();
        }
        conn.connect().Close();
    }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("Update TBL_Category set CategoryName=@p1,Count=@p2 where CategoryId=@p3",conn.connect());
        cmd.Parameters.AddWithValue("@p1", TextBox1.Text);
        cmd.Parameters.AddWithValue("@p2", TextBox2.Text);
        cmd.Parameters.AddWithValue("@p3", id);
        SqlDataReader dr = cmd.ExecuteReader();
        conn.connect().Close();
    }
}