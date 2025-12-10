using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Comprehensive_practice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 新增按鈕事件實作以對應 Designer 中的事件綁定，避免 CS1061
        private void btnShowHighest_Click(object sender, EventArgs e)
        {
            // 使用 Designer 中的控制項名稱
            string surname = textBoxSurname.Text;
            string givenName = textBoxGiven.Text;
            int quiz1, quiz2, quiz3;

            // 解析三個小考欄位為整數
            if (int.TryParse(this.txtExam1.Text, out quiz1) &&
                int.TryParse(this.txtExam2.Text, out quiz2) &&
                int.TryParse(this.txtExam3.Text, out quiz3))
            {
                ShowResult(surname, givenName, quiz1, quiz2, quiz3);
            }
            else
            {
                MessageBox.Show("成績一律輸入整數", "資料錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearTextBoxes();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 保留使用者原本的空方法（若 Designer 綁定）
        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        // 顯示最高分並更新結果 Label
        private void ShowResult(string surname, string givenName, int quiz1, int quiz2, int quiz3)
        {
            int highestScore = Math.Max(quiz1, Math.Max(quiz2, quiz3));
            string fullName = string.Concat(surname, givenName);
            string message = string.Format("{0} 的最高分是 {1}", fullName, highestScore);

            // 顯示訊息視窗
            MessageBox.Show(message, "最高分", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 同步更新畫面上的結果 Label
            this.lblResult.Text = $"最高分: {highestScore}";

            // 清除成績欄位（保留姓名欄）
            ClearTextBoxes();
        }



        // 清除小考欄位；提供重載以相容不同呼叫方式
        private void ClearTextBoxes()
        {
            this.txtExam1.Text = string.Empty;
            this.txtExam2.Text = string.Empty;
            this.txtExam3.Text = string.Empty;
        }

        // 若有其他地方呼叫 clearTextBoxes(0) 或類似，保留一個接受 int 的重載
        private void ClearTextBoxes(int _)
        {
            ClearTextBoxes();
        }
    }
}
