using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd1_1
{
    class moneys
    {
        double money1;
        public double show(double moner) {
            if (moner>=100)
            {
              money1=  moner - 50;
              Console.WriteLine("您的金额是"+money1);
            }
            else if (moner<100)
            {

                money1 = moner;
                Console.WriteLine("您的金额是" + money1);
            }
            return money1;
        
        }
    }
}
