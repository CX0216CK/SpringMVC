using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六章
{
    class Emmpoiee
    {
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 30 && value <= 100)
                {
                    _age = value;
                }
                else
                {
                    _age = 30;
                }
            }
        }

        /// <summary>
        /// 姓名
        /// </summary>
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 性别
        /// </summary>
        private string _gender;
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }


        /// <summary>
        /// 工号
        /// </summary>
        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
      
    }
}
