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
            int[] number = new int[3]{55,60,63};
            int[] number1 = new int[3] ;
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i]+"\t");
                
            }
            for (int i = 0; i < number.Length; i++)
            {
                number1[i]=number[i]+5;
            
                Console.Write(number1[i] + "\t");
            }
            Console.ReadLine();
        }
    }
}
