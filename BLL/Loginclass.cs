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
    public class Loginclass
    {
        Connectionclass objdal = new Connectionclass();
        public string fn_login(string uname,string pw)
        {
            string s = "select count(id) from Reg where username='" + uname + "'and password='" + pw + "'";
            string i = objdal.Fn_Scalar(s);
            return i;
        }
        public string fn_selid(string uname,string pw)
        {
            string s = "select id from Reg where username='" + uname + "'and password='" + pw + "'";
            string id = objdal.Fn_Scalar(s);
            return id;
        }
    }
}
