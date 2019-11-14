namespace ElectionsSystem
{
    partial class Registration
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
            this.tbx_id = new System.Windows.Forms.TextBox();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_street = new System.Windows.Forms.TextBox();
            this.dtp_birthdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_gender = new System.Windows.Forms.ComboBox();
            this.tbx_house = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_pass = new System.Windows.Forms.TextBox();
            this.tbx_rePass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_neighborhood = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_id
            // 
            this.tbx_id.Location = new System.Drawing.Point(131, 52);
            this.tbx_id.MaxLength = 9;
            this.tbx_id.Name = "tbx_id";
            this.tbx_id.Size = new System.Drawing.Size(122, 20);
            this.tbx_id.TabIndex = 0;
            this.tbx_id.TextChanged += new System.EventHandler(this.tbx_id_TextChanged);
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(131, 85);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(122, 20);
            this.tbx_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Full name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbx_street
            // 
            this.tbx_street.Location = new System.Drawing.Point(131, 204);
            this.tbx_street.Name = "tbx_street";
            this.tbx_street.Size = new System.Drawing.Size(122, 20);
            this.tbx_street.TabIndex = 4;
            // 
            // dtp_birthdate
            // 
            this.dtp_birthdate.CustomFormat = "dd/MM/yyyy";
            this.dtp_birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_birthdate.Location = new System.Drawing.Point(131, 128);
            this.dtp_birthdate.Name = "dtp_birthdate";
            this.dtp_birthdate.Size = new System.Drawing.Size(122, 20);
            this.dtp_birthdate.TabIndex = 5;
            this.dtp_birthdate.Value = new System.DateTime(2000, 1, 1, 13, 22, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Birth Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender:";
            // 
            // cbx_gender
            // 
            this.cbx_gender.FormattingEnabled = true;
            this.cbx_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbx_gender.Location = new System.Drawing.Point(131, 168);
            this.cbx_gender.Name = "cbx_gender";
            this.cbx_gender.Size = new System.Drawing.Size(122, 21);
            this.cbx_gender.TabIndex = 8;
            // 
            // tbx_house
            // 
            this.tbx_house.Location = new System.Drawing.Point(131, 243);
            this.tbx_house.Name = "tbx_house";
            this.tbx_house.Size = new System.Drawing.Size(122, 20);
            this.tbx_house.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Street:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "House:";
            // 
            // tbx_pass
            // 
            this.tbx_pass.Location = new System.Drawing.Point(131, 312);
            this.tbx_pass.Name = "tbx_pass";
            this.tbx_pass.PasswordChar = '*';
            this.tbx_pass.Size = new System.Drawing.Size(122, 20);
            this.tbx_pass.TabIndex = 12;
            // 
            // tbx_rePass
            // 
            this.tbx_rePass.Location = new System.Drawing.Point(131, 350);
            this.tbx_rePass.Name = "tbx_rePass";
            this.tbx_rePass.PasswordChar = '*';
            this.tbx_rePass.Size = new System.Drawing.Size(122, 20);
            this.tbx_rePass.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Confirm password:";
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(194, 388);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 16;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Neighborhood:";
            // 
            // tbx_neighborhood
            // 
            this.tbx_neighborhood.Location = new System.Drawing.Point(131, 278);
            this.tbx_neighborhood.Name = "tbx_neighborhood";
            this.tbx_neighborhood.Size = new System.Drawing.Size(122, 20);
            this.tbx_neighborhood.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(282, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbx_neighborhood);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbx_rePass);
            this.Controls.Add(this.tbx_pass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_house);
            this.Controls.Add(this.cbx_gender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_birthdate);
            this.Controls.Add(this.tbx_street);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.tbx_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Registration";
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_FormClosing);
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_id;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_street;
        private System.Windows.Forms.DateTimePicker dtp_birthdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_gender;
        private System.Windows.Forms.TextBox tbx_house;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_pass;
        private System.Windows.Forms.TextBox tbx_rePass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbx_neighborhood;
        private System.Windows.Forms.Button button1;
    }
}