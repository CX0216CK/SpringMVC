using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd1
{
    class add
    {
        int c;
        string c1;
        double c2;
        public int add3(int a,int b) { 
        c=a+b;
        Console.WriteLine(c.ToString());
        return c;
        }
        public double add1(double a, double b) {
            c2= a + b;
           
            Console.WriteLine(c2.ToString());
            return c2;
        }
        public string add2(string a, string b) {
            c1 = a + b;
            Console.WriteLine(c1.ToString());
            return c1;
        }
    }
}
