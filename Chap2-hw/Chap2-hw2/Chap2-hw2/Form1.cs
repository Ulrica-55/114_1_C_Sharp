using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap2_hw2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            coinheadPictureBox.Visible = false;
            cointailPictureBox.Visible = false;
        }

        private void showheadsButton_Click(object sender, EventArgs e)
        {
            coinheadPictureBox.Visible = true;
            cointailPictureBox.Visible = false;
        }

        private void showtailsButton_Click(object sender, EventArgs e)
        {
            coinheadPictureBox.Visible = false;
            cointailPictureBox.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
