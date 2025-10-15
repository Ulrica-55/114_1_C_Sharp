using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者按下「審核資格」按鈕時觸發的事件
        private void checkButton_Click(object sender, EventArgs e)
        {
            // 此處可加入貸款資格審核的邏輯
            const decimal MINIMUM_SALARY = 1200000m; // 最低年薪
            const int MINIMUM_YEARS = 2; // 最低年資

            decimal salary; // 使用者輸入的年薪
            int yearsOnJob; // 使用者輸入的年資

            try
            {
                salary = decimal.Parse(salaryTextBox.Text); // 解析年薪輸入
                yearsOnJob = int.Parse(yearsTextBox.Text); // 解析年資輸入

                // 根據年薪與年資決定是否符合資格
                if (salary >= MINIMUM_SALARY)
                {
                    if (yearsOnJob >= MINIMUM_YEARS)
                    {
                        decisionLabel.Text = "符合資格"; // 顯示符合資格
                    }
                    else
                    {
                        decisionLabel.Text = "不符合資格:年資未達最低標準"; // 顯示不符合資格
                    }

                }
                else
                {
                    decisionLabel.Text = "不符合資格:收入未達最低標準"; // 顯示不符合資格
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// 顯示錯誤訊息
            }

        }

        // 當使用者按下「清除」按鈕時觸發的事件
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空年薪與年資輸入框，以及審核結果標籤
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // 將游標焦點回到年薪輸入框
            salaryTextBox.Focus();
        }

        // 當使用者按下「離開」按鈕時觸發的事件
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
