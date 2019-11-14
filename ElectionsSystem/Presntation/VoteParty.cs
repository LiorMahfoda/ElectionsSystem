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

    public partial class VoteParty : Form
    {
        Citizen user; 
        bool voted;
        public VoteParty(Citizen user,bool voted)
        {
            InitializeComponent();
            this.user = user;
            this.voted = voted;
            CenterToScreen();
        }

        private void VoteParty_Load(object sender, EventArgs e)
        {
            Database db = Database.Instance;
            db.OpenConn();
            List<string> parties = db.getParties();
            foreach (string name in parties)
            {
                RadioButton r = new RadioButton();
                r.Text = name;
                flp_voteParty.Controls.Add(r);

            }
            db.CloseConn(true);
        }

        private void btn_voteParty_Click(object sender, EventArgs e)
        {
            string selected;
            foreach (object o in flp_voteParty.Controls)
            {
                if ((o as RadioButton).Checked)
                {
                    selected = (o as RadioButton).Text;
                    VoteContender v = new VoteContender(user,selected,voted);
                    v.Owner = this;
                    v.Show();
                    this.Hide();
                    break;
                }
                
            }
        }

        private void VoteParty_FormClosing(object sender, FormClosingEventArgs e)
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
