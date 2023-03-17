using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;
using System.Data.SqlClient;


public partial class Course : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            List<EntityCourse> list = BLLCourse.BLL_List();
            DropDownList1.DataSource= list;
            DropDownList1.DataTextField = "CourseName";
            DropDownList1.DataValueField= "Id";
            DropDownList1.DataBind();

            List<EntityStudent> list2 = BLLStudent.BLL_List();
            DropDownList2.DataSource = list2;
            DropDownList2.DataTextField = "Name";
            DropDownList2.DataValueField = "Id";
            DropDownList2.DataBind();

        }
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityApplication ent = new EntityApplication();
        ent.ApplicationStudentId = int.Parse(DropDownList2.SelectedValue.ToString());
        ent.ApplicationCourseId = int.Parse(DropDownList1.SelectedValue.ToString());
        BLLCourse.addApplication(ent);
    }
}