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
    public partial class bian : Form
    {
        public bian()
        {
            InitializeComponent();
        }
      public  ce1 b;
    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            b.CaseNum = Convert.ToInt32(textBox1.Text.Trim());
            b.FindBugs = Convert.ToInt32(textBox2.Text.Trim());
            b.WorkDay = Convert.ToInt32(textBox3.Text.Trim());

        
            MessageBox.Show("提交成功", "提示");

            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
