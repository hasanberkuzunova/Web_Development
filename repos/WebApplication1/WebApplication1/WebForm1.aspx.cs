using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TableMusicSchoolTableAdapter dt = new DataSet1TableAdapters.TableMusicSchoolTableAdapter();
            dt.InsertQuery(TextBox1.Text, TextBox2.Text,TextBox3.Text,DropDownList1.SelectedItem.ToString(), DropDownList2.SelectedItem.ToString());
        }
    }
}