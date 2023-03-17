using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityStudent student = new EntityStudent();
        student.Name = TextBox1.Text;
        student.Surname = TextBox2.Text;
        student.Number = TextBox3.Text;
        student.Password = TextBox4.Text;
        student.Photo = TextBox5.Text;
        BLLStudent.AddStudentBLL(student);
    }
}