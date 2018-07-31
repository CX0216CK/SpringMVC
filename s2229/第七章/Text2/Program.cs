using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text2
{
    class Program
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            Emp e1 = new Emp();
            Traffic f = new Car();
            Traffic f1 = new Tube();
            e.GOhome(f1);
            e.GOhome(f);
            Console.ReadLine();
        }
    }
}
