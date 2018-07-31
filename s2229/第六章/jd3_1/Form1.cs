using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jd3_1
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
   
       
        }
        //长方形 红
        public void red() {
           
            Graphics g = this.panel1.CreateGraphics();
            Pen p = new Pen(Color.Red, 3);
            Rectangle rec = new Rectangle(30, 30, 150, 150);
            g.DrawRectangle(p, rec);
       
        }
        public void yello()
        {
            Graphics g = this.panel1.CreateGraphics();
            Pen p = new Pen(Color.Yellow, 3);
            Rectangle rec = new Rectangle(30, 30, 150, 150);
            g.DrawRectangle(p, rec);
        
        }
        public void blue()
        {
            Graphics g = this.panel1.CreateGraphics();
            Pen p = new Pen(Color.Blue, 3);
            Rectangle rec = new Rectangle(30, 30, 150, 150);
            g.DrawRectangle(p, rec);
          

        }
        //圆形
        public void rea1() {
            Graphics g = this.panel1.CreateGraphics();
            Pen p = new Pen(Color.Red, 3);
            g.DrawEllipse(p, 30, 30, 100, 100);
   
        }
        public void Yello1()
        {
            Graphics g = this.panel1.CreateGraphics();
            Pen p = new Pen(Color.Yellow, 3);
            g.DrawEllipse(p, 30, 30, 100, 100);
           
        }
        public void blue1()
        {
            Graphics g = this.panel1.CreateGraphics();
            Pen p = new Pen(Color.Blue, 3);
            g.DrawEllipse(p, 30, 30, 100, 100);
           
        }

        public void panl() {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel1.Invalidate();
          MessageBox.Show("hh");
            if (radioButton1.Checked == true && radioButton3.Checked == true )
            {
              red();
            }
            else if (radioButton1.Checked == true && radioButton4.Checked==true)
            {
                yello();
            }
            else if (radioButton1.Checked == true && radioButton5.Checked == true){
                     blue();    
            }
              
         if (radioButton2.Checked == true && radioButton3.Checked == true )
            {
             rea1();
            }
            else if (radioButton2.Checked == true && radioButton4.Checked==true)
            {
            Yello1();
            }
         else if (radioButton2.Checked == true && radioButton5.Checked == true)
         {
             blue1();
         }
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }
}
    
}
