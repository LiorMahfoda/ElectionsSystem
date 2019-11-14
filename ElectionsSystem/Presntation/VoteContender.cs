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
    public partial class VoteContender : Form
    {
        Citizen user;
        bool voted;
        private string party;
        public VoteContender(Citizen user, string party,bool voted)
        {
            this.voted = voted;
            this.user = user;
            this.party = party;
            InitializeComponent();
            CenterToScreen();

            Database db = Database.Instance;
            db.OpenConn();
            List<string> contender = db.getContenders();
            foreach (string name in contender)
            {
                RadioButton r = new RadioButton();
                r.Text = name;
                flp_contenders.Controls.Add(r);
            }
            db.CloseConn(true);
        }

        private void VoteContender_Load(object sender, EventArgs e)
        {

          
        }

        private void btn_voteContender_Click(object sender, EventArgs e)
        {


            string selected = " ";
            foreach (object o in flp_contenders.Controls)
            {
                if ((o as RadioButton).Checked)
                {
                    selected = (o as RadioButton).Text;
                    break;
                }

            }

            Database db = Database.Instance;
            db.OpenConn();
            bool flag=false;
            if (voted) {
                flag=db.changeVote(user.id, party, selected);
            
            }
            else flag=db.addVote(user.id, party, selected);
           
            
            if(flag){
                MessageBox.Show("Thank you for voting");
                Owner.Owner.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Something went wrong");
            db.CloseConn(true);

        }

        private void VoteContender_FormClosing(object sender, FormClosingEventArgs e)
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
