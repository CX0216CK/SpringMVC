using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran1 = new Random();
            for (int i = 1; i <= 3; i++)
            {
                
                int r1 = ran1.Next(100, 1000);
                Console.WriteLine(r1);
            }
            Console.ReadLine();
        }
    }
}
