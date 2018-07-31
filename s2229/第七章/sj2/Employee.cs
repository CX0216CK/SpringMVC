using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj2
{
 public  class Employee
    {
        public Employee() { }

        public Employee(string id, int age, string name, string gender, List<father> list)
        {
            this.ID = id;
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
            this.WorkList = list;
        }

        /// <summary>
        /// 工号
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Gender { get; set; }

      
     
     
        public List<father> WorkList { get; set; }

        public virtual string DoWork()
        {
            return "工作列表";
        }
    }
}
