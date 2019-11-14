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
    public partial class DeletePartyMember : Form
    {
        PartyLeader user;
        DataTable partyMembers = new DataTable();
        public DeletePartyMember(PartyLeader user)
        {
            this.user = user;
            InitializeComponent();
            Database db = Database.Instance;
            db.OpenConn();
            partyMembers = db.getPartyMembers(user.partyName);

            int index = -1;
            
            foreach (DataRow partyMember in partyMembers.Rows)
            {
                if (partyMember[0].ToString().Trim() == user.id)
                
                    index = partyMembers.Rows.IndexOf(partyMember);
                else
                    cbx_partyMembers.Items.Add(partyMember[1]);      
            }
            partyMembers.Rows.RemoveAt(index);
            db.CloseConn(true);
        }

        private void DeletePartyMember_FormClosing(object sender, FormClosingEventArgs e)
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

            if (string.IsNullOrWhiteSpace(cbx_partyMembers.Text))
            {
                MessageBox.Show("Please fill all the details");
                return;
            }
            Database db = Database.Instance;
            db.OpenConn();

            try
            {

                string name = partyMembers.Rows[cbx_partyMembers.SelectedIndex][1].ToString();
                if (MessageBox.Show("Are you sure you want to delete " + name + " from "+user.partyName+"?", "add", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (db.deletePartyMember (partyMembers.Rows[cbx_partyMembers.SelectedIndex][0].ToString()))
                        MessageBox.Show("deleted successfully!");
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
    }
}
