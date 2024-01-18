using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class userprofileclass
    {
        Connectionclass objdal = new Connectionclass();
        public SqlDataReader fn_proview(string id)
        {
            string s = "select name,age,address,photo from Reg where id=" + id + "";
            SqlDataReader dr = objdal.Fn_Reader(s);
            return dr;
        }
        public DataSet fn_viewds(string id)
        {
            string s = "select name,age,address,photo from Reg where id=" + id + "";
            DataSet ds = objdal.Fn_Dataset(s);
            return ds;
        }
        public DataTable fn_viewdt(string id)
        {
            string s = "select name,age,address,photo from Reg where id=" + id + "";
            DataTable dt = objdal.Fn_DataTable(s);
            return dt;
        }
    }
}
