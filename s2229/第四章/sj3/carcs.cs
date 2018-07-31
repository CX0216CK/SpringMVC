using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj3
{
    class carcs
    {
        public carcs(string car,string cloar,string con) {
            this.Car = car;
            this.Cloar = cloar;
            this.Con = con; ;
        }
        public carcs(string car, string cloar, string con, string su)
        {
            this.Car = car;
            this.Cloar = cloar;
            this.Con = con; ;
            this.Su = su;
        }
        //车
        private string car;
        public string Car
        {
            get { return car; }
            set { car = value; }
        }
        //颜色
        private string cloar;
        public string Cloar
        {
            get { return cloar; }
            set { cloar = value; }
        }
        //国家
        private string con;
        public string Con
        {
            get { return con; }
            set { con = value; }
        }
        //速度
        private string su;
        public string Su
        {
            get { return su; }
            set { su = value; }
        }
        public void show() {
            Console.WriteLine("我是一辆\t" + car + "颜色是\t" + cloar + "国家\t" + con);
        }
        public void show1()
        {
            Console.WriteLine("我是一辆\t" + car + "颜色是\t" + cloar + "国家\t" + con + "速度\t" + su);
        }
    }
}
