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
    public partial class computer : Form
    {
        public computer()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                textBox3.Text = (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)).ToString();

            }


            catch (Exception EX)
            {

                MessageBox.Show("請輸入數值");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                textBox3.Text = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)).ToString();

            }


            catch (Exception EX) {

                MessageBox.Show("請輸入數值");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                textBox3.Text = (Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text)).ToString();

            }


            catch (Exception EX)
            {

                MessageBox.Show("請輸入數值");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {

                textBox3.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)).ToString();

            }


            catch (Exception EX)
            {

                MessageBox.Show("請輸入數值");
            }

        }
    }
}
