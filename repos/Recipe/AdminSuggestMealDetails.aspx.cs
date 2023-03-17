using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class AdminSuggestMealDetails : System.Web.UI.Page
{
    SQLClass conn = new SQLClass();
    string id= string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Request.QueryString["RecipeId"];
        if (!Page.IsPostBack)
        {
                SqlCommand cmd = new SqlCommand("Select * From TBL_Recipe where RecipeId=@p1", conn.connect());
                cmd.Parameters.AddWithValue("@p1", id);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    TextBox1.Text = dr[1].ToString();
                    TextBox2.Text = dr[2].ToString();
                    TextBox3.Text = dr[3].ToString();
                    TextBox4.Text = dr[5].ToString();
                    TextBox5.Text = dr[6].ToString();
                }
                conn.connect().Close();
            SqlCommand comm = new SqlCommand("Select * from TBL_Category", conn.connect());
            SqlDataReader dr2 = comm.ExecuteReader();
            DropDownList1.DataTextField = "CategoryName";
            DropDownList1.DataValueField = "CategoryId";
            DropDownList1.DataSource = dr2;
            DropDownList1.DataBind();
        }
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("Update TBL_Recipe set RecipeSituation=1 where RecipeId=@p1", conn.connect());
        cmd.Parameters.AddWithValue("@p1", id);
        cmd.ExecuteNonQuery();
        conn.connect().Close();

        SqlCommand cmd2 = new SqlCommand("Insert Into TBL_Food (FoodName,FoodIngredients,FoodRecipe,CategoryId) " +
            "values (@p1,@p2,@p3,@p4)", conn.connect());
        cmd2.Parameters.AddWithValue("@p1", TextBox1.Text);
        cmd2.Parameters.AddWithValue("@p2", TextBox2.Text);
        cmd2.Parameters.AddWithValue("@p3", TextBox3.Text);
        cmd2.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
        cmd2.ExecuteNonQuery();
        conn.connect().Close();
    }
}