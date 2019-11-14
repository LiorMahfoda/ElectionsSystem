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
    public partial class ApplyRequestContender : Form
    {
        Citizen user;
           
        public ApplyRequestContender(Citizen user)
        {
            InitializeComponent();
            this.user=user;
        }

        private void ContenderRegistration_Load(object sender, EventArgs e)
        {

        }

    

    

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_platform.Text))
            {
                MessageBox.Show("Please fill all the details");
                return;
            }
            Database db = Database.Instance;
            db.OpenConn();

            try
            {


                if (MessageBox.Show("Are you sure you want to aplly request to be contender?", "add", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                {
                    List<string> admins = db.getAdmins();
                    foreach (string admin in admins)
                    {
                        string message = "ID: " + user.id + "\nPlatform: " + tbx_platform.Text;
                        if (db.createMessage(user.id, admin, "Conteder Apply", message, "False"))
                            MessageBox.Show("Applied successfully!");
                        else
                            MessageBox.Show("Plase try again");
                    }
                }
            }
            catch (Exception ex) { }
            
         
            db.CloseConn(true);
        }

      

        private void ContenderRegistration_FormClosing(object sender, FormClosingEventArgs e)
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
