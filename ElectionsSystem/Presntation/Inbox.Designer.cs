namespace ElectionsSystem.Presntation
{
    partial class Inbox
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgv_Outbox = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_user = new System.Windows.Forms.Label();
            this.cbx_type = new System.Windows.Forms.ComboBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_message = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_to = new System.Windows.Forms.ComboBox();
            this.tbx_subject = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_Inbox = new System.Windows.Forms.DataGridView();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbc_messages = new System.Windows.Forms.TabControl();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Outbox)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inbox)).BeginInit();
            this.tbc_messages.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 9);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(54, 23);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgv_Outbox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(394, 234);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Outbox";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgv_Outbox
            // 
            this.dgv_Outbox.AllowUserToAddRows = false;
            this.dgv_Outbox.AllowUserToDeleteRows = false;
            this.dgv_Outbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Outbox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgv_Outbox.Location = new System.Drawing.Point(25, 11);
            this.dgv_Outbox.Name = "dgv_Outbox";
            this.dgv_Outbox.ReadOnly = true;
            this.dgv_Outbox.Size = new System.Drawing.Size(345, 212);
            this.dgv_Outbox.TabIndex = 2;
            this.dgv_Outbox.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Outbox_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "To";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Message";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "serialNumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_user);
            this.tabPage2.Controls.Add(this.cbx_type);
            this.tabPage2.Controls.Add(this.btn_send);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbx_message);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cbx_to);
            this.tabPage2.Controls.Add(this.tbx_subject);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(394, 234);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create message";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(14, 25);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(34, 13);
            this.lbl_user.TabIndex = 8;
            this.lbl_user.Text = "Type:";
            // 
            // cbx_type
            // 
            this.cbx_type.FormattingEnabled = true;
            this.cbx_type.Location = new System.Drawing.Point(66, 22);
            this.cbx_type.Name = "cbx_type";
            this.cbx_type.Size = new System.Drawing.Size(102, 21);
            this.cbx_type.TabIndex = 7;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(249, 172);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 6;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Message:";
            // 
            // tbx_message
            // 
            this.tbx_message.Location = new System.Drawing.Point(66, 99);
            this.tbx_message.Name = "tbx_message";
            this.tbx_message.Size = new System.Drawing.Size(102, 96);
            this.tbx_message.TabIndex = 4;
            this.tbx_message.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recipient:";
            // 
            // cbx_to
            // 
            this.cbx_to.FormattingEnabled = true;
            this.cbx_to.Location = new System.Drawing.Point(249, 22);
            this.cbx_to.Name = "cbx_to";
            this.cbx_to.Size = new System.Drawing.Size(75, 21);
            this.cbx_to.TabIndex = 1;
            // 
            // tbx_subject
            // 
            this.tbx_subject.Location = new System.Drawing.Point(66, 56);
            this.tbx_subject.Name = "tbx_subject";
            this.tbx_subject.Size = new System.Drawing.Size(102, 20);
            this.tbx_subject.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_Inbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(394, 234);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inbox";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_Inbox
            // 
            this.dgv_Inbox.AllowUserToAddRows = false;
            this.dgv_Inbox.AllowUserToDeleteRows = false;
            this.dgv_Inbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Inbox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.From,
            this.Subject,
            this.Message,
            this.serialNumber});
            this.dgv_Inbox.Location = new System.Drawing.Point(14, 11);
            this.dgv_Inbox.Name = "dgv_Inbox";
            this.dgv_Inbox.ReadOnly = true;
            this.dgv_Inbox.Size = new System.Drawing.Size(345, 212);
            this.dgv_Inbox.TabIndex = 1;
            this.dgv_Inbox.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Inbox_CellClick);
            this.dgv_Inbox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Inbox_CellContentClick_1);
            // 
            // From
            // 
            this.From.HeaderText = "From";
            this.From.Name = "From";
            this.From.ReadOnly = true;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Width = 200;
            // 
            // Message
            // 
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Visible = false;
            // 
            // serialNumber
            // 
            this.serialNumber.HeaderText = "serialNumber";
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.ReadOnly = true;
            this.serialNumber.Visible = false;
            // 
            // tbc_messages
            // 
            this.tbc_messages.Controls.Add(this.tabPage1);
            this.tbc_messages.Controls.Add(this.tabPage2);
            this.tbc_messages.Controls.Add(this.tabPage4);
            this.tbc_messages.Location = new System.Drawing.Point(12, 39);
            this.tbc_messages.Name = "tbc_messages";
            this.tbc_messages.SelectedIndex = 0;
            this.tbc_messages.Size = new System.Drawing.Size(402, 260);
            this.tbc_messages.TabIndex = 11;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(344, 10);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(66, 23);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Inbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(494, 298);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.tbc_messages);
            this.Controls.Add(this.btn_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Inbox";
            this.Text = "Inbox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inbox_FormClosing);
            this.Load += new System.EventHandler(this.Inbox_Load);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Outbox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inbox)).EndInit();
            this.tbc_messages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox tbx_message;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_to;
        private System.Windows.Forms.TextBox tbx_subject;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_Inbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumber;
        private System.Windows.Forms.TabControl tbc_messages;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Outbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btn_refresh;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.ComboBox cbx_type;
    }
}