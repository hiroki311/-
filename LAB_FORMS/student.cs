using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_FORMS
{
    public partial class student : Form
    {
        string 姓名;
        int 國文分數;
        int 英文分數;
        int 數學分數;
          public student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            姓名 = textBox1.Text;
            國文分數 = int.Parse(textBox2.Text);
            英文分數 = int.Parse(textBox3.Text);
            數學分數 = int.Parse(textBox4.Text);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "姓名: " + 姓名 + "\n"
                    + "國文: " + 國文分數 + "\n"
                    + "英文: " + 英文分數 + "\n"
                    + "數學: " + 數學分數 + "\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string 最高分數 = "國文";
            int price = 0;
            switch (最高分數)
            {
                case "國文分數":
                    label6.Text = "國文" + textBox2.Text + "分";
                    break;
                case "英文分數":
                    label6.Text = "英文" + textBox3.Text + "分";
                    break;
                case "數學分數":
                    label6.Text = "數學" + textBox4.Text + "分";
                    break;
                    label6.Text = (最高分數);
                        

            }


        }
    }
}
