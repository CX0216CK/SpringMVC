using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace text12
{
    class Program
    {
        static void Main(string[] args)
        {
            String numberString = Console.ReadLine();
            
            Regex r = new Regex("^\\s*([A-Za-z0-9_-]+(\\.\\w+)*@(\\w+\\.)+\\w{2,5})\\s*$");
            if (r.IsMatch(numberString))
            {
                Console.WriteLine("额");
            }
            else
            {
                Console.WriteLine("heh ");
            }
            Console.ReadLine();
        }
    }
}
