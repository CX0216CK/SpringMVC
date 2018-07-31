using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd1_1
{
    class dog1:father
    {
          public dog1(string name, string cloao) { 
        this.name= name;
            this.cloor= cloor;
        }
          public override string bark()
          {
            string n = string.Format("我是{0},狗{1},汪汪",this.cloor,this.name);
            return n;
        }
    }
}
