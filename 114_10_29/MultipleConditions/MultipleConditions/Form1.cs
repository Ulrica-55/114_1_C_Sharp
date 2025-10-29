using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleConditions
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

        private void judgeButton_Click(object sender, EventArgs e)
        {
            try
            {   int score = int.Parse(scoreTextBox.Text);
                string grade;
                //if (score >= 90)
                //{
                //    grade = "A";
                //}
                //else if (score >= 80)//sore is less than 90 是隱含的條件
                //{
                //    grade = "B";
                //}
                //else if (score >= 70)//sore is less than 80 是隱含的條件
                //{
                //    grade = "C";
                //}
                //else if (score >= 60)//sore is less than 70 是隱含的條件
                //{
                //    grade = "D";
                //}
                //else
                //{
                //    grade = "F";
                //}
                if (score >= 60)
                {
                    if (score >=70)
                    {
                        if (score >= 80)
                        {
                            if (score >= 90)
                            {
                                grade = "A";
                            }
                            else
                            {
                                grade = "B";
                            }
                        }
                        else
                        {
                            grade = "C";
                        }
                    }
                    else
                    {
                        grade = "D";
                    }
                }
                else
                {
                    grade = "F";
                }
                    gradeLabel.Text = grade;
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效的數字成績。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
