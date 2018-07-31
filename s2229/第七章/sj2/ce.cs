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
    public partial class ce : Form
    {
      
        public ce()
        {
            InitializeComponent();
        }
    public gong ce1;
 
        private void button1_Click(object sender, EventArgs e)
        {

            ce1.Bug=Convert.ToInt32( textBox1.Text);
            ce1.CodingLine =Convert.ToInt32( textBox2.Text);
            ce1.WorkDay = Convert.ToInt32(textBox3.Text);
            MessageBox.Show("提交成功","提示");
         
            this.Close();
        }
    }
}
