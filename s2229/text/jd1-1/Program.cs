using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd1_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("请输入您的金额");
           double monkey = double.Parse(Console.ReadLine());
            moneys mon = new moneys();
            mon.show(monkey);
            Console.ReadLine();
        }
    }
}
