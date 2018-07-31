using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj3
{
    class Program
    {
        static void Main(string[] args)
        {
            carcs c = new carcs("奔驰车","红色","德国");
            c.show();
            carcs c2 = new carcs("宝马车", "银灰色", "德国");
            c2.show();
            carcs c1 = new carcs("宝马车", "银灰色", "德国", "200");
            c1.show1();
            Console.ReadLine();
        }
    }
}
