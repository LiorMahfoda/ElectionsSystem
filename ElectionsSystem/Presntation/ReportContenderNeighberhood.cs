using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectionsSystem.Presntation
{
    public partial class ReportContenderNeighberhood : Form
    {
        public ReportContenderNeighberhood()
        {
            InitializeComponent();
        }

        private void ReportContenderNeighberhood_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'election.Vote' table. You can move, or remove it, as needed.
            this.voteTableAdapter.Fill(this.election.Vote);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void ReportContenderNeighberhood_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure want to exit?",
                               "Exit",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                    Application.Exit();
                else
                    e.Cancel = true;
            }
        }
    }
}
