namespace ATM_Project
{
    partial class AdminForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rblPayInterest = new System.Windows.Forms.RadioButton();
            this.rblMoneyRefill = new System.Windows.Forms.RadioButton();
            this.rblATMService = new System.Windows.Forms.RadioButton();
            this.rblAccountReport = new System.Windows.Forms.RadioButton();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmunt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblInterest = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.lblOutOfService = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAccountsReport = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblAccountsReport);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.lblOutOfService);
            this.groupBox1.Controls.Add(this.txtInterest);
            this.groupBox1.Controls.Add(this.lblInterest);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtAmunt);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Location = new System.Drawing.Point(92, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supervisor ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rblAccountReport);
            this.groupBox2.Controls.Add(this.rblATMService);
            this.groupBox2.Controls.Add(this.rblMoneyRefill);
            this.groupBox2.Controls.Add(this.rblPayInterest);
            this.groupBox2.Location = new System.Drawing.Point(213, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // rblPayInterest
            // 
            this.rblPayInterest.AutoSize = true;
            this.rblPayInterest.Location = new System.Drawing.Point(3, 16);
            this.rblPayInterest.Name = "rblPayInterest";
            this.rblPayInterest.Size = new System.Drawing.Size(81, 17);
            this.rblPayInterest.TabIndex = 0;
            this.rblPayInterest.TabStop = true;
            this.rblPayInterest.Text = "Pay Interest";
            this.rblPayInterest.UseVisualStyleBackColor = true;
            this.rblPayInterest.CheckedChanged += new System.EventHandler(this.rblPayInterest_CheckedChanged);
            // 
            // rblMoneyRefill
            // 
            this.rblMoneyRefill.AutoSize = true;
            this.rblMoneyRefill.Location = new System.Drawing.Point(3, 39);
            this.rblMoneyRefill.Name = "rblMoneyRefill";
            this.rblMoneyRefill.Size = new System.Drawing.Size(127, 17);
            this.rblMoneyRefill.TabIndex = 1;
            this.rblMoneyRefill.TabStop = true;
            this.rblMoneyRefill.Text = "Refill the ATM Money";
            this.rblMoneyRefill.UseVisualStyleBackColor = true;
            this.rblMoneyRefill.CheckedChanged += new System.EventHandler(this.rblMoneyRefill_CheckedChanged);
            // 
            // rblATMService
            // 
            this.rblATMService.AutoSize = true;
            this.rblATMService.Location = new System.Drawing.Point(3, 62);
            this.rblATMService.Name = "rblATMService";
            this.rblATMService.Size = new System.Drawing.Size(121, 17);
            this.rblATMService.TabIndex = 2;
            this.rblATMService.TabStop = true;
            this.rblATMService.Text = "ATM Out Of Service";
            this.rblATMService.UseVisualStyleBackColor = true;
            this.rblATMService.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rblAccountReport
            // 
            this.rblAccountReport.AutoSize = true;
            this.rblAccountReport.Location = new System.Drawing.Point(3, 85);
            this.rblAccountReport.Name = "rblAccountReport";
            this.rblAccountReport.Size = new System.Drawing.Size(129, 17);
            this.rblAccountReport.TabIndex = 3;
            this.rblAccountReport.TabStop = true;
            this.rblAccountReport.Text = "Print Accounts Report";
            this.rblAccountReport.UseVisualStyleBackColor = true;
            this.rblAccountReport.CheckedChanged += new System.EventHandler(this.rblAccountReport_CheckedChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(6, 30);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(98, 18);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Enter Amount";
            this.lblAmount.Visible = false;
            // 
            // txtAmunt
            // 
            this.txtAmunt.Location = new System.Drawing.Point(9, 48);
            this.txtAmunt.Name = "txtAmunt";
            this.txtAmunt.Size = new System.Drawing.Size(100, 20);
            this.txtAmunt.TabIndex = 1;
            this.txtAmunt.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(6, 76);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(128, 13);
            this.lblInterest.TabIndex = 3;
            this.lblInterest.Text = "Enter Interest Percentage";
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(9, 92);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(100, 20);
            this.txtInterest.TabIndex = 4;
            // 
            // lblOutOfService
            // 
            this.lblOutOfService.AutoSize = true;
            this.lblOutOfService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutOfService.Location = new System.Drawing.Point(12, 128);
            this.lblOutOfService.Name = "lblOutOfService";
            this.lblOutOfService.Size = new System.Drawing.Size(158, 18);
            this.lblOutOfService.TabIndex = 5;
            this.lblOutOfService.Text = "ATM Out Of Service";
            this.lblOutOfService.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(258, 158);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Visible = false;
            // 
            // lblAccountsReport
            // 
            this.lblAccountsReport.AutoSize = true;
            this.lblAccountsReport.Location = new System.Drawing.Point(12, 153);
            this.lblAccountsReport.Name = "lblAccountsReport";
            this.lblAccountsReport.Size = new System.Drawing.Size(87, 13);
            this.lblAccountsReport.TabIndex = 7;
            this.lblAccountsReport.Text = "Accounts Report";
            this.lblAccountsReport.Visible = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 363);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rblAccountReport;
        private System.Windows.Forms.RadioButton rblATMService;
        private System.Windows.Forms.RadioButton rblMoneyRefill;
        private System.Windows.Forms.RadioButton rblPayInterest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAmunt;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblOutOfService;
        private System.Windows.Forms.Label lblAccountsReport;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}