using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd1
{
    class Mario
    {
        //宽度
        private string weight;
        public string Weight1
        {
            get { return weight; }
            set { weight = value; }
        }
        //高度
        private string height;
        public string Height
        {
            get { return height; }
            set { height = value; }
        }
        //生命
        private int  PE;
        public int  PE1
        {
            get { return PE; }
            set { PE = value; }
        }
        //发射
        private string fa;
        public string Fa
        {
            get { return fa; }
            set { fa = value; }
        }


        public bool show() {
            if (PE < 90)
            {
                return false;
            }
            else {

                return true;
            }
        
        }
    }
}
