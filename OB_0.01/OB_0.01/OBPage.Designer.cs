namespace OB_0._01
{
    partial class frmMain
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
            this.lbloccurencepage = new System.Windows.Forms.Label();
            this.txtReturnOB = new System.Windows.Forms.Label();
            this.lblReturnOBnumber = new System.Windows.Forms.Label();
            this.lblOB = new System.Windows.Forms.Label();
            this.txtOB = new System.Windows.Forms.TextBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblShift = new System.Windows.Forms.Label();
            this.cbShift = new System.Windows.Forms.ComboBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.cbSite = new System.Windows.Forms.ComboBox();
            this.lblOfficer = new System.Windows.Forms.Label();
            this.cbOfficer = new System.Windows.Forms.ComboBox();
            this.lblOccurence = new System.Windows.Forms.Label();
            this.cbOccurence = new System.Windows.Forms.ComboBox();
            this.txtOccurence = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbloccurencepage
            // 
            this.lbloccurencepage.AutoSize = true;
            this.lbloccurencepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloccurencepage.Location = new System.Drawing.Point(278, 9);
            this.lbloccurencepage.Name = "lbloccurencepage";
            this.lbloccurencepage.Size = new System.Drawing.Size(200, 31);
            this.lbloccurencepage.TabIndex = 0;
            this.lbloccurencepage.Text = "OCCURENCE";
            // 
            // txtReturnOB
            // 
            this.txtReturnOB.AutoSize = true;
            this.txtReturnOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnOB.Location = new System.Drawing.Point(4, 44);
            this.txtReturnOB.Name = "txtReturnOB";
            this.txtReturnOB.Size = new System.Drawing.Size(68, 20);
            this.txtReturnOB.TabIndex = 1;
            this.txtReturnOB.Text = "Return OB";
            this.txtReturnOB.UseCompatibleTextRendering = true;
            this.txtReturnOB.UseMnemonic = false;
            this.txtReturnOB.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblReturnOBnumber
            // 
            this.lblReturnOBnumber.AutoSize = true;
            this.lblReturnOBnumber.Location = new System.Drawing.Point(78, 46);
            this.lblReturnOBnumber.Name = "lblReturnOBnumber";
            this.lblReturnOBnumber.Size = new System.Drawing.Size(44, 13);
            this.lblReturnOBnumber.TabIndex = 2;
            this.lblReturnOBnumber.Text = "Number";
            // 
            // lblOB
            // 
            this.lblOB.AutoSize = true;
            this.lblOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOB.Location = new System.Drawing.Point(172, 46);
            this.lblOB.Name = "lblOB";
            this.lblOB.Size = new System.Drawing.Size(27, 16);
            this.lblOB.TabIndex = 3;
            this.lblOB.Text = "OB";
            // 
            // txtOB
            // 
            this.txtOB.Location = new System.Drawing.Point(205, 43);
            this.txtOB.Name = "txtOB";
            this.txtOB.Size = new System.Drawing.Size(79, 20);
            this.txtOB.TabIndex = 4;
            this.txtOB.Text = "####";
            this.txtOB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(477, 46);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(97, 16);
            this.lblDateTime.TabIndex = 5;
            this.lblDateTime.Text = "Date and Time";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(581, 43);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(581, 70);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 7;
            this.txtTime.Text = "-";
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShift.Location = new System.Drawing.Point(1, 103);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(33, 16);
            this.lblShift.TabIndex = 8;
            this.lblShift.Text = "Shift";
            // 
            // cbShift
            // 
            this.cbShift.FormattingEnabled = true;
            this.cbShift.Items.AddRange(new object[] {
            "DAYSHIFT",
            "NIGHTSHIFT"});
            this.cbShift.Location = new System.Drawing.Point(80, 103);
            this.cbShift.Name = "cbShift";
            this.cbShift.Size = new System.Drawing.Size(64, 21);
            this.cbShift.TabIndex = 9;
            this.cbShift.Text = "-";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSite.Location = new System.Drawing.Point(172, 103);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(31, 16);
            this.lblSite.TabIndex = 10;
            this.lblSite.Text = "Site";
            // 
            // cbSite
            // 
            this.cbSite.FormattingEnabled = true;
            this.cbSite.Items.AddRange(new object[] {
            "ML",
            "ER1",
            "ER2",
            "HR",
            "CF",
            "PS",
            "PW",
            "LV",
            "D1",
            "TO",
            "NG",
            "RE",
            "PV",
            "CONTROL"});
            this.cbSite.Location = new System.Drawing.Point(209, 103);
            this.cbSite.Name = "cbSite";
            this.cbSite.Size = new System.Drawing.Size(74, 21);
            this.cbSite.TabIndex = 11;
            this.cbSite.Text = "-";
            // 
            // lblOfficer
            // 
            this.lblOfficer.AutoSize = true;
            this.lblOfficer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfficer.Location = new System.Drawing.Point(477, 105);
            this.lblOfficer.Name = "lblOfficer";
            this.lblOfficer.Size = new System.Drawing.Size(46, 16);
            this.lblOfficer.TabIndex = 12;
            this.lblOfficer.Text = "Officer";
            this.lblOfficer.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cbOfficer
            // 
            this.cbOfficer.AutoCompleteCustomSource.AddRange(new string[] {
            "THABO BUBE-NG",
            "PETER SOLOS MAHLANGU-NG",
            "ALFRED KHUMALO-ML",
            "OSCAR MDLULI-ML",
            "BULELANI ARON KUMBALA-ML",
            "SAKHILE NKOSI-RE",
            "SANDISWA MDLULI-PV",
            "FANDY MANAKA-TO"});
            this.cbOfficer.FormattingEnabled = true;
            this.cbOfficer.Items.AddRange(new object[] {
            "THABO BUBE-NG",
            "PETER SOLOS MAHLANGU-NG",
            "ALFRED KHUMALO-ML",
            "FANDY MANAKA-TO",
            "MATTHEW THOMPSON-CONTROL"});
            this.cbOfficer.Location = new System.Drawing.Point(581, 102);
            this.cbOfficer.Name = "cbOfficer";
            this.cbOfficer.Size = new System.Drawing.Size(200, 21);
            this.cbOfficer.TabIndex = 13;
            this.cbOfficer.Text = "-";
            // 
            // lblOccurence
            // 
            this.lblOccurence.AutoSize = true;
            this.lblOccurence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccurence.Location = new System.Drawing.Point(4, 146);
            this.lblOccurence.Name = "lblOccurence";
            this.lblOccurence.Size = new System.Drawing.Size(73, 16);
            this.lblOccurence.TabIndex = 14;
            this.lblOccurence.Text = "Occurence";
            this.lblOccurence.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // cbOccurence
            // 
            this.cbOccurence.FormattingEnabled = true;
            this.cbOccurence.Items.AddRange(new object[] {
            "AIO",
            "ARREST",
            "DUTY ON",
            "FAILED TO START PATROL",
            "FAILED PATROL",
            "NETWORK FAILED ",
            "POWER FAILED",
            "LATE ENTRY"});
            this.cbOccurence.Location = new System.Drawing.Point(83, 141);
            this.cbOccurence.Name = "cbOccurence";
            this.cbOccurence.Size = new System.Drawing.Size(201, 21);
            this.cbOccurence.TabIndex = 15;
            this.cbOccurence.Text = "-";
            // 
            // txtOccurence
            // 
            this.txtOccurence.Location = new System.Drawing.Point(83, 169);
            this.txtOccurence.Multiline = true;
            this.txtOccurence.Name = "txtOccurence";
            this.txtOccurence.Size = new System.Drawing.Size(698, 144);
            this.txtOccurence.TabIndex = 16;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLog.Location = new System.Drawing.Point(706, 403);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 17;
            this.btnLog.Text = "LOG";
            this.btnLog.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Yellow;
            this.btnLogout.Location = new System.Drawing.Point(80, 403);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.txtOccurence);
            this.Controls.Add(this.cbOccurence);
            this.Controls.Add(this.lblOccurence);
            this.Controls.Add(this.cbOfficer);
            this.Controls.Add(this.lblOfficer);
            this.Controls.Add(this.cbSite);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.cbShift);
            this.Controls.Add(this.lblShift);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.txtOB);
            this.Controls.Add(this.lblOB);
            this.Controls.Add(this.lblReturnOBnumber);
            this.Controls.Add(this.txtReturnOB);
            this.Controls.Add(this.lbloccurencepage);
            this.Name = "frmMain";
            this.Text = "OBPage";
            this.Load += new System.EventHandler(this.OBPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbloccurencepage;
        private System.Windows.Forms.Label txtReturnOB;
        private System.Windows.Forms.Label lblReturnOBnumber;
        private System.Windows.Forms.Label lblOB;
        private System.Windows.Forms.TextBox txtOB;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.ComboBox cbShift;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.ComboBox cbSite;
        private System.Windows.Forms.Label lblOfficer;
        private System.Windows.Forms.ComboBox cbOfficer;
        private System.Windows.Forms.Label lblOccurence;
        private System.Windows.Forms.ComboBox cbOccurence;
        private System.Windows.Forms.TextBox txtOccurence;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnLogout;
    }
}

