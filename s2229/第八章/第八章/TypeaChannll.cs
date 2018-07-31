using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace 第八章
{
    class TypeaChannll:channerBase
    {
        public override void show()
        {
            XmlDocument x = new XmlDocument();
            x.Load(base.Path);
            XmlNode xmlRote = x.DocumentElement;
            foreach (XmlNode item in xmlRote)
            {
                if (item.Name == "tvProgrmTable")
                {
                    foreach (XmlNode item1 in item)
                    {
                        Console.Write(item1["playTime"].InnerText+"\t");
                        Console.Write(item1["meridien"].InnerText + "\t");
                        Console.Write(item1["programName"].InnerText + "\t");
                        Console.Write(item1["path"].InnerText + "\n");
                    }
                }
            }
        }
    }
}
