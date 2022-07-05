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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void openhello_Click(object sender, EventArgs e)
        {
            helloform helloform = new helloform();
            helloform.Show();

        }
        void Firstmethod()
        {
            MessageBox.Show("123");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            class1 a = new class1();
            a.today();
            
        }

        private void method_Click(object sender, EventArgs e)
        {
            class1 method = new class1();
            method.Method03();


        }

        string Year(int age)
        {
            int OLD = DateTime.Now.Year - age;
            string birthday = "你的生日是" + "年" + OLD;
            
            return birthday;




                


        }
        private void button1_Click_1(object sender, EventArgs e)
        {
         class1 method01  = new class1();
            method01.Method03();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         class1 method  =  new class1();
            method.method06();
        }

        private void loan_Click(object sender, EventArgs e)
        {
            Bar Barpos = new Bar();
            Barpos.Show();
        }

        private void birthday_Click(object sender, EventArgs e)
        {
            string a = Year (100);
            MessageBox.Show(a);



        }

        private void cash_Click(object sender, EventArgs e)
        {
            Formcash ccash = new Formcash();
            ccash.Show();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            student student = new student();
            student.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            student2 student2 = new student2();
            student2.Show();
        }
    }
}
