﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class MessagesAdminDetail : System.Web.UI.Page
{
   SQLClass conn = new SQLClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel2.Visible= false;
        SqlCommand cmd = new SqlCommand("Select * From TBL_Messages",conn.connect());
        SqlDataReader dr = cmd.ExecuteReader();
        DataList1.DataSource= dr;
        DataList1.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel2.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel2.Visible = true;
    }
}