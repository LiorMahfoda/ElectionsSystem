namespace ElectionsSystem.Presntation
{
    partial class ReportGender
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
            this.VoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.election = new ElectionsSystem.Election();
            this.election1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.election1 = new ElectionsSystem.Election();
            this.citizensTableAdapter = new ElectionsSystem.ElectionTableAdapters.CitizensTableAdapter();
            this.voteTableAdapter = new ElectionsSystem.ElectionTableAdapters.VoteTableAdapter();
            this.election1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citizensBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.election1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.voteBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.voteBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.voteBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.voteBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.election1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.voteBindingSource10 = new System.Windows.Forms.BindingSource(this.components);
            this.voteBindingSource11 = new System.Windows.Forms.BindingSource(this.components);
            this.voteBindingSource12 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.election1BindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.election)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.election1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.election1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.election1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citizensBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.election1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.election1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.election1BindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // VoteBindingSource
            // 
            this.VoteBindingSource.DataMember = "Vote";
            this.VoteBindingSource.DataSource = this.election;
            // 
            // election
            // 
            this.election.DataSetName = "Election";
            this.election.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // election1BindingSource2
            // 
            this.election1BindingSource2.DataSource = this.election1;
            this.election1BindingSource2.Position = 0;
            // 
            // election1
            // 
            this.election1.DataSetName = "Election";
            this.election1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citizensTableAdapter
            // 
            this.citizensTableAdapter.ClearBeforeFill = true;
            // 
            // voteTableAdapter
            // 
            this.voteTableAdapter.ClearBeforeFill = true;
            // 
            // election1BindingSource
            // 
            this.election1BindingSource.DataSource = this.election1;
            this.election1BindingSource.Position = 0;
            // 
            // election1BindingSource1
            // 
            this.election1BindingSource1.DataSource = this.election1;
            this.election1BindingSource1.Position = 0;
            // 
            // voteBindingSource6
            // 
            this.voteBindingSource6.DataMember = "Vote";
            this.voteBindingSource6.DataSource = this.election1;
            // 
            // voteBindingSource7
            // 
            this.voteBindingSource7.DataMember = "Vote";
            this.voteBindingSource7.DataSource = this.election1;
            // 
            // voteBindingSource8
            // 
            this.voteBindingSource8.DataMember = "Vote";
            this.voteBindingSource8.DataSource = this.election1BindingSource2;
            // 
            // election1BindingSource3
            // 
            this.election1BindingSource3.DataSource = this.election1;
            this.election1BindingSource3.Position = 0;
            // 
            // voteBindingSource10
            // 
            this.voteBindingSource10.DataMember = "Vote";
            this.voteBindingSource10.DataSource = this.election1BindingSource3;
            // 
            // voteBindingSource11
            // 
            this.voteBindingSource11.DataMember = "Vote";
            this.voteBindingSource11.DataSource = this.election1BindingSource3;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VoteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ElectionsSystem.Presntation.ReportPerGender.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(73, 29);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(603, 205);
            this.reportViewer1.TabIndex = 0;
            // 
            // election1BindingSource4
            // 
            this.election1BindingSource4.DataSource = this.election1;
            this.election1BindingSource4.Position = 0;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(693, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(54, 246);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ReportGender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElectionsSystem.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(759, 283);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportGender";
            this.Text = "Resuls by gender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportAge_FormClosing);
            this.Load += new System.EventHandler(this.ReportAge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.election)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.election1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.election1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.election1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citizensBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.election1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.election1BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteBindingSource12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.election1BindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Election election;
        private ElectionTableAdapters.CitizensTableAdapter citizensTableAdapter;
        private ElectionTableAdapters.VoteTableAdapter voteTableAdapter;
        private System.Windows.Forms.BindingSource election1BindingSource;
        private Election election1;
        private System.Windows.Forms.BindingSource citizensBindingSource1;
        private System.Windows.Forms.BindingSource election1BindingSource1;
        private System.Windows.Forms.BindingSource election1BindingSource2;
        private System.Windows.Forms.BindingSource voteBindingSource5;
        private System.Windows.Forms.BindingSource voteBindingSource6;
        private System.Windows.Forms.BindingSource voteBindingSource7;
        private System.Windows.Forms.BindingSource voteBindingSource8;
        private System.Windows.Forms.BindingSource voteBindingSource10;
        private System.Windows.Forms.BindingSource election1BindingSource3;
        private System.Windows.Forms.BindingSource voteBindingSource11;
        private System.Windows.Forms.BindingSource voteBindingSource12;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VoteBindingSource;
        private System.Windows.Forms.BindingSource election1BindingSource4;
        private System.Windows.Forms.Button btn_back;
    }
}