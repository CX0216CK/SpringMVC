using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj2
{
  public class gong:father
    {
      
       public gong(string type, string name, string description):base (type,name,description){ 
       }
       public gong() { }
      //有效编码行数
       public int CodingLine { get; set; }
      //目前没有解决的BuG
       public int Bug { get; set; }
      //用时-工作日
       public int WorkDay { get; set; }
       public override void show()
       {
           ce f = new ce();
           f.ce1 = this;
           f.ShowDialog();
       }
       public override string s()
       {
           string v = string.Format("有效编码行数{0}\n目前没有解决的Bug{1}\n用时{2}", this.CodingLine, this.Bug, this.WorkDay);
           return v;
       }
    }
}
