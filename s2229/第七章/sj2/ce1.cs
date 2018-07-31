using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj2
{
   public class ce1:father
    {
       
       public ce1(string type, string name, string description):base (type,name,description){ 
       }
       public ce1() { }
       //编写测试用例个数
       public int CaseNum { get; set; }
       //发现的BUg
       public int FindBugs { get; set; }
       //用时
       public int WorkDay { get; set; }
       public override void show()
       {
           bian f = new bian();
           f.b = this;
           f.ShowDialog();
       }
       public override string s()
       {
           System.Windows.Forms.MessageBox.Show(this.CaseNum.ToString());
           string c = string.Format("有效编码行数{0}\n遗留问题{1}\n工作日{2}\n",this.CaseNum, this.FindBugs, this.WorkDay);
        return c;
       }
    }
   

}