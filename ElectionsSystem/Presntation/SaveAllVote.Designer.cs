namespace ElectionsSystem.Presntation
{
    partial class SaveAllVote
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.voteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.election = new ElectionsSystem.Election();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.voteTableAdapter = new ElectionsSystem.ElectionTableAdapters.VoteTableAdapter();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.election)).BeginInit();
            this.SuspendLayout();
            // 
            // voteBindingSource
            // 
            this.voteBindingSource.DataMember = "Vote";
            this.voteBindingSource.DataSource = this.election;
            // 
            // election
            // 
            this.election.DataSetName = "Election";
            this.election.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.voteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ElectionsSystem.Presntation.SaveVote.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(792, 309);
            this.reportViewer1.TabIndex = 0;
            // 
            // voteTableAdapter
            // 
            this.voteTableAdapter.ClearBeforeFill = true;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(811, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(54, 309);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // SaveAllVote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources._411472130;
            this.ClientSize = new System.Drawing.Size(877, 324);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SaveAllVote";
            this.Text = "Save All Vote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveAllVote_FormClosing);
            this.Load += new System.EventHandler(this.SaveAllVote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.election)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Election election;
        private System.Windows.Forms.BindingSource voteBindingSource;
        private ElectionTableAdapters.VoteTableAdapter voteTableAdapter;
        private System.Windows.Forms.Button btn_back;
    }
}