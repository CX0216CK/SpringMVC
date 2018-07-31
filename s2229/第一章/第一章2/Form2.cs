using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第一章2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        login l = new login();
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        Form1 f1 = new Form1();
        public void show()
        {

            for (int i = 0; i < f1.log.Length; i++)
            {

                if (f1.log[i] == null)
                {
                    f1.log[i] = new login();
                    f1.log[i].Nane = textBox1.Text;
                    f1.log[i].Id = textBox2.Text;
                    f1.log[i].Email = textBox3.Text;

                    if (textBox3.Text == textBox6.Text)
                    {
                        f1.log[i].Pwd = textBox4.Text;
                        if (textBox4.Text != textBox5.Text)
                        {
                            MessageBox.Show("两次密码必须一样");
                            break;
                        }
                        else
                        {
                            foreach (login item in f1.log)
                            {
                                MessageBox.Show(item.Nane);
                                break;
                            }
                            MessageBox.Show("注册成功");

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

        private void button1_Click(object sender, EventArgs e)
        {

            show();
        }
    }
}
