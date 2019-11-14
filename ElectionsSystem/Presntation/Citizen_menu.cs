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
    public partial class Citizen_menu : Form
    {
        BussinessLogic.Citizen user;
        public Citizen_menu(Citizen user)
        {

            InitializeComponent();

            this.user = user; ;
            Database db = Database.Instance;
       //     db.OpenConn();

//name = db.getName(id);
            lbl_name.Text += user.name;
         //   db.CloseConn(true);
            CenterToScreen();
        }
        //avoid error in design view mode !!!
        public Citizen_menu()
        {
            InitializeComponent();
        }

        private void Citizen_FormClosing(object sender, FormClosingEventArgs e)
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

        

        private void btn_vote_Click(object sender, EventArgs e)
        {

            Database db = Database.Instance;
            db.OpenConn();
            int age =user.getAge();
            if (db.ElectionStatus() == true)
            {
                db.CloseConn(true);

                if (age < 18)
                {
                    MessageBox.Show("You can't vote!");
                    return;
                }



                bool voted;
                DataTable dt = db.isVoted(user.id, out voted);
                if (voted)
                {


                    if (MessageBox.Show("You voted\n Contender:" + dt.Rows[0][1].ToString() + "\n Party:" + dt.Rows[0][2].ToString() + "\n Do you wish to change yor vote?",
                                   "Change vote",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Information) == DialogResult.Cancel)
                    {

                        return;
                    }
                }

                VoteParty v = new VoteParty(user, voted);
                v.Owner = this;
                v.Show();
                this.Hide();
            }
            else {

                MessageBox.Show("You can't vote! Not Election Day !");
                db.CloseConn(true);
            }
                
        }
    
        private void btn_back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            Database db = Database.Instance;
            if (user is PartyMember || user is Admin || user is Contender || user is Press)
            {
                MessageBox.Show("Sorry you cant apply  !!!");
            }
            else { 
            ApplyRequestContender c = new ApplyRequestContender(user);
            c.Owner = this;
            c.Show();
            this.Hide();
            }
        }



        private void btn_printContenders_Click(object sender, EventArgs e)
        {
            PrintAllContenders p = new PrintAllContenders();
            p.Owner = this;
            p.Show();
            this.Hide();
        }

        private void btn_printParties_Click(object sender, EventArgs e)
        {
            PrintAllParties p = new PrintAllParties();
            p.Owner = this;
            p.Show();
            this.Hide();
        }

        private void btn_printPress_Click(object sender, EventArgs e)
        {
            PrintPress p = new PrintPress();
            p.Owner = this;
            p.Show();
            this.Hide();
        }

        private void btn_inbox_Click(object sender, EventArgs e)
        {
            Inbox i = new Inbox(user);
            i.Owner = this;
            i.Show();
            this.Hide();
        }

        private void btn_Show_party_members_Click(object sender, EventArgs e)
        {
            ShowPartyMembers s = new ShowPartyMembers();
            s.Owner = this;
            s.Show();
            this.Hide();
        }

        private void btn_show_par_plat_Click(object sender, EventArgs e)
        {
            Showpartyplatform s = new Showpartyplatform();
            s.Owner = this;
            s.Show();
            this.Hide();
        }

        private void btn_show_con_plat_Click(object sender, EventArgs e)
        {
            Showcontenderplatform s = new Showcontenderplatform();
            s.Owner = this;
            s.Show();
            this.Hide();
        }

        private void Citizen_Load(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void btn_requestPress_Click(object sender, EventArgs e)
        {
            Database db = Database.Instance;
            if (user is PartyMember || user is Admin || user is Contender || user is Press)
            {
                MessageBox.Show("Sorry you cant request to be press  !!!");
            }
            else
            {
                PressRequest p = new PressRequest(user);
                p.Owner = this;
                p.Show();
                this.Hide();
            }
        }

        private void button111_Click(object sender, EventArgs e)
        {
             Database db = Database.Instance;
            if (user is PartyMember || user is Admin || user is Contender || user is Press)
            {
                MessageBox.Show("Sorry you cant request to add party  !!!");
            }
            else
            {
            PartyRegistration p = new PartyRegistration(user);
            p.Owner = this;
            p.Show();
            this.Hide();}
        }

        private void btn_Pass_Click(object sender, EventArgs e)
        {
            ChangePass p = new ChangePass(user);
            p.Owner = this;
            p.Show();
            this.Hide();
        }

        private void flp_citizenMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
