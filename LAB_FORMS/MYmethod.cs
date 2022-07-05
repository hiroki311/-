using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_FORMS
{
   public partial class class1
    {
        private void Method01()
        {
            
            MessageBox.Show("private mothod");

        }
        public void Method02()
        {
            MessageBox.Show("public mothod");

        }
        public void Method03()
        {
            Method01();
        }
        public void today()
        {
            MessageBox.Show("懂了");

        }
    }
}
