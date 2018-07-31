using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第三章
{
    public partial class time : Form
    {
        public time()
        {
            InitializeComponent();
        }

        private void time_Load(object sender, EventArgs e)
        {
            
            dataGridView1.AutoGenerateColumns = false;
            BindingSource bw = new BindingSource();
            bw.DataSource = main.list.Values;
          
            this.dataGridView1.DataSource = bw;

        }
    }
}
