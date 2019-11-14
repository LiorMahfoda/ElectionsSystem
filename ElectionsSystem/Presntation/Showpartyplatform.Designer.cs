namespace ElectionsSystem.Presntation
{
    partial class Showpartyplatform
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
            this.cbx_party = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 212);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(54, 23);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // cbx_party
            // 
            this.cbx_party.FormattingEnabled = true;
            this.cbx_party.Location = new System.Drawing.Point(12, 34);
            this.cbx_party.Name = "cbx_party";
            this.cbx_party.Size = new System.Drawing.Size(152, 21);
            this.cbx_party.TabIndex = 11;
            this.cbx_party.SelectedIndexChanged += new System.EventHandler(this.cbx_party_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Choose Party";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbx
            // 
            this.tbx.Location = new System.Drawing.Point(203, 34);
            this.tbx.Name = "tbx";
            this.tbx.Size = new System.Drawing.Size(313, 174);
            this.tbx.TabIndex = 13;
            this.tbx.Text = "";
            this.tbx.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Party Platform";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Showpartyplatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(541, 247);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_party);
            this.Controls.Add(this.btn_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Showpartyplatform";
            this.Text = "Show party platfform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Showpartyplatform_FormClosing);
            this.Load += new System.EventHandler(this.Showpartyplatform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox cbx_party;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tbx;
        private System.Windows.Forms.Label label2;
    }
}