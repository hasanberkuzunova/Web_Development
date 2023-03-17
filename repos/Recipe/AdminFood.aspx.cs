using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class AdminFood : System.Web.UI.Page
{
   SQLClass conn = new SQLClass();
    string operation=String.Empty;
    string id= String.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {
        Panel2.Visible= false;
        Panel4.Visible= false;
       
        if (Page.IsPostBack == false) {
            id = Request.QueryString["FoodId"];
            operation = Request.QueryString["operation"];
            SqlCommand cmd = new SqlCommand("Select * from TBL_Food", conn.connect());
        SqlDataReader reader = cmd.ExecuteReader();
        DataList1.DataSource= reader;
        DataList1.DataBind();

 //Category List
       
            SqlCommand comm = new SqlCommand("Select * from TBL_Category", conn.connect());
            SqlDataReader dr = comm.ExecuteReader();
            DropDownList1.DataTextField = "CategoryName";
            DropDownList1.DataValueField= "CategoryId";
            DropDownList1.DataSource= dr;
            DropDownList1.DataBind();
        }
        if (operation == "delete")
        {
            SqlCommand cmd2 = new SqlCommand("Delete from TBL_Food where FoodId=@p1", conn.connect());
            cmd2.Parameters.AddWithValue("@p1", id);
            cmd2.ExecuteNonQuery();
            conn.connect().Close();
        }
       
       
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel2.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel2.Visible = true;
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Panel4.Visible = false;
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Panel4.Visible = true;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("Insert Into TBL_Food (FoodName,FoodIngredients,FoodRecipe,CategoryId) " +
            "values (@p1,@p2,@p3,@p4)",conn.connect());
        cmd.Parameters.AddWithValue("@p1", TextBox1.Text);
        cmd.Parameters.AddWithValue("@p2", TextBox2.Text);
        cmd.Parameters.AddWithValue("@p3", TextBox3.Text);
        cmd.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
        cmd.ExecuteNonQuery();
        conn.connect().Close();
        //Count increment
        SqlCommand cmd2 = new SqlCommand("Update TBL_Category set Count=Count+1 where CategoryId=@p1", conn.connect());
        cmd2.Parameters.AddWithValue("@p1", DropDownList1.SelectedValue);
        cmd2.ExecuteNonQuery();
        conn.connect().Close();
    }
}