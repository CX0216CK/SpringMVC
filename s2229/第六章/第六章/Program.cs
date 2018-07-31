using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六章
{
    class Program
    {
        static void Main(string[] args)
        {
            Emmpoiee ee = new Emmpoiee();
       
            SE structc = new SE();
            structc.Name = "我爱你";
            structc.Age = 25;
            structc.Id = "2222";
            structc.Popularity = 55;
            Console.WriteLine(structc.SayHi());
            
            Console.ReadLine();
            
        }
    }
}
