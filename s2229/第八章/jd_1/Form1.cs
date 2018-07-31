using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace jd_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<student> list = new List<student>();
     
        private void button1_Click(object sender, EventArgs e)
        {
            
            XmlDocument doc = new XmlDocument(); ;
            doc.Load("student.xml");
            XmlNode rood = doc.DocumentElement;
      student s = new student();
            foreach (XmlNode item in rood.ChildNodes)
            {   
                
                if (item.Name=="Name")
                {
                    
                    s.name = item.InnerText;
                    list.Add(s);
                   
                }
                else if (item.Name=="Age")
                {
                  
                       s.age = item.InnerText;
                       list.Add(s);
                }
                else if (item.Name=="Hobby")
                {
                    
                    s.hobby = item.InnerText;
                    list.Add(s);
                }
               
             
            }
            
         
        }
    }
}
