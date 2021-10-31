using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtsoA.Text);
            double b = double.Parse(txtsob.Text);
            double c = a + b;
            txtkq.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtsoA.Text);
            double b = double.Parse(txtsob.Text);
            double c = a - b;
            txtkq.Text = c.ToString();
        }
    }
}
