namespace ElectionsSystem.Presntation
{
    partial class PrintPress
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
            this.dgv_PressTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PressTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(22, 28);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(54, 23);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dgv_PressTable
            // 
            this.dgv_PressTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PressTable.Location = new System.Drawing.Point(22, 84);
            this.dgv_PressTable.Name = "dgv_PressTable";
            this.dgv_PressTable.Size = new System.Drawing.Size(240, 150);
            this.dgv_PressTable.TabIndex = 10;
            // 
            // PrintPress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv_PressTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PrintPress";
            this.Text = "PrintPress";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrintPress_FormClosing);
            this.Load += new System.EventHandler(this.PrintPress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PressTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dgv_PressTable;
    }
}