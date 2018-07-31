using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace text
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            table.Add("he","呵呵");
            table.Add("ha", "哈哈");
            List<string> lise = new List<string>();
            foreach (object  obj in table.Keys)
            {
                Console.WriteLine(obj);
            }
            foreach (object item in table.Keys)
            {
                   Console.WriteLine(item);
            }
            foreach (object item1 in table)
            {
                Console.WriteLine("");
            }
            lise.Add("呵呵");
            lise.Add("哈哈");
            lise.Insert(0, "jj");
            foreach (string item in lise)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < lise.Count; i++)
            {
                Console.WriteLine(lise[i]);
            }
            foreach (string item in lise)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
