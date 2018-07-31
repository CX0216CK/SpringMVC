using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text
{
    class text
    {
        public static void Main(string[] args)
        {
          int [] number=new int[5];
          int[] number1 = new int[5];
          for (int i = 0; i < number.Length; i++)
          {
              Console.WriteLine("请输入第"+(i+1)+"积分");
              number[i] = int.Parse(Console.ReadLine());
          }
          for (int i = 0; i <number.Length; i++)
          {
              number1[i]= number1[i]+500;
              Console.WriteLine(number[i]);
              Console.WriteLine(number1[i]);
          }
        }
    }
}
