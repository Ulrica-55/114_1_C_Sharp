namespace Chap2_hw1
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
            this.jokerPictureBox5 = new System.Windows.Forms.PictureBox();
            this.aofspadesPictureBox = new System.Windows.Forms.PictureBox();
            this.kofspadesPictureBox = new System.Windows.Forms.PictureBox();
            this.twoofclubsPictureBox = new System.Windows.Forms.PictureBox();
            this.eightofdiamondsPictureBox = new System.Windows.Forms.PictureBox();
            this.cardsLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jokerPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aofspadesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kofspadesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoofclubsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eightofdiamondsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(238, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click a Card to See Its Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // jokerPictureBox5
            // 
            this.jokerPictureBox5.Image = global::Chap2_hw1.Properties.Resources.Joker_Black;
            this.jokerPictureBox5.Location = new System.Drawing.Point(682, 154);
            this.jokerPictureBox5.Name = "jokerPictureBox5";
            this.jokerPictureBox5.Size = new System.Drawing.Size(100, 170);
            this.jokerPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jokerPictureBox5.TabIndex = 5;
            this.jokerPictureBox5.TabStop = false;
            this.jokerPictureBox5.Click += new System.EventHandler(this.jokerPictureBox5_Click);
            // 
            // aofspadesPictureBox
            // 
            this.aofspadesPictureBox.Image = global::Chap2_hw1.Properties.Resources.Ace_Spades;
            this.aofspadesPictureBox.Location = new System.Drawing.Point(538, 154);
            this.aofspadesPictureBox.Name = "aofspadesPictureBox";
            this.aofspadesPictureBox.Size = new System.Drawing.Size(100, 170);
            this.aofspadesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aofspadesPictureBox.TabIndex = 4;
            this.aofspadesPictureBox.TabStop = false;
            this.aofspadesPictureBox.Click += new System.EventHandler(this.aofspadesPictureBox_Click);
            // 
            // kofspadesPictureBox
            // 
            this.kofspadesPictureBox.Image = global::Chap2_hw1.Properties.Resources.King_Spades;
            this.kofspadesPictureBox.Location = new System.Drawing.Point(401, 154);
            this.kofspadesPictureBox.Name = "kofspadesPictureBox";
            this.kofspadesPictureBox.Size = new System.Drawing.Size(100, 170);
            this.kofspadesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kofspadesPictureBox.TabIndex = 3;
            this.kofspadesPictureBox.TabStop = false;
            this.kofspadesPictureBox.Click += new System.EventHandler(this.kofspadesPictureBox_Click);
            // 
            // twoofclubsPictureBox
            // 
            this.twoofclubsPictureBox.Image = global::Chap2_hw1.Properties.Resources._2_Clubs;
            this.twoofclubsPictureBox.Location = new System.Drawing.Point(262, 154);
            this.twoofclubsPictureBox.Name = "twoofclubsPictureBox";
            this.twoofclubsPictureBox.Size = new System.Drawing.Size(100, 170);
            this.twoofclubsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.twoofclubsPictureBox.TabIndex = 2;
            this.twoofclubsPictureBox.TabStop = false;
            this.twoofclubsPictureBox.Click += new System.EventHandler(this.twoofclubsPictureBox_Click);
            // 
            // eightofdiamondsPictureBox
            // 
            this.eightofdiamondsPictureBox.Image = global::Chap2_hw1.Properties.Resources._8_Diamonds;
            this.eightofdiamondsPictureBox.Location = new System.Drawing.Point(126, 154);
            this.eightofdiamondsPictureBox.Name = "eightofdiamondsPictureBox";
            this.eightofdiamondsPictureBox.Size = new System.Drawing.Size(100, 170);
            this.eightofdiamondsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eightofdiamondsPictureBox.TabIndex = 1;
            this.eightofdiamondsPictureBox.TabStop = false;
            this.eightofdiamondsPictureBox.Click += new System.EventHandler(this.eightofdiamondsPictureBox_Click);
            // 
            // cardsLabel
            // 
            this.cardsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardsLabel.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cardsLabel.Location = new System.Drawing.Point(223, 361);
            this.cardsLabel.Name = "cardsLabel";
            this.cardsLabel.Size = new System.Drawing.Size(461, 59);
            this.cardsLabel.TabIndex = 6;
            this.cardsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cardsLabel.Click += new System.EventHandler(this.cardsLabel_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ExitButton.Location = new System.Drawing.Point(376, 452);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(140, 48);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 519);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.cardsLabel);
            this.Controls.Add(this.jokerPictureBox5);
            this.Controls.Add(this.aofspadesPictureBox);
            this.Controls.Add(this.kofspadesPictureBox);
            this.Controls.Add(this.twoofclubsPictureBox);
            this.Controls.Add(this.eightofdiamondsPictureBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.jokerPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aofspadesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kofspadesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoofclubsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eightofdiamondsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox eightofdiamondsPictureBox;
        private System.Windows.Forms.PictureBox twoofclubsPictureBox;
        private System.Windows.Forms.PictureBox kofspadesPictureBox;
        private System.Windows.Forms.PictureBox aofspadesPictureBox;
        private System.Windows.Forms.PictureBox jokerPictureBox5;
        private System.Windows.Forms.Label cardsLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}

