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
    public partial class ChangePass : Form
    {
        Citizen user;
        public ChangePass(Citizen user)
        {
            InitializeComponent();
            CenterToScreen();
            this.user = user;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ChangePass_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_newPassword.Text) || string.IsNullOrWhiteSpace(tbx_RenewPassword.Text))
            {
                MessageBox.Show("Please fill all the details");
                return;
            }

            if (MessageBox.Show("Are you sure you want to change password", "add", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (tbx_newPassword.Text == tbx_RenewPassword.Text)
                {
                    user.pass = tbx_newPassword.Text;
                    Database db = Database.Instance;
                    db.OpenConn();
                    db.changePassword(tbx_newPassword.Text,user.id);
                    db.CloseConn(true);
                    MessageBox.Show("Successfully change!");
                    Owner.Show();
                    this.Hide();
                }

                else 
                {
                    MessageBox.Show("Wrong password!");
                    return;
                }


            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }
    }
}
