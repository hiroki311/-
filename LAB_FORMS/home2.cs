using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4;

namespace LAB_FORMS
{
    public partial class home2 : Form
    {
        public home2()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            helloform helloform = new helloform();
            helloform.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(helloform);
            helloform.Show();
        }

        private void 貸款金額_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Formcash P2 = new Formcash();
            P2.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(P2);
            P2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Student11 P3 = new Student11();
            P3.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(P3);
            P3.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            student2 P4 = new student2();
            P4.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(P4);
            P4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            computer P5 = new computer();
            P5.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(P5);
            P5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            圈差 P6 = new 圈差();
            P6.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(P6);
            P6.Show();

        }

        private void 餐廳_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear(); 
            Bar P7 = new Bar();
            P7.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(P7);
            P7.Show();
        }
    }
}
