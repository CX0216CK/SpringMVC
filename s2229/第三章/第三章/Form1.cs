using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace 第三章
{
    public partial class Form1 : Form
    {
  
        public Form1 f;
        public List<SE> li;
        public main myMain;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int i = 0;
            if (kong())
            {
            SE s3 = new SE();
            s3.Id = textBox1.Text;
            s3.Sex = comboBox1.Text;
            s3.Name = Convert.ToString(textBox3.Text);
            s3.Age =Convert.ToInt32( textBox2.Text);
           
                
            
            foreach (SE item in li)
            {
                if (s3.Id== item.Id)
                {
                    MessageBox.Show("工号已经存在了");
                    return;
                }
            }


           li.Add(s3);
           myMain.binggride(li);
      
       
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
           
            int num = r.Next(10,100);
            textBox1.Text = num.ToString();
        
             comboBox1.SelectedIndex = 0;
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //非空验证
        #region 非空验证
        public bool kong()
        {
            if (textBox1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show ("请输入员工号");
                return false;
            }
            else if (textBox2.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入年龄");
                return false;
            }
            else if (textBox2.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入姓名");
                return false;
            }
            else
            {
                return true;
            }
        #endregion
     
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int num = r.Next(10, 100);
            textBox1.Text = num.ToString();
        }
    }
}
