using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class DeleteStudent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Request.QueryString["StudentID"]);
        EntityStudent student = new EntityStudent();
        student.Id = id;
        BLLStudent.BLLDeleteStudent(student.Id);
        Response.Redirect("StudentList.aspx");
    }
}