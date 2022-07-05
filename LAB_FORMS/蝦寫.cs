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
    public partial class 蝦寫 : Form
    {
        public 蝦寫()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";

            
            

            for (int i = 1; i <= 9; i++)
            {
                 

                for (int k = 2; k <= 9; k++)
                {
                    result += k + "x" + i + "=" + (k * i).ToString().PadLeft(2, ' ') + "  ";

                    if (k == 9)
                    {
                        
                        result += "\n";
                        label2.Text =  result;
                    }

                    //label2.Text += result;
                    //result += "\n";
                }
 }
           }    

                










           
       

        private void button2_Click(object sender, EventArgs e)
        {
            int[] aaa = { 1, 2, 3 };

        }
    }







}