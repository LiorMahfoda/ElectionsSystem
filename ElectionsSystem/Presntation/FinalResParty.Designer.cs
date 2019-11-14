namespace ElectionsSystem.Presntation
{
    partial class FinalResParty
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
            this.electionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.election = new ElectionsSystem.Election();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_back = new System.Windows.Forms.Button();
            this.voteTableAdapter = new ElectionsSystem.ElectionTableAdapters.VoteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.election)).BeginInit();
            this.SuspendLayout();
            // 
            // voteBindingSource
            // 
            this.voteBindingSource.DataMember = "Vote";
            this.voteBindingSource.DataSource = this.electionBindingSource;
            // 
            // electionBindingSource
            // 
            this.electionBindingSource.DataSource = this.election;
            this.electionBindingSource.Position = 0;
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
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ElectionsSystem.Presntation.FinalResParty.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(16, 9);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(643, 229);
            this.reportViewer1.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(690, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(54, 246);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // voteTableAdapter
            // 
            this.voteTableAdapter.ClearBeforeFill = true;
            // 
            // FinalResParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(759, 261);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FinalResParty";
            this.Text = "Final Result Party";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FinalResParty_FormClosing);
            this.Load += new System.EventHandler(this.FinalResParty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.election)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource electionBindingSource;
        private Election election;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.BindingSource voteBindingSource;
        private ElectionTableAdapters.VoteTableAdapter voteTableAdapter;
    }
}