namespace MultipleConditions
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Button judgeButton;
        private System.Windows.Forms.Label gradeLabel;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelScore = new System.Windows.Forms.Label();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.judgeButton = new System.Windows.Forms.Button();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelScore.Location = new System.Drawing.Point(30, 30);
            this.labelScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(122, 55);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "成績:";
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.scoreTextBox.Location = new System.Drawing.Point(184, 19);
            this.scoreTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(270, 66);
            this.scoreTextBox.TabIndex = 1;
            // 
            // judgeButton
            // 
            this.judgeButton.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.judgeButton.Location = new System.Drawing.Point(40, 326);
            this.judgeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.judgeButton.Name = "judgeButton";
            this.judgeButton.Size = new System.Drawing.Size(225, 69);
            this.judgeButton.TabIndex = 2;
            this.judgeButton.Text = "等級判斷";
            this.judgeButton.UseVisualStyleBackColor = true;
            this.judgeButton.Click += new System.EventHandler(this.judgeButton_Click);
            // 
            // gradeLabel
            // 
            this.gradeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gradeLabel.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gradeLabel.Location = new System.Drawing.Point(184, 184);
            this.gradeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(270, 69);
            this.gradeLabel.TabIndex = 3;
            this.gradeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(30, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "等級:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.judgeButton);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.labelScore);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}

