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
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }
        






        //创建一个SE类型的数组
        public SE[] p = new SE[3];
        
        //对象数组的初始化
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
        //绑定到listview 
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

        private void frmmain_Load(object sender, EventArgs e)
        {
            //调用绑定到listview中的方法
            show();
        }
        //双击listView1
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            //创建了一个ListViewItem类型的变量用于存储listview中的一行
            ListViewItem select = listView1.SelectedItems[0];
            //在增加学生的那边创建一个ListViewItem类型接收这个一行的的值
            frm.ff = select;
            frm.Show();
        }
        
    }
}
