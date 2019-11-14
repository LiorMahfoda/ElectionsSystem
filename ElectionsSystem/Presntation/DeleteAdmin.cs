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
    using BussinessLogic;
    public partial class DeleteAdmin : Form
    {
        Admin user;
        DataTable admins = new DataTable();
        public DeleteAdmin(Admin user)
        {
            this.user = user;
            InitializeComponent();
            Database db = Database.Instance;
            db.OpenConn();
            admins = db.getAdminsName_Id();
            int index = -1;
            foreach (DataRow admin in admins.Rows)
            {
                if (admin[0].ToString().Trim() == user.id)

                    index = admins.Rows.IndexOf(admin);
                else
                cbx_admins.Items.Add(admin[1]);
                            
            }
            db.CloseConn(true);
        }

        private void DeleteAdmin_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbx_admins.Text))
            {
                MessageBox.Show("Please fill all the details");
                return;
            }
            Database db = Database.Instance;
            db.OpenConn();

            try
            {
                
                string name = admins.Rows[cbx_admins.SelectedIndex][1].ToString();
                if (MessageBox.Show("Are you sure you want to delete " + name + "?", "add", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (db.deleteAdmin(admins.Rows[cbx_admins.SelectedIndex][0].ToString()))
                    {
                        MessageBox.Show("deleted successfully!");
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

        private void tbx_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }
    }
}
