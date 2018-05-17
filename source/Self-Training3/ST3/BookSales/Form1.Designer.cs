namespace BookSales
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIsStudent = new System.Windows.Forms.CheckBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCharged = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotalRevenue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalIsStudent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalCustomer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Sales Program";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalMoney);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkIsStudent);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(40, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill:";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalMoney.ForeColor = System.Drawing.Color.Black;
            this.lblTotalMoney.Location = new System.Drawing.Point(225, 165);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(379, 29);
            this.lblTotalMoney.TabIndex = 3;
            this.lblTotalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total money:";
            // 
            // chkIsStudent
            // 
            this.chkIsStudent.AutoSize = true;
            this.chkIsStudent.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIsStudent.ForeColor = System.Drawing.Color.Black;
            this.chkIsStudent.Location = new System.Drawing.Point(23, 120);
            this.chkIsStudent.Name = "chkIsStudent";
            this.chkIsStudent.Size = new System.Drawing.Size(187, 24);
            this.chkIsStudent.TabIndex = 2;
            this.chkIsStudent.Text = "Customer is student:";
            this.chkIsStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkIsStudent.UseVisualStyleBackColor = true;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(225, 78);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(379, 26);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(225, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(379, 26);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of books:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnStatistic);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.btnCharged);
            this.groupBox2.Location = new System.Drawing.Point(40, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 107);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(483, 37);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 39);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnStatistic
            // 
            this.btnStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStatistic.ForeColor = System.Drawing.Color.Black;
            this.btnStatistic.Location = new System.Drawing.Point(351, 37);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(88, 39);
            this.btnStatistic.TabIndex = 0;
            this.btnStatistic.Text = "Statistic";
            this.btnStatistic.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(232, 37);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 39);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnCharged
            // 
            this.btnCharged.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCharged.ForeColor = System.Drawing.Color.Black;
            this.btnCharged.Location = new System.Drawing.Point(93, 37);
            this.btnCharged.Name = "btnCharged";
            this.btnCharged.Size = new System.Drawing.Size(95, 39);
            this.btnCharged.TabIndex = 0;
            this.btnCharged.Text = "Charged";
            this.btnCharged.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotalRevenue);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtTotalIsStudent);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtTotalCustomer);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(40, 490);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(648, 186);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistical:";
            // 
            // txtTotalRevenue
            // 
            this.txtTotalRevenue.Location = new System.Drawing.Point(232, 147);
            this.txtTotalRevenue.Name = "txtTotalRevenue";
            this.txtTotalRevenue.ReadOnly = true;
            this.txtTotalRevenue.Size = new System.Drawing.Size(372, 26);
            this.txtTotalRevenue.TabIndex = 1;
            this.txtTotalRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(23, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Revenue:";
            // 
            // txtTotalIsStudent
            // 
            this.txtTotalIsStudent.Location = new System.Drawing.Point(232, 95);
            this.txtTotalIsStudent.Name = "txtTotalIsStudent";
            this.txtTotalIsStudent.ReadOnly = true;
            this.txtTotalIsStudent.Size = new System.Drawing.Size(372, 26);
            this.txtTotalIsStudent.TabIndex = 1;
            this.txtTotalIsStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(23, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total customer is student:";
            // 
            // txtTotalCustomer
            // 
            this.txtTotalCustomer.Location = new System.Drawing.Point(232, 43);
            this.txtTotalCustomer.Name = "txtTotalCustomer";
            this.txtTotalCustomer.ReadOnly = true;
            this.txtTotalCustomer.Size = new System.Drawing.Size(372, 26);
            this.txtTotalCustomer.TabIndex = 1;
            this.txtTotalCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total customers:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 697);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Sales";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkIsStudent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCharged;
        private System.Windows.Forms.TextBox txtTotalRevenue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalIsStudent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalCustomer;
        private System.Windows.Forms.Label label6;
    }
}

