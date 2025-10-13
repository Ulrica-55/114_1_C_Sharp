namespace Chap3_hw2
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
            this.pearPictureBox = new System.Windows.Forms.PictureBox();
            this.orangePictureBox = new System.Windows.Forms.PictureBox();
            this.applePictureBox = new System.Windows.Forms.PictureBox();
            this.bananaPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pearPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bananaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 4;
            // 
            // pearPictureBox
            // 
            this.pearPictureBox.Image = global::Chap3_hw2.Properties.Resources.Pear;
            this.pearPictureBox.Location = new System.Drawing.Point(286, 286);
            this.pearPictureBox.Name = "pearPictureBox";
            this.pearPictureBox.Size = new System.Drawing.Size(146, 140);
            this.pearPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pearPictureBox.TabIndex = 3;
            this.pearPictureBox.TabStop = false;
            this.pearPictureBox.Click += new System.EventHandler(this.pearPictureBox_Click);
            // 
            // orangePictureBox
            // 
            this.orangePictureBox.Image = global::Chap3_hw2.Properties.Resources.Orange;
            this.orangePictureBox.Location = new System.Drawing.Point(88, 286);
            this.orangePictureBox.Name = "orangePictureBox";
            this.orangePictureBox.Size = new System.Drawing.Size(146, 140);
            this.orangePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orangePictureBox.TabIndex = 2;
            this.orangePictureBox.TabStop = false;
            this.orangePictureBox.Click += new System.EventHandler(this.orangePictureBox_Click);
            // 
            // applePictureBox
            // 
            this.applePictureBox.Image = global::Chap3_hw2.Properties.Resources.Apple;
            this.applePictureBox.Location = new System.Drawing.Point(286, 81);
            this.applePictureBox.Name = "applePictureBox";
            this.applePictureBox.Size = new System.Drawing.Size(146, 140);
            this.applePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.applePictureBox.TabIndex = 1;
            this.applePictureBox.TabStop = false;
            this.applePictureBox.Click += new System.EventHandler(this.applePictureBox_Click);
            // 
            // bananaPictureBox
            // 
            this.bananaPictureBox.Image = global::Chap3_hw2.Properties.Resources.Banana;
            this.bananaPictureBox.Location = new System.Drawing.Point(88, 81);
            this.bananaPictureBox.Name = "bananaPictureBox";
            this.bananaPictureBox.Size = new System.Drawing.Size(146, 140);
            this.bananaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bananaPictureBox.TabIndex = 0;
            this.bananaPictureBox.TabStop = false;
            this.bananaPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(83, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "115 Calories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(296, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "80 Calories";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(84, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "90 Calories";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(282, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "120 Calories";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(546, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total Calories";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.totalLabel.Location = new System.Drawing.Point(546, 177);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(176, 30);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "0";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resetButton.Location = new System.Drawing.Point(563, 326);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(144, 42);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(563, 395);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(144, 42);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 603);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pearPictureBox);
            this.Controls.Add(this.orangePictureBox);
            this.Controls.Add(this.applePictureBox);
            this.Controls.Add(this.bananaPictureBox);
            this.Name = "Form1";
            this.Text = "Calorie Counter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pearPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bananaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bananaPictureBox;
        private System.Windows.Forms.PictureBox applePictureBox;
        private System.Windows.Forms.PictureBox orangePictureBox;
        private System.Windows.Forms.PictureBox pearPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
    }
}

