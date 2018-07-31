using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sj3_2
{
    public partial class Form1 : Form
    {
     public SE[] p=new SE[3];
   
        public Form1()
        {
            InitializeComponent();
          

        }
        public string ab;
        public string aa;
        public string b;
        private void Form1_Load(object sender, EventArgs e)
        {
         
     
            
            show();  
        }
        public void show()
        {
            p[0] = new SE();
            p[0].ID = 111;
            p[0].name = "王小毛";
            p[0].age = 26;
            p[0].year = "未评价";
            p[0].score = "0";
            p[1] = new SE();
            p[1].ID = 112;
            p[1].name = "周新宇";
            p[1].age = 22;
            p[1].year = "未评价";
            p[1].score = "0";
            p[2] = new SE();
            p[2].ID = 113;
            p[2].name = "张烨";
            p[2].age = 30;
            p[2].year = "未评价";
            p[2].score = "0";
            a();

        }
        public void a()
        {
            if (this.listView1.Items != null)
            {
                this.listView1.Items.Clear();
            }
            foreach (SE item in p)
            {
                
                    ListViewItem list = new ListViewItem(Convert.ToString(item.ID));
                    list.SubItems.Add(item.name);
                    list.SubItems.Add(Convert.ToString(item.age));
                    list.SubItems.Add(item.year);
                    list.SubItems.Add(item.score);
                    listView1.Items.Add(list);
              
            }
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
         
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick_1(object sender, EventArgs e)
        {
            int index = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].ID == Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text))
                {
                    index = i;
                    break;
                }
            }

            ping p1 = new ping(this, index);
            p1.Show();
            p1.name = listView1.SelectedItems[0].SubItems[1].Text;
        }
    }
}
