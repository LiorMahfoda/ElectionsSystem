namespace ElectionsSystem.Presntation
{
    partial class AddPress
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.cbx_citizens = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_workPlace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.AutoSize = true;
            this.btn_add.Location = new System.Drawing.Point(165, 160);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(15, 160);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // cbx_citizens
            // 
            this.cbx_citizens.FormattingEnabled = true;
            this.cbx_citizens.Location = new System.Drawing.Point(140, 28);
            this.cbx_citizens.Name = "cbx_citizens";
            this.cbx_citizens.Size = new System.Drawing.Size(100, 21);
            this.cbx_citizens.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Citizen";
            // 
            // tbx_workPlace
            // 
            this.tbx_workPlace.Location = new System.Drawing.Point(140, 91);
            this.tbx_workPlace.Name = "tbx_workPlace";
            this.tbx_workPlace.Size = new System.Drawing.Size(100, 20);
            this.tbx_workPlace.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter workplace";
            // 
            // AddPress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(287, 256);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_workPlace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_citizens);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_add);
            this.Name = "AddPress";
            this.Text = "AddPress";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPress_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox cbx_citizens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_workPlace;
        private System.Windows.Forms.Label label2;
    }
}