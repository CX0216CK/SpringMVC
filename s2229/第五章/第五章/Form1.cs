using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第五章
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num21 = 0;
         List<HealthCheckItem> li = new List<HealthCheckItem>();
        List<HealthCheckItem> li1 = new List<HealthCheckItem>();//添加删除套餐
        List<HealthCheckLitem> li2 = new List<HealthCheckLitem>();
        List<HealthCheckLitem> ss = new List<HealthCheckLitem>();
        List<string> ls = new List<string>();
        //项目名称

        public void show() {
           
            HealthCheckItem h1 = new HealthCheckItem();
            h1.Name = "身高";
            h1.Descrption = "用于身高测量";
            h1.Price = "20";
            li.Add(h1);
            li1.Add(h1);
            HealthCheckItem h2 = new HealthCheckItem();
            h2.Name = "体重";
            h2.Descrption = "用于测量体重";
            h2.Price = "30";
            li.Add(h2);
            li1.Add(h2);
            HealthCheckItem h3= new HealthCheckItem();
            h3.Name = "视力";
            h3.Descrption = "用于检测视力";
            h3.Price = "40";
            li.Add(h3);
            li1.Add(h3);
            HealthCheckItem h4 = new HealthCheckItem();
            h4.Name = "听力";
            h4.Descrption = "用于检测听力";
            h4.Price = "50";
            li.Add(h4);
            li1.Add(h4);
            HealthCheckItem h5 = new HealthCheckItem();
            h5.Name = "肝功能";
            h5.Descrption = "用于检测肝功能";
            h5.Price = "60";
            li.Add(h5);
            li1.Add(h5);
            HealthCheckItem h6 = new HealthCheckItem();
            h6.Name = "B超";
            h6.Descrption = "用来检测";
            h6.Price = "70";
            li.Add(h6);
            li1.Add(h6);
            HealthCheckItem h7 = new HealthCheckItem();
            h7.Name = "心电图";
            h7.Descrption = "用于检测心脏";
            h7.Price = "100";
            li.Add(h7);
            li1.Add(h7);
            foreach (HealthCheckItem item in li )
            {
                comboBox2.Items.Add(item.Name);
            }
          
                   
                    BindingSource bs = new BindingSource();
                    bs.DataSource = li;
                    this.dataGridView1.DataSource = bs;
                   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
            button3.Enabled = false;
            HealthCheckLitem i = new HealthCheckLitem();
            
            i.Name = "入学体检";
            li2.Add(i);
            foreach (HealthCheckLitem item in li2)
            {
                comboBox1.Items.Add(item.Name); 
            }
            
          
            show();
       
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
              
            label7.Text = r().ToString();
           
        }
     
        string num ;
        private void button1_Click(object sender, EventArgs e)
        {
            sh();
            } 
        public void sh(){

            num = textBox1.Text;
         for (int i = 0; i < li2.Count; i++)
         {
             if (li2[i].Name == num.Trim())
             {
                 MessageBox.Show("已经有这个套餐");
                 break;
             }
             else
             {
                 li2[i].Name = num;
                 comboBox1.Items.Add(num);
               
             }
         
         }
        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }
        //删除
        double num3;
        private void button3_Click(object sender, EventArgs e)
        {
            string one=Convert.ToString( dataGridView1.SelectedRows[0].Cells[1].Value);
            MessageBox.Show(one);
            for (int i = 0; i < li.Count; i++)
            {
                  if (li[i].Name == one)
              {
                  li.Remove(li[i]);
                  BindingSource bs = new BindingSource();
                  bs.DataSource = li;
                  dataGridView1.DataSource = bs;                 
              }                
                  num3 += Convert.ToDouble(li[i].Price);
            }
            label7.Text = num3.ToString();
        }
        //添加
        
        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < li.Count; i++)
            {
                if (li[i].Name.Equals(this.comboBox2.Text))
                {
                    MessageBox.Show(i.ToString());
                    MessageBox.Show("您已有此项目!");
                    return;
                }
            }
            
            li.Add(li1[comboBox2.SelectedIndex]);
            num3 += Convert.ToDouble(li[comboBox2.SelectedIndex].Price);
            MessageBox.Show(li[comboBox2.SelectedIndex].Price.ToString());
            label7.Text = num3.ToString();
            BindingSource bs = new BindingSource();
            bs.DataSource = li;
            dataGridView1.DataSource = bs;
          

        }
        HealthCheckLitem i; 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            label6.Text = comboBox1.Text;
            for (int i = 0; i < li2.Count; i++)
			{
                if (comboBox1.Text == li2[i].Name)
            {
            }
               else
               {
                   li2.Add(li2[comboBox2.SelectedIndex]);
                   BindingSource bs = new BindingSource();
                   bs.DataSource = li2;
                   dataGridView1.DataSource = bs;
               }
			}
          
        }
        
        public double r() {
        
            for (int i = 0; i < li.Count; i++)
			{

                num21 += Convert.ToDouble(li[i].Price);

			}
        return num21;
        
        }

    }
}
