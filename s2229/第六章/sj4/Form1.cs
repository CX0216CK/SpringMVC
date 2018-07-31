using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sj4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        operation o = new operation();
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
            
                jia j = new jia();
                j.onenumber = Convert.ToDouble(textBox1.Text.Trim());
                j.twonumber = Convert.ToDouble(textBox2.Text.Trim());
               label1.Text= j.get().ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                jian j = new jian();
                j.onenumber = Convert.ToDouble(textBox1.Text.Trim());
                j.twonumber = Convert.ToDouble(textBox2.Text.Trim());
                label1.Text = j.get().ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                cheng j = new cheng();
                j.onenumber = Convert.ToDouble(textBox1.Text.Trim());
                j.twonumber = Convert.ToDouble(textBox2.Text.Trim());
                label1.Text = j.get().ToString();
            }
            else
            {
                chu j = new chu();
                j.onenumber = Convert.ToDouble(textBox1.Text.Trim());
                j.twonumber = Convert.ToDouble(textBox2.Text.Trim());
                label1.Text = j.get().ToString();
                
            }
             
        }
    }
}
