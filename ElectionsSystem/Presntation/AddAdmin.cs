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
    public partial class AddAdmin : Form
    {
        DataTable citizens = new DataTable();
        public AddAdmin()
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbx_citizens.Text))
            {
                MessageBox.Show("Please fill all the details");
                return;
            }
            Database db = Database.Instance;
            db.OpenConn();

            try
            {
                
                string name = citizens.Rows[cbx_citizens.SelectedIndex][1].ToString();
                if (MessageBox.Show("Are you sure you want to make " + name + " admin?", "add", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (db.AddAdmin(citizens.Rows[cbx_citizens.SelectedIndex][0].ToString()))
                    {
                        MessageBox.Show("Added successfully!");
                        Owner.Show();
                        this.Hide();
                        
                    }
                    else
                        MessageBox.Show("Something went wrong. Please try again.");
                }
            }
            catch (Exception ex) { }
            db.CloseConn(true);
        }

        private void AddAdmin_FormClosing(object sender, FormClosingEventArgs e)
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
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btn_add.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {

        }

        private void cbx_citizens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
