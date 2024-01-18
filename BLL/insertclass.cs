using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
   
    public class insertclass
    {
        Connectionclass objdal = new Connectionclass();
        
        public int Fn_insert(string na,int ag,string addr,string ph,string una,string pw)
        {
            string strins = "insert into Reg values('" + na + "'," + ag + ",'" + addr + "','" + ph + "','" + una + "','" + pw + "')";
            int i = objdal.Fn_Nonquery(strins);
            return i;
        }
    }
}
