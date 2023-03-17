using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CommentAdminDetail : System.Web.UI.Page
{
    SQLClass conn = new SQLClass();
    string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Request.QueryString["CommentId"];
        if (Page.IsPostBack == false)
        {
            SqlCommand cmd = new SqlCommand("Select CommentatorName,CommentatorMail,CommentContent," +
                "FoodName" +
                " from TBL_Comment inner join TBL_Food on TBL_Comment.FoodId=TBL_Food.FoodId " +
                "where CommentId=@p1", conn.connect());
            cmd.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TextBox1.Text = dr[0].ToString();
                TextBox2.Text = dr[1].ToString();
                TextBox3.Text = dr[2].ToString();
                TextBox4.Text = dr[3].ToString();
            }
            conn.connect().Close();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("Update TBL_Comment " +
            "SET CommentContent=@p1,CommentApproval=@p2 where CommentId=@p3", conn.connect());
        cmd.Parameters.AddWithValue("@p1", TextBox3.Text);
        cmd.Parameters.AddWithValue("@p2", "True");
        cmd.Parameters.AddWithValue("@p3", id);
        cmd.ExecuteNonQuery();
        conn.connect().Close();

    }
}