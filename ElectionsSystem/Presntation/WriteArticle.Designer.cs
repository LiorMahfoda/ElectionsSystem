namespace ElectionsSystem.Presntation
{
    partial class WriteArticle
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
            this.rtbx_article = new System.Windows.Forms.RichTextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.tbx_topic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Article:";
            // 
            // rtbx_article
            // 
            this.rtbx_article.Location = new System.Drawing.Point(115, 81);
            this.rtbx_article.Name = "rtbx_article";
            this.rtbx_article.Size = new System.Drawing.Size(100, 96);
            this.rtbx_article.TabIndex = 1;
            this.rtbx_article.Text = "";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(40, 219);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(140, 218);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // tbx_topic
            // 
            this.tbx_topic.Location = new System.Drawing.Point(115, 31);
            this.tbx_topic.Name = "tbx_topic";
            this.tbx_topic.Size = new System.Drawing.Size(100, 20);
            this.tbx_topic.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Topic";
            // 
            // WriteArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(270, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_topic);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.rtbx_article);
            this.Controls.Add(this.label1);
            this.Name = "WriteArticle";
            this.Text = "Write Article";
            this.Load += new System.EventHandler(this.WriteArticle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbx_article;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox tbx_topic;
        private System.Windows.Forms.Label label2;
    }
}