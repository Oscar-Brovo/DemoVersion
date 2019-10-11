namespace OBDemoProgram
{
    partial class frmAdminPanel
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
            this.tcAdminPanel = new System.Windows.Forms.TabControl();
            this.tpAddOfficer = new System.Windows.Forms.TabPage();
            this.btnOfficerBack = new System.Windows.Forms.Button();
            this.tpAddEmployee = new System.Windows.Forms.TabPage();
            this.btnEmployeeBack = new System.Windows.Forms.Button();
            this.tpAddSite = new System.Windows.Forms.TabPage();
            this.btnSiteBack = new System.Windows.Forms.Button();
            this.txtOfficerPSiRA = new System.Windows.Forms.TextBox();
            this.txtOfficerName = new System.Windows.Forms.TextBox();
            this.txtOfficerSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmployeeSurname = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSiteClientName = new System.Windows.Forms.TextBox();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.txtSiteCallSign = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmployeeConPassword = new System.Windows.Forms.TextBox();
            this.txtEmployeePassword = new System.Windows.Forms.TextBox();
            this.txtEmployeeUsername = new System.Windows.Forms.TextBox();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSiteContactNumber = new System.Windows.Forms.TextBox();
            this.tcAdminPanel.SuspendLayout();
            this.tpAddOfficer.SuspendLayout();
            this.tpAddEmployee.SuspendLayout();
            this.tpAddSite.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAdminPanel
            // 
            this.tcAdminPanel.Controls.Add(this.tpAddOfficer);
            this.tcAdminPanel.Controls.Add(this.tpAddEmployee);
            this.tcAdminPanel.Controls.Add(this.tpAddSite);
            this.tcAdminPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAdminPanel.Location = new System.Drawing.Point(0, 0);
            this.tcAdminPanel.Name = "tcAdminPanel";
            this.tcAdminPanel.SelectedIndex = 0;
            this.tcAdminPanel.Size = new System.Drawing.Size(961, 598);
            this.tcAdminPanel.TabIndex = 0;
            // 
            // tpAddOfficer
            // 
            this.tpAddOfficer.Controls.Add(this.label3);
            this.tpAddOfficer.Controls.Add(this.label2);
            this.tpAddOfficer.Controls.Add(this.label1);
            this.tpAddOfficer.Controls.Add(this.txtOfficerSurname);
            this.tpAddOfficer.Controls.Add(this.txtOfficerName);
            this.tpAddOfficer.Controls.Add(this.txtOfficerPSiRA);
            this.tpAddOfficer.Controls.Add(this.btnOfficerBack);
            this.tpAddOfficer.Location = new System.Drawing.Point(4, 25);
            this.tpAddOfficer.Name = "tpAddOfficer";
            this.tpAddOfficer.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddOfficer.Size = new System.Drawing.Size(953, 569);
            this.tpAddOfficer.TabIndex = 0;
            this.tpAddOfficer.Text = "Add Officer";
            this.tpAddOfficer.UseVisualStyleBackColor = true;
            // 
            // btnOfficerBack
            // 
            this.btnOfficerBack.Location = new System.Drawing.Point(836, 516);
            this.btnOfficerBack.Name = "btnOfficerBack";
            this.btnOfficerBack.Size = new System.Drawing.Size(109, 45);
            this.btnOfficerBack.TabIndex = 0;
            this.btnOfficerBack.Text = "Back";
            this.btnOfficerBack.UseVisualStyleBackColor = true;
            // 
            // tpAddEmployee
            // 
            this.tpAddEmployee.Controls.Add(this.cbAdmin);
            this.tpAddEmployee.Controls.Add(this.label10);
            this.tpAddEmployee.Controls.Add(this.label11);
            this.tpAddEmployee.Controls.Add(this.label12);
            this.tpAddEmployee.Controls.Add(this.txtEmployeeConPassword);
            this.tpAddEmployee.Controls.Add(this.txtEmployeePassword);
            this.tpAddEmployee.Controls.Add(this.txtEmployeeUsername);
            this.tpAddEmployee.Controls.Add(this.label4);
            this.tpAddEmployee.Controls.Add(this.label5);
            this.tpAddEmployee.Controls.Add(this.label6);
            this.tpAddEmployee.Controls.Add(this.txtEmployeeSurname);
            this.tpAddEmployee.Controls.Add(this.txtEmployeeName);
            this.tpAddEmployee.Controls.Add(this.txtEmployeeID);
            this.tpAddEmployee.Controls.Add(this.btnEmployeeBack);
            this.tpAddEmployee.Location = new System.Drawing.Point(4, 25);
            this.tpAddEmployee.Name = "tpAddEmployee";
            this.tpAddEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddEmployee.Size = new System.Drawing.Size(953, 569);
            this.tpAddEmployee.TabIndex = 1;
            this.tpAddEmployee.Text = "Add Employee";
            this.tpAddEmployee.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeBack
            // 
            this.btnEmployeeBack.Location = new System.Drawing.Point(836, 516);
            this.btnEmployeeBack.Name = "btnEmployeeBack";
            this.btnEmployeeBack.Size = new System.Drawing.Size(109, 45);
            this.btnEmployeeBack.TabIndex = 1;
            this.btnEmployeeBack.Text = "Back";
            this.btnEmployeeBack.UseVisualStyleBackColor = true;
            // 
            // tpAddSite
            // 
            this.tpAddSite.Controls.Add(this.label13);
            this.tpAddSite.Controls.Add(this.txtSiteContactNumber);
            this.tpAddSite.Controls.Add(this.label7);
            this.tpAddSite.Controls.Add(this.label8);
            this.tpAddSite.Controls.Add(this.label9);
            this.tpAddSite.Controls.Add(this.txtSiteClientName);
            this.tpAddSite.Controls.Add(this.txtSiteName);
            this.tpAddSite.Controls.Add(this.txtSiteCallSign);
            this.tpAddSite.Controls.Add(this.btnSiteBack);
            this.tpAddSite.Location = new System.Drawing.Point(4, 25);
            this.tpAddSite.Name = "tpAddSite";
            this.tpAddSite.Size = new System.Drawing.Size(953, 569);
            this.tpAddSite.TabIndex = 2;
            this.tpAddSite.Text = "Add Site";
            this.tpAddSite.UseVisualStyleBackColor = true;
            // 
            // btnSiteBack
            // 
            this.btnSiteBack.Location = new System.Drawing.Point(836, 516);
            this.btnSiteBack.Name = "btnSiteBack";
            this.btnSiteBack.Size = new System.Drawing.Size(109, 45);
            this.btnSiteBack.TabIndex = 2;
            this.btnSiteBack.Text = "Back";
            this.btnSiteBack.UseVisualStyleBackColor = true;
            // 
            // txtOfficerPSiRA
            // 
            this.txtOfficerPSiRA.Location = new System.Drawing.Point(175, 51);
            this.txtOfficerPSiRA.Name = "txtOfficerPSiRA";
            this.txtOfficerPSiRA.Size = new System.Drawing.Size(100, 22);
            this.txtOfficerPSiRA.TabIndex = 1;
            // 
            // txtOfficerName
            // 
            this.txtOfficerName.Location = new System.Drawing.Point(175, 90);
            this.txtOfficerName.Name = "txtOfficerName";
            this.txtOfficerName.Size = new System.Drawing.Size(100, 22);
            this.txtOfficerName.TabIndex = 2;
            // 
            // txtOfficerSurname
            // 
            this.txtOfficerSurname.Location = new System.Drawing.Point(175, 129);
            this.txtOfficerSurname.Name = "txtOfficerSurname";
            this.txtOfficerSurname.Size = new System.Drawing.Size(100, 22);
            this.txtOfficerSurname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "PSiRA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Surename";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID";
            // 
            // txtEmployeeSurname
            // 
            this.txtEmployeeSurname.Location = new System.Drawing.Point(177, 133);
            this.txtEmployeeSurname.Name = "txtEmployeeSurname";
            this.txtEmployeeSurname.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeSurname.TabIndex = 9;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(177, 91);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeName.TabIndex = 8;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(177, 49);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeID.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Client Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Site Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Call Sign";
            // 
            // txtSiteClientName
            // 
            this.txtSiteClientName.Location = new System.Drawing.Point(174, 130);
            this.txtSiteClientName.Name = "txtSiteClientName";
            this.txtSiteClientName.Size = new System.Drawing.Size(100, 22);
            this.txtSiteClientName.TabIndex = 9;
            // 
            // txtSiteName
            // 
            this.txtSiteName.Location = new System.Drawing.Point(174, 88);
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(100, 22);
            this.txtSiteName.TabIndex = 8;
            // 
            // txtSiteCallSign
            // 
            this.txtSiteCallSign.Location = new System.Drawing.Point(174, 50);
            this.txtSiteCallSign.Name = "txtSiteCallSign";
            this.txtSiteCallSign.Size = new System.Drawing.Size(100, 22);
            this.txtSiteCallSign.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Confirm Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Username";
            // 
            // txtEmployeeConPassword
            // 
            this.txtEmployeeConPassword.Location = new System.Drawing.Point(177, 277);
            this.txtEmployeeConPassword.Name = "txtEmployeeConPassword";
            this.txtEmployeeConPassword.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeConPassword.TabIndex = 15;
            // 
            // txtEmployeePassword
            // 
            this.txtEmployeePassword.Location = new System.Drawing.Point(177, 230);
            this.txtEmployeePassword.Name = "txtEmployeePassword";
            this.txtEmployeePassword.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeePassword.TabIndex = 14;
            // 
            // txtEmployeeUsername
            // 
            this.txtEmployeeUsername.Location = new System.Drawing.Point(177, 182);
            this.txtEmployeeUsername.Name = "txtEmployeeUsername";
            this.txtEmployeeUsername.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeUsername.TabIndex = 13;
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(138, 329);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(69, 21);
            this.cbAdmin.TabIndex = 19;
            this.cbAdmin.Text = "Admin";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Contact Number";
            // 
            // txtSiteContactNumber
            // 
            this.txtSiteContactNumber.Location = new System.Drawing.Point(174, 170);
            this.txtSiteContactNumber.Name = "txtSiteContactNumber";
            this.txtSiteContactNumber.Size = new System.Drawing.Size(100, 22);
            this.txtSiteContactNumber.TabIndex = 13;
            // 
            // frmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 598);
            this.Controls.Add(this.tcAdminPanel);
            this.Name = "frmAdminPanel";
            this.Text = "frmAdminPanel";
            this.tcAdminPanel.ResumeLayout(false);
            this.tpAddOfficer.ResumeLayout(false);
            this.tpAddOfficer.PerformLayout();
            this.tpAddEmployee.ResumeLayout(false);
            this.tpAddEmployee.PerformLayout();
            this.tpAddSite.ResumeLayout(false);
            this.tpAddSite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdminPanel;
        private System.Windows.Forms.TabPage tpAddOfficer;
        private System.Windows.Forms.Button btnOfficerBack;
        private System.Windows.Forms.TabPage tpAddEmployee;
        private System.Windows.Forms.Button btnEmployeeBack;
        private System.Windows.Forms.TabPage tpAddSite;
        private System.Windows.Forms.Button btnSiteBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOfficerSurname;
        private System.Windows.Forms.TextBox txtOfficerName;
        private System.Windows.Forms.TextBox txtOfficerPSiRA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmployeeSurname;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSiteClientName;
        private System.Windows.Forms.TextBox txtSiteName;
        private System.Windows.Forms.TextBox txtSiteCallSign;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmployeeConPassword;
        private System.Windows.Forms.TextBox txtEmployeePassword;
        private System.Windows.Forms.TextBox txtEmployeeUsername;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSiteContactNumber;
    }
}