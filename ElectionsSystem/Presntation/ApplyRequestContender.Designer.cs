namespace ElectionsSystem.Presntation
{
    partial class ApplyRequestContender
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
            this.tbx_platform = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_platform
            // 
            this.tbx_platform.Location = new System.Drawing.Point(129, 33);
            this.tbx_platform.Name = "tbx_platform";
            this.tbx_platform.Size = new System.Drawing.Size(100, 96);
            this.tbx_platform.TabIndex = 5;
            this.tbx_platform.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Insert platform:";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(129, 156);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(98, 23);
            this.btn_send.TabIndex = 7;
            this.btn_send.Text = "Sumbit Request";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(33, 156);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(54, 23);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ApplyRequestContender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(252, 213);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_platform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ApplyRequestContender";
            this.Text = "Apply Request Contender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContenderRegistration_FormClosing);
            this.Load += new System.EventHandler(this.ContenderRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbx_platform;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_back;
    }
}