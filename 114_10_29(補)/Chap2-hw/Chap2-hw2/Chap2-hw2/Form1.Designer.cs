namespace Chap2_hw2
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
            this.cointailPictureBox = new System.Windows.Forms.PictureBox();
            this.coinheadPictureBox = new System.Windows.Forms.PictureBox();
            this.showheadsButton = new System.Windows.Forms.Button();
            this.showtailsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cointailPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinheadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cointailPictureBox
            // 
            this.cointailPictureBox.Image = global::Chap2_hw2.Properties.Resources.Tails2;
            this.cointailPictureBox.Location = new System.Drawing.Point(407, 72);
            this.cointailPictureBox.Name = "cointailPictureBox";
            this.cointailPictureBox.Size = new System.Drawing.Size(151, 172);
            this.cointailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cointailPictureBox.TabIndex = 1;
            this.cointailPictureBox.TabStop = false;
            // 
            // coinheadPictureBox
            // 
            this.coinheadPictureBox.Image = global::Chap2_hw2.Properties.Resources.Heads2;
            this.coinheadPictureBox.Location = new System.Drawing.Point(137, 72);
            this.coinheadPictureBox.Name = "coinheadPictureBox";
            this.coinheadPictureBox.Size = new System.Drawing.Size(151, 172);
            this.coinheadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coinheadPictureBox.TabIndex = 0;
            this.coinheadPictureBox.TabStop = false;
            // 
            // showheadsButton
            // 
            this.showheadsButton.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showheadsButton.Location = new System.Drawing.Point(76, 290);
            this.showheadsButton.Name = "showheadsButton";
            this.showheadsButton.Size = new System.Drawing.Size(161, 73);
            this.showheadsButton.TabIndex = 2;
            this.showheadsButton.Text = "Show Heads";
            this.showheadsButton.UseVisualStyleBackColor = true;
            this.showheadsButton.Click += new System.EventHandler(this.showheadsButton_Click);
            // 
            // showtailsButton
            // 
            this.showtailsButton.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showtailsButton.Location = new System.Drawing.Point(287, 290);
            this.showtailsButton.Name = "showtailsButton";
            this.showtailsButton.Size = new System.Drawing.Size(149, 73);
            this.showtailsButton.TabIndex = 3;
            this.showtailsButton.Text = "Show Tails";
            this.showtailsButton.UseVisualStyleBackColor = true;
            this.showtailsButton.Click += new System.EventHandler(this.showtailsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(482, 290);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(149, 73);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showtailsButton);
            this.Controls.Add(this.showheadsButton);
            this.Controls.Add(this.cointailPictureBox);
            this.Controls.Add(this.coinheadPictureBox);
            this.Name = "Form1";
            this.Text = "Heads or Tails";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cointailPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinheadPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox coinheadPictureBox;
        private System.Windows.Forms.PictureBox cointailPictureBox;
        private System.Windows.Forms.Button showheadsButton;
        private System.Windows.Forms.Button showtailsButton;
        private System.Windows.Forms.Button exitButton;
    }
}

