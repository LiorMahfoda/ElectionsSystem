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
    public partial class PartyRegistration : Form
    {
        Citizen user;
        DataTable citizensForPm = new DataTable();
        public PartyRegistration(Citizen user)
        {
            this.user = user;
            InitializeComponent();
            CenterToScreen();

            Database db = Database.Instance;
            db.OpenConn();
            citizensForPm = db.getOnlyCitizens();

            int index = -1;
            foreach (DataRow member in citizensForPm.Rows)
            {
                if (member[0].ToString().Trim() == user.id)

                    index = citizensForPm.Rows.IndexOf(member);
                else
                    clb_members.Items.Add(member[1]);
            }
            citizensForPm.Rows.RemoveAt(index);
            //foreach (DataRow citizen in citizensForPm.Rows)
            //{
            //    clb_members.Items.Add(citizen[1]);
            //}


            db.CloseConn(true);
        }



        private void PartyRegistration_Load(object sender, EventArgs e)
        {

        }


        private void btn_addParty_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_platform.Text) || string.IsNullOrWhiteSpace(tbx_name.Text))
            {
                MessageBox.Show("Please fill all the details");
                return;
            }
            Database db = Database.Instance;
            db.OpenConn();

            try
            {


                if (MessageBox.Show("Are you sure you want to aplly your request?", "add", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                {
                    List<string> admins = db.getAdmins();
                    foreach (string admin in admins)
                    {
                        string message = "Party leader: " + user.id + "\nPlatform: " + tbx_platform.Text + "\nParty Members:";

                        for (int i = 0; i < clb_members.Items.Count; i++)
                            if (clb_members.GetItemChecked(i))
                                message += "\n" + citizensForPm.Rows[i][0].ToString();

                        if (!(db.createMessage(user.id, admin, "Request to start a party", message, "False")))
                        {

                            throw new Exception();


                        }

                    }

                    MessageBox.Show("Successfully applied!");
                    Owner.Show();
                    this.Hide();
                }
            }
            catch (Exception ex) { MessageBox.Show("Please try again"); }


            db.CloseConn(true);

        }

        private void tbx_platform_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartyRegistration_FormClosing(object sender, FormClosingEventArgs e)
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