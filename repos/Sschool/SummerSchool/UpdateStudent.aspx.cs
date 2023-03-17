using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;


public partial class UpdateStudent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Request.QueryString["StudentID"].ToString());
        TextBox6.Text = id.ToString();
        TextBox6.Enabled= false;
        if (!Page.IsPostBack)
        {
            EntityStudent student = new EntityStudent();
            List<EntityStudent> entityStudents = BLLStudent.BLL_Detail(id);
            TextBox1.Text = entityStudents[0].Name.ToString();
            TextBox2.Text = entityStudents[0].Surname.ToString();
            TextBox3.Text = entityStudents[0].Number.ToString();
            TextBox4.Text = entityStudents[0].Password.ToString();
            TextBox5.Text = entityStudents[0].Photo.ToString();
        }
        
        
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityStudent student = new EntityStudent();
        student.Name = TextBox1.Text;
        student.Surname = TextBox2.Text;
        student.Number = TextBox3.Text;
        student.Password = TextBox4.Text;
        student.Photo = TextBox5.Text;
        student.Id = Convert.ToInt32(TextBox6.Text);
        BLLStudent.BLLUpdateStudent(student);
        Response.Redirect("StudentList.aspx");

    }
}