namespace ElectionsSystem.Presntation
{
    partial class PartyRegistration
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
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_platform = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clb_members = new System.Windows.Forms.CheckedListBox();
            this.btn_addParty = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(99, 28);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(100, 20);
            this.tbx_name.TabIndex = 0;
            this.tbx_name.TextChanged += new System.EventHandler(this.tbx_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Party name:";
            // 
            // tbx_platform
            // 
            this.tbx_platform.Location = new System.Drawing.Point(99, 67);
            this.tbx_platform.Name = "tbx_platform";
            this.tbx_platform.Size = new System.Drawing.Size(100, 137);
            this.tbx_platform.TabIndex = 2;
            this.tbx_platform.Text = "";
            this.tbx_platform.TextChanged += new System.EventHandler(this.tbx_platform_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Platform:";
            // 
            // clb_members
            // 
            this.clb_members.FormattingEnabled = true;
            this.clb_members.Location = new System.Drawing.Point(321, 67);
            this.clb_members.Name = "clb_members";
            this.clb_members.Size = new System.Drawing.Size(100, 139);
            this.clb_members.TabIndex = 8;
            // 
            // btn_addParty
            // 
            this.btn_addParty.Location = new System.Drawing.Point(346, 266);
            this.btn_addParty.Name = "btn_addParty";
            this.btn_addParty.Size = new System.Drawing.Size(75, 23);
            this.btn_addParty.TabIndex = 8;
            this.btn_addParty.Text = "Add party";
            this.btn_addParty.UseVisualStyleBackColor = true;
            this.btn_addParty.Click += new System.EventHandler(this.btn_addParty_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(6, 256);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(54, 23);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Party member:";
            // 
            // PartyRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(495, 291);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_addParty);
            this.Controls.Add(this.clb_members);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_platform);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PartyRegistration";
            this.Text = "Party registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PartyRegistration_FormClosing);
            this.Load += new System.EventHandler(this.PartyRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tbx_platform;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clb_members;
        private System.Windows.Forms.Button btn_addParty;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label3;
    }
}