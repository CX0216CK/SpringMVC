using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sj2
{
    class PM:Emm
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


        public override string SayHi()
        {
            string message;
            message = string.Format(@"大家好，我是 {0} ，今年 {1} 岁，项目管理经验 {2}年。
设计",
             this.Name, this.Age, this._yearOfExperience
            );
            return message;
        }
    }
}
