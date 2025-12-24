namespace Q2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxServices;
        private System.Windows.Forms.CheckBox chkOilChange;
        private System.Windows.Forms.CheckBox chkTire;

        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.TextBox txtCar;

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;

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
            this.groupBoxServices = new System.Windows.Forms.GroupBox();
            this.chkTire = new System.Windows.Forms.CheckBox();
            this.chkOilChange = new System.Windows.Forms.CheckBox();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelCar = new System.Windows.Forms.Label();
            this.txtCar = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBoxServices.SuspendLayout();
            this.groupBoxCustomer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxServices
            // 
            this.groupBoxServices.Controls.Add(this.chkTire);
            this.groupBoxServices.Controls.Add(this.chkOilChange);
            this.groupBoxServices.Location = new System.Drawing.Point(24, 24);
            this.groupBoxServices.Name = "groupBoxServices";
            this.groupBoxServices.Size = new System.Drawing.Size(240, 97);
            this.groupBoxServices.TabIndex = 0;
            this.groupBoxServices.TabStop = false;
            this.groupBoxServices.Text = "機油和潤滑";
            this.groupBoxServices.Enter += new System.EventHandler(this.groupBoxServices_Enter);
            // 
            // chkTire
            // 
            this.chkTire.AutoSize = true;
            this.chkTire.Location = new System.Drawing.Point(16, 60);
            this.chkTire.Name = "chkTire";
            this.chkTire.Size = new System.Drawing.Size(172, 22);
            this.chkTire.TabIndex = 1;
            this.chkTire.Text = "潤滑保養(NT$540)";
            this.chkTire.UseVisualStyleBackColor = true;
            // 
            // chkOilChange
            // 
            this.chkOilChange.AutoSize = true;
            this.chkOilChange.Location = new System.Drawing.Point(16, 28);
            this.chkOilChange.Name = "chkOilChange";
            this.chkOilChange.Size = new System.Drawing.Size(172, 22);
            this.chkOilChange.TabIndex = 0;
            this.chkOilChange.Text = "更換機油(NT$780)";
            this.chkOilChange.UseVisualStyleBackColor = true;
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.textBox2);
            this.groupBoxCustomer.Controls.Add(this.textBox1);
            this.groupBoxCustomer.Controls.Add(this.label2);
            this.groupBoxCustomer.Controls.Add(this.label1);
            this.groupBoxCustomer.Controls.Add(this.labelName);
            this.groupBoxCustomer.Controls.Add(this.txtName);
            this.groupBoxCustomer.Controls.Add(this.labelCar);
            this.groupBoxCustomer.Controls.Add(this.txtCar);
            this.groupBoxCustomer.Location = new System.Drawing.Point(40, 304);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(636, 206);
            this.groupBoxCustomer.TabIndex = 1;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "費用摘要";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(98, 18);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "服務與工資";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 29);
            this.txtName.TabIndex = 1;
            // 
            // labelCar
            // 
            this.labelCar.AutoSize = true;
            this.labelCar.Location = new System.Drawing.Point(16, 72);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(44, 18);
            this.labelCar.TabIndex = 2;
            this.labelCar.Text = "零件";
            // 
            // txtCar
            // 
            this.txtCar.Location = new System.Drawing.Point(120, 68);
            this.txtCar.Name = "txtCar";
            this.txtCar.Size = new System.Drawing.Size(152, 29);
            this.txtCar.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(59, 539);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 36);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "計算總價";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(285, 539);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 36);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "離開";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Location = new System.Drawing.Point(24, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 140);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "機油和潤滑";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 95);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(155, 22);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "煞車維修 (1200)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(16, 67);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(147, 22);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "輪胎更換 (800)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(16, 39);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(155, 22);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "機油更換 (1000)";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "稅金(零件)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "總費用";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 29);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 29);
            this.textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 596);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxServices);
            this.Controls.Add(this.groupBoxCustomer);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Name = "Form1";
            this.Text = "汽車維修服務";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxServices.ResumeLayout(false);
            this.groupBoxServices.PerformLayout();
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

