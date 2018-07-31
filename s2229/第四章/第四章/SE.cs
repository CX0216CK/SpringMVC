using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第四章
{
    class SE
    {
        //学生的带参构造函数
        public SE(string id,string name,int age,string sex,int year) {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.Year = year;
        }
        //学生的ID
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        //学生的姓名
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //学生的年龄
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        //学生的性别
        private string sex;
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        //学生的人气
        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public void s()
        {
            System.Windows.Forms.MessageBox.Show("工号是" + id + "名字是" + name + "年龄是" + age + "性别" + sex + "人气" + year);
        }
    }
}
