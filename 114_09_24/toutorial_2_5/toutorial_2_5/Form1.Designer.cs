namespace toutorial_2_5
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
            this.cardbackPictureBox = new System.Windows.Forms.PictureBox();
            this.cardfacePictureBox = new System.Windows.Forms.PictureBox();
            this.showfaceButton = new System.Windows.Forms.Button();
            this.showbackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardbackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfacePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardbackPictureBox
            // 
            this.cardbackPictureBox.Image = global::toutorial_2_5.Properties.Resources.Backface_Red;
            this.cardbackPictureBox.Location = new System.Drawing.Point(284, 55);
            this.cardbackPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardbackPictureBox.Name = "cardbackPictureBox";
            this.cardbackPictureBox.Size = new System.Drawing.Size(122, 215);
            this.cardbackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardbackPictureBox.TabIndex = 1;
            this.cardbackPictureBox.TabStop = false;
            this.cardbackPictureBox.Click += new System.EventHandler(this.cardbackPictureBox_Click);
            // 
            // cardfacePictureBox
            // 
            this.cardfacePictureBox.Image = global::toutorial_2_5.Properties.Resources.Ace_Hearts;
            this.cardfacePictureBox.Location = new System.Drawing.Point(284, 55);
            this.cardfacePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardfacePictureBox.Name = "cardfacePictureBox";
            this.cardfacePictureBox.Size = new System.Drawing.Size(122, 215);
            this.cardfacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardfacePictureBox.TabIndex = 0;
            this.cardfacePictureBox.TabStop = false;
            // 
            // showfaceButton
            // 
            this.showfaceButton.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showfaceButton.Location = new System.Drawing.Point(92, 283);
            this.showfaceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showfaceButton.Name = "showfaceButton";
            this.showfaceButton.Size = new System.Drawing.Size(190, 40);
            this.showfaceButton.TabIndex = 2;
            this.showfaceButton.Text = "顯示正面";
            this.showfaceButton.UseVisualStyleBackColor = true;
            this.showfaceButton.Click += new System.EventHandler(this.showfaceButton_Click);
            // 
            // showbackButton
            // 
            this.showbackButton.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showbackButton.Location = new System.Drawing.Point(392, 283);
            this.showbackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showbackButton.Name = "showbackButton";
            this.showbackButton.Size = new System.Drawing.Size(171, 43);
            this.showbackButton.TabIndex = 3;
            this.showbackButton.Text = "顯示背面";
            this.showbackButton.UseVisualStyleBackColor = true;
            this.showbackButton.Click += new System.EventHandler(this.showbackButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 375);
            this.Controls.Add(this.showbackButton);
            this.Controls.Add(this.showfaceButton);
            this.Controls.Add(this.cardbackPictureBox);
            this.Controls.Add(this.cardfacePictureBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "翻轉撲克牌";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardbackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfacePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardfacePictureBox;
        private System.Windows.Forms.PictureBox cardbackPictureBox;
        private System.Windows.Forms.Button showfaceButton;
        private System.Windows.Forms.Button showbackButton;
    }
}

