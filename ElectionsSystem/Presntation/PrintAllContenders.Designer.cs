namespace ElectionsSystem.Presntation
{
    partial class PrintAllContenders
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
            this.dgv_printAllContenders = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_printAllContenders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_printAllContenders
            // 
            this.dgv_printAllContenders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_printAllContenders.Location = new System.Drawing.Point(17, 68);
            this.dgv_printAllContenders.Name = "dgv_printAllContenders";
            this.dgv_printAllContenders.Size = new System.Drawing.Size(240, 150);
            this.dgv_printAllContenders.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(17, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(54, 23);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // PrintAllContenders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv_printAllContenders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PrintAllContenders";
            this.Text = "PrintAllContenders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrintAllContenders_FormClosing);
            this.Load += new System.EventHandler(this.PrintAllContenders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_printAllContenders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_printAllContenders;
        private System.Windows.Forms.Button btn_back;
    }
}