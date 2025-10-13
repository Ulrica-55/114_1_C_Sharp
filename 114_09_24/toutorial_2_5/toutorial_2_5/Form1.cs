using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toutorial_2_5
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent(); // 初始化表單上的所有控制項
        }

        // 表單載入事件處理函式
        // 當表單載入時，將卡牌正面與背面圖片隱藏
        private void Form1_Load(object sender, EventArgs e)
        {
            cardbackPictureBox.Visible = false; // 隱藏卡牌背面圖片
            cardfacePictureBox.Visible = false; // 隱藏卡牌正面圖片
        }

        // 顯示卡牌正面按鈕的事件處理函式
        // 當使用者按下顯示正面按鈕時，顯示正面圖片並隱藏背面圖片
        private void showfaceButton_Click(object sender, EventArgs e)
        {
            cardbackPictureBox.Visible = false; // 隱藏卡牌背面圖片
            cardfacePictureBox.Visible = true;  // 顯示卡牌正面圖片
        }

        // 顯示卡牌背面按鈕的事件處理函式
        // 當使用者按下顯示背面按鈕時，顯示背面圖片並隱藏正面圖片
        private void showbackButton_Click(object sender, EventArgs e)
        {
            cardbackPictureBox.Visible = true;  // 顯示卡牌背面圖片
            cardfacePictureBox.Visible = false; // 隱藏卡牌正面圖片
        }

        private void cardbackPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
