using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj2
{
 public class PM
    {
        public PM(string name,double monkey, double xiangmonkey, double fen)
        {
            this.Name = name;
            this.Monkey = monkey;
            this.Xiangmonkey = xiangmonkey;
            this.fen = fen;
        
        }
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
        //经理的基本工资
        private double monkey;
        public double Monkey
        {
            get { return monkey; }
            set { monkey = value; }
        }
        //经理的项目工资
        private double xiangmonkey;
        public double Xiangmonkey
        {
            get { return xiangmonkey; }
            set { xiangmonkey = value; }
        }
       //分红
        private double fen;
        public double Fen
        {
            get { return fen; }
            set { fen = value; }
        }

        public void show() {
            Console.WriteLine("------------------经理"+name+"--------------------");
            Console.WriteLine("经理的基本工资"+monkey);
            Console.WriteLine("经理的项目工资"+xiangmonkey);
            Console.WriteLine("经理的分红"+fen);
            double sum = monkey + xiangmonkey + fen;
            Console.WriteLine("总计"+sum);
        }
    }
}
