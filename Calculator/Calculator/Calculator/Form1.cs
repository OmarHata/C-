using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public string Opreation { get; private set; }
        public string Operation { get; private set; }

        public Form1()
        {
            double Number1;
            double Number2;
            string Opreation;
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
           double Number1 = Convert.ToDouble(textBox1.Text);
            double Number2= Convert.ToDouble(textBox2.Text);
            textBox3.Text = (Number1 + Number2).ToString();
            Opreation = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Number1 = Convert.ToDouble(textBox1.Text);
            double Number2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (Number1 - Number2).ToString();
            Opreation = "-";
        }
    }
}
