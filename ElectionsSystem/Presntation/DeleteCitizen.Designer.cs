namespace ElectionsSystem.Presntation
{
    partial class DeleteCitizen
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.tbx_id = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(183, 51);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tbx_id
            // 
            this.tbx_id.Location = new System.Drawing.Point(77, 53);
            this.tbx_id.Name = "tbx_id";
            this.tbx_id.Size = new System.Drawing.Size(100, 20);
            this.tbx_id.TabIndex = 3;
            this.tbx_id.TextChanged += new System.EventHandler(this.tbx_id_TextChanged);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(21, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(54, 23);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // DeleteCitizen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(284, 92);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.tbx_id);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DeleteCitizen";
            this.Text = "Delete Citizen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteCitizen_FormClosing);
            this.Load += new System.EventHandler(this.DeleteCitizen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox tbx_id;
        private System.Windows.Forms.Button btn_back;
    }
}