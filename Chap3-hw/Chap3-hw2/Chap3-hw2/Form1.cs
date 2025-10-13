using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap3_hw2
{
    public partial class Form1 : Form
    {

        const decimal BANANA_CALORIES = 115;
        const decimal APPLE_CALORIES = 80;
        const decimal ORANGE_CALORIES = 90;
        const decimal PEAR_CALORIES = 120;

        private decimal total;




        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            total += BANANA_CALORIES;
            totalLabel.Text = total.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void applePictureBox_Click(object sender, EventArgs e)
        {
            total += APPLE_CALORIES;
            totalLabel.Text = total.ToString();
        }

        private void orangePictureBox_Click(object sender, EventArgs e)
        {
            total += ORANGE_CALORIES;
            totalLabel.Text = total.ToString();
        }

        private void pearPictureBox_Click(object sender, EventArgs e)
        {
            total += PEAR_CALORIES;
            totalLabel.Text = total.ToString();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            total = 0;
            totalLabel.Text = "0";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
