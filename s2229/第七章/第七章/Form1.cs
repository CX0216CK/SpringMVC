using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第七章
{
    public partial class Form1 : Form
    {
        List<SE> li = new List<SE>();

        public Form1()
        {
            InitializeComponent();
        }
        public void show() {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SE s = new SE();
            s.ID = "110";
            s.name = "呵呵";
            s.ren = "11";
            li.Add(s);
            SE s1 = new SE();
            s1.ID = "120";
            s1.name = "哈哈";
            s1.ren = "22";
            li.Add(s1);
            SE s2 = new SE();
            s2.ID = "130";
            s2.name = "呵哈";
            s2.ren = "33";
            li.Add(s2);
        
            BindingSource bs = new BindingSource();
            bs.DataSource = li;
            dataGridView1.DataSource = bs;
        }

        private void 演奏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string n = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            
            xiang x = new xiang();
            x.groupBox1.Text = n + "  开始演奏";
            x.Show();
           
        }
    }
}
