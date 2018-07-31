using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj1
{
    //汽车的类
  public  class Vehicle
    {
        //型号
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        //产地
        private string place;
        public string Place
        {
            get { return place; }
            set { place = value; }
        }
        public Vehicle(string t,string p) {
            this.Type = t;
            this.Place = p;
        }
        public void show() {
            Console.WriteLine("汽车正在行驶");
        
        }
    }
}
