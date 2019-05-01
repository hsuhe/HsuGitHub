using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 繼承
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            B x = new B();
        }
    }
    class A
    {
        public A()
        {
            MessageBox.Show("建構子A開始");
        }
        ~A()
        {
            MessageBox.Show("解構子A開始");
        }
    }
    class B:A //B繼承A
    {
        public B()
        {
            MessageBox.Show("建構子B開始");
        }
        ~B()
        {
            MessageBox.Show("解構子B開始");
        }
    }

}
