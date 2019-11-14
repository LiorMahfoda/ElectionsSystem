namespace ElectionsSystem
{
    partial class LogIn
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
            this.tbx_id = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_signIn = new System.Windows.Forms.Button();
            this.lbl_regirser = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tbx_id
            // 
            this.tbx_id.Location = new System.Drawing.Point(153, 22);
            this.tbx_id.Name = "tbx_id";
            this.tbx_id.Size = new System.Drawing.Size(124, 20);
            this.tbx_id.TabIndex = 0;
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(153, 61);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '*';
            this.tbx_password.Size = new System.Drawing.Size(124, 20);
            this.tbx_password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // btn_signIn
            // 
            this.btn_signIn.Location = new System.Drawing.Point(202, 111);
            this.btn_signIn.Name = "btn_signIn";
            this.btn_signIn.Size = new System.Drawing.Size(75, 23);
            this.btn_signIn.TabIndex = 4;
            this.btn_signIn.Text = "Sign in";
            this.btn_signIn.UseVisualStyleBackColor = true;
            this.btn_signIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // lbl_regirser
            // 
            this.lbl_regirser.AutoSize = true;
            this.lbl_regirser.Location = new System.Drawing.Point(288, 94);
            this.lbl_regirser.Name = "lbl_regirser";
            this.lbl_regirser.Size = new System.Drawing.Size(46, 13);
            this.lbl_regirser.TabIndex = 5;
            this.lbl_regirser.TabStop = true;
            this.lbl_regirser.Text = "Register";
            this.lbl_regirser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_regirser_LinkClicked);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources._411472130;
            this.ClientSize = new System.Drawing.Size(368, 224);
            this.Controls.Add(this.lbl_regirser);
            this.Controls.Add(this.btn_signIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LogIn";
            this.Text = "Log In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogIn_FormClosing);
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.BackgroundImageLayoutChanged += new System.EventHandler(this.btn_LogIn_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.TextBox tbx_id;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_signIn;
        private System.Windows.Forms.LinkLabel lbl_regirser;
    }
}