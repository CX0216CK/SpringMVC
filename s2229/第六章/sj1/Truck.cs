using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj1
{
    class Truck:Vehicle
    {
        public Truck(string t, string p) : base(t, p) { 
        
        
        
        }
        public void sh() {
            Console.WriteLine("型号是{0},产地为{1}的卡车正在行驶",this.Type,this.Place);
        }
    }
}
