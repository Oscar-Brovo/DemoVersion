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
            this.txtPSiRA = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
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
            this.tpAddOfficer.Controls.Add(this.txtSurname);
            this.tpAddOfficer.Controls.Add(this.txtName);
            this.tpAddOfficer.Controls.Add(this.txtPSiRA);
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
            this.tpAddEmployee.Controls.Add(this.label4);
            this.tpAddEmployee.Controls.Add(this.label5);
            this.tpAddEmployee.Controls.Add(this.label6);
            this.tpAddEmployee.Controls.Add(this.textBox4);
            this.tpAddEmployee.Controls.Add(this.textBox5);
            this.tpAddEmployee.Controls.Add(this.textBox6);
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
            this.tpAddSite.Controls.Add(this.label7);
            this.tpAddSite.Controls.Add(this.label8);
            this.tpAddSite.Controls.Add(this.label9);
            this.tpAddSite.Controls.Add(this.textBox7);
            this.tpAddSite.Controls.Add(this.textBox8);
            this.tpAddSite.Controls.Add(this.textBox9);
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
            // txtPSiRA
            // 
            this.txtPSiRA.Location = new System.Drawing.Point(175, 51);
            this.txtPSiRA.Name = "txtPSiRA";
            this.txtPSiRA.Size = new System.Drawing.Size(100, 22);
            this.txtPSiRA.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(175, 118);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(175, 189);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 22);
            this.txtSurname.TabIndex = 3;
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
            this.label2.Location = new System.Drawing.Point(56, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(177, 187);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(177, 116);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(177, 49);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "label9";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(174, 188);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 9;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(174, 117);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 8;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(174, 50);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 7;
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
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPSiRA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
    }
}