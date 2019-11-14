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
    public partial class DeletePress : Form
    {
        DataTable pressMembers = new DataTable();
        public DeletePress()
        {
            InitializeComponent();
            Database db = Database.Instance;
            db.OpenConn();
            pressMembers = db.getPressName_Ids();



            foreach (DataRow pressMember in pressMembers.Rows)
            {
                cbx_pressMembers.Items.Add(pressMember[1]);
            }
            db.CloseConn(true);
        }

        private void DeletePress_Load(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbx_pressMembers.Text))
            {
                MessageBox.Show("Please fill all the details");
                return;
            }
            Database db = Database.Instance;
            db.OpenConn();

            try
            {

                string name = pressMembers.Rows[cbx_pressMembers.SelectedIndex][1].ToString();
                if (MessageBox.Show("Are you sure you want to delete "+ name+" ?", "add", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (db.deletePress(pressMembers.Rows[cbx_pressMembers.SelectedIndex][0].ToString()))
                        MessageBox.Show("deleted successfully!");
                    else
                        MessageBox.Show("Something went wrong. Please try again.");
                }
            }
            catch (Exception ex) { }
            db.CloseConn(true);
        }

        private void DeletePress_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cbx_pressMembers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
