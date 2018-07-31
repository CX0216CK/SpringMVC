using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第五章
{
    class HealthCheckItem
    {
        //项目描述
        private string descrption;
        public string Descrption
        {
            get { return descrption; }
            set { descrption = value; }
        }
        //项目名称
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //项目价格
        private string price;
        public string Price
        {
            get { return price; }
            set { price = value; }
        }
}
    }
