using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj1
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck tr = new Truck("奥迪","德国");
            tr.show();
            tr.sh();
            
            Console.ReadLine();
        }
    }
}
