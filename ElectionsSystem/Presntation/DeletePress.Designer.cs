﻿namespace ElectionsSystem.Presntation
{
    partial class DeletePress
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.cbx_pressMembers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(137, 104);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose press member:";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(15, 104);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(54, 23);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // cbx_pressMembers
            // 
            this.cbx_pressMembers.FormattingEnabled = true;
            this.cbx_pressMembers.Location = new System.Drawing.Point(137, 21);
            this.cbx_pressMembers.Name = "cbx_pressMembers";
            this.cbx_pressMembers.Size = new System.Drawing.Size(75, 21);
            this.cbx_pressMembers.TabIndex = 11;
            this.cbx_pressMembers.SelectedIndexChanged += new System.EventHandler(this.cbx_pressMembers_SelectedIndexChanged);
            // 
            // DeletePress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(224, 202);
            this.Controls.Add(this.cbx_pressMembers);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DeletePress";
            this.Text = "DeletePress";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeletePress_FormClosing);
            this.Load += new System.EventHandler(this.DeletePress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox cbx_pressMembers;
    }
}