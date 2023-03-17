using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1.web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DBMailEntities ent = new DBMailEntities();
            TableMail table = new TableMail();
            table.Name = TextBox1.Text;
            table.Password = TextBox2.Text;
            table.Mail = TextBox3.Text;
            table.Status = 0;
            ent.TableMail.Add(table);
            ent.SaveChanges();
        }
    }
}