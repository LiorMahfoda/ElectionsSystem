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
    public partial class DeleteContender : Form
    {
        public DeleteContender()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Database db = Database.Instance;
            db.OpenConn();
            try
            {
                string name = db.getName(tbx_id.Text);
                if (MessageBox.Show("Are you sure you want to delete " + name + "?", "delete", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                    if (db.deleteContender(tbx_id.Text))
                        MessageBox.Show("Deleted successfully!");
                    else
                        MessageBox.Show("Something went wrong. Please try again.");
            }
            catch { MessageBox.Show("id " + tbx_id.Text + " doesn't exist"); }
            db.CloseConn(true);
        }

        private void DeleteContender_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }
    }
}
