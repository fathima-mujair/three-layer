using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;

namespace Three_layer
{
    public partial class Login : System.Web.UI.Page
    {
        Loginclass objbll = new Loginclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string i = objbll.fn_login(TextBox1.Text, TextBox2.Text);
            if (i == "1")
            {
                string id = objbll.fn_selid(TextBox1.Text, TextBox2.Text);

                Session["uid"] = id;
                
                Response.Redirect("Userprofile.aspx");
            }
            else
                Label1.Text = "invalid username and password";
        }
    }
}