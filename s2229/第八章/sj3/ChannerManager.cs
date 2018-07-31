using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace sj3
{
   public class ChannerManager:ChannelBAse
    {
       private string path = "path/fulChennels.xml";
       private Dictionary<string, ChannelBAse> full = new Dictionary<string, ChannelBAse>();
       public void lodachanel() {
           XmlDataDocument doc = new XmlDataDocument();
           doc.Load(path);
           XmlNode root = doc.DocumentElement;
           foreach (XmlNode item in root)
           {
               ChannelBAse channel = (item["channelType"].InnerText);
               channel.channelName = item["tvChannel"].InnerText;
               channel.path2 = item["path"].InnerText;
           }
       
       }
    }
}
