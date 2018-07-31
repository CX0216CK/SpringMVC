using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sj3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            update();
        }
        public void update() {
            this.treeView1.Nodes.Clear();
            TreeNode rood = new TreeNode("我的电台");
            this.treeView1.Nodes.Add(rood);
            TreeNode rood1 = new TreeNode("所有电台");
            this.treeView1.Nodes.Add(rood1);
           
        }
    }
}
