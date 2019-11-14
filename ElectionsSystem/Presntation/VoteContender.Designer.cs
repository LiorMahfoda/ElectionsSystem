namespace ElectionsSystem
{
    partial class VoteContender
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
            this.label1 = new System.Windows.Forms.Label();
            this.flp_contenders = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_voteContender = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose contender";
            // 
            // flp_contenders
            // 
            this.flp_contenders.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_contenders.Location = new System.Drawing.Point(28, 80);
            this.flp_contenders.Name = "flp_contenders";
            this.flp_contenders.Size = new System.Drawing.Size(94, 100);
            this.flp_contenders.TabIndex = 1;
            // 
            // btn_voteContender
            // 
            this.btn_voteContender.Location = new System.Drawing.Point(122, 203);
            this.btn_voteContender.Name = "btn_voteContender";
            this.btn_voteContender.Size = new System.Drawing.Size(75, 23);
            this.btn_voteContender.TabIndex = 2;
            this.btn_voteContender.Text = "Sumbit vote";
            this.btn_voteContender.UseVisualStyleBackColor = true;
            this.btn_voteContender.Click += new System.EventHandler(this.btn_voteContender_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(54, 23);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // VoteContender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(231, 262);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_voteContender);
            this.Controls.Add(this.flp_contenders);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "VoteContender";
            this.Text = "Vote contender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VoteContender_FormClosing);
            this.Load += new System.EventHandler(this.VoteContender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flp_contenders;
        private System.Windows.Forms.Button btn_voteContender;
        private System.Windows.Forms.Button btn_back;
    }
}