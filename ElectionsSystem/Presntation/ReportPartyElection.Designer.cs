namespace ElectionsSystem.Presntation
{
    partial class ReportPartyElection
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
            this.voteTableAdapter = new ElectionsSystem.ElectionTableAdapters.VoteTableAdapter();
            this.electionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.voteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.voteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.election)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource2)).BeginInit();
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
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ElectionsSystem.Presntation.ReportPerParty.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 6);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // voteTableAdapter
            // 
            this.voteTableAdapter.ClearBeforeFill = true;
            // 
            // electionBindingSource1
            // 
            this.electionBindingSource1.DataSource = this.election;
            this.electionBindingSource1.Position = 0;
            // 
            // voteBindingSource1
            // 
            this.voteBindingSource1.DataMember = "Vote";
            this.voteBindingSource1.DataSource = this.electionBindingSource1;
            // 
            // voteBindingSource2
            // 
            this.voteBindingSource2.DataMember = "Vote";
            this.voteBindingSource2.DataSource = this.electionBindingSource1;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(423, 6);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(54, 246);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ReportPartyElection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(493, 257);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportPartyElection";
            this.Text = "ReportPartyElection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportPartyElection_FormClosing);
            this.Load += new System.EventHandler(this.ReportElection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.election)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource electionBindingSource;
        private Election election;
        private System.Windows.Forms.BindingSource voteBindingSource;
        private ElectionTableAdapters.VoteTableAdapter voteTableAdapter;
        private System.Windows.Forms.BindingSource voteBindingSource1;
        private System.Windows.Forms.BindingSource electionBindingSource1;
        private System.Windows.Forms.BindingSource voteBindingSource2;
        private System.Windows.Forms.Button btn_back;

    }
}