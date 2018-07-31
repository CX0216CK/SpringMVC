using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj2
{
    class Program
    {
        static void Main(string[] args)
        {
            PM p = new PM("艾边成",8000,4000,2000);
            p.show();
        
            SE p1 = new SE("艾边成", 4000, 3000);
            p1.show();
            Console.ReadLine();
        }
    }
}
