using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jd1
{
    public partial class Form1 : Form
    {
        Dictionary<string, gs> c = new Dictionary<string, gs>();
        
        public List<gs> lis = new List<gs>();
        public Form1()
        {
            InitializeComponent();
        }
        #region 查询
        public void select() {
            
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            
            gs g = new gs();
            g.Name = "IBm";
            g.Coun = "美国";
            g.Cahn = "高端服务器";
            lis.Add(g);
            gs g1 = new gs();
            g1.Name = "goole";
            g1.Coun = "美国";
            g1.Cahn = "搜索引擎";
            lis.Add(g1);
            gs g2 = new gs();
            g2.Name = "dracle";
            g2.Coun = "美国";
            g2.Cahn = "数据库";
            lis.Add(g2);
            BindingSource bs = new BindingSource();
            bs.DataSource = lis;
            this.dataGridView1.DataSource = bs;

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int count= lis.Count();
           MessageBox.Show("一共有"+count.ToString()+"公司");
        }

        private void button3_Click(object sender, EventArgs e)
        {

          string name = dataGridView1.CurrentRow.Cells["Column1"].Value.ToString();
          //foreach (gs item in lis)
          //{
          //    if (item.Name == name)
          //    {
          //        MessageBox.Show(name);
          //        lis.Remove(item);
          //    }
          //}
          for (int i = 0; i < lis.Count; i++)
          {
              if (lis[i].Name == name)
              {
                  MessageBox.Show(name);
                  lis.Remove(lis[i]);
              }
          }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = lis;
            this.dataGridView1.DataSource = bs;
        }
    }
}
