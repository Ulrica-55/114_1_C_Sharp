using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;  // 宣告輸入檔案物件
            decimal totalSales = 0.0m; // 儲存總銷售額
            decimal currentSales = 0.0m; // 儲存目前讀取的銷售額
            string line; // 儲存讀取的行                        

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFile.FileName);  // 開啟檔案
                salesListBox.Items.Clear(); // 清除清單框內容

                while (!inputFile.EndOfStream)  // 讀取直到檔案結尾
                {
                    line = inputFile.ReadLine();

                    string[] parts = line.Split(new char[] (' '), StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length >= 2)
                    {
                        string month = parts[0];
                        string saleValue = parts[1];

                        if (decimal.TryParse(line = inputFile.ReadLine(), out currentSales))
                        {
                            salesListBox.Items.Add(month + "" + currentSales.ToString("C")); // 將銷售額加入清單框                     
                            totalSales += currentSales;  // 加到總銷售額
                        }
                        else
                        {
                            MessageBox.Show("無法解析銷售額: " + line);
                            inputFile.Close();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("資料格式錯誤:" + line);
                        inputFile.Close (); 
                        return;
                    }
                }
                inputFile.Close();  // 關閉檔案
                totalLabel.Text = totalSales.ToString("C"); // 顯示總銷售額
            }
            else
            {
                MessageBox.Show("未選擇檔案");
            }

                
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
