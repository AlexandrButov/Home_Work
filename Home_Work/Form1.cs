using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tab2_button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tab2_textBox1.Text);
            int b = Convert.ToInt32(tab2_textBox2.Text);
            int c = a + b;
            tab2_textBox3.Text = c.ToString();
        }
    }
}
