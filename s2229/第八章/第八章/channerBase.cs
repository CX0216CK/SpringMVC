using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第八章
{
   public abstract class channerBase
    {
        private string path = "path/bei.xml";
        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        private string path1 = "path/凤凰电视台.xml";

        public string Path1
        {
            get { return path1; }
            set { path1 = value; }
        }
       public abstract void show();
    }
}
