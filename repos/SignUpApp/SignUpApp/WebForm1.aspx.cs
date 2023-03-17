using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Data.SqlClient;
namespace SignUpApp

{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           

            SqlConnection conn = new SqlConnection("Server=DESKTOP-06E9EHK;Database=DBSignUp;Trusted_Connection=True;");
            conn.Open();

            SqlCommand cmd = new SqlCommand("sbmt", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@ID", Guid.NewGuid());
            cmd.Parameters.AddWithValue("@Email", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Status", 0);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}

