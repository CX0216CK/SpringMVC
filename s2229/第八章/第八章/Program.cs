using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace 第八章
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument x = new XmlDocument();
            x.Load("path/fulChennels.xml");
            XmlNode tvProgrmTable = x.DocumentElement;
            foreach (XmlNode item in tvProgrmTable.ChildNodes)
            {
                foreach (XmlNode item1 in item.ChildNodes)
                {
                    if (item1.Name=="channelType")
                    {
                        Console.Write(item1.InnerText+"\t");
                    }
                    else if (item1.Name=="tvChannel")
                    {
                        Console.Write(item1.InnerText + "\t");
                    }
                    else if (item1.Name=="path")
                    {
                        Console.WriteLine(item1.InnerText + "\n");
                    }
                }
            
            }

            TypeaChannll type = new TypeaChannll();
            feng fen = new feng();

            type.show();
            fen.show();
            Console.ReadLine();
        }
    }
}
