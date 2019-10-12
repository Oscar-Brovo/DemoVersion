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
            this.btnRemoveOfficer = new System.Windows.Forms.Button();
            this.btnLogOfficer = new System.Windows.Forms.Button();
            this.btnClearOfficer = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lstOfficers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOfficerSurname = new System.Windows.Forms.TextBox();
            this.txtOfficerName = new System.Windows.Forms.TextBox();
            this.txtOfficerPSiRA = new System.Windows.Forms.TextBox();
            this.btnOfficerBack = new System.Windows.Forms.Button();
            this.tpAddEmployee = new System.Windows.Forms.TabPage();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmployeeConPassword = new System.Windows.Forms.TextBox();
            this.txtEmployeePassword = new System.Windows.Forms.TextBox();
            this.txtEmployeeUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmployeeSurname = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.btnEmployeeBack = new System.Windows.Forms.Button();
            this.tpAddSite = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSiteContactNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSiteClientName = new System.Windows.Forms.TextBox();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.txtSiteCallSign = new System.Windows.Forms.TextBox();
            this.btnSiteBack = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtOfficerConNum = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lstSitesList = new System.Windows.Forms.ListBox();
            this.btnSiteClear = new System.Windows.Forms.Button();
            this.btnSiteRemove = new System.Windows.Forms.Button();
            this.btnSiteLog = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
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
            this.tpAddOfficer.Controls.Add(this.label15);
            this.tpAddOfficer.Controls.Add(this.txtOfficerConNum);
            this.tpAddOfficer.Controls.Add(this.btnRemoveOfficer);
            this.tpAddOfficer.Controls.Add(this.btnLogOfficer);
            this.tpAddOfficer.Controls.Add(this.btnClearOfficer);
            this.tpAddOfficer.Controls.Add(this.label14);
            this.tpAddOfficer.Controls.Add(this.lstOfficers);
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
            // btnRemoveOfficer
            // 
            this.btnRemoveOfficer.Location = new System.Drawing.Point(454, 310);
            this.btnRemoveOfficer.Name = "btnRemoveOfficer";
            this.btnRemoveOfficer.Size = new System.Drawing.Size(124, 33);
            this.btnRemoveOfficer.TabIndex = 17;
            this.btnRemoveOfficer.Text = "Remove Officer";
            this.btnRemoveOfficer.UseVisualStyleBackColor = true;
            this.btnRemoveOfficer.Click += new System.EventHandler(this.btnRemoveOfficer_Click);
            // 
            // btnLogOfficer
            // 
            this.btnLogOfficer.Location = new System.Drawing.Point(454, 257);
            this.btnLogOfficer.Name = "btnLogOfficer";
            this.btnLogOfficer.Size = new System.Drawing.Size(124, 32);
            this.btnLogOfficer.TabIndex = 16;
            this.btnLogOfficer.Text = "Add New Officer";
            this.btnLogOfficer.UseVisualStyleBackColor = true;
            this.btnLogOfficer.Click += new System.EventHandler(this.btnLogOfficer_Click);
            // 
            // btnClearOfficer
            // 
            this.btnClearOfficer.Location = new System.Drawing.Point(454, 40);
            this.btnClearOfficer.Name = "btnClearOfficer";
            this.btnClearOfficer.Size = new System.Drawing.Size(306, 29);
            this.btnClearOfficer.TabIndex = 15;
            this.btnClearOfficer.Text = "Clear Fields and Selection";
            this.btnClearOfficer.UseVisualStyleBackColor = true;
            this.btnClearOfficer.Click += new System.EventHandler(this.btnClearOfficer_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "List Of All Officers";
            // 
            // lstOfficers
            // 
            this.lstOfficers.FormattingEnabled = true;
            this.lstOfficers.ItemHeight = 16;
            this.lstOfficers.Location = new System.Drawing.Point(27, 40);
            this.lstOfficers.Name = "lstOfficers";
            this.lstOfficers.Size = new System.Drawing.Size(383, 500);
            this.lstOfficers.TabIndex = 13;
            this.lstOfficers.SelectedIndexChanged += new System.EventHandler(this.lstOfficers_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "PSiRA";
            // 
            // txtOfficerSurname
            // 
            this.txtOfficerSurname.Location = new System.Drawing.Point(570, 165);
            this.txtOfficerSurname.Name = "txtOfficerSurname";
            this.txtOfficerSurname.Size = new System.Drawing.Size(190, 22);
            this.txtOfficerSurname.TabIndex = 9;
            // 
            // txtOfficerName
            // 
            this.txtOfficerName.Location = new System.Drawing.Point(570, 126);
            this.txtOfficerName.Name = "txtOfficerName";
            this.txtOfficerName.Size = new System.Drawing.Size(190, 22);
            this.txtOfficerName.TabIndex = 8;
            // 
            // txtOfficerPSiRA
            // 
            this.txtOfficerPSiRA.Location = new System.Drawing.Point(570, 87);
            this.txtOfficerPSiRA.Name = "txtOfficerPSiRA";
            this.txtOfficerPSiRA.Size = new System.Drawing.Size(190, 22);
            this.txtOfficerPSiRA.TabIndex = 7;
            // 
            // btnOfficerBack
            // 
            this.btnOfficerBack.Location = new System.Drawing.Point(836, 516);
            this.btnOfficerBack.Name = "btnOfficerBack";
            this.btnOfficerBack.Size = new System.Drawing.Size(109, 45);
            this.btnOfficerBack.TabIndex = 0;
            this.btnOfficerBack.Text = "Back";
            this.btnOfficerBack.UseVisualStyleBackColor = true;
            this.btnOfficerBack.Click += new System.EventHandler(this.btnOfficerBack_Click);
            // 
            // tpAddEmployee
            // 
            this.tpAddEmployee.Controls.Add(this.button5);
            this.tpAddEmployee.Controls.Add(this.button6);
            this.tpAddEmployee.Controls.Add(this.button4);
            this.tpAddEmployee.Controls.Add(this.label17);
            this.tpAddEmployee.Controls.Add(this.listBox2);
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
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(437, 343);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(69, 21);
            this.cbAdmin.TabIndex = 19;
            this.cbAdmin.Text = "Admin";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(433, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Confirm Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(433, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(433, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Username";
            // 
            // txtEmployeeConPassword
            // 
            this.txtEmployeeConPassword.Location = new System.Drawing.Point(564, 304);
            this.txtEmployeeConPassword.Name = "txtEmployeeConPassword";
            this.txtEmployeeConPassword.Size = new System.Drawing.Size(178, 22);
            this.txtEmployeeConPassword.TabIndex = 15;
            // 
            // txtEmployeePassword
            // 
            this.txtEmployeePassword.Location = new System.Drawing.Point(564, 257);
            this.txtEmployeePassword.Name = "txtEmployeePassword";
            this.txtEmployeePassword.Size = new System.Drawing.Size(178, 22);
            this.txtEmployeePassword.TabIndex = 14;
            // 
            // txtEmployeeUsername
            // 
            this.txtEmployeeUsername.Location = new System.Drawing.Point(564, 209);
            this.txtEmployeeUsername.Name = "txtEmployeeUsername";
            this.txtEmployeeUsername.Size = new System.Drawing.Size(178, 22);
            this.txtEmployeeUsername.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Surename";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID";
            // 
            // txtEmployeeSurname
            // 
            this.txtEmployeeSurname.Location = new System.Drawing.Point(564, 160);
            this.txtEmployeeSurname.Name = "txtEmployeeSurname";
            this.txtEmployeeSurname.Size = new System.Drawing.Size(178, 22);
            this.txtEmployeeSurname.TabIndex = 9;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(564, 118);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(178, 22);
            this.txtEmployeeName.TabIndex = 8;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(564, 76);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(178, 22);
            this.txtEmployeeID.TabIndex = 7;
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
            this.tpAddSite.Controls.Add(this.btnSiteRemove);
            this.tpAddSite.Controls.Add(this.btnSiteLog);
            this.tpAddSite.Controls.Add(this.btnSiteClear);
            this.tpAddSite.Controls.Add(this.label16);
            this.tpAddSite.Controls.Add(this.lstSitesList);
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(450, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Contact Number";
            // 
            // txtSiteContactNumber
            // 
            this.txtSiteContactNumber.Location = new System.Drawing.Point(569, 205);
            this.txtSiteContactNumber.Name = "txtSiteContactNumber";
            this.txtSiteContactNumber.Size = new System.Drawing.Size(190, 22);
            this.txtSiteContactNumber.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Client Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(450, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Site Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Call Sign";
            // 
            // txtSiteClientName
            // 
            this.txtSiteClientName.Location = new System.Drawing.Point(569, 165);
            this.txtSiteClientName.Name = "txtSiteClientName";
            this.txtSiteClientName.Size = new System.Drawing.Size(190, 22);
            this.txtSiteClientName.TabIndex = 9;
            // 
            // txtSiteName
            // 
            this.txtSiteName.Location = new System.Drawing.Point(569, 123);
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(190, 22);
            this.txtSiteName.TabIndex = 8;
            // 
            // txtSiteCallSign
            // 
            this.txtSiteCallSign.Location = new System.Drawing.Point(569, 85);
            this.txtSiteCallSign.Name = "txtSiteCallSign";
            this.txtSiteCallSign.Size = new System.Drawing.Size(190, 22);
            this.txtSiteCallSign.TabIndex = 7;
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(451, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "Contact Number";
            // 
            // txtOfficerConNum
            // 
            this.txtOfficerConNum.Location = new System.Drawing.Point(570, 206);
            this.txtOfficerConNum.Name = "txtOfficerConNum";
            this.txtOfficerConNum.Size = new System.Drawing.Size(190, 22);
            this.txtOfficerConNum.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 20);
            this.label16.TabIndex = 16;
            this.label16.Text = "List Of All Sites";
            // 
            // lstSitesList
            // 
            this.lstSitesList.FormattingEnabled = true;
            this.lstSitesList.ItemHeight = 16;
            this.lstSitesList.Location = new System.Drawing.Point(11, 35);
            this.lstSitesList.Name = "lstSitesList";
            this.lstSitesList.Size = new System.Drawing.Size(383, 500);
            this.lstSitesList.TabIndex = 15;
            // 
            // btnSiteClear
            // 
            this.btnSiteClear.Location = new System.Drawing.Point(453, 35);
            this.btnSiteClear.Name = "btnSiteClear";
            this.btnSiteClear.Size = new System.Drawing.Size(306, 29);
            this.btnSiteClear.TabIndex = 17;
            this.btnSiteClear.Text = "Clear Fields and Selection";
            this.btnSiteClear.UseVisualStyleBackColor = true;
            this.btnSiteClear.Click += new System.EventHandler(this.btnSiteClear_Click);
            // 
            // btnSiteRemove
            // 
            this.btnSiteRemove.Location = new System.Drawing.Point(453, 310);
            this.btnSiteRemove.Name = "btnSiteRemove";
            this.btnSiteRemove.Size = new System.Drawing.Size(124, 33);
            this.btnSiteRemove.TabIndex = 19;
            this.btnSiteRemove.Text = "Remove Site";
            this.btnSiteRemove.UseVisualStyleBackColor = true;
            // 
            // btnSiteLog
            // 
            this.btnSiteLog.Location = new System.Drawing.Point(453, 257);
            this.btnSiteLog.Name = "btnSiteLog";
            this.btnSiteLog.Size = new System.Drawing.Size(124, 32);
            this.btnSiteLog.TabIndex = 18;
            this.btnSiteLog.Text = "Add New Site";
            this.btnSiteLog.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(15, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(169, 20);
            this.label17.TabIndex = 21;
            this.label17.Text = "List Of All Officers";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(18, 32);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(383, 500);
            this.listBox2.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(436, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(306, 29);
            this.button4.TabIndex = 22;
            this.button4.Text = "Clear Fields and Selection";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(436, 434);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 33);
            this.button5.TabIndex = 24;
            this.button5.Text = "Remove Officer";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(436, 381);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 32);
            this.button6.TabIndex = 23;
            this.button6.Text = "Add New Officer";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // frmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 598);
            this.Controls.Add(this.tcAdminPanel);
            this.Name = "frmAdminPanel";
            this.Text = "frmAdminPanel";
            this.Load += new System.EventHandler(this.frmAdminPanel_Load);
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
        private System.Windows.Forms.ListBox lstOfficers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOfficerSurname;
        private System.Windows.Forms.TextBox txtOfficerName;
        private System.Windows.Forms.TextBox txtOfficerPSiRA;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRemoveOfficer;
        private System.Windows.Forms.Button btnLogOfficer;
        private System.Windows.Forms.Button btnClearOfficer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtOfficerConNum;
        private System.Windows.Forms.Button btnSiteClear;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox lstSitesList;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnSiteRemove;
        private System.Windows.Forms.Button btnSiteLog;
    }
}