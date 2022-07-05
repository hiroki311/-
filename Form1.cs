using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            button2.Click += Button2_Click;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("成功");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Click -= Button2_Click;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }
        delegate double Payment (double aaa);
        // Payment：委派(定義)的模板
        double Discount50off(double qqq)
        {
        return qqq * 0.5;
        }
        double Discount20off(double qqq)
        {
            return qqq * 0.8;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Payment pay; //實際運作的公式
            if(comboBox1.Text == "50%")
            {
                pay = Discount50off; //公式運作內容
            }
            else
            {
                pay = Discount20off;
            }
            double qqq = double.Parse(textBox1.Text);
            double result = pay(qqq);
            MessageBox.Show(result.ToString());
        }
        
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            student a = new student();
            a.name = "jak";
            a.Walk();


        }
    }
}
