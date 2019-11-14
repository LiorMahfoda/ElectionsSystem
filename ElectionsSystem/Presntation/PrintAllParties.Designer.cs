namespace ElectionsSystem.Presntation
{
    partial class PrintAllParties
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
            this.dgv_partyTable = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_partyTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_partyTable
            // 
            this.dgv_partyTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_partyTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_partyTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_partyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_partyTable.Location = new System.Drawing.Point(21, 74);
            this.dgv_partyTable.Name = "dgv_partyTable";
            this.dgv_partyTable.Size = new System.Drawing.Size(240, 176);
            this.dgv_partyTable.TabIndex = 0;
            this.dgv_partyTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_partyTable_CellContentClick);
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
            // PrintAllParties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv_partyTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PrintAllParties";
            this.Text = "PrintAllParties";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrintAllParties_FormClosing);
            this.Load += new System.EventHandler(this.PrintAllParties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_partyTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_partyTable;
        private System.Windows.Forms.Button btn_back;
    }
}