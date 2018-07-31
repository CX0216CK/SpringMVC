using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace 第九章
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //路径
        string path = "D:\\Text.txt";
       
        private void button2_Click(object sender, EventArgs e)
        {
        
            //类
            FileStream myfs = new FileStream(path,FileMode.Open);
            //创建一个读取器
            StreamReader  read = new StreamReader(myfs,Encoding.Default);
            string s = read.ReadToEnd();
            textBox1.Text = s;
            read.Close();
            myfs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //类
            FileStream myfs = new FileStream(path, FileMode.Create);
            //创建一个读取器
            string word = textBox1.Text;
            StreamWriter sw = new StreamWriter(myfs);
            sw.Write(word);
            sw.Close();
            myfs.Close();
            MessageBox.Show("写入成功");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists("D:\\我是.txt"))
            {
                File.Delete("D:\\我是.txt");
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("没有找到");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists("D:\\Text.txt"))
            {
                File.Copy("D:\\Text.txt","E:\\Text1.txt");
                MessageBox.Show("复制成功");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (File.Exists("D:\\Text.txt"))
            {
                File.Move("D:\\Text.txt", "F:\\Text.txt");
                MessageBox.Show("移动成功");
            }
        }
    }
}
