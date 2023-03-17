using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class AdminMessageDetails : System.Web.UI.Page
{
    SQLClass conn = new SQLClass();
    string id= string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Request.QueryString["MessageId"];
        if (Page.IsPostBack == false)
        {
            //   id = Request.QueryString["CategoryId"];
            SqlCommand cmd = new SqlCommand("Select * from TBL_Messages where MessageId=@p1", conn.connect());
            cmd.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TextBox1.Text = dr[1].ToString();
                TextBox2.Text = dr[2].ToString();
                TextBox3.Text = dr[3].ToString();
                TextBox4.Text = dr[4].ToString();
            }
            conn.connect().Close();
        }
    }
}