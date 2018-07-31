using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 体检套餐1
{
    public class HealthCheckItem
    {
        //项目描述
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        //项目名称
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //价钱
        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        
    }
}
