using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class AdminAboutUs : System.Web.UI.Page
{
    SQLClass conn = new SQLClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel2.Visible= false;
        if (!Page.IsPostBack)
        {
                    SqlCommand cmd = new SqlCommand("Select * From TBL_AboutUs",conn.connect());
                    SqlDataReader dataReader= cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        TextBox1.Text = dataReader[0].ToString();
                    }
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

    protected void Button3_Click(object sender, EventArgs e)
    {
        
       SqlCommand cmd = new SqlCommand("Update TBL_AboutUs set Text=@p1", conn.connect());
            cmd.Parameters.AddWithValue("@p1", TextBox1.Text);
            cmd.ExecuteNonQuery();
            conn.connect().Close();
    }
}