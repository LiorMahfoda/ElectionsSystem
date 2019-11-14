namespace ElectionsSystem.Presntation
{
    partial class VoteParty
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
            this.flp_voteParty = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_voteParty = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flp_voteParty
            // 
            this.flp_voteParty.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_voteParty.Location = new System.Drawing.Point(37, 84);
            this.flp_voteParty.Name = "flp_voteParty";
            this.flp_voteParty.Size = new System.Drawing.Size(135, 100);
            this.flp_voteParty.TabIndex = 0;
            // 
            // btn_voteParty
            // 
            this.btn_voteParty.Location = new System.Drawing.Point(148, 227);
            this.btn_voteParty.Name = "btn_voteParty";
            this.btn_voteParty.Size = new System.Drawing.Size(75, 23);
            this.btn_voteParty.TabIndex = 1;
            this.btn_voteParty.Text = "Next";
            this.btn_voteParty.UseVisualStyleBackColor = true;
            this.btn_voteParty.Click += new System.EventHandler(this.btn_voteParty_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose party:";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 15);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(54, 23);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // VoteParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(235, 262);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_voteParty);
            this.Controls.Add(this.flp_voteParty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "VoteParty";
            this.Text = "vote party";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VoteParty_FormClosing);
            this.Load += new System.EventHandler(this.VoteParty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_voteParty;
        private System.Windows.Forms.Button btn_voteParty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
    }
}