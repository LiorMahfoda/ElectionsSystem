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
    public partial class ChangePlatform : Form
    {
        Contender user;   
        public ChangePlatform(Contender user)
        {
            this.user = user;
            InitializeComponent();
            CenterToScreen();
        }

        private void ChangePlatform_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbx_plat.Text))
            {
                MessageBox.Show("Please fill all the details");
                return;
            }
            Database db = Database.Instance;
            db.OpenConn();
            if (db.changePlat(user.id, rtbx_plat.Text))
            {
                MessageBox.Show("changed successfully!");
                user.platform = rtbx_plat.Text;
            }

            else { MessageBox.Show("Somthing went wrong"); }

            db.CloseConn(true);
        }
    }
}
