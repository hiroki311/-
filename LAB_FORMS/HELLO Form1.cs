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
    public partial class helloform : Form
    {
        public helloform()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string NAME = boxname.Text;
            
            string engname = textBoxengname.Text;
            string boxboygirl = textBoxboygirl.Text;
            string seisa = textBox3seisa.Text;



            MessageBox.Show("你好我是" + NAME +"\n" 
                +"英文名子是" + engname +"\n" 
                + "性別是" + boxboygirl +"\n"
                + "星座是" + seisa +"\n"
                +"很高興認識你");
        }

        private void boxname_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttoneng_Click(object sender, EventArgs e)
        {
            string NAME = boxname.Text;

            string engname = textBoxengname.Text;
            string boxboygirl = textBoxboygirl.Text;
            string seisa = textBox3seisa.Text;



            MessageBox.Show("hello我是" + NAME + "\n"
                + "英文名子是" + engname + "\n"
                + "性別是" + boxboygirl + "\n"
                + "星座是" + seisa + "\n"
                + "很高興認識你");
        }

        private void textBox3seisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            button.BackColor = Color.Silver;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            button.BackColor = Color.WhiteSmoke;
        }

        private void buttoneng_MouseMove(object sender, MouseEventArgs e)
        {
            buttoneng.BackColor = Color.Silver;
        }

        private void buttoneng_MouseLeave(object sender, EventArgs e)
        {
            buttoneng.BackColor = Color.WhiteSmoke;
        }
    }
}
