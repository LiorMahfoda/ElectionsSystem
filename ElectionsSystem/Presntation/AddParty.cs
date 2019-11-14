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
    public partial class AddParty : Form
    {
        DataTable citizensForPl = new DataTable();
        DataTable citizensForPm = new DataTable();
        public AddParty()
        {
            InitializeComponent();
            CenterToScreen();

            Database db = Database.Instance;
            db.OpenConn();
            citizensForPl = db.getOnlyCitizens();
            citizensForPm = db.getOnlyCitizens();
            foreach (DataRow citizen in citizensForPm.Rows)
            {
                clb_partyMembers.Items.Add(citizen[1]);
            }


            foreach (DataRow citizen in citizensForPl.Rows)
            {
                cbx_PartyLeader.Items.Add(citizen[1]);
            }
            db.CloseConn(true);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Database db = Database.Instance;
            db.OpenConn();
            List<string> ids = new List<string>();
            //List<string> selected = new List<string>();
            for (int i = 0; i < clb_partyMembers.Items.Count; i++)
                if (clb_partyMembers.GetItemChecked(i))
                    ids.Add(citizensForPm.Rows[i][0].ToString());



            if (db.AddNewParty(tbx_partyName.Text, tbx_platform.Text, ids, citizensForPl.Rows[cbx_PartyLeader.SelectedIndex][0].ToString()))
            {
                MessageBox.Show("Party added successfully!");
                Owner.Show();
                this.Hide();

            }
            else
                MessageBox.Show("Failed!");
            db.CloseConn(true);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void AddParty_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}