using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第四章
{
    class PM
    {
        //经理的带参构造函数
        public PM(string id, string name, int age, string sex, int year)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.Year = year;
        }


        //经理的ID
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        //经理的姓名
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //经理的年龄
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        //经理的性别
        private string sex;
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        //经理的人气
        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public void s() {
            System.Windows.Forms.MessageBox.Show("工号是"+id+"名字是"+name+"年龄是"+age+"性别"+sex+"人气"+year);
        }
    }
}
