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
    public partial class AddPress : Form
    {
        DataTable citizens = new DataTable();
        public AddPress()
        {
            InitializeComponent();
            Database db = Database.Instance;
            db.OpenConn();
            citizens = db.getOnlyCitizens();
            foreach (DataRow citizen in citizens.Rows)
            {
                cbx_citizens.Items.Add(citizen[1]);
            }
            db.CloseConn(true);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbx_citizens.Text) || string.IsNullOrWhiteSpace(tbx_workPlace.Text))
            {
                MessageBox.Show("Please fill all the details");
                return;
            }
            Database db = Database.Instance;
            db.OpenConn();

            try
            {

                string name = citizens.Rows[cbx_citizens.SelectedIndex][1].ToString();
                if (MessageBox.Show("Are you sure you want to make " + name + " Press Member?", "add", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (db.AddPress (citizens.Rows[cbx_citizens.SelectedIndex][0].ToString(),tbx_workPlace.Text))
                        MessageBox.Show("Added successfully!");
                    else
                        MessageBox.Show("Something went wrong. Please try again.");
                }
            }
            catch (Exception ex) { }
            db.CloseConn(true);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void AddPress_FormClosing(object sender, FormClosingEventArgs e)
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
