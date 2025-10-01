using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutorial_3_1
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 表單載入事件（目前未實作任何功能）
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // 點擊「離開」按鈕時關閉表單
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 點擊「顯示日期」按鈕時，組合輸入的日期資訊並顯示於標籤
        private void showdateButton_Click(object sender, EventArgs e)
        {
            // 取得使用者輸入的星期、月份、日期與年份
            string dayOfWeek = dayOfWeekTextBox.Text;
            string month = monthTextBox.Text;
            string dayOfMonth = dayOfMonthTextBox.Text;
            string year = yearTextBox.Text;

            // 組合成「中華民國YYYY年MM月DD日星期X」格式的字串
            string output = "中華民國" + year +"年" + month + "月" + dayOfMonth + "日" + "星期" + dayOfWeek;
            // 顯示於標籤
            dateOutputLabel.Text = output;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dayOfWeekTextBox.Text= "";
            monthTextBox.Text= "";
            dayOfMonthTextBox.Text= "";
            yearTextBox.Text= "";
            dateOutputLabel.Text= "";
        }
    }
}
