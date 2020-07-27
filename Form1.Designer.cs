namespace Assignment1
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.carPriceGb = new System.Windows.Forms.GroupBox();
            this.carPriceTb = new System.Windows.Forms.TextBox();
            this.rateInterestGb = new System.Windows.Forms.GroupBox();
            this.rateInterestTb = new System.Windows.Forms.TextBox();
            this.loanPeriodGb = new System.Windows.Forms.GroupBox();
            this.loanPeriodTb = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.mainGb = new System.Windows.Forms.GroupBox();
            this.mainLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.exitLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.carPriceGb.SuspendLayout();
            this.rateInterestGb.SuspendLayout();
            this.loanPeriodGb.SuspendLayout();
            this.mainGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(8, 16);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(449, 41);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Fernando Car Loan Financing";
            // 
            // carPriceGb
            // 
            this.carPriceGb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.carPriceGb.Controls.Add(this.carPriceTb);
            this.carPriceGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carPriceGb.Location = new System.Drawing.Point(121, 92);
            this.carPriceGb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carPriceGb.Name = "carPriceGb";
            this.carPriceGb.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carPriceGb.Size = new System.Drawing.Size(258, 73);
            this.carPriceGb.TabIndex = 1;
            this.carPriceGb.TabStop = false;
            this.carPriceGb.Text = "Car Price (Decimal)";
            // 
            // carPriceTb
            // 
            this.carPriceTb.Location = new System.Drawing.Point(28, 31);
            this.carPriceTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carPriceTb.Name = "carPriceTb";
            this.carPriceTb.Size = new System.Drawing.Size(192, 23);
            this.carPriceTb.TabIndex = 0;
            // 
            // rateInterestGb
            // 
            this.rateInterestGb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rateInterestGb.Controls.Add(this.rateInterestTb);
            this.rateInterestGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateInterestGb.Location = new System.Drawing.Point(420, 92);
            this.rateInterestGb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rateInterestGb.Name = "rateInterestGb";
            this.rateInterestGb.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rateInterestGb.Size = new System.Drawing.Size(271, 73);
            this.rateInterestGb.TabIndex = 2;
            this.rateInterestGb.TabStop = false;
            this.rateInterestGb.Text = "Ann. Rate of Interest (% decimal)";
            // 
            // rateInterestTb
            // 
            this.rateInterestTb.Location = new System.Drawing.Point(28, 31);
            this.rateInterestTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rateInterestTb.Name = "rateInterestTb";
            this.rateInterestTb.Size = new System.Drawing.Size(192, 23);
            this.rateInterestTb.TabIndex = 0;
            // 
            // loanPeriodGb
            // 
            this.loanPeriodGb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.loanPeriodGb.Controls.Add(this.loanPeriodTb);
            this.loanPeriodGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanPeriodGb.Location = new System.Drawing.Point(267, 181);
            this.loanPeriodGb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loanPeriodGb.Name = "loanPeriodGb";
            this.loanPeriodGb.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loanPeriodGb.Size = new System.Drawing.Size(271, 73);
            this.loanPeriodGb.TabIndex = 3;
            this.loanPeriodGb.TabStop = false;
            this.loanPeriodGb.Text = "Loan Period >= 2 yrs (integer)";
            // 
            // loanPeriodTb
            // 
            this.loanPeriodTb.Location = new System.Drawing.Point(28, 31);
            this.loanPeriodTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loanPeriodTb.Name = "loanPeriodTb";
            this.loanPeriodTb.Size = new System.Drawing.Size(192, 23);
            this.loanPeriodTb.TabIndex = 0;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Aqua;
            this.outputLabel.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(283, 290);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(223, 30);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(121, 290);
            this.calculateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(116, 30);
            this.calculateBtn.TabIndex = 5;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(574, 290);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(116, 30);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // mainGb
            // 
            this.mainGb.BackColor = System.Drawing.Color.Yellow;
            this.mainGb.Controls.Add(this.mainLbl);
            this.mainGb.Location = new System.Drawing.Point(121, 10);
            this.mainGb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainGb.Name = "mainGb";
            this.mainGb.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainGb.Size = new System.Drawing.Size(570, 49);
            this.mainGb.TabIndex = 8;
            this.mainGb.TabStop = false;
            // 
            // mainLbl
            // 
            this.mainLbl.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLbl.Location = new System.Drawing.Point(36, 11);
            this.mainLbl.Name = "mainLbl";
            this.mainLbl.Size = new System.Drawing.Size(476, 28);
            this.mainLbl.TabIndex = 0;
            this.mainLbl.Text = "Fernando Car Loan Financing";
            this.mainLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(749, 10);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(53, 310);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // exitLabel
            // 
            this.exitLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.Location = new System.Drawing.Point(761, 102);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.exitLabel.Size = new System.Drawing.Size(30, 26);
            this.exitLabel.TabIndex = 9;
            this.exitLabel.Text = "E";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(761, 138);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(30, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "x";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(761, 177);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(30, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "i";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(761, 210);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(30, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "t";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 375);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.mainGb);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.loanPeriodGb);
            this.Controls.Add(this.rateInterestGb);
            this.Controls.Add(this.carPriceGb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Car Loan Financing";
            this.carPriceGb.ResumeLayout(false);
            this.carPriceGb.PerformLayout();
            this.rateInterestGb.ResumeLayout(false);
            this.rateInterestGb.PerformLayout();
            this.loanPeriodGb.ResumeLayout(false);
            this.loanPeriodGb.PerformLayout();
            this.mainGb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.GroupBox carPriceGb;
        private System.Windows.Forms.TextBox carPriceTb;
        private System.Windows.Forms.GroupBox rateInterestGb;
        private System.Windows.Forms.TextBox rateInterestTb;
        private System.Windows.Forms.GroupBox loanPeriodGb;
        private System.Windows.Forms.TextBox loanPeriodTb;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.GroupBox mainGb;
        private System.Windows.Forms.Label mainLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

