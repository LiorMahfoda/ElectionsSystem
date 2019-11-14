namespace ElectionsSystem.Presntation
{
    partial class AddParty
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
            this.clb_partyMembers = new System.Windows.Forms.CheckedListBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tbx_platform = new System.Windows.Forms.RichTextBox();
            this.tbx_partyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_PartyLeader = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // clb_partyMembers
            // 
            this.clb_partyMembers.FormattingEnabled = true;
            this.clb_partyMembers.Location = new System.Drawing.Point(278, 102);
            this.clb_partyMembers.Name = "clb_partyMembers";
            this.clb_partyMembers.Size = new System.Drawing.Size(75, 94);
            this.clb_partyMembers.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(13, 224);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_add
            // 
            this.btn_add.AutoSize = true;
            this.btn_add.Location = new System.Drawing.Point(278, 227);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tbx_platform
            // 
            this.tbx_platform.Location = new System.Drawing.Point(94, 99);
            this.tbx_platform.Name = "tbx_platform";
            this.tbx_platform.Size = new System.Drawing.Size(66, 96);
            this.tbx_platform.TabIndex = 3;
            this.tbx_platform.Text = "";
            // 
            // tbx_partyName
            // 
            this.tbx_partyName.Location = new System.Drawing.Point(94, 47);
            this.tbx_partyName.Name = "tbx_partyName";
            this.tbx_partyName.Size = new System.Drawing.Size(66, 20);
            this.tbx_partyName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "PartyName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Platform:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Party leader:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "partyMember:";
            // 
            // cbx_PartyLeader
            // 
            this.cbx_PartyLeader.FormattingEnabled = true;
            this.cbx_PartyLeader.Location = new System.Drawing.Point(278, 47);
            this.cbx_PartyLeader.Name = "cbx_PartyLeader";
            this.cbx_PartyLeader.Size = new System.Drawing.Size(75, 21);
            this.cbx_PartyLeader.TabIndex = 10;
            // 
            // AddParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(365, 262);
            this.Controls.Add(this.cbx_PartyLeader);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_partyName);
            this.Controls.Add(this.tbx_platform);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.clb_partyMembers);
            this.Name = "AddParty";
            this.Text = "AddParty";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddParty_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_partyMembers;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.RichTextBox tbx_platform;
        private System.Windows.Forms.TextBox tbx_partyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_PartyLeader;
    }
}