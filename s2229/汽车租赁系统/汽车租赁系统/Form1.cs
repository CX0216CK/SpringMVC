using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 汽车租赁系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //创建一个集合保存可租用的车
        Dictionary<string,vehicle> dic=new Dictionary<string,vehicle>();
        //保存租车的集合
        Dictionary<string, vehicle> zu = new Dictionary<string, vehicle>();
        #region 租车的初始化
        public void zu1() {
          
            Car car = new Car();
            car.Licenseno = "京 p 00e66";
            car.Color = "银灰";
            car.Name = "奔驰";
            car.Dialyrent = 250;
            car.Rentdate = 5;
            car.Load = "无";
            Truck tr = new Truck();
            tr.Name = "卡车";
            tr.Licenseno = "津 p c00987";
            tr.Color = "黑色";
            tr.Rentdate = 3;
            tr.Dialyrent = 100;
            tr.Load="50吨";
            dic.Add(car.Licenseno,car);
            dic.Add(tr.Licenseno,tr);
          
            foreach (KeyValuePair<string, vehicle> item in dic)
            {
               
                ListViewItem item1 = new ListViewItem(item.Key);
                item1.SubItems.Add(item.Value.Color);
                item1.SubItems.Add(item.Value.Name);
                item1.SubItems.Add(item.Value.Dialyrent.ToString());
                item1.SubItems.Add(item.Value.Rentdate.ToString());
                item1.SubItems.Add(item.Value.Load.ToString());
                listView1.Items.Add(item1);
            }
          
        }
        #endregion
        #region 租车的实现
        public void shi() {
           
            string key = listView1.SelectedItems[0].Text;
            dic[key].Rentuser = textBox1.Text;
            zu.Add(dic[key].Licenseno,dic[key]);
            if (dic.ContainsKey(key))
            {
                dic.Remove(key);
            }
        
        }
        #endregion
        #region 租车的非空验证
        public bool kong(){
            if (textBox1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入租车人");
                return false;
            }
            else if(listView1.SelectedItems.Count==0)
            {
                MessageBox.Show("请选择要租用的车");
                return false;
            }
            else
            {
                return true;
            }
            
        
        }
     
        #endregion
        #region 租车的非空
        public bool kong1()
        {
            if (textBox2.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入租用天数");
                return false;
            }
            else if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要还的车辆");
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        //租车
        private void button2_Click(object sender, EventArgs e)
        {
            if (kong())
            {
                //租车
                MessageBox.Show(listView1.Items.Count.ToString());
                    shi();
                    if (listView1.Items!=null)
                    {
                        listView1.Items.Clear();
                    }
                    foreach (KeyValuePair<string, vehicle> item in dic)
                    {

                        ListViewItem item1 = new ListViewItem(item.Key);
                        item1.SubItems.Add(item.Value.Color);
                        item1.SubItems.Add(item.Value.Name);
                        item1.SubItems.Add(item.Value.Dialyrent.ToString());
                        item1.SubItems.Add(item.Value.Rentdate.ToString());
                        item1.SubItems.Add(item.Value.Load.ToString());
                        listView1.Items.Add(item1);
                    }
            }
        
        }
        //刷新显示车辆
        private void button1_Click(object sender, EventArgs e)
        {
            zu1();
        }
        //还车的刷新
        private void button4_Click(object sender, EventArgs e)
        {
            if (listView2.Items!=null)
            {
                listView2.Items.Clear();
            }
            foreach (KeyValuePair<string, vehicle> item in zu)
            {

                ListViewItem item1 = new ListViewItem(item.Key);
                item1.SubItems.Add(item.Value.Color);
                item1.SubItems.Add(item.Value.Name);
                item1.SubItems.Add(item.Value.Dialyrent.ToString());
                item1.SubItems.Add(item.Value.Rentdate.ToString());
                item1.SubItems.Add(item.Value.Load.ToString());
                listView2.Items.Add(item1);
            }
        }
        #region 计算租金
        public void sum() { 
         string key = listView2.SelectedItems[0].Text;
         zu[key].Yearsofservice =Convert.ToInt32( textBox2.Text);
         double place = zu[key].place();
         string l = string.Format("您的总价是{0}",place);
         MessageBox.Show(l);
         dic.Add(zu[key].Licenseno,zu[key]);
         if (zu.ContainsKey(key))
         {
             zu.Remove(key);
         }
        }
       
        #endregion
        //还车租金
        private void btnjie_Click(object sender, EventArgs e)
        {
            if ( kong1())
            {
                
    
            sum();
            if (listView2.Items != null)
            {
                listView2.Items.Clear();
            }
            foreach (KeyValuePair<string, vehicle> item in zu)
            {

                ListViewItem item1 = new ListViewItem(item.Key);
                item1.SubItems.Add(item.Value.Color);
                item1.SubItems.Add(item.Value.Name);
                item1.SubItems.Add(item.Value.Dialyrent.ToString());
                item1.SubItems.Add(item.Value.Rentdate.ToString());
                item1.SubItems.Add(item.Value.Load.ToString());
                listView2.Items.Add(item1);
            }
            
            if (listView1.Items != null)
            {
                listView1.Items.Clear();
            }
            foreach (KeyValuePair<string, vehicle> item in dic)
            {

                ListViewItem item1 = new ListViewItem(item.Key);
                item1.SubItems.Add(item.Value.Color);
                item1.SubItems.Add(item.Value.Name);
                item1.SubItems.Add(item.Value.Dialyrent.ToString());
                item1.SubItems.Add(item.Value.Rentdate.ToString());
                item1.SubItems.Add(item.Value.Load.ToString());
                listView1.Items.Add(item1);
            }
            }

        }
        #region 入库
        public void ru() {
            string type="";
            if (radioButton1.Checked)
            {
		         type="轿车";
                 textBox7.ReadOnly = true;
                 textBox7.Text = "无";
               
            }else
            	{
                type="卡车";
        	}
          
            dic.Add(uti.create(textBox3.Text, textBox4.Text, comboBox1.Text, textBox5.Text, type, textBox6.Text, textBox7.Text).Licenseno, uti.create(textBox3.Text, textBox4.Text, comboBox1.Text, textBox5.Text, type, textBox6.Text,textBox7.Text));
        
        
        }
        #endregion
        //入库
        private void btnru_Click(object sender, EventArgs e)
        {
           
            ru();
            MessageBox.Show("入库成功");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.ReadOnly = true;
        }
    }
}
