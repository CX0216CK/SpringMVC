using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd3
{
    class Program
    {
        static void Main(string[] args)
        {
            Eat c = new Eat();
            Console.WriteLine("请选择: 1 狮子 2 鸟 3 猴子");
            int number =int.Parse( Console.ReadLine());
            switch (number)
            {
                case 1:
                     c.show(new lion());
                    break;
                case 2:
                    c.show(new bird());
                    break;
                case 3:
                    c.show(new monkey());
                    break;

                default:
                    Console.WriteLine("请正确选择");
                    break;
            }
            Console.ReadLine();
        }
    }
}
