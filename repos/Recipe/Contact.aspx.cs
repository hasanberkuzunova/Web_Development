using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Contact : System.Web.UI.Page
{
    SQLClass conn=new SQLClass();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand command = new SqlCommand("Insert into TBL_Messages " +
            "(MessageOwner,MessageOwnerMail,MessageTopic,MessageContent)" +
            " values (@p1,@p2,@p3,@p4)", conn.connect());
        command.Parameters.AddWithValue("@p1", TextBox1.Text);
        command.Parameters.AddWithValue("@p2", TextBox2.Text);
        command.Parameters.AddWithValue("@p3", TextBox3.Text);
        command.Parameters.AddWithValue("@p4", TextBox4.Text);
        command.ExecuteNonQuery();
        conn.connect().Close();
        Response.Write("<script> alert('Your message has been received.') </script>");
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
    }
}