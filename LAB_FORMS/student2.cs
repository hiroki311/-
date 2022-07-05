using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace LAB_FORMS
{
    public partial class student2 : Form
    {
        public student2()
        {
            InitializeComponent();
           
            this.listView1.Columns.Add("姓名", 50, HorizontalAlignment.Center);
            this.listView1.Columns.Add("國文", 50, HorizontalAlignment.Center);
            this.listView1.Columns.Add("英文", 50, HorizontalAlignment.Center);
            this.listView1.Columns.Add("數學", 50, HorizontalAlignment.Center);
            this.listView1.Columns.Add("總分", 50, HorizontalAlignment.Center);
            this.listView1.Columns.Add("平均分", 50, HorizontalAlignment.Center);
            this.listView1.Columns.Add("最高", 50, HorizontalAlignment.Center);
            this.listView1.Columns.Add("最低", 50, HorizontalAlignment.Center);
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.FullRowSelect = true;
        }
        
        

        //int 國文;
        //int 數學;
        //int 英文;
        int autoID = 1;
        
        
        
       public void addToListView(string name,int 國文,int 英文,int 數學 ,int 輸入值總分, double 平均分數, string 最高分, string 最低分) 
        {
            ListViewItem eachRow = new ListViewItem(textBox1.Text);
           
            ListViewItem.ListViewSubItem rowSurname = new ListViewItem.ListViewSubItem(eachRow,(國文).ToString());
            ListViewItem.ListViewSubItem rowEN = new ListViewItem.ListViewSubItem(eachRow, (英文).ToString());
            ListViewItem.ListViewSubItem rowMA = new ListViewItem.ListViewSubItem(eachRow, (數學).ToString());
            ListViewItem.ListViewSubItem row輸入值總分 = new ListViewItem.ListViewSubItem(eachRow, (輸入值總分).ToString());
            ListViewItem.ListViewSubItem row平均分數 = new ListViewItem.ListViewSubItem(eachRow, (平均分數).ToString("F1"));
            ListViewItem.ListViewSubItem row輸入值最高分 = new ListViewItem.ListViewSubItem(eachRow, (最高分).ToString());
            ListViewItem.ListViewSubItem row輸入值最低分 = new ListViewItem.ListViewSubItem(eachRow, (最低分).ToString());
            eachRow.SubItems.Add(rowSurname);
            eachRow.SubItems.Add(rowEN);
            eachRow.SubItems.Add(rowMA);
            eachRow.SubItems.Add(row輸入值總分);
            eachRow.SubItems.Add(row平均分數);
            eachRow.SubItems.Add(row輸入值最高分);
            eachRow.SubItems.Add(row輸入值最低分);

            listView1.Items.Add(eachRow);
            autoID++;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                string userName = textBox1.Text.ToString();
                int ch = int.Parse(textBox2.Text);
                int en = int.Parse(textBox3.Text);
                int ma = int.Parse(textBox4.Text);
                int 輸入值總分 = ch + en + ma;
                double 輸入值平均分 = Convert.ToDouble(輸入值總分) / 3;
                string[] 國英數科目 = new string[] { "國文", "英文", "數學" };
                int[] 國英數分數 = new int[] { ch, en, ma };
                Array.Sort(國英數科目, 國英數分數);

                string txtnum = textBox1.Text;
                string txtnum2 = textBox2.Text;
                string txtnum3 = textBox3.Text;
                string txtnum4 = textBox4.Text;
                int num;
                int nun;
                bool isnum = int.TryParse(txtnum, out num);
                bool isnu = int.TryParse(txtnum2, out nun);
                bool isn = int.TryParse(txtnum3, out nun);
                bool isS = int.TryParse(txtnum4, out nun);
                if (isnum && isnu && isn && isS)
                {

                    addToListView(userName, (ch), (en), (ma), (輸入值總分), (輸入值平均分), (國英數科目[2] + 國英數分數[2]), (國英數科目[0] + 國英數分數[0]));

                }
              
            }
            catch(Exception)
            {
                MessageBox.Show("請輸入數值!!");
            }
          
        }
            
            
           

        


        private void button4_Click(object sender, EventArgs e)
        {
            
            listView1.Items.Clear();
            listView2.Items.Clear();
            autoID = 1;
            button1.Enabled = true;
            button2.Enabled = true;
            button5.Enabled = true;
        }

        

            Random rnd= new Random();

        
        private void button2_Click(object sender, EventArgs e)
        {
            String userName = textBox1.Text.ToString();

            int 國文分數 = rnd.Next(0, 100);
            int 英文分數 = rnd.Next(0, 100);
            int 數學分數 = rnd.Next(0, 100);
            int 總分分數 = 國文分數 + 英文分數 + 數學分數;
            double 平均分數 = Convert.ToDouble(總分分數) / 3;
            int n1, n2, n3;
            n1 = 國文分數;
            n2 = 英文分數;
            n3 = 數學分數;
            string[] 最高分項目 = new string[] { "國文", "英文", "數學" };
            int[] 最高分分數 = new int[] { n1, n2, n3 };
            Array.Sort(最高分分數, 最高分項目);
          


            
             RNDADD((userName),(國文分數), (英文分數), (數學分數),(總分分數),(平均分數),(最高分項目[2]+ 最高分分數[2]),(最高分項目[0] + 最高分分數[0]));
            


        }
        List<double> 國文 = new List<double>();
        List<double> 英文 = new List<double>();
        List<double> 數學 = new List<double>();

        public void RNDADD(string name, int 國文, int 英文, int 數學, int 總分,double 平均分數,string 最高分,string 最低分)
        {
            ListViewItem eachRow = new ListViewItem(textBox1.Text+ autoID);
            
            ListViewItem.ListViewSubItem rowSurname = new ListViewItem.ListViewSubItem(eachRow, 國文.ToString());
            ListViewItem.ListViewSubItem rowEN = new ListViewItem.ListViewSubItem(eachRow, 英文.ToString());
            ListViewItem.ListViewSubItem rowMA = new ListViewItem.ListViewSubItem(eachRow, 數學.ToString());
            ListViewItem.ListViewSubItem row總分 = new ListViewItem.ListViewSubItem(eachRow, 總分.ToString());
            ListViewItem.ListViewSubItem row平均分數 = new ListViewItem.ListViewSubItem(eachRow, 平均分數.ToString("F1"));
            ListViewItem.ListViewSubItem row最高分 = new ListViewItem.ListViewSubItem(eachRow, 最高分.ToString());
            ListViewItem.ListViewSubItem row最低分 = new ListViewItem.ListViewSubItem(eachRow, 最低分.ToString());
            eachRow.SubItems.Add(rowSurname);
            eachRow.SubItems.Add(rowEN);
            eachRow.SubItems.Add(rowMA);
            eachRow.SubItems.Add(row總分);
            eachRow.SubItems.Add(row平均分數);
            eachRow.SubItems.Add(row最高分);
            eachRow.SubItems.Add(row最低分);
            listView1.Items.Add(eachRow);
            autoID++;

        }
       
        private void button3_Click(object sender, EventArgs e)
        {

            string 總和國文 = "0";
            string 總和英文 = "0";
            string 總和數學 = "0";
            

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                總和國文 = (Convert.ToInt32(總和國文) +  Convert.ToInt32(listView1.Items[i].SubItems[1].Text)).ToString();
                總和英文 = (Convert.ToInt32(總和英文) + Convert.ToInt32(listView1.Items[i].SubItems[2].Text)).ToString();
                總和數學 = (Convert.ToInt32(總和數學) + Convert.ToInt32(listView1.Items[i].SubItems[3].Text)).ToString();
                國文.Add (Convert.ToInt32(listView1.Items[i].SubItems[1].Text));
                英文.Add(Convert.ToInt32(listView1.Items[i].SubItems[2].Text));
                數學.Add(Convert.ToInt32(listView1.Items[i].SubItems[3].Text));
            } 
            listView2.Items.Add("總分");

            listView2.Items[0].SubItems.Add(總和國文);
            listView2.Items[0].SubItems.Add(總和英文);
            listView2.Items[0].SubItems.Add(總和數學);
            listView2.Items.Add("平均分");
            listView2.Items[1].SubItems.Add(((double.Parse(總和國文) / listView1.Items.Count).ToString("F1")));
            listView2.Items[1].SubItems.Add((Math.Round(double.Parse(總和英文) / listView1.Items.Count)).ToString("F1"));
            listView2.Items[1].SubItems.Add((Math.Round(double.Parse(總和數學) / listView1.Items.Count)).ToString("F1"));
            listView2.Items.Add("最高分");
            listView2.Items[2].SubItems.Add(國文.Max().ToString());
            listView2.Items[2].SubItems.Add(英文.Max().ToString());
            listView2.Items[2].SubItems.Add(數學.Max().ToString());
            listView2.Items.Add("最低分");
            listView2.Items[3].SubItems.Add(國文.Min().ToString());
            listView2.Items[3].SubItems.Add(英文.Min().ToString());
            listView2.Items[3].SubItems.Add(數學.Min().ToString());

            button1.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = false;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            for (double i = 0; i < 20; i++)
            {
            int 國文分數 = rnd.Next(0, 100);
            int 英文分數 = rnd.Next(0, 100);
            int 數學分數 = rnd.Next(0, 100);
            int 總分分數 = 國文分數 + 英文分數 + 數學分數;
                double 平均分數 = Convert.ToDouble(總分分數) / 3;
                int n1, n2, n3;
            n1 = 國文分數;
            n2 = 英文分數;
            n3 = 數學分數;
            string[] 最高分項目 = new string[] { "國文", "英文", "數學" };
            int[] 最高分分數 = new int[] { n1, n2, n3 };
            Array.Sort(最高分分數, 最高分項目);
            RNDADD(i.ToString(), (國文分數), (英文分數), (數學分數), (總分分數), (平均分數), (最高分項目[2] + 最高分分數[2]), (最高分項目[0] + 最高分分數[0]));
            }

        }
    }
}
