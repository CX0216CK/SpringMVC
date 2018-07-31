using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六章
{
    class SE :Emmpoiee
    {
      
        /// <summary>
        /// 人气值

        /// </summary>
        private int _popularity = 0;
        public int Popularity
        {
            get { return _popularity; }
            set { _popularity = value; }
        }

        public string SayHi()
        {
            string message = string.Format("大家好，我是 {0}, 今年 {1}岁，工号是 {2}，我的人气值高达 {3}!", this.Name, this.Age, this.Id, this.Popularity);
            return message;
        }
             


    
    }
}
