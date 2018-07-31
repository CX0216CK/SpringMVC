using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 刘洋洋
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DBhelp dbHelp = new DBhelp();
        DataSet set = new DataSet();
        SqlDataAdapter ss;

        private void frmwei_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            string sql = string.Format("SELECT * FROM dbo.Room");
            if (set.Tables["h"] != null)
            {
                set.Tables["h"].Clear();
            }
            ss = new SqlDataAdapter(sql, dbHelp.Con);
            ss.Fill(set, "h");
            dataGridView1.DataSource = set.Tables["h"];

        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          if (textBox1.Text.Trim().Equals(string.Empty))
            {
                string cc = string.Format("select ID,Number,Beds,Price,Remark from dbo.Room");
                if (set.Tables["te"] != null)
                {
                    set.Tables["te"].Clear();
                }
                ss = new SqlDataAdapter(cc, dbHelp.Con);
                ss.Fill(set, "te");
                dataGridView1.DataSource = set.Tables["te"];
            }
            else
            {
                string sql = string.Format("select ID,Number,Beds,Price,Remark from dbo.Room  where Number='{0}'", textBox1.Text);
                if (set.Tables["sa"] != null)
                {
                    set.Tables["sa"].Clear();
                }
                ss = new SqlDataAdapter(sql, dbHelp.Con);
                ss.Fill(set, "sa");
                dataGridView1.DataSource = set.Tables["hote"];
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string one = Convert.ToString(dataGridView1.SelectedRows[0].Cells[4].Value);
            DialogResult result = MessageBox.Show("确认要删除吗", "提示", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string s = string.Format("delete FROM dbo.Room where Id={0}", one);
                SqlCommand con = new SqlCommand(s, dbHelp.Con);
                dbHelp.Oper();
                int a = con.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("删除成功");
                    string sql = string.Format("SELECT * FROM dbo.Room ");
                    if (set.Tables["e"] != null)
                    {
                        set.Tables["e"].Clear();
                    }
                    ss = new SqlDataAdapter(sql, dbHelp.Con);
                    ss.Fill(set, "e");
                    dataGridView1.DataSource = set.Tables["e"];
                }
            }
        }
        }

       
    }

