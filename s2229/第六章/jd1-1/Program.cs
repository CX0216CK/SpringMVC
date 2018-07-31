using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd1_1
{
    class Program
    {
     
        static void Main(string[] args)
        {
            List<father> li = new List<father>();
            cat c = new cat("呵呵","白色");
        
            dog1 d = new dog1("哈哈","黑色");
            li.Add(c);
            li.Add(d);
            foreach (father item in li)
            {
                Console.WriteLine(item.bark());
            }
            Console.ReadLine();
        }
    }
}
