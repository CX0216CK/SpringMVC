using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace jd3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\book.txt";
            //类
            FileStream myfs = new FileStream(path, FileMode.Open);
            //创建一个读取器
            StreamReader read = new StreamReader(myfs, Encoding.UTF8);
            string s = read.ReadLine();
            int number = Convert.ToInt32(s);
            Console.WriteLine(number);
            for (int i = 1; i <=number; i++)
            {
              
                Console.Write("第"+i+"本书");
                Console.WriteLine("书名:"+read.ReadLine());
                Console.WriteLine("作者:" + read.ReadLine());
                Console.WriteLine("出版社:" + read.ReadLine());
                Console.WriteLine("价格:" + read.ReadLine());
            }
            read.Close();
            myfs.Close();
          
            
            Console.ReadLine();
        }
    }
}
