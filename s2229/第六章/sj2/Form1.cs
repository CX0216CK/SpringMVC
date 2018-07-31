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
    public partial class Form1 : Form
    {
        List<Emm> li = new List<Emm>();
        List<job> jo = new List<job>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SE structc = new SE();
            structc.Name = "我爱你";
            structc.Age = 25;
            structc.Id = "2222";
            structc.Popularity = 55;
            PM p = new PM();
            p.Name = "kk";
            p.Id = "11";
            p.Gender = "女";
            p.Age = 20;
            p.YearOfExperience = 11;
            p.SayHi();
            li.Add(p);
            li.Add(structc);
            foreach (Emm item in li)
            {
                //if (item is SE)
                //{
                //    MessageBox.Show(((SE)item).SayHi());

                //}
                //else if (item is PM)
                //{
                //    MessageBox.Show(((PM)item).SayHi());
                //}
                MessageBox.Show (item.SayHi());
            }
        }
    }
}
