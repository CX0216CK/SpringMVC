using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jd_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<father> li = new List<father>();
        bem b = new bem(110, "hh", 20, "hh");
        bem b1 = new bem(1110, "hh", 20, "hh");
        List<father> li1 = new List<father>();
        fei f = new fei(120, "oo", 30, "oo");
       
        private void label5_Click(object sender, EventArgs e)
        {
            
        }
        public void tian() {

         
            li.Add(b);
            li.Add(b1);
            li1.Add(f);
          
        }
        public void show(){
            
            #region 注释
            //if (item.id == 110 && item.pwd.Equals("hh"))
            //{
            //    label9.Text = item.id.ToString();
            //    label10.Text = item.usrname;
            //    button2.Enabled = true;
            //    button1.Enabled = true;
            //    button3.Enabled = true;
            //}
            //else if (item.id ==120 && item.pwd.Equals("oo"))
            //{
            //     label9.Text = item.id.ToString();
            //    label10.Text = item.usrname;
            //    button2.Enabled = true;

            //    button3.Enabled = true;
            //}
            //else
            //{
            //    label9.Text =null;
            //    label10.Text = null;
            //}
            #endregion
            label9.Text = "";
            label10.Text = "";
            if (feikong())
            {
             #region 注释
                //foreach (father item in li)
                //{
                //    if (Convert.ToInt32(textBox1.Text.Trim()) == 110 && textBox2.Text.Trim().Equals("hh"))
                //    {
                //        label9.Text = item.id.ToString();
                //           label10.Text = item.usrname;
                //            button2.Enabled = true;
                //           button1.Enabled = true;
                //            button3.Enabled = true;
                //    }
                //    else if (Convert.ToInt32( textBox1.Text)==120 && textBox2.Text.Trim().Equals("oo"))
                //    {
                //        label9.Text = item.id.ToString();
                //         label10.Text = item.usrname;
                //          button2.Enabled = true;
                //          button3.Enabled = true;
                //    }
                //    else
                //    {
                //        label9.Text = null;
                //         label10.Text = null;
                //    }

                //}
                #endregion
                foreach (father item in li)
	            {
                    if (textBox1.Text.Trim() == item.id.ToString() && textBox2.Text.Trim()==item.pwd)
                {
                    label9.Text = item.id.ToString();
                    label10.Text = item.usrname; ;
                }
	                }
                foreach (father item in li1)
                {
                    if (textBox1.Text.Trim() == item.id.ToString() && textBox2.Text.Trim() == item.pwd)
                    {
                        label9.Text = item.id.ToString();
                        label10.Text = item.usrname; ;
                    }
                }
        
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tian();
            //button2.Enabled = false;
            //button1.Enabled = false;
            //button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label11.Text = "";
            foreach (father item in li)
            {
                if (textBox1.Text.Trim() == item.id.ToString() && textBox2.Text.Trim() == item.pwd)
                {
                    label11.Text = item.yu.ToString();
                }
            }
            foreach (father item in li1)
            {
                if (textBox1.Text.Trim() == item.id.ToString() && textBox2.Text.Trim() == item.pwd)
                {
                    label11.Text = item.yu.ToString();
                }
            }
        
        }

        //非空验证
        public bool feikong() {
            if (textBox1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入账号");
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

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (father item in li)
            {
                if (textBox1.Text.Trim() == item.id.ToString() && textBox2.Text.Trim() == item.pwd)
                {
                    MessageBox.Show(textBox5.Text);
                    item.show(Convert.ToDouble(textBox5.Text));
                    
            
                }
            }
            foreach (father item in li1)
            {
                if (textBox1.Text.Trim() == item.id.ToString() && textBox2.Text.Trim() == item.pwd)
                {
                    item.show(Convert.ToDouble(textBox5.Text));
                    MessageBox.Show(textBox5.Text);
                }
            }
            foreach (father item in li)
            {
                if (textBox1.Text.Trim() == item.id.ToString() && textBox2.Text.Trim() == item.pwd)
                {
                    label11.Text = item.yu.ToString();
                }
            }
            foreach (father item in li1)
            {
                if (textBox1.Text.Trim() == item.id.ToString() && textBox2.Text.Trim() == item.pwd)
                {
                    label11.Text = item.yu.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (father item in li1)
            {
                if (textBox1.Text.Trim() == item.id.ToString() && textBox2.Text.Trim() == item.pwd)
                {

                    MessageBox.Show("对不起不是本行卡不可以转账");
                    return;
                }
            }
            foreach (father item in li)
            {
                
                if (textBox1.Text.Trim() == item.id.ToString() && textBox2.Text.Trim() == item.pwd)
                {
                    item.show(Convert.ToDouble(textBox3.Text));

                 

                }
                if (textBox4.Text.Trim() == item.id.ToString())
                {
                    item.zhuan(Convert.ToDouble(textBox3.Text));
                    MessageBox.Show("转账成功");
                }
            }
            foreach (father item in li)
            {
                if (textBox1.Text.Trim() == item.id.ToString() && textBox2.Text.Trim() == item.pwd)
                {
                    label11.Text = item.yu.ToString();
                }
            }
            foreach (father item in li1)
            {
                if (textBox1.Text.Trim() == item.id.ToString() && textBox2.Text.Trim() == item.pwd)
                {
                    label11.Text = item.yu.ToString();
                }
            }
           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label11.Text = "";
            textBox5.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
