namespace Chap3_hw3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grossincomeTextBox = new System.Windows.Forms.TextBox();
            this.standardDeductionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.otherexemptionsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resultLable = new System.Windows.Forms.Label();
            this.calculatetaxButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(30, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入年度總收入:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(30, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "請輸入標準扣除額:";
            // 
            // grossincomeTextBox
            // 
            this.grossincomeTextBox.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grossincomeTextBox.Location = new System.Drawing.Point(413, 66);
            this.grossincomeTextBox.Name = "grossincomeTextBox";
            this.grossincomeTextBox.Size = new System.Drawing.Size(287, 55);
            this.grossincomeTextBox.TabIndex = 2;
            // 
            // standardDeductionTextBox
            // 
            this.standardDeductionTextBox.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.standardDeductionTextBox.Location = new System.Drawing.Point(413, 151);
            this.standardDeductionTextBox.Name = "standardDeductionTextBox";
            this.standardDeductionTextBox.Size = new System.Drawing.Size(287, 55);
            this.standardDeductionTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(30, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "請輸入其他免稅額:";
            // 
            // otherexemptionsTextBox
            // 
            this.otherexemptionsTextBox.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.otherexemptionsTextBox.Location = new System.Drawing.Point(413, 243);
            this.otherexemptionsTextBox.Name = "otherexemptionsTextBox";
            this.otherexemptionsTextBox.Size = new System.Drawing.Size(287, 55);
            this.otherexemptionsTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(30, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 40);
            this.label4.TabIndex = 6;
            this.label4.Text = "計算結果:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // resultLable
            // 
            this.resultLable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLable.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultLable.Location = new System.Drawing.Point(289, 472);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(446, 174);
            this.resultLable.TabIndex = 7;
            this.resultLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculatetaxButton
            // 
            this.calculatetaxButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.calculatetaxButton.Location = new System.Drawing.Point(289, 363);
            this.calculatetaxButton.Name = "calculatetaxButton";
            this.calculatetaxButton.Size = new System.Drawing.Size(212, 57);
            this.calculatetaxButton.TabIndex = 8;
            this.calculatetaxButton.Text = "計算";
            this.calculatetaxButton.UseVisualStyleBackColor = true;
            this.calculatetaxButton.Click += new System.EventHandler(this.calculatetaxButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 760);
            this.Controls.Add(this.calculatetaxButton);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.otherexemptionsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.standardDeductionTextBox);
            this.Controls.Add(this.grossincomeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox grossincomeTextBox;
        private System.Windows.Forms.TextBox standardDeductionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox otherexemptionsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultLable;
        private System.Windows.Forms.Button calculatetaxButton;
    }
}

