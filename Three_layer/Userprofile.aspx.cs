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
    public partial class Userprofile : System.Web.UI.Page
    {
        userprofileclass objbll = new userprofileclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Session["uid"].ToString();
            SqlDataReader dr = objbll.fn_proview(id);
            while (dr.Read())
            {
                TextBox1.Text = dr["name"].ToString();
                TextBox2.Text = dr["Age"].ToString();
                TextBox3.Text = dr["Address"].ToString();
                Image1.ImageUrl = dr["photo"].ToString();
            }
            DataSet ds = objbll.fn_viewds(id);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            DataTable dt = objbll.fn_viewdt(id);
            DataList1.DataSource = dt;
            DataList1.DataBind();
        }
    }
}