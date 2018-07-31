using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd3
{
    class Program
    {
        static void Main(string[] args)
        {
            wu u = new wu("呵呵",10000);
            u.show();
            wu u1 = new wu("呵呵",10000,1,2);
            u1.show1();
            Console.ReadLine();
        }
    }
}
