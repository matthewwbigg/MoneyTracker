namespace MoneyTrackerCSHARP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.txtIdLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.chkDeposit = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnViewData = new System.Windows.Forms.Button();
            this.btnAddTrans = new System.Windows.Forms.Button();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(296, 447);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtIdLabel
            // 
            this.txtIdLabel.AutoSize = true;
            this.txtIdLabel.Location = new System.Drawing.Point(153, 86);
            this.txtIdLabel.Name = "txtIdLabel";
            this.txtIdLabel.Size = new System.Drawing.Size(77, 13);
            this.txtIdLabel.TabIndex = 1;
            this.txtIdLabel.Text = "Transaction ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amount";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(167, 232);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(49, 13);
            this.lblDeposit.TabIndex = 6;
            this.lblDeposit.Text = "Deposit?";
            // 
            // chkDeposit
            // 
            this.chkDeposit.AutoSize = true;
            this.chkDeposit.Location = new System.Drawing.Point(184, 248);
            this.chkDeposit.Name = "chkDeposit";
            this.chkDeposit.Size = new System.Drawing.Size(15, 14);
            this.chkDeposit.TabIndex = 7;
            this.chkDeposit.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(61, 299);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(260, 20);
            this.textBox3.TabIndex = 9;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(167, 283);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category";
            // 
            // btnViewData
            // 
            this.btnViewData.Location = new System.Drawing.Point(12, 447);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(75, 23);
            this.btnViewData.TabIndex = 10;
            this.btnViewData.Text = "View Data";
            this.btnViewData.UseVisualStyleBackColor = true;
            // 
            // btnAddTrans
            // 
            this.btnAddTrans.Location = new System.Drawing.Point(154, 352);
            this.btnAddTrans.Name = "btnAddTrans";
            this.btnAddTrans.Size = new System.Drawing.Size(75, 39);
            this.btnAddTrans.TabIndex = 11;
            this.btnAddTrans.Text = "Add Transaction";
            this.btnAddTrans.UseVisualStyleBackColor = true;
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.Location = new System.Drawing.Point(154, 447);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(75, 23);
            this.btnAnalytics.TabIndex = 12;
            this.btnAnalytics.Text = "Analytics";
            this.btnAnalytics.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(19, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(344, 29);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Enter New Transactions Below";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 482);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAnalytics);
            this.Controls.Add(this.btnAddTrans);
            this.Controls.Add(this.btnViewData);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.chkDeposit);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtIdLabel);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Money Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label txtIdLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.CheckBox chkDeposit;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnViewData;
        private System.Windows.Forms.Button btnAddTrans;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.Label lblTitle;
    }
}

