namespace Fuel_Economy_with_TryParse
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計器變數。
        /// 此容器由設計器管理，用於儲存可釋放的資源（如控制項）。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// disposing 為 true 表示同時釋放受控與非受控資源；否則僅釋放非受控資源。
        /// 在覆寫 Dispose 時要確保呼叫 base.Dispose(disposing)。
        /// 清除任何使用中的資源。
        /// disposing 為 true 表示同時釋放受控與非受控資源；否則僅釋放非受控資源。
        /// 在覆寫 Dispose 時要確保呼叫 base.Dispose(disposing)。
        /// 清除任何使用中的資源。
        /// disposing 為 true 表示同時釋放受控與非受控資源；否則僅釋放非受控資源。
        /// 在覆寫 Dispose 時要確保呼叫 base.Dispose(disposing)。
        /// 清除任何使用中的資源。
        /// disposing 為 true 表示同時釋放受控與非受控資源；否則僅釋放非受控資源。
        /// 在覆寫 Dispose 時要確保呼叫 base.Dispose(disposing)。
        /// </summary>
        /// <param name="disposing">如果為 true，則釋放受控資源。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// 設計器所需的方法 — 請勿使用程式碼編輯器直接修改內容。
        /// 這個方法會建立並設定表單中的所有控制項屬性（包含文字、字型、位置與事件綁定）。
        /// 若需改動 UI 建議使用設計工具或小心調整此方法內容。
        /// 設計器所需的方法 — 請勿使用程式碼編輯器直接修改內容。
        /// 這個方法會建立並設定表單中的所有控制項屬性（包含文字、字型、位置與事件綁定）。
        /// 若需改動 UI 建議使用設計工具或小心調整此方法內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.mpgLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.gallonsTextBox = new System.Windows.Forms.TextBox();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.gallonsPromptLabel = new System.Windows.Forms.Label();
            this.milesPromptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(508, 412);
            this.exitButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(262, 108);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "結束";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(224, 412);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(262, 108);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "計算 MPG";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // mpgLabel
            // 
            this.mpgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpgLabel.Location = new System.Drawing.Point(616, 243);
            this.mpgLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.mpgLabel.Name = "mpgLabel";
            this.mpgLabel.Size = new System.Drawing.Size(345, 67);
            this.mpgLabel.TabIndex = 13;
            this.mpgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(32, 270);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(529, 40);
            this.outputDescriptionLabel.TabIndex = 12;
            this.outputDescriptionLabel.Text = "您車輛的每加侖英里數 (MPG)：";
            // 
            // gallonsTextBox
            // 
            this.gallonsTextBox.Location = new System.Drawing.Point(616, 149);
            this.gallonsTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.gallonsTextBox.Name = "gallonsTextBox";
            this.gallonsTextBox.Size = new System.Drawing.Size(340, 48);
            this.gallonsTextBox.TabIndex = 11;
            // 
            // milesTextBox
            // 
            this.milesTextBox.Location = new System.Drawing.Point(616, 37);
            this.milesTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(340, 48);
            this.milesTextBox.TabIndex = 10;
            // 
            // gallonsPromptLabel
            // 
            this.gallonsPromptLabel.AutoSize = true;
            this.gallonsPromptLabel.Location = new System.Drawing.Point(32, 157);
            this.gallonsPromptLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.gallonsPromptLabel.Name = "gallonsPromptLabel";
            this.gallonsPromptLabel.Size = new System.Drawing.Size(449, 40);
            this.gallonsPromptLabel.TabIndex = 9;
            this.gallonsPromptLabel.Text = "輸入使用的汽油（加侖）：";
            // 
            // milesPromptLabel
            // 
            this.milesPromptLabel.AutoSize = true;
            this.milesPromptLabel.Location = new System.Drawing.Point(32, 45);
            this.milesPromptLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.milesPromptLabel.Name = "milesPromptLabel";
            this.milesPromptLabel.Size = new System.Drawing.Size(305, 40);
            this.milesPromptLabel.TabIndex = 8;
            this.milesPromptLabel.Text = "輸入行駛英里數：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 557);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.gallonsTextBox);
            this.Controls.Add(this.milesTextBox);
            this.Controls.Add(this.gallonsPromptLabel);
            this.Controls.Add(this.milesPromptLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "油耗計算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label mpgLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.TextBox gallonsTextBox;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.Label gallonsPromptLabel;
        private System.Windows.Forms.Label milesPromptLabel;
    }
}

