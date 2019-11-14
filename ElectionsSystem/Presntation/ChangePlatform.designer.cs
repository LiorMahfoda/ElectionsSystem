namespace ElectionsSystem.Presntation
{
    partial class ChangePlatform
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
            this.rtbx_plat = new System.Windows.Forms.RichTextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbx_plat
            // 
            this.rtbx_plat.Location = new System.Drawing.Point(139, 34);
            this.rtbx_plat.Name = "rtbx_plat";
            this.rtbx_plat.Size = new System.Drawing.Size(100, 96);
            this.rtbx_plat.TabIndex = 0;
            this.rtbx_plat.Text = "";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(36, 218);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(174, 218);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(75, 23);
            this.btn_Change.TabIndex = 2;
            this.btn_Change.Text = "Change";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter platform:";
            // 
            // ChangePlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.rtbx_plat);
            this.Name = "ChangePlatform";
            this.Text = "ChangePlatform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePlatform_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbx_plat;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Label label1;
    }
}