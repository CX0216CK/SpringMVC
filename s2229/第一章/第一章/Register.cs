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
    public  partial class Register : Form
    { 
        public Register()
        {
            InitializeComponent();
        }
      
        public static login[] lo = new login[20];
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        login l = new login();
        private void Register_Load(object sender, EventArgs e)
        {
            
        }
   
        public void show() {
            Form1 f1 = new Form1();
            if (kong())
            {
                
           
            for (int i = 0; i < lo.Length; i++)
            {

                if (lo[i] == null)
                {
                    lo[i] = new login();
                    lo[i].Nane = textBox1.Text;
                    lo[i].Id = textBox2.Text;
                    lo[i].Email = textBox3.Text;

                    if (textBox3.Text == textBox6.Text)
                    {
                        lo[i].Pwd = textBox4.Text;
                        if (textBox4.Text != textBox5.Text)
                        {
                            MessageBox.Show("两次密码必须一样");
                            break;
                        }
                        else
                        {
                         
                            MessageBox.Show("注册成功");
                            this.Hide();
                            f1.Show();
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("两次邮箱必须一样");
                        break;
                    }

                }


            }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            show();
        }

        public bool kong() {
            if (textBox1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入姓名");
                return false;
            }
            else if (textBox2.Text.Trim().Equals(string.Empty))
            {
                   MessageBox.Show("请输入身份证号");
                return false;
            }
            else if (textBox3.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入邮箱地址");
                return false;
            }
            else if (textBox6.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("确认邮箱");
                return false;
            }
            else if (textBox4.Text.Trim().Equals(string.Empty))
            {
                
                MessageBox.Show("密码");
                return false;
            }
            else
            {
                return true;
            }
        
        
        }
    }
}
