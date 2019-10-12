namespace OBDemoProgram
{
    partial class frmMenu
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
            this.btnNewOB = new System.Windows.Forms.Button();
            this.btnOBList = new System.Windows.Forms.Button();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewOB
            // 
            this.btnNewOB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewOB.Location = new System.Drawing.Point(0, 0);
            this.btnNewOB.Name = "btnNewOB";
            this.btnNewOB.Size = new System.Drawing.Size(309, 80);
            this.btnNewOB.TabIndex = 0;
            this.btnNewOB.Text = "New  OB";
            this.btnNewOB.UseVisualStyleBackColor = true;
            // 
            // btnOBList
            // 
            this.btnOBList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOBList.Location = new System.Drawing.Point(0, 80);
            this.btnOBList.Name = "btnOBList";
            this.btnOBList.Size = new System.Drawing.Size(309, 80);
            this.btnOBList.TabIndex = 1;
            this.btnOBList.Text = "OB List";
            this.btnOBList.UseVisualStyleBackColor = true;
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminPanel.Location = new System.Drawing.Point(0, 160);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(309, 80);
            this.btnAdminPanel.TabIndex = 2;
            this.btnAdminPanel.Text = "Admin Panel";
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.Location = new System.Drawing.Point(0, 240);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(309, 80);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 325);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnAdminPanel);
            this.Controls.Add(this.btnOBList);
            this.Controls.Add(this.btnNewOB);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewOB;
        private System.Windows.Forms.Button btnOBList;
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.Button btnLogOut;
    }
}