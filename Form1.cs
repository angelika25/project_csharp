using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przelicznik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = (double.Parse(textBox1.Text) * (0.0058824)).ToString();
                label7.Text = (double.Parse(textBox1.Text) * (0.1)).ToString();
            }
        }
    }
}
