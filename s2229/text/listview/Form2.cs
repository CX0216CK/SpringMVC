using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview
{
    public partial class Form2 : Form
    {
        //创建了一个公有的ListViewItem类型
        public ListViewItem ff;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = ff.SubItems[1].Text;
            textBox3.Text = ff.SubItems[3].Text;
            textBox2.Text = ff.SubItems[4].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmmain f = new frmmain();
            ff.SubItems[3].Text = textBox3.Text;
            ff.SubItems[4].Text=  textBox2.Text ;
        }
    }
}
