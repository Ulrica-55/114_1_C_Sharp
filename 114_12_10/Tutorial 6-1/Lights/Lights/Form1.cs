using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lights
{
    // 表單主要類別：定義 UI 行為（此類別為 partial，另一半由 Designer 產生）
    public partial class Form1 : Form
    {

        // 建構子：建立表單執行個體並初始化由 Designer 產生的控制項與事件綁定
        public Form1()
        {
            InitializeComponent();
        }

        // switchButton 的 Click 事件處理器
        // sender: 觸發事件的物件（通常為按鈕）
        // e: 事件參數（此處為 EventArgs，沒有額外資料）
        private void switchButton_Click(object sender, EventArgs e)
        {
            // 若表示「燈開」的圖片可見，表示目前是 ON 狀態
            if (lightOnPictureBox.Visible == true) // 目前燈是開啟狀態
            {
                // 呼叫關燈的輔助方法，將 UI 切換為 OFF
                turnLightOff();
            }
            else
            {
                // 若不是可見（代表燈為關閉），則呼叫開燈方法
                turnLightOn();
            }
        }

        // 將介面切換為「燈開」的狀態
        // - 顯示代表開燈的圖片（lightOnPictureBox）
        // - 隱藏代表關燈的圖片（lightOffPictureBox）
        // - 更新狀態標籤為 "ON"
        private void turnLightOn()
        {
            lightOnPictureBox.Visible = true;
            lightOffPictureBox.Visible = false;
            lightStateLabel.Text = "ON";
        }

        // 將介面切換為「燈關」的狀態
        // - 隱藏代表開燈的圖片（lightOnPictureBox）
        // - 顯示代表關燈的圖片（lightOffPictureBox）
        // - 更新狀態標籤為 "OFF"
        private void turnLightOff()
        {
            lightOnPictureBox.Visible = false;
            lightOffPictureBox.Visible = true;
            lightStateLabel.Text = "OFF";
        }

        // exitButton 的 Click 事件處理器
        // 關閉目前表單（若此表單為主要視窗，關閉會結束應用程式）
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
