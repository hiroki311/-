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
    public partial class 圈差 : Form
    {

        bool isX = true;
        public 圈差()
        {
            InitializeComponent();
        }

        void 清除()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;


        }


        DialogResult qa;
        private void testwin()
        {
            
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X") qa = MessageBox.Show("X 贏了!!", "完局", MessageBoxButtons.OK);
            
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") qa = MessageBox.Show("X 贏了!!", "完局", MessageBoxButtons.OK); 
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") qa = MessageBox.Show("X 贏了!!", "完局", MessageBoxButtons.OK); 
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") qa = MessageBox.Show("X 贏了!!", "完局", MessageBoxButtons.OK); 
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") qa = MessageBox.Show("X 贏了!!", "完局", MessageBoxButtons.OK); 
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") qa = MessageBox.Show("X 贏了!!", "完局", MessageBoxButtons.OK); 
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") qa = MessageBox.Show("X 贏了!!", "完局", MessageBoxButtons.OK); 
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X") qa = MessageBox.Show("X 贏了!!", "完局", MessageBoxButtons.OK); 
            //
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O") qa = MessageBox.Show("O 贏了!!", "完局", MessageBoxButtons.OK); 
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") qa = MessageBox.Show("O 贏了!!", "完局", MessageBoxButtons.OK); 
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") qa = MessageBox.Show("O 贏了!!", "完局", MessageBoxButtons.OK); 
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") qa = MessageBox.Show("O 贏了!!", "完局", MessageBoxButtons.OK); 
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") qa = MessageBox.Show("O 贏了!!", "完局", MessageBoxButtons.OK); 
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") qa = MessageBox.Show("O 贏了!!", "完局", MessageBoxButtons.OK); 
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O") qa = MessageBox.Show("O 贏了!!", "完局", MessageBoxButtons.OK);
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") qa = MessageBox.Show("O 贏了!!", "完局", MessageBoxButtons.OK);
            if (qa == DialogResult.OK)
            {
                清除();
                qa = DialogResult.None;
            }

            
        }






        private void button1_Click(object sender, EventArgs e)
        {

            if (isX == true)
            {
                button1.Text = "X";
                isX = false;
            }
            else
            {
                button1.Text = "O";
                isX = true;
            }

            button1.Enabled = false;
            testwin();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                button2.Text = "X";
                isX = false;
            }
            else
            {
                button2.Text = "O";
                isX = true;
            }
            button2.Enabled = false;
            testwin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                button3.Text = "X";
                isX = false;
            }
            else
            {
                button3.Text = "O";
                isX = true;
            }
            button3.Enabled = false;
            testwin();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                button4.Text = "X";
                isX = false;
            }
            else
            {
                button4.Text = "O";
                isX = true;
            }
            button4.Enabled = false;
            testwin();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                button5.Text = "X";
                isX = false;
            }
            else
            {
                button5.Text = "O";
                isX = true;
            }
            button5.Enabled = false;
            testwin();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                button6.Text = "X";
                isX = false;
            }
            else
            {
                button6.Text = "O";
                isX = true;
            }
            button6.Enabled = false;
            testwin();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                button7.Text = "X";
                isX = false;
            }
            else
            {
                button7.Text = "O";
                isX = true;
            }
            button7.Enabled = false;
            testwin();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                button8.Text = "X";
                isX = false;
            }
            else
            {
                button8.Text = "O";
                isX = true;
            }
            button8.Enabled = false;
            testwin();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                button9.Text = "X";
                isX = false;
            }
            else
            {
                button9.Text = "O";
                isX = true;
            }
            button9.Enabled = false;
            testwin();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            清除();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
