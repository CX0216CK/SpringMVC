using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六章
{
    class PM :Emmpoiee
    {

        /// <summary>
        /// 资历
        /// </summary>
        private int _yearOfExperience;
        public int YearOfExperience
        {
            get { return _yearOfExperience; }
            set { _yearOfExperience = value; }
        }

        /// <summary>
        /// 问好
        /// </summary>
        /// <returns>问好的内容</returns>
        public string SayHi()
        {
            string message;
            message = string.Format(
                "大家好，我是 {0} ，今年 {1} 岁，项目管理经验 {2}年。",
             this.Name,this.Age,this._yearOfExperience
            );
            return message;
        }
    }
}
