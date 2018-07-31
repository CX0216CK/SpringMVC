using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第一章
{
    public partial class Form1 : Form
    {

        public login[] log;
        main ma = new main();
      
        public Form1()
        {
            InitializeComponent();
            
        }
      
    
        private void Form1_Load(object sender, EventArgs e)
        {
            log = new login[20];
            log[0] = new login();
            log[0].Nane = "张丽丽 ";
            log[0].Id = "120185198005088521";
            log[0].Pwd = "lili1980";
            log[0].Pwd = "lili1980";
            log[0].Pwd = "lili1980";
            log[0].Email = "liili@souhu.com";
           //foreach (login item in log)
           //{
           //    MessageBox.Show(item.Email);
           //    break;
           //}
              
        }
        //非空验证
        public bool kong()
        {

            if (textBox1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入电子邮箱");
                return false;
            }
            else if (textBox2.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入密码");
                return false;
            }
            else
            {
                return true;
            }
        }
        public void show()
        {
            string pwd = textBox2.Text;
            string email = textBox1.Text;
            if (kong())
            {
                //foreach (login ll in l.log)
                //{
                //    if (ll != null)
                //    {
                //        if (pwd==ll.Pwd&&email==ll.Email)
                //        {
                //            MessageBox.Show(ll.Nane);
                //            MessageBox.Show("登录成功");
                           
                //            ma.Show();
                        
                //            ma.Text = "欢迎你"+Convert.ToString(email);
                //        }
                        
                //    }
                 

                //}
               
                for (int i = 0; i < log.Length; i++)
                {
                    
                    if (pwd == log[i].Pwd && email == log[i].Email)
                     {                          
                            MessageBox.Show("登录成功");
                           ma.Show();
                           ma.Text = "欢迎你"+Convert.ToString(email);
                           break;
                     }
                    else if (pwd == Register.lo[i].Pwd && email == Register.lo[i].Email)
                    {
                        MessageBox.Show("登录成功");
                        ma.Show();
                        ma.Text = "欢迎你" + Convert.ToString(email);
                        break;
                    }
                  
                }
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            show();
        }
       
        private void label4_Click(object sender, EventArgs e)
        {
            Register re = new Register();
            this.Hide();
            re.Show();
          
        }
    }
}
