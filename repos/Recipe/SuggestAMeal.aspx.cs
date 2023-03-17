using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class SuggestaMeal : System.Web.UI.Page
{
   SQLClass conn = new SQLClass();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand command= new SqlCommand("Insert Into TBL_Recipe " +
            "(RecipeName,RecipeIngredients,RecipeDescription,RecipePhoto,RecipeOwner,RecipeOwnerMail) " +
            "VALUES (@t1,@t2,@t3,@t4,@t5,@t6)",conn.connect());
        command.Parameters.AddWithValue("@t1",TextBox1.Text);
        command.Parameters.AddWithValue("@t2", TextBox2.Text);
        command.Parameters.AddWithValue("@t3", TextBox3.Text);
        command.Parameters.AddWithValue("@t4",FileUpload1.FileName);
        command.Parameters.AddWithValue("@t5", TextBox4.Text);
        command.Parameters.AddWithValue("@t6", TextBox5.Text);
        command.ExecuteNonQuery(); 
        conn.connect().Close();
        Response.Write("<script> alert('Your recipe has been received.') </script>");
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
    //    FileUpload1.FileName = "";
    }
}