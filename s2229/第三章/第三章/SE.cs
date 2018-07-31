using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第三章
{
   public class SE
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string sex;
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set {
                if (value>00&&value<100)
                {
                    age = value;
                }
                else
                {
                    age = 20;
                }
            }
        }

        public DateTime star;
        public DateTime leave;
        public List<SE> item = new List<SE>();
             


    }
}
