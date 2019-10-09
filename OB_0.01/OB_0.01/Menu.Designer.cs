namespace OB_0._01
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
            this.btnList = new System.Windows.Forms.Button();
            this.btnNewOB = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(56, 21);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List OB";
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // btnNewOB
            // 
            this.btnNewOB.Location = new System.Drawing.Point(56, 50);
            this.btnNewOB.Name = "btnNewOB";
            this.btnNewOB.Size = new System.Drawing.Size(75, 23);
            this.btnNewOB.TabIndex = 1;
            this.btnNewOB.Text = "New OB";
            this.btnNewOB.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(32, 79);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(118, 23);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Admin Consale";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(56, 134);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 178);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnNewOB);
            this.Controls.Add(this.btnList);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnNewOB;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnLogout;
    }
}