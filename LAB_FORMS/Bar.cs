using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Bar : Form
    {
        public Bar()
        {
            InitializeComponent();
        }
        delegate double Payment(double 定義存入值);
        double Discount10off(double price)
        { return price * 0.9; }

        double Discount100off(double price)
        { return price * 1; }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string nt;
            nt = textBox1.Text;
            if (nt == "")
            {
                MessageBox.Show("請輸入金額");
            }
            else
            {


                Payment pay;

                { pay = Discount10off; }

                double price = double.Parse(Total.ToString());
                double 折扣金額 = pay(price);
                
                { pay = Discount100off; }

                double pprice = double.Parse(Total.ToString());
                double 原價 = pay(pprice);
                //MessageBox.Show(reslut.ToString());
                DialogResult aresult = MessageBox.Show("總金額:" + 原價 + "元" + "\n" + "折扣後金額:" + 折扣金額 + "元", "確認付款"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (aresult == DialogResult.Yes)
                {
                    MessageBox.Show("謝謝光臨");
                }
                else
                {
                    MessageBox.Show("已取消交易");
                }
            }
        }



        int Total;
        int 牛排 = 220, 海鮮 = 250, 果汁 = 30, 啤酒 = 50;
        int 牛排點次數, 海鮮點次數, 果汁點次數, 啤酒點次數;
        string 牛排字串, 海鮮字串, 果汁字串, 啤酒字串;

        public void steak1_Click(object sender, EventArgs e)
        {

            {
                牛排點次數++;
                Total = Total + 牛排;
                textBox1.Text = "NT" + Total.ToString();
                牛排字串 = "牛排 x" + 牛排點次數 + "共" + Total.ToString()+"\n";
                label6.Text = 牛排字串 + 海鮮字串 + 果汁字串 + 啤酒字串;

                    
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)

        {



        }

        public void button5_Click(object sender, EventArgs e)
        {
            string nt;
            nt = textBox1.Text;
            if (nt == "")
            {
                MessageBox.Show("請輸入金額");
            }
            else
            {
                Payment pay;
                { pay = Discount100off; }

                double pprice = double.Parse(Total.ToString());
                double 原價  = pay(pprice);
                DialogResult qresult;
                qresult = MessageBox.Show("總金額:" + 原價.ToString(), "確認付款", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (qresult==DialogResult.Yes) 
                {
                    MessageBox.Show("謝謝光臨");
                }
                else
                {
                    MessageBox.Show("已取消交易");
                }

                    //MessageBox.Show(reslut.ToString());
            }

        }

        private void bear2_Click(object sender, EventArgs e)
        {
            啤酒點次數++;
            Total = Total + 啤酒;
            textBox1.Text = "NT" + Total.ToString();
            啤酒字串 = "啤酒 x" + 啤酒點次數 + "共" + Total.ToString() + "\n";
            label6.Text = 牛排字串 + 海鮮字串 + 果汁字串 + 啤酒字串;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Total = 0;
            牛排點次數 = 0;
            果汁點次數 = 0;
            啤酒點次數 = 0;
            海鮮點次數 = 0;
            牛排字串 = "";
            海鮮字串 = "";
            啤酒字串 = "";
            果汁字串 = "";
            label6.Text = "尚未點餐";
            textBox1.Text = "";
        }

        private void seafood3_Click(object sender, EventArgs e)
        {
            海鮮點次數++;
            Total = Total + 海鮮;
            textBox1.Text = "NT" + Total.ToString();
            海鮮字串 = "海鮮 x" + 海鮮點次數 + "共" + Total.ToString() + "\n";
            label6.Text = 牛排字串 + 海鮮字串 + 果汁字串 + 啤酒字串;
        }

        private void juice4_Click(object sender, EventArgs e)
        {
            果汁點次數++;
            Total = Total + 果汁;
            textBox1.Text = "NT" + Total.ToString();
            果汁字串 = "果汁 x" + 果汁點次數 + "共" + Total.ToString() + "\n";
            label6.Text = 牛排字串 + 海鮮字串 + 果汁字串 + 啤酒字串;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
