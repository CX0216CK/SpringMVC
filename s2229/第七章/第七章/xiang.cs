using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第七章
{
    public partial class xiang : Form
    {
        public xiang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SE s = new SE();
            father f = null;
            if (radioButton1.Checked==true)
            {
                f = new gang();
            }
            else if (radioButton2.Checked==true)
            {
                f=new xaio();
            }
            else if (radioButton3.Checked==true)
            {
                f = new sa();
            }
            s.play(f);
            Console.WriteLine();
        }
    }
}
