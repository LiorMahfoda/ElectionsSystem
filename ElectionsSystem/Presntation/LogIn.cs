using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectionsSystem
{
    using BussinessLogic;

    public partial class LogIn : Form
    {
        Presntation.Citizen_menu p;
        BussinessLogic.Citizen user;
        DataTable citizens = new DataTable();

        public LogIn()
        {
            InitializeComponent();
            CenterToScreen();
            Database db = Database.Instance;
            db.OpenConn();
            citizens = db.getTableCitizens();
            DateTime today = DateTime.Today;
            foreach (DataRow row in citizens.Rows)
            {
                string s = row[8].ToString().Substring(0, 10);

                DateTime lastLogin = Convert.ToDateTime(s);
                //DateTime lastLogin = Convert.ToDateTime(row[8].ToString());
                TimeSpan diff = today - lastLogin;
                if (diff.TotalDays >= 30)
                {
                    if (diff.TotalDays < 60)
                        db.changeStatus(row[0].ToString(), "blocked");
                    else
                        deleteCitizen(row[0].ToString());
                }
            }

            db.CloseConn(true);


        }

        private void deleteCitizen(string id)
        {
            Database db = Database.Instance;
            db.OpenConn();
            if (db.isPartyMember(id))
            {
                if (db.isPartyLeader(id))
                {
                    PartyLeader p = db.getPartyLeader(id);
                    string defualtId = "000000000";
                    db.changePartyLeaderMember(p.partyName, defualtId);
                }

                db.deletePartyMember(id);

            }
            if (db.isContender(id))
                db.deleteContender(id);

            if (db.isAdmin(id))
                db.deleteAdmin(id);

            if (db.isPress(id))
                db.deletePress(id);

            db.deleteCitizen(id);
            db.addToDeletedCitizens(id);
            db.CloseConn(true);
        }



        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            
            Database db = Database.Instance;
            db.OpenConn();

            string status = db.getStatus(tbx_id.Text);
            if (status == "deleted" && db.isDeleted(tbx_id.Text))
            {
                MessageBox.Show("User does not exist");
                return;
            }

            else if (status.Trim() == "blocked")
            {
                List<string> admins = db.getAdmins();
                foreach (string admin in admins)
                {
                    string message = "ID: " + tbx_id.Text;
                    if (!(db.createMessage(tbx_id.Text, admin, "Request to unblock User", message, "False")))
                    {
                        throw new Exception();
                    }

                }

                MessageBox.Show("User is block\nRequest to unblock was sent to admin");
                db.CloseConn(true);
                return;
            }

            else
            {
                db.changeLogDate(tbx_id.Text);
                string pass = db.getPassword(tbx_id.Text);

                if (pass != tbx_password.Text)
                    MessageBox.Show("Incorrect id or password");
                else
                {
                    if (db.isAdmin(tbx_id.Text))
                    {
                        user = db.getAdmin(tbx_id.Text);
                        p = new Presntation.Admin_menu(user as Admin);
                    }
                    else if (db.isContender(tbx_id.Text))
                    {
                        user = db.getContender(tbx_id.Text);
                        p = new Presntation.Contender_menu(user as Contender);
                    }
                    else if (db.isLeader(tbx_id.Text))
                    {
                        user = db.getPartyLeader(tbx_id.Text);
                        p = new Presntation.PartyLeader_menu(user as PartyLeader);
                    }
                    else if (db.isPartyMember(tbx_id.Text))
                    {
                        user = db.getPartyMember(tbx_id.Text);
                        p = new Presntation.PartyMember_menu(user as PartyMember);
                    }
                    else if (db.isPress(tbx_id.Text))
                    {
                        user = db.getPress(tbx_id.Text);
                        p = new Presntation.Press_menu(user as Press);
                    }

                    else
                    {

                        user = db.getCitizen(tbx_id.Text);
                        p = new Presntation.Citizen_menu(user);
                    }
                    p.Owner = this;
                    p.Show();
                    this.Hide();
                }
            }
            db.CloseConn(true);
        }

        private void lbl_regirser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration c = new Registration();
            c.Owner = this;
            c.Show();
            this.Hide();
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
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

        private void LogIn_Load(object sender, EventArgs e)
        {

        }



    }
}