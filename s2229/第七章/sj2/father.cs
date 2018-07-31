using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj2
{
  public abstract  class father
    {
      //工作类型
        public string Type { get; set; }
      //工作名称
        public string  Name { get; set; }
      //描述
        public string  Description { get; set; }
        public father( string type,string name,string description) {
            this.Type = type;
            this.Name = name;
            this.Description = description;
        }
        public father() { }
      //执行
        public abstract void show();
        public abstract string s();
    }
}
