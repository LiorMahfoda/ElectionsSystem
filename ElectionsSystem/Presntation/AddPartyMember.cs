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
    public partial class AddPartyMember : Form
    {
        DataTable citizens = new DataTable();
        PartyLeader user;
        public AddPartyMember(PartyLeader user)
        {
            this.user = user; ;
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

        private void flb_PartyLeaderMember_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddPartyMember_FormClosing(object sender, FormClosingEventArgs e)
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

        
        private void btn_Add_Click(object sender, EventArgs e)
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
                if (MessageBox.Show("Are you sure you want to add " + name + " to "+user.partyName+"?", "add", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (db.AddPartyMember(citizens.Rows[cbx_citizens.SelectedIndex][0].ToString(),user.partyName))
                        MessageBox.Show("Added successfully!");
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
