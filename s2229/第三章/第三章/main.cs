using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第三章
{
    public partial class main : Form
    {
      public  List<SE> li = new List<SE>();
     
      public static Dictionary<string, Record> list = new Dictionary<string, Record>();
        public main()
        {
            InitializeComponent();
        }
   

        private void main_Load(object sender, EventArgs e)
        {
            bing();
          
           
        }
        public void bing()
        {

            SE s = new SE();
            s.Name = "呵呵";
            s.Sex = "男";
            s.Id = "1";
            s.Age = 15;
            li.Add(s);

            SE s1 = new SE();
            s1.Name = "哈哈";
            s1.Sex = "女";
            s1.Id = "3";
            s1.Age = 25;
            li.Add(s1);
            binggride(li);
        }
        public void binggride(List<SE> list) {
            this.dataGridView1.DataSource = new BindingList<SE>(li);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;
            List<SE> it=new List<SE>();
            foreach (SE item in li)
            {
                if (item.Id.IndexOf(number)!=-1)
                {
                    it.Add(item);
                }
               
            }
            dataGridView1.DataSource = new BindingList<SE>(it);
       
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 o = new Form1();
            o.myMain = this;
            o.li = li;
            o.Show();
          
        }

        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("请选中一行");
                return;
            }
            string w1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            bool c = false;
            foreach (string item in list.Keys)
            {
                if (item==w1)
                {
                    list[item].Leve = DateTime.Now;
                    MessageBox.Show("签退成功");
                    c = true;
               
                    break;
                }
            }

            if (!c)
            {
                MessageBox.Show("抱歉尚未签到");
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult reatult = MessageBox.Show("确定要删除吗", "温馨提示", MessageBoxButtons.OKCancel);
            string a = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            MessageBox.Show(a);
            if (reatult == DialogResult.OK)
            {
                for (int i = 0; i < li.Count; i++)
                {
                    if (li[i].Name==a)
                    {
                        li.Remove(li[i]);
                    }
                    
                }
                BindingSource bs = new BindingSource();
                bs.DataSource = li;
                this.dataGridView1.DataSource = bs;
                
            }
      
        }

        private void 签到ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //string a = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            //MessageBox.Show("签到成功");
            //SE y = new SE();
            //y.star = DateTime.Now;
            if (dataGridView1.SelectedRows.Count!=1)
            {
                MessageBox.Show("请选中一行");
                return;
            }
            string w = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            foreach (string id in list.Keys)
            {
                if (w==id)
                {
                    MessageBox.Show("你已经签到过了");
                    return;
                }
            }
        Record y=new Record();
            y.Id1 =w;
           // y.Name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            y.Tinme = DateTime.Now;
            MessageBox.Show(y.Tinme.ToString());
            list.Add(y.Id1, y);
            
            MessageBox.Show("签到成功");
        }
       
        private void 打卡记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (true)
            {
                time t = new time();
                foreach (string item in list.Keys)
                {
                    MessageBox.Show(item);
                }
                t.Show();
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
