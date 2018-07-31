using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj2
{
    class job
    {
        //工作名称
        public string Name { get; set; }
        //工作描述
        public string Description { get; set; }
        //带参的构造函数
        public job(string n,string d) {
            this.Name = n;
            this.Description = d;
        
        }
       
      
    }
}
