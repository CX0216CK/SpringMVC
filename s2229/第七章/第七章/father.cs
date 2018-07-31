using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第七章
{
    public class father
    {
        public virtual void show() {

            Console.WriteLine("钢琴在演奏");
        }
        public void play(father f) {
            f.show();
        
        }
    }
}
