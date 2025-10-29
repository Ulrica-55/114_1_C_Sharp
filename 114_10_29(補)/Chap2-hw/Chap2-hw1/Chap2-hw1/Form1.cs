using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap2_hw1
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

        private void eightofdiamondsPictureBox_Click(object sender, EventArgs e)
        {
            cardsLabel.Text = "菱形8";
        }

        private void twoofclubsPictureBox_Click(object sender, EventArgs e)
        {
            cardsLabel.Text = "梅花2";
        }

        private void kofspadesPictureBox_Click(object sender, EventArgs e)
        {
            cardsLabel.Text = "黑桃K";
        }

        private void aofspadesPictureBox_Click(object sender, EventArgs e)
        {
            cardsLabel.Text = "黑桃A";
        }

        private void jokerPictureBox5_Click(object sender, EventArgs e)
        {
            cardsLabel.Text = "鬼牌";
        }

        private void cardsLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
