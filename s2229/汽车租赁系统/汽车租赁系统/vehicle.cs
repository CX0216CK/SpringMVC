using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 汽车租赁系统
{
   public class vehicle
    {
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private double dialyrent;
        public double Dialyrent
        {
            get { return dialyrent; }
            set { dialyrent = value; }
        }

        private string licenseno;
        public string Licenseno
        {
            get { return licenseno; }
            set { licenseno = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int rentdate;
        public int Rentdate
        {
            get { return rentdate; }
            set { rentdate = value; }
        }

        private string rentuser;
        public string Rentuser
        {
            get { return rentuser; }
            set { rentuser = value; }
        }

        private int yearsofservice;
        public int Yearsofservice
        {
            get { return yearsofservice; }
            set { yearsofservice = value; }
        }

        private string load;
        public string Load
        {
            get { return load; }
            set { load = value; }
        }
        public virtual double place() {
            return 20;
        }
    }
}
