using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd1
{
    class Program
    {
        static void Main(string[] args)
        {
            string y1;
            do
            {
                
          
            add ad = new add();
            ad.add3(1,1);
            ad.add1(1.1,1.2);
            ad.add2("I","LOVE YOU");
            Console.WriteLine("输入Y继续");
            y1 = Console.ReadLine();
            } while (y1.Equals("Y"));
            Console.ReadLine();
        }
    }
}
