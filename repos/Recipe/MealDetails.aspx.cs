using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class MealDetails : System.Web.UI.Page
{
    SQLClass conn = new SQLClass();
    string foodId="";
    protected void Page_Load(object sender, EventArgs e)
    {
        foodId = Request.QueryString["foodId"];
        SqlCommand comm = new SqlCommand("Select FoodName,FoodPhoto From TBL_Food where FoodId=@p1",conn.connect());
        comm.Parameters.AddWithValue("@p1", Convert.ToInt32(foodId));
        SqlDataReader dr = comm.ExecuteReader();
        while (dr.Read())
        {
            Label3.Text = dr[0].ToString();
            Image2.ImageUrl= dr[1].ToString();
        }
        conn.connect().Close();

        SqlCommand comm2 = new SqlCommand("Select * From TBL_Comment where FoodId=@p2", conn.connect());
        comm2.Parameters.AddWithValue("@p2", Convert.ToInt32(foodId));
        SqlDataReader dr2 = comm2.ExecuteReader();
        DataList2.DataSource= dr2;
        DataList2.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand comm = new SqlCommand("Insert Into TBL_Comment" +
            " (CommentatorName,CommentatorMail,CommentContent,FoodId) values" +
            "(@p1,@p2,@p3,@p4)",conn.connect());
        comm.Parameters.AddWithValue("@p1", TextBox2.Text);
        comm.Parameters.AddWithValue("@p2", TextBox3.Text);
        comm.Parameters.AddWithValue("@p3", TextBox4.Text);
        comm.Parameters.AddWithValue("@p4", foodId);
        comm.ExecuteNonQuery();
        conn.connect().Close();
        Response.Write("<script> alert('Your comment has been received.') </script>");
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";

    }
}