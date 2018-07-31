using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 汽车租赁系统
{
   public class uti
    {
       public static vehicle create(string no,string name,string color, string year,string type,string rentdate,string load) {
           vehicle ver = null;
           switch (type)
           {
               case "轿车":
                   ver = new Car();
                   ver.Licenseno = no;
                   ver.Color = color;
                   ver.Name = name;
                   ver.Dialyrent = Convert.ToInt32( year);
                   ver.Rentdate = Convert.ToInt32( rentdate);
                   ver.Load = load;
                   break;
               case "卡车":
                   ver = new Truck();
                      ver.Licenseno = no;
                   ver.Color = color;
                   ver.Name = name;
                   ver.Dialyrent = Convert.ToInt32( year);
                   ver.Rentdate = Convert.ToInt32( rentdate);
                   ver.Load = load;
                   break;
       
           }
           return ver;
       }
    }
}
