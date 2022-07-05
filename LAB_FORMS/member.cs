using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_FORMS
{
    public partial class member : Form
    {
        public member()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            member student2 = new member();
           
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Member mem1 = new Member();
            mem1.age = 20;
            mem1.NAME = "mi";

            MessageBox.Show("你的姓名  " + mem1.NAME + "年齡" + mem1.age);
            Member mem2 = new Member()
            {
                NAME = "ni",
                age = 20,
            };
            MessageBox.Show("他的名子" + mem2.NAME + "年齡" + mem2.age);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.button3.Click += new System.EventHandler(this.button3_Click);
            re01.Click += new EventHandler(RE01CLICK);
            
        }

        private void RE02_Click_1(object sender, EventArgs e)
        {
            RE02.Click += RE02_Click;
        }


        private void RE02_Click(object sender, EventArgs e)
        {
            MessageBox.Show("快速註冊");
        }

        private void RE01CLICK(object sender, EventArgs e)
        {
            MessageBox.Show("成功");
        }

       

      
        private void RE3_Click(object sender, EventArgs e)
        {
            re01.Click -= RE01CLICK;
        }
    }
}
