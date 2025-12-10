using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
            if (cardListBox.SelectedIndex != -1)
            {
                showSelectedCard(cardListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("請選擇一張卡片");
            }
        }

        private void showSelectedCard(string cardName)
        {  
            switch(cardName)
                {
                case "黑桃A":
                    //在此處添加顯示黑桃A的邏輯
                    showAceSpades();
                    break;
                case "紅心10":
                    //在此處添加顯示紅心10的邏輯
                    showTenHearts();
                    break;
                case "梅花K":
                    //在此處添加顯示梅花K的邏輯
                    showKingClub();
                    break;
                default:
                    MessageBox.Show("未知的卡片選擇");
                    break;
            }
        }

        private void showAceSpades()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }
        private void showTenHearts()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = true;
            kingClubsPictureBox.Visible = false;
        }
        private void showKingClub()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = true;
        }



        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void cardListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
