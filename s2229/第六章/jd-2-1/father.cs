using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd_2_1
{
    class father
    {
        //卡号
        public int id { get; set; }
        //密码
        public string pwd { get; set; }
        //用户名
        public string usrname { get; set; }
        //余额
        public double yu { get; set; }

        //虚方法取款
        public virtual double show( double mon) {
             yu = yu - mon;
            return yu;
        
        }
        //转账
        public virtual double zhuan(double mon)
        {
             yu = yu - mon;
            return yu;
        }
    }
}
