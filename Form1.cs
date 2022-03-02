using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Github01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text), y = double.Parse(textBox2.Text);
            double soucet = x + y;
            MessageBox.Show("Soucet je: " + soucet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text), y = double.Parse(textBox2.Text);
            double rozdil = x - y;
            MessageBox.Show("Rozdíl je: " + rozdil);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text), y = double.Parse(textBox2.Text);
            double soucin = x * y;
            MessageBox.Show("Součin je: " + soucin);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text), y = double.Parse(textBox2.Text);
            double podil = x / y;
            MessageBox.Show("Podíl je: " + podil);
        }
    }
}
