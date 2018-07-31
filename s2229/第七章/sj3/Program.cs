
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
            kan k = new kan();
            k.show(new Cat());
            k.show(new Dog());
            Console.ReadLine();
        }
    }
}
