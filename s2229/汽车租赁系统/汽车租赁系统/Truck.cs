using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 汽车租赁系统
{
   public class Truck:vehicle
    {
 
      

        public override double place()
        {
            double num = this.Rentdate * this.Yearsofservice;
            return num;
        }
    }
}
