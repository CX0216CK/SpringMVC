using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 汽车租赁系统
{
   public class Car:vehicle
    {
       public void car() { }

       public override double place() {
           double num = this.Rentdate * this.Yearsofservice;
       return num;
       }
    }
}
