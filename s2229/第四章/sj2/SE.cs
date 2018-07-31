using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj2
{
    class SE
    {
          public SE(string name,double monkey, double xiangmonkey)
        {
            this.Name = name;
            this.Monkey = monkey;
            this.Xiangmonkey = xiangmonkey;
        
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
        private double monkey;
        //程序员基本工资
        public double Monkey
        {
            get { return monkey; }
            set { monkey = value; }
        }
        //程序员考核工资
        private double xiangmonkey;
        public double Xiangmonkey
        {
            get { return xiangmonkey; }
            set { xiangmonkey = value; }
        }
        public void show()
        {
            Console.WriteLine("------------------程序员" + name + "--------------------");
            Console.WriteLine("程序员基本工资" + monkey);
            Console.WriteLine("程序员考核工资" + xiangmonkey);
            double sum = monkey + xiangmonkey;
            Console.WriteLine("总计" + sum);
        }
    }
}
