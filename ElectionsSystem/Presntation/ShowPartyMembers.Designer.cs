namespace ElectionsSystem.Presntation
{
    partial class ShowPartyMembers
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
            this.flp_Parties = new System.Windows.Forms.FlowLayoutPanel();
            this.dgv_showMember = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_showM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showMember)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Party:";
            // 
            // flp_Parties
            // 
            this.flp_Parties.AutoScroll = true;
            this.flp_Parties.AutoSize = true;
            this.flp_Parties.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_Parties.Location = new System.Drawing.Point(80, 41);
            this.flp_Parties.Name = "flp_Parties";
            this.flp_Parties.Size = new System.Drawing.Size(106, 74);
            this.flp_Parties.TabIndex = 1;
            this.flp_Parties.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_parties_Paint);
            // 
            // dgv_showMember
            // 
            this.dgv_showMember.AllowUserToAddRows = false;
            this.dgv_showMember.AllowUserToDeleteRows = false;
            this.dgv_showMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_showMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showMember.Location = new System.Drawing.Point(24, 161);
            this.dgv_showMember.Name = "dgv_showMember";
            this.dgv_showMember.ReadOnly = true;
            this.dgv_showMember.Size = new System.Drawing.Size(224, 127);
            this.dgv_showMember.TabIndex = 2;
            this.dgv_showMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_showM_CellContentClick);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(4, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_showM
            // 
            this.btn_showM.Location = new System.Drawing.Point(197, 53);
            this.btn_showM.Name = "btn_showM";
            this.btn_showM.Size = new System.Drawing.Size(75, 35);
            this.btn_showM.TabIndex = 4;
            this.btn_showM.Text = "show members";
            this.btn_showM.UseVisualStyleBackColor = true;
            this.btn_showM.Click += new System.EventHandler(this.btn_showM_Click);
            // 
            // ShowPartyMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(284, 318);
            this.Controls.Add(this.btn_showM);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv_showMember);
            this.Controls.Add(this.flp_Parties);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ShowPartyMembers";
            this.Text = "ShowPartyMembers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowPartyMembers_FormClosing);
            this.Load += new System.EventHandler(this.ShowPartyMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flp_Parties;
        private System.Windows.Forms.DataGridView dgv_showMember;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_showM;
    }
}