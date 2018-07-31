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
            TreeNode note1 = treeView1.SelectedNode;
            DirectoryInfo di = new DirectoryInfo(note1.Tag.ToString());
           DirectoryInfo[] dis= di.GetDirectories();
           foreach (DirectoryInfo item in dis)
           {
               TreeNode note = new TreeNode();
               note.Text = item.Name;
               note.Tag = item.FullName;
               note.Nodes.Clear();
               note1.Nodes.Add(note);
           }

           FileInfo[] file = di.GetFiles();
           listView1.Items.Clear();
           foreach (FileInfo item in file)
           {
               ListViewItem it = new ListViewItem();
               //文件名
               it.Text = item.Name;
               //文件大小
               it.SubItems.Add((item.Length/1024).ToString());
               //文件类型
               it.SubItems.Add(item.Extension);
               //文件路径
               it.SubItems.Add(item.FullName);
               listView1.Items.Add(it);
           }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode root = new TreeNode("D:\\");
            root.Tag = "D:\\";
            treeView1.Nodes.Add(root);
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count==0)
            {
                return;
            }
            else
            {
                
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                DialogResult reasut = fbd.ShowDialog();
              
              
             
                if (reasut == DialogResult.OK)
                {
                    string path = listView1.SelectedItems[0].SubItems[3].Text;
                    string path1 = fbd.SelectedPath + "\\" + listView1.SelectedItems[0].Text;
                    File.Copy(path, path1,true);
                    MessageBox.Show("文件复制成功");
                }
            }
           
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count==0)
            {
                return;
            }
            else
            {
                string path = listView1.SelectedItems[0].SubItems[3].Text;
                File.Delete(path);
                MessageBox.Show("删除成功");
                TreeNode note1 = treeView1.SelectedNode;
                DirectoryInfo di = new DirectoryInfo(note1.Tag.ToString());
                FileInfo[] file = di.GetFiles();
                listView1.Items.Clear();
                foreach (FileInfo item in file)
                {
                    ListViewItem it = new ListViewItem();
                    //文件名
                    it.Text = item.Name;
                    //文件大小
                    it.SubItems.Add((item.Length / 1024).ToString());
                    //文件类型
                    it.SubItems.Add(item.Extension);
                    //文件路径
                    it.SubItems.Add(item.FullName);
                    listView1.Items.Add(it);
                }
            }
            
        }
    }
}
