using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 体检套餐1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        //创建一个套餐集合
        List<HealthCheckItem> item = new List<HealthCheckItem>();
        List<HealthCheckItem> item1 = new List<HealthCheckItem>();
        HealthCheckSet seee = new HealthCheckSet();
        Dictionary<string, HealthCheckSet> dic = new Dictionary<string, HealthCheckSet>();
       
        //初始化
        public void load() {
            //dic.Add("学生套餐",seee);
            HealthCheckItem h1 = new HealthCheckItem();
            h1.Name = "身高";
            h1.Description = "用于身高测量";
            h1.Price = 20;
           // dic[comboBox1.Text].items.Add(h1);
            item1.Add(h1);
            HealthCheckItem h2 = new HealthCheckItem();
            h2.Name = "体重";
            h2.Description = "用于测量体重";
            h2.Price = 30;
           // dic[comboBox1.Text].items.Add(h2);
            item1.Add(h2);
            HealthCheckItem h3 = new HealthCheckItem();
            h3.Name = "视力";
            h3.Description = "用于检测视力";
            h3.Price = 40;
           // dic[comboBox1.Text].items.Add(h3);
            item1.Add(h3);
            HealthCheckItem h4 = new HealthCheckItem();
            h4.Name = "听力";
            h4.Description = "用于检测听力";
            h4.Price = 50;
           // dic[comboBox1.Text].items.Add(h4);
            item1.Add(h4);
            HealthCheckItem h5 = new HealthCheckItem();
            h5.Name = "肝功能";
            h5.Description = "用于检测肝功能";
            h5.Price = 60;
          //  dic[comboBox1.Text].items.Add(h5);
            item1.Add(h5);
            HealthCheckItem h6 = new HealthCheckItem();
            h6.Name = "B超";
            h6.Description = "用来检测";
            h6.Price = 70;
           // dic[comboBox1.Text].items.Add(h6);
            item1.Add(h6);
            HealthCheckItem h7 = new HealthCheckItem();
            h7.Name = "心电图";
            h7.Description = "用于检测心脏";
            h7.Price = 100;
            //dic[comboBox1.Text].items.Add(h7);
            item1.Add(h7);
            this.dataGridView1.DataSource = new BindingList<HealthCheckItem>(dic[comboBox1.Text].Items);
            dic[comboBox1.Text].CarlPrice();
            label7.Text = dic[comboBox1.Text].Price.ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Text=comboBox1.Text;
//            HealthCheckSet set = new HealthCheckSet();
            
            string xia = comboBox1.Text;
            if (xia=="请选择")
            {
                dataGridView1.DataSource=new BindingList<HealthCheckItem>();
                label6.Text = "";
                label7.Text = "";
                return;
            }
            else
            {
                this.dataGridView1.DataSource = new BindingList<HealthCheckItem>(dic[xia].Items);
                MessageBox.Show(xia);
                
            }
            dic[comboBox1.Text].CarlPrice();
            label7.Text = dic[comboBox1.Text].Price.ToString();
        }
        public void c() {
            this.comboBox1.DataSource = new BindingList<string>(dic.Keys.ToList());
            this.comboBox1.DisplayMember = "name";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AllowUserToAddRows = false;
            dic.Add("学生套餐", seee);
            dic.Add("学生套餐z", new HealthCheckSet());

            c();
            load();
           
            for (int i = 0; i <  item1.Count; i++)
            {
                comboBox2.Items.Add(item1[i].Name);
            }
            comboBox2.SelectedIndex = 0;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string one = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            MessageBox.Show(one);
            for (int i = 0; i < dic[comboBox1.Text].Items.Count; i++)
            {
                if (one == dic[comboBox1.Text].Items[i].Name)
                {
                    dic[comboBox1.Text].Items.Remove(dic[comboBox1.Text].Items[i]);
                    break;
                }
            }
            this.dataGridView1.DataSource = new BindingList<HealthCheckItem>(dic[comboBox1.Text].Items);
            seee.CarlPrice();
            label7.Text = seee.Price.ToString();
        }
   
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dic[comboBox1.Text].Items.Count; i++)
            {
                if (dic[comboBox1.Text].Items[i].Name.Equals(comboBox2.Text))
                {
                    MessageBox.Show(i.ToString());
                    MessageBox.Show("存在这个项目");
                    return;
                }
            }
            MessageBox.Show(comboBox2.SelectedIndex.ToString());
            dic[comboBox1.Text].Items.Add(item1[comboBox2.SelectedIndex]);
            this.dataGridView1.DataSource = new BindingList<HealthCheckItem>(dic[comboBox1.Text].Items);

            //this.dataGridView1.DataSource = new BindingList<HealthCheckItem>(dic[comboBox1.Text].Items);
            dic[comboBox1.Text].CarlPrice();
            label7.Text = dic[comboBox1.Text].Price.ToString();
            MessageBox.Show(dic[comboBox1.Text].Items[0].Name);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string item in dic.Keys)
            {
                if (textBox1.Text == item)
                {
                    MessageBox.Show("存在此套餐");
                }
                else
                {
                    dic.Add(textBox1.Text, new HealthCheckSet());
                    c();
                    //this.dataGridView1.DataSource = new BindingList<HealthCheckItem>(dic[comboBox1.Text].items);
                    break;
                }
            }
            dic[comboBox1.Text].CarlPrice();
            label7.Text = dic[comboBox1.Text].Price.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
