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
    public partial class Formcash : Form
    {
        public Formcash()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a1 = double.Parse(textBox1.Text); //貸款金額
            double a2 = double.Parse(textBox2.Text) * 12; //期限 年
            double a3 = double.Parse(textBox3.Text) / 100; //利率
            double a4 = double.Parse(textBox4.Text); //頭期款
            double a5 = a3 / 12;                     //年利率轉成月利率
            double a6 = (Math.Pow((1 + a5), a2) * a5) / (Math.Pow((1 + a5), a2) - 1);  //每月應還本息之平均攤還率 
            double a7 = a1 - a4;                     //貸款扣掉頭期款
            double a8 = Math.Floor(a7 * a6);                  //平均每月該還本息金額
            double 總付額;
            總付額 = a8 * 24;
            
            MessageBox.Show(總付額.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            report report = new report();
            report.Show();
            double a1 = double.Parse(textBox1.Text); //貸款金額
            double a2 = double.Parse(textBox2.Text) * 12; //期限 年
            double a3 = double.Parse(textBox3.Text) / 100; //利率
            double a4 = double.Parse(textBox4.Text); //頭期款
            double a5 = a3 / 12;                     //年利率轉成月利率
            double a6 = (Math.Pow((1 + a5), a2) * a5) / (Math.Pow((1 + a5), a2) - 1);  //每月應還本息之平均攤還率 
            double a7 = a1 - a4;                     //貸款扣掉頭期款
            double a8 = Math.Floor(a7 * a6);                  //平均每月該還本息金額
            double 總付額;
            總付額 = a8 * 24;
            report.intextBox1.Text = textBox1.Text;
            report.intextBox2.Text = textBox2.Text;
            report.intextBox3.Text = textBox3.Text;
            report.intextBox4.Text = a8.ToString();
            report.intextBox5.Text = 總付額.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a1 = double.Parse(textBox1.Text); //貸款金額
            double a2 = double.Parse(textBox2.Text) * 12; //期限 年
            double a3 = double.Parse(textBox3.Text) / 100; //利率
            double a4 = double.Parse(textBox4.Text); //頭期款
            double a5 = a3 / 12;                     //年利率轉成月利率
            double a6 = (Math.Pow((1 + a5), a2) * a5) / (Math.Pow((1 + a5), a2) - 1);  //每月應還本息之平均攤還率 
            double a7 = a1 - a4;                     //貸款扣掉頭期款
            double a8 = Math.Floor(a7 * a6);                  //平均每月該還本息金額
            
            MessageBox.Show(a8.ToString());
        }
    }
}
