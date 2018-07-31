using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            zhaohu hu = new zhaohu();
            fount f = new fount();
            mayi ma = new mayi();
            ma.ma();
            f.show(ma);
           
            hu.ss(f);
            ma.sh();
            Console.ReadLine();
        }
    }
}
