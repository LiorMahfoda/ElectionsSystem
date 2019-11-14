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
    public partial class ShowPartyMembers : Form
    {
        public ShowPartyMembers()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }//end of btn_back

        private void dgv_showM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flp_parties_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowPartyMembers_Load(object sender, EventArgs e)
        {
            Database db = Database.Instance;
            db.OpenConn();
            List<string> parties = db.getParties();
            foreach (string name in parties)
            {
                RadioButton r = new RadioButton();
                r.Text = name;
                flp_Parties.Controls.Add(r);

            }//end foreach
            db.CloseConn(true);
        }

        private void btn_showM_Click(object sender, EventArgs e)
        {
            string selected;
            foreach (object o in flp_Parties.Controls)
            {
                if ((o as RadioButton).Checked)
                {
                    selected = (o as RadioButton).Text;//put to selected the party name that was selected.
                    Database db = Database.Instance;
                    db.OpenConn();
                    dgv_showMember.DataSource = db.getPartyMembersTable(selected).DefaultView;//loads on dgv_showMember all the members from "selected" party.
                    db.CloseConn(true);
                    break;
                }//end if
            }//end foreach

        }

        private void ShowPartyMembers_FormClosing(object sender, FormClosingEventArgs e)
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
