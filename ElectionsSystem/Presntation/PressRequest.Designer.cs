namespace ElectionsSystem.Presntation
{
    partial class PressRequest
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
            this.tbx_workplace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_sumbit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_workplace
            // 
            this.tbx_workplace.Location = new System.Drawing.Point(142, 36);
            this.tbx_workplace.Name = "tbx_workplace";
            this.tbx_workplace.Size = new System.Drawing.Size(100, 20);
            this.tbx_workplace.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter work place:";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(25, 120);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_sumbit
            // 
            this.btn_sumbit.Location = new System.Drawing.Point(142, 119);
            this.btn_sumbit.Name = "btn_sumbit";
            this.btn_sumbit.Size = new System.Drawing.Size(100, 23);
            this.btn_sumbit.TabIndex = 3;
            this.btn_sumbit.Text = "Sumbit request";
            this.btn_sumbit.UseVisualStyleBackColor = true;
            this.btn_sumbit.Click += new System.EventHandler(this.btn_sumbit_Click);
            // 
            // PressRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(258, 198);
            this.Controls.Add(this.btn_sumbit);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_workplace);
            this.Name = "PressRequest";
            this.Text = "PressRequest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PressRequest_FormClosing);
            this.Load += new System.EventHandler(this.PressRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_workplace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_sumbit;
    }
}