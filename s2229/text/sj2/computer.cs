using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj2
{
    class computer
    {
        public string model;
        public string id;
        public string data;
        public void show(computer[] s)
        {
            Console.WriteLine("计算机型号" + "\t" + "计算机ID" + "\t" + "日期");
            foreach (computer con in s)
            {
                Console.Write(con.model + "\t");
                Console.Write(this.id + "\t "+"\t");    
                Console.WriteLine(con.data + "\t");

            }
            Console.WriteLine("计算机型号"+"\t"+"计算机ID"+"\t"+"日期");
            foreach (computer con in s)
            {
                Console.Write(con.model+"\t");
                Console.Write(con.id + "\t");
                Console.WriteLine(con.data + "\t");
               
            }
           
        
        }
        
    }
}
