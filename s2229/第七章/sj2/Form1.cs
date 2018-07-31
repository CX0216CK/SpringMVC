using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sj2
{
    public partial class Form1 : Form
    {
       
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tian();
         
        }
        Employee empl;
        public void tian() {
            List<father> fa = new List<father>();
            fa.Add(new ce1("编码","编码","实现购物车模块"));
            fa.Add(new ce1("编码", "编码基类", "完成项目基类模块"));
            fa.Add(new gong("测试", "压力测试", "测试项目自己已经完成的模块"));
         empl = new SE("1120", "王小毛", 24, "男", 100, fa);
                        BindingSource bs = new BindingSource();
                            bs.DataSource=fa;
            dataGridView1.DataSource=bs;
          
        }
       
        private void 执行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.CurrentRow.Index;
            MessageBox.Show(index.ToString());
           
            empl.WorkList[index].show();
       
        }
       
        private void 完成情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.CurrentRow.Index;
            MessageBox.Show(index.ToString());
           string vb= empl.WorkList[index].s();
           MessageBox.Show(vb);
        }
    }
}
