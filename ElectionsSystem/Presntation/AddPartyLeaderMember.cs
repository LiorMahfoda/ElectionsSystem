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
    
    public partial class AddPartyLeaderMember : Form
    {
        DataTable partyMembers = new DataTable();
        PartyLeader user;
        public AddPartyLeaderMember(PartyLeader user)
        {
            this.user = user;
            InitializeComponent();
            Database db = Database.Instance;
            db.OpenConn();
            partyMembers = db.getPartyMembers(user.partyName);
            int index = -1;
            foreach (DataRow member in partyMembers.Rows)
            {
                if (member[0].ToString().Trim() == user.id)

                    index = partyMembers.Rows.IndexOf(member);
                else
                    cbx_Part_members.Items.Add(member[1]);
            }
            partyMembers.Rows.RemoveAt(index);
            db.CloseConn(true);
        }

        private void flb_PartyLeaderMember_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddPartyLeaderMember_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure you want to exit?",
                               "Exit",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                    Application.Exit();
                else
                    e.Cancel = true;
            }
        }

  
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbx_Part_members.Text))
            {
                MessageBox.Show("Please fill all the details");
                return;
            }
            Database db = Database.Instance;
            db.OpenConn();
            try
            {
                
                string name = partyMembers.Rows[cbx_Part_members.SelectedIndex][1].ToString();
                if (MessageBox.Show("Are you sure you want to make " + name + " to party leader?", "add", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (db.AddPartyLeaderMember(partyMembers.Rows[cbx_Part_members.SelectedIndex][0].ToString(), user.partyName))
                    {
                        MessageBox.Show("Added successfully!");
                        LogIn l = new LogIn();
                        this.Hide();
                        l.Show();
                    }
                    else
                        MessageBox.Show("Something went wrong. Please try again.");
                }
            }
            catch(Exception ex) {}
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
