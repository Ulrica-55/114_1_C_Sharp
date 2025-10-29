using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap3_hw1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal replacementcost;
            decimal discountPercentage;
            decimal insure;

            replacementcost = decimal.Parse(replacementTextBox.Text);
            discountPercentage = decimal.Parse(textBox1.Text);
            insure = replacementcost * (discountPercentage / 100.0m);

            insureLabel.Text = insure.ToString("c");

            
        }
    }
}
