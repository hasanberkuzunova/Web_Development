using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class _Default : System.Web.UI.Page
{
    SQLClass conn = new SQLClass();
    string operation = string.Empty;
    string id= string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            id = Request.QueryString["CategoryId"];
            operation = Request.QueryString["operation"];
        }
        SqlCommand command= new SqlCommand("Select * from TBL_Category",conn.connect());
        SqlDataReader dataReader= command.ExecuteReader();
        DataList1.DataSource = dataReader;
        DataList1.DataBind();

        //Delete OP
        if (operation == "delete")
        {
            SqlCommand delete = new SqlCommand("Delete from TBL_Category where CategoryId=@p1", conn.connect());
            delete.Parameters.AddWithValue("@p1", id); 
            delete.ExecuteNonQuery();
            conn.connect().Close();
        }
        Panel2.Visible=false;
        Panel4.Visible=false;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel2.Visible = false;
      //  Panel4.Visible = false;
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        Panel2.Visible = true;
       // Panel4.Visible = true;
    }

    protected void Button2_Click1(object sender, EventArgs e)
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
        SqlCommand comm = new SqlCommand("insert into TBL_Category (CategoryName) values (@p1)",conn.connect());
        comm.Parameters.AddWithValue("@p1",TextBox1.Text);
    //    comm.Parameters.AddWithValue("@p2",FileUpload1);
        comm.ExecuteNonQuery();
        conn.connect().Close();
    }
}