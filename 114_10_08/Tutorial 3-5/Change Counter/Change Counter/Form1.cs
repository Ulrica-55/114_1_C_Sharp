using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        // 定義硬幣面額常數（單位：分）
        const decimal FIVE_CENT = 5.0m;      // 5分硬幣
        const decimal TEN_CENT = 10.0m;      // 10分硬幣
        const decimal TWENTYFIVE_CENT = 25.0m; // 25分硬幣
        const decimal FIFTY_CENT = 50.0m;    // 50分硬幣

        // 儲存目前累計的總金額（單位：分）
        private decimal total;

        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 點擊5分硬幣圖片時執行的事件處理方法
        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 累加5分到總金額
            total += FIVE_CENT;
            // 顯示目前總金額於標籤
            totalLabel.Text = total.ToString();
        }

        // 點擊10分硬幣圖片時執行的事件處理方法
        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 累加10分到總金額
            total += TEN_CENT;
            // 顯示目前總金額於標籤
            totalLabel.Text = total.ToString();
        }

        // 點擊25分硬幣圖片時執行的事件處理方法
        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 累加25分到總金額
            total += TWENTYFIVE_CENT;
            // 顯示目前總金額於標籤
            totalLabel.Text = total.ToString();
        }

        // 點擊50分硬幣圖片時執行的事件處理方法
        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 累加50分到總金額
            total += FIFTY_CENT;
            // 顯示目前總金額於標籤
            totalLabel.Text = total.ToString();
        }

        // 點擊離開按鈕時執行的事件處理方法
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單，結束程式
            this.Close();
        }
    }
}
