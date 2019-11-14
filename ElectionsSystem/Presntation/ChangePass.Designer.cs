namespace ElectionsSystem.Presntation
{
    partial class ChangePass
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_newPassword = new System.Windows.Forms.TextBox();
            this.tbx_RenewPassword = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_ChangePass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Re-Enter new password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "New password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbx_newPassword
            // 
            this.tbx_newPassword.Location = new System.Drawing.Point(129, 36);
            this.tbx_newPassword.Name = "tbx_newPassword";
            this.tbx_newPassword.Size = new System.Drawing.Size(100, 20);
            this.tbx_newPassword.TabIndex = 4;
            // 
            // tbx_RenewPassword
            // 
            this.tbx_RenewPassword.Location = new System.Drawing.Point(130, 77);
            this.tbx_RenewPassword.Name = "tbx_RenewPassword";
            this.tbx_RenewPassword.Size = new System.Drawing.Size(100, 20);
            this.tbx_RenewPassword.TabIndex = 5;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(33, 214);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_ChangePass
            // 
            this.btn_ChangePass.Location = new System.Drawing.Point(154, 214);
            this.btn_ChangePass.Name = "btn_ChangePass";
            this.btn_ChangePass.Size = new System.Drawing.Size(75, 23);
            this.btn_ChangePass.TabIndex = 7;
            this.btn_ChangePass.Text = "Change";
            this.btn_ChangePass.UseVisualStyleBackColor = true;
            this.btn_ChangePass.Click += new System.EventHandler(this.btn_ChangePass_Click);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_ChangePass);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.tbx_RenewPassword);
            this.Controls.Add(this.tbx_newPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ChangePass";
            this.Text = "ChangePass";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePass_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_newPassword;
        private System.Windows.Forms.TextBox tbx_RenewPassword;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_ChangePass;
    }
}