﻿namespace OBDemoProgram
{
    partial class frmOBList
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
            this.lstOBList = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewEntry = new System.Windows.Forms.Button();
            this.cmbFilterBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstOBList
            // 
            this.lstOBList.FormattingEnabled = true;
            this.lstOBList.ItemHeight = 16;
            this.lstOBList.Location = new System.Drawing.Point(33, 117);
            this.lstOBList.Name = "lstOBList";
            this.lstOBList.Size = new System.Drawing.Size(458, 564);
            this.lstOBList.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(390, 698);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 38);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnViewEntry
            // 
            this.btnViewEntry.Location = new System.Drawing.Point(33, 692);
            this.btnViewEntry.Name = "btnViewEntry";
            this.btnViewEntry.Size = new System.Drawing.Size(99, 44);
            this.btnViewEntry.TabIndex = 2;
            this.btnViewEntry.Text = "View Entry";
            this.btnViewEntry.UseVisualStyleBackColor = true;
            this.btnViewEntry.Click += new System.EventHandler(this.btnViewEntry_Click);
            // 
            // cmbFilterBox
            // 
            this.cmbFilterBox.FormattingEnabled = true;
            this.cmbFilterBox.Location = new System.Drawing.Point(131, 73);
            this.cmbFilterBox.Name = "cmbFilterBox";
            this.cmbFilterBox.Size = new System.Drawing.Size(121, 24);
            this.cmbFilterBox.TabIndex = 3;
            this.cmbFilterBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter By";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Occurrence Book Refference List";
            // 
            // frmOBList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 748);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFilterBox);
            this.Controls.Add(this.btnViewEntry);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstOBList);
            this.Name = "frmOBList";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmOBList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOBList;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewEntry;
        private System.Windows.Forms.ComboBox cmbFilterBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}