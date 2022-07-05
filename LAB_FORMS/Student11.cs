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
    public partial class Student11 : Form
    {
        string name;
        int 國文分數;
        int 英文分數;
        int 數學分數;
        public Student11()
        {
            InitializeComponent();
        }
        
        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            

            anser.Text = "姓名:" + name + "\n"
                       + "國文:" + 國文分數 + "\n"
                       + "英文:" + 英文分數 + "\n"
                       + "數學:" + 數學分數 + "\n";

            //int[] 所有分數 = new int[3] { 國文分數, 英文分數, 數學分數 };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = (textBox1.Text);
            國文分數 = int.Parse(textBox2.Text);
            英文分數 = int.Parse(textBox3.Text);
            數學分數 = int.Parse(textBox4.Text);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Dictionary<string, int> dy = new Dictionary<string, int>();
            //dy.Add("國文", 國文分數);
            //dy.Add("英文", 英文分數);
            //dy.Add("數學", 數學分數);
            //var a = dy.AsEnumerable().OrderByDescending(x => x.Value).ToList();
            //label5.Text = "最高分" + a[0].Key + a[0].Value + "分   \n"

            //   + "最低分" + a[a.Count - 1].Key + a[a.Count - 1].Value + "分";
            int[] 分數= { 國文分數, 英文分數, 數學分數 };
            string[] 科目 ={ "國文","英文","數學"};
            Array.Sort (分數,科目);
            label5.Text = "最高科目分數:" + 分數[2] + 科目[2] + "\n最低科目分數" + 分數[0] + 科目[0];
        }
    }
}
