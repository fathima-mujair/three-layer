using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Three_layer
{
    public partial class Registration : System.Web.UI.Page
    {
        insertclass objbll = new insertclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/phs/" + FileUpload1.FileName;
             FileUpload1.SaveAs(MapPath(p));
             int i = objbll.Fn_insert(TextBox1.Text, Convert.ToInt32(TextBox2.Text), TextBox3.Text, p, TextBox4.Text, TextBox5.Text);
            if (i != 0)
                Label1.Text = "inserted";
        }
    }
}