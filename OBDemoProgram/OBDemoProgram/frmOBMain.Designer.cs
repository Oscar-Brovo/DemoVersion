namespace OBDemoProgram
{
    partial class frmOBMain
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
            this.txtOccurenceNote = new System.Windows.Forms.TextBox();
            this.cmbOccurence = new System.Windows.Forms.ComboBox();
            this.lblOccurence = new System.Windows.Forms.Label();
            this.cmbOfficer = new System.Windows.Forms.ComboBox();
            this.lblOfficer = new System.Windows.Forms.Label();
            this.cmbSite = new System.Windows.Forms.ComboBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.lblShift = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.dtmDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.txtOBNumber = new System.Windows.Forms.TextBox();
            this.lblOB = new System.Windows.Forms.Label();
            this.lblReturnOBnumber = new System.Windows.Forms.Label();
            this.txtReturnOB = new System.Windows.Forms.Label();
            this.lbloccurencepage = new System.Windows.Forms.Label();
            this.btnLogEntry = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOccurenceNote
            // 
            this.txtOccurenceNote.Location = new System.Drawing.Point(124, 214);
            this.txtOccurenceNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtOccurenceNote.Multiline = true;
            this.txtOccurenceNote.Name = "txtOccurenceNote";
            this.txtOccurenceNote.Size = new System.Drawing.Size(929, 176);
            this.txtOccurenceNote.TabIndex = 35;
            // 
            // cmbOccurence
            // 
            this.cmbOccurence.FormattingEnabled = true;
            this.cmbOccurence.Items.AddRange(new object[] {
            "AIO",
            "ARREST",
            "DUTY ON",
            "FAILED TO START PATROL",
            "FAILED PATROL",
            "NETWORK FAILED ",
            "POWER FAILED",
            "LATE ENTRY"});
            this.cmbOccurence.Location = new System.Drawing.Point(124, 180);
            this.cmbOccurence.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOccurence.Name = "cmbOccurence";
            this.cmbOccurence.Size = new System.Drawing.Size(267, 24);
            this.cmbOccurence.TabIndex = 34;
            this.cmbOccurence.Text = "-";
            // 
            // lblOccurence
            // 
            this.lblOccurence.AutoSize = true;
            this.lblOccurence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccurence.Location = new System.Drawing.Point(19, 180);
            this.lblOccurence.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOccurence.Name = "lblOccurence";
            this.lblOccurence.Size = new System.Drawing.Size(91, 20);
            this.lblOccurence.TabIndex = 33;
            this.lblOccurence.Text = "Occurence";
            // 
            // cmbOfficer
            // 
            this.cmbOfficer.AutoCompleteCustomSource.AddRange(new string[] {
            "THABO BUBE-NG",
            "PETER SOLOS MAHLANGU-NG",
            "ALFRED KHUMALO-ML",
            "OSCAR MDLULI-ML",
            "BULELANI ARON KUMBALA-ML",
            "SAKHILE NKOSI-RE",
            "SANDISWA MDLULI-PV",
            "FANDY MANAKA-TO"});
            this.cmbOfficer.FormattingEnabled = true;
            this.cmbOfficer.Items.AddRange(new object[] {
            "THABO BUBE-NG",
            "PETER SOLOS MAHLANGU-NG",
            "ALFRED KHUMALO-ML",
            "FANDY MANAKA-TO",
            "MATTHEW THOMPSON-CONTROL"});
            this.cmbOfficer.Location = new System.Drawing.Point(788, 132);
            this.cmbOfficer.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOfficer.Name = "cmbOfficer";
            this.cmbOfficer.Size = new System.Drawing.Size(265, 24);
            this.cmbOfficer.TabIndex = 32;
            this.cmbOfficer.Text = "-";
            // 
            // lblOfficer
            // 
            this.lblOfficer.AutoSize = true;
            this.lblOfficer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfficer.Location = new System.Drawing.Point(649, 135);
            this.lblOfficer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOfficer.Name = "lblOfficer";
            this.lblOfficer.Size = new System.Drawing.Size(60, 20);
            this.lblOfficer.TabIndex = 31;
            this.lblOfficer.Text = "Officer";
            // 
            // cmbSite
            // 
            this.cmbSite.FormattingEnabled = true;
            this.cmbSite.Items.AddRange(new object[] {
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
            this.cmbSite.Location = new System.Drawing.Point(292, 133);
            this.cmbSite.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSite.Name = "cmbSite";
            this.cmbSite.Size = new System.Drawing.Size(97, 24);
            this.cmbSite.TabIndex = 30;
            this.cmbSite.Text = "-";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSite.Location = new System.Drawing.Point(242, 133);
            this.lblSite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(38, 20);
            this.lblSite.TabIndex = 29;
            this.lblSite.Text = "Site";
            // 
            // cmbShift
            // 
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Items.AddRange(new object[] {
            "DAYSHIFT",
            "NIGHTSHIFT"});
            this.cmbShift.Location = new System.Drawing.Point(120, 133);
            this.cmbShift.Margin = new System.Windows.Forms.Padding(4);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(84, 24);
            this.cmbShift.TabIndex = 28;
            this.cmbShift.Text = "-";
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShift.Location = new System.Drawing.Point(-51, 126);
            this.lblShift.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(43, 20);
            this.lblShift.TabIndex = 27;
            this.lblShift.Text = "Shift";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(788, 92);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(132, 22);
            this.txtTime.TabIndex = 26;
            this.txtTime.Text = "-";
            // 
            // dtmDate
            // 
            this.dtmDate.Location = new System.Drawing.Point(788, 59);
            this.dtmDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtmDate.Name = "dtmDate";
            this.dtmDate.Size = new System.Drawing.Size(265, 22);
            this.dtmDate.TabIndex = 25;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(649, 63);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(119, 20);
            this.lblDateTime.TabIndex = 24;
            this.lblDateTime.Text = "Date and Time";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOBNumber
            // 
            this.txtOBNumber.Location = new System.Drawing.Point(286, 59);
            this.txtOBNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtOBNumber.Name = "txtOBNumber";
            this.txtOBNumber.Size = new System.Drawing.Size(104, 22);
            this.txtOBNumber.TabIndex = 23;
            this.txtOBNumber.Text = "####";
            // 
            // lblOB
            // 
            this.lblOB.AutoSize = true;
            this.lblOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOB.Location = new System.Drawing.Point(246, 59);
            this.lblOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOB.Name = "lblOB";
            this.lblOB.Size = new System.Drawing.Size(34, 20);
            this.lblOB.TabIndex = 22;
            this.lblOB.Text = "OB";
            // 
            // lblReturnOBnumber
            // 
            this.lblReturnOBnumber.AutoSize = true;
            this.lblReturnOBnumber.Location = new System.Drawing.Point(117, 63);
            this.lblReturnOBnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReturnOBnumber.Name = "lblReturnOBnumber";
            this.lblReturnOBnumber.Size = new System.Drawing.Size(58, 17);
            this.lblReturnOBnumber.TabIndex = 21;
            this.lblReturnOBnumber.Text = "Number";
            // 
            // txtReturnOB
            // 
            this.txtReturnOB.AutoSize = true;
            this.txtReturnOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnOB.Location = new System.Drawing.Point(22, 61);
            this.txtReturnOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtReturnOB.Name = "txtReturnOB";
            this.txtReturnOB.Size = new System.Drawing.Size(85, 24);
            this.txtReturnOB.TabIndex = 20;
            this.txtReturnOB.Text = "Return OB";
            this.txtReturnOB.UseCompatibleTextRendering = true;
            this.txtReturnOB.UseMnemonic = false;
            // 
            // lbloccurencepage
            // 
            this.lbloccurencepage.AutoSize = true;
            this.lbloccurencepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloccurencepage.Location = new System.Drawing.Point(384, 17);
            this.lbloccurencepage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbloccurencepage.Name = "lbloccurencepage";
            this.lbloccurencepage.Size = new System.Drawing.Size(360, 39);
            this.lbloccurencepage.TabIndex = 19;
            this.lbloccurencepage.Text = "OCCURENCE BOOK";
            // 
            // btnLogEntry
            // 
            this.btnLogEntry.Location = new System.Drawing.Point(124, 422);
            this.btnLogEntry.Name = "btnLogEntry";
            this.btnLogEntry.Size = new System.Drawing.Size(152, 53);
            this.btnLogEntry.TabIndex = 36;
            this.btnLogEntry.Text = "Log Entry";
            this.btnLogEntry.UseVisualStyleBackColor = true;
            this.btnLogEntry.Click += new System.EventHandler(this.btnLogEntry_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(966, 444);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 31);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(19, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Shift";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(18, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 40);
            this.label2.TabIndex = 39;
            this.label2.Text = "Occurrence\r\n    Notes";
            // 
            // frmOBMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogEntry);
            this.Controls.Add(this.txtOccurenceNote);
            this.Controls.Add(this.cmbOccurence);
            this.Controls.Add(this.lblOccurence);
            this.Controls.Add(this.cmbOfficer);
            this.Controls.Add(this.lblOfficer);
            this.Controls.Add(this.cmbSite);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.cmbShift);
            this.Controls.Add(this.lblShift);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.dtmDate);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.txtOBNumber);
            this.Controls.Add(this.lblOB);
            this.Controls.Add(this.lblReturnOBnumber);
            this.Controls.Add(this.txtReturnOB);
            this.Controls.Add(this.lbloccurencepage);
            this.Name = "frmOBMain";
            this.Text = "frmOBMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOccurenceNote;
        private System.Windows.Forms.ComboBox cmbOccurence;
        private System.Windows.Forms.Label lblOccurence;
        private System.Windows.Forms.ComboBox cmbOfficer;
        private System.Windows.Forms.Label lblOfficer;
        private System.Windows.Forms.ComboBox cmbSite;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.ComboBox cmbShift;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.DateTimePicker dtmDate;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.TextBox txtOBNumber;
        private System.Windows.Forms.Label lblOB;
        private System.Windows.Forms.Label lblReturnOBnumber;
        private System.Windows.Forms.Label txtReturnOB;
        private System.Windows.Forms.Label lbloccurencepage;
        private System.Windows.Forms.Button btnLogEntry;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}