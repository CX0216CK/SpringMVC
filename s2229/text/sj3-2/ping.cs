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
    public partial class ping : Form
    {
       
        private Form1 my;
        private SE s;
        public ping( Form1 f1 ,int index)
        {
            InitializeComponent();
            this.my = f1;
            this.s = my.p[index];
        }
        public  string name;
        public ping()
        {
       
            InitializeComponent();
        }

        private void ping_Load(object sender, EventArgs e)
        {
            textBox1.Text = name;
        }
  
       
        private void button1_Click(object sender, EventArgs e)
        {
       






            PM p = new PM();
            p.jude(s, this.textBox3.Text.Trim(),Convert.ToString( textBox2.Text.Trim()));
            this.my.a();
            this.Close();







        }
   

    }
}
