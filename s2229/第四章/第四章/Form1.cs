using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第四章
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PM p = new PM("111", "艾边成", 25, "男", 100);
        SE p1 = new SE("111", "艾边成", 25, "男", 1010);
        public void show() {
          
        }
        public void show1()
        {
      
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            p.s();
            p1.s();
        }
    }
}
