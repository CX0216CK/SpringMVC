using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj2
{
    class Program
    {
        static void Main(string[] args)
        {
            computer co = new computer();
            Random ran = new Random();
        int r= ran.Next(100,1000);
            int r1=ran.Next(100,1000);
             int r2=ran.Next(100,1000);
            computer[] con = new computer[3];
            con[0] = new computer();
            con[0].model="hpcq-217tx";
            con[0].data="2013-10-05";
            con[0].id = "hpcq-217tx" + r;
            con[1] = new computer();
            con[1].id = "Mc240ch/a" +r1 ;
            con[1].model = "Mc240ch/a";
            con[1].data = "2013-10-5";
            con[2] = new computer();
            con[2].model = "SYNW18/H/W";
            con[2].data = "2013-10-5";
            con[2].id = "SYNW18/H/W" + r2;
            co.show(con);

            Console.ReadLine();
        }
    }
}
