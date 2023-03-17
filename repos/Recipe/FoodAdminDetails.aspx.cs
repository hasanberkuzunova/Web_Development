using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FoodAdminDetails : System.Web.UI.Page
{
    SQLClass conn = new SQLClass();
    string id;

    protected void Page_Load(object sender, EventArgs e)
    {
        
        id = Request.QueryString["FoodId"];
        if (!IsPostBack)
        {
            // Fill category drop-down list
            SqlCommand comm = new SqlCommand("Select * from TBL_Category", conn.connect());
            SqlDataReader datareader = comm.ExecuteReader();
            DropDownList1.DataTextField = "CategoryName";
            DropDownList1.DataValueField = "CategoryId";
            DropDownList1.DataSource = datareader;
            DropDownList1.DataBind();
            conn.connect().Close();

            // Fill food details
            SqlCommand cmd = new SqlCommand("Select * from TBL_Food where FoodId=@p1", conn.connect());
            cmd.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TextBox1.Text = dr[1].ToString();
                TextBox2.Text = dr[2].ToString();
                TextBox3.Text = dr[3].ToString();

                // Select the category of the food item in the drop-down list
                string categoryId = dr["CategoryId"].ToString();
                ListItem selectedCategory = DropDownList1.Items.FindByValue(categoryId);
                if (selectedCategory != null)
                {
                    selectedCategory.Selected = true;
                }
            }
            conn.connect().Close();
        }
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        /*  id = Request.QueryString["FoodId"];
          FileUpload1.SaveAs(Server.MapPath("/Photo/"+FileUpload1.FileName));

                  SqlCommand cmd = new SqlCommand("Update TBL_Food set " +
                    "FoodName=@p1,FoodIngredients=@p2," +
                    "FoodRecipe=@p3,CategoryId=@p4,FoodPhoto=@p6" +
                    " where FoodId=@p5", conn.connect());
                  cmd.Parameters.AddWithValue("@p1", TextBox1.Text);
                  cmd.Parameters.AddWithValue("@p2", TextBox2.Text);
                  cmd.Parameters.AddWithValue("@p3", TextBox3.Text);
                  cmd.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
                  cmd.Parameters.AddWithValue("@p5", id);
                  cmd.Parameters.AddWithValue("@p6", "~/Photo/"+FileUpload1.FileName); 
                  cmd.ExecuteNonQuery();
                  conn.connect().Close(); 
          */
        string id = Request.QueryString["FoodId"];
        SqlCommand cmd = new SqlCommand("UPDATE TBL_Food SET " +
            "FoodName=@p1, FoodIngredients=@p2, " +
            "FoodRecipe=@p3, CategoryId=@p4" +
            (FileUpload1.HasFile ? ", FoodPhoto=@p6" : "") +
            " WHERE FoodId=@p5", conn.connect());
        cmd.Parameters.AddWithValue("@p1", TextBox1.Text);
        cmd.Parameters.AddWithValue("@p2", TextBox2.Text);
        cmd.Parameters.AddWithValue("@p3", TextBox3.Text);
        cmd.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
        cmd.Parameters.AddWithValue("@p5", id);
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath("/Photo/" + FileUpload1.FileName));
            cmd.Parameters.AddWithValue("@p6", "~/Photo/" + FileUpload1.FileName);
        }
        cmd.ExecuteNonQuery();
        conn.connect().Close();

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
      
        SqlCommand cmd = new SqlCommand("Update TBL_Food set Situation=0", conn.connect());
        cmd.ExecuteNonQuery();
        conn.connect().Close();
        ////////
        SqlCommand cmd2 = new SqlCommand("Update TBL_Food set Situation=1 where FoodId=@p1", conn.connect());
        cmd2.Parameters.AddWithValue("@p1", id);
        cmd2.ExecuteNonQuery();
        conn.connect().Close();

    }
}