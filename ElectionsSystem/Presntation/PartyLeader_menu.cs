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
    public partial class PartyLeader_menu : Citizen_menu
    {
        PartyLeader user;
        public PartyLeader_menu(PartyLeader user)
            : base(user)
        {
            this.user = user;
            InitializeComponent();
            // add party member as a leader button
            Button btn_add_PartyLeaderMember = new Button();
            btn_add_PartyLeaderMember.Text = "Add Member";
            btn_add_PartyLeaderMember.Size = new System.Drawing.Size(144, 23);
            btn_add_PartyLeaderMember.Click += new EventHandler(btn_add_PartyLeaderMember_Click);
            flp_citizenMenu.Controls.Add(btn_add_PartyLeaderMember);
           
            // remove party member as a leader button
            Button btn_rmv_PartyLeaderMember = new Button();
            btn_rmv_PartyLeaderMember.Text = "Remove Member";
            btn_rmv_PartyLeaderMember.Size = new System.Drawing.Size(144, 23);
            btn_rmv_PartyLeaderMember.Click += new EventHandler(btn_rmv_PartyMember_Click);
            flp_citizenMenu.Controls.Add(btn_rmv_PartyLeaderMember);

           

            Button btn_Leave_Party = new Button();
            btn_Leave_Party.Text = "Leave Party";
            btn_Leave_Party.Size = new System.Drawing.Size(144, 23);
            btn_Leave_Party.Click += new EventHandler(btn_Leave_Party_Click);
            flp_citizenMenu.Controls.Add(btn_Leave_Party);
        }

        private void btn_rmv_PartyMember_Click(object sender, EventArgs e)
        {
            DeletePartyMember c = new DeletePartyMember(user);
            c.Owner = this;
            c.Show();
            this.Hide();
        }

        public void LoadForm(Object sender, EventArgs e)
        {
        }


        private void btn_Leave_Party_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete self from " + user.partyName + "?", "add", MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Information) == DialogResult.OK)
            {
                MessageBox.Show("Choose new partyleader");
                AddPartyLeaderMember c = new AddPartyLeaderMember(user);
                c.Owner = this;
                c.Show();
                this.Hide();
            }
        }//finish button

        
        // add party member as a leader button action
        private void btn_add_PartyLeaderMember_Click(object sender, EventArgs e)
        {
            
            AddPartyMember d = new AddPartyMember(user); 
            d.Owner = this;
            d.Show();
            this.Hide();
        }
       

    }
}
