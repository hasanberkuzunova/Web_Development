using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class StudentList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<EntityStudent> entityStudents = BLLStudent.BLL_List();
        Repeater1.DataSource= entityStudents;
        Repeater1.DataBind();
    }
}