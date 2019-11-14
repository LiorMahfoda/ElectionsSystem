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
    public partial class PartyMember_menu : Citizen_menu
    {
        PartyMember user;
        
        public PartyMember_menu(PartyMember user):base(user)
        {
            this.user = user;
            InitializeComponent();
            Button btn_leave_party = new Button();
            btn_leave_party.Text = "Leave Party";
            btn_leave_party.Size = new System.Drawing.Size(144, 23);
            btn_leave_party.Click += new EventHandler(btn_leave_party_Click);
            flp_citizenMenu.Controls.Add(btn_leave_party);
        }

        

        private void btn_leave_party_Click(object sender, EventArgs e)
        {
            Database db = Database.Instance;
            db.OpenConn();

            if (MessageBox.Show("Are you sure you want to leave " + user.partyName + "?", "delete", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                if (db.deletePartyMember(user.id))
                    MessageBox.Show("Deleted successfully!");
                else
                    MessageBox.Show("Something went wrong. Please try again.");

            
            db.CloseConn(true);
        }

        public void LoadForm(Object sender, EventArgs e)
        
        {
        }
    }
}
