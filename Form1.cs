using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoConflic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Test_Master()
        {
            int a = 0;
            int b = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int c = a + b;
        }
    }
}
