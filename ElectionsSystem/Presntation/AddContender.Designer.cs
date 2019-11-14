namespace ElectionsSystem.Presntation
{
    partial class AddContender
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_platform = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_citizens = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(22, 198);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(54, 23);
            this.btn_back.TabIndex = 17;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(140, 198);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(98, 23);
            this.btn_send.TabIndex = 16;
            this.btn_send.Text = "Add contender";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Your platform:";
            // 
            // tbx_platform
            // 
            this.tbx_platform.Location = new System.Drawing.Point(138, 64);
            this.tbx_platform.Name = "tbx_platform";
            this.tbx_platform.Size = new System.Drawing.Size(100, 96);
            this.tbx_platform.TabIndex = 14;
            this.tbx_platform.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Choose citizen:";
            // 
            // cbx_citizens
            // 
            this.cbx_citizens.FormattingEnabled = true;
            this.cbx_citizens.Location = new System.Drawing.Point(138, 14);
            this.cbx_citizens.Name = "cbx_citizens";
            this.cbx_citizens.Size = new System.Drawing.Size(100, 21);
            this.cbx_citizens.TabIndex = 19;
            this.cbx_citizens.SelectedIndexChanged += new System.EventHandler(this.cbx_id_SelectedIndexChanged);
            // 
            // AddContender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(269, 259);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_citizens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_platform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddContender";
            this.Text = "AddContender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddContender_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbx_platform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_citizens;
    }
}