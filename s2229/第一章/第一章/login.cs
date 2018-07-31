using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一章
{

   public class login
    {
       
        //email
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        //ID
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        //姓名
        private string nane;
        public string Nane
        {
            get { return nane; }
            set { nane = value; }
        }
        //密码
        private string pwd;
        public string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }
        public void show()
        {
          
        }
    }
}
