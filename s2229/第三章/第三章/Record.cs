using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第三章
{
   public class Record
    {
       //签到时间
        private DateTime tinme;

        public DateTime Tinme
        {
            get { return tinme; }
            set { tinme = value; }
        }
           //签退时间
        private DateTime leve;

        public DateTime Leve
        {
            get { return leve; }
            set { leve = value; }
        }
       //工号
        private string Id;

        public string Id1
        {
            get { return Id; }
            set { Id = value; }
        }
       //姓名
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
