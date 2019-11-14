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
    public partial class Admin_menu : Citizen_menu
    {
        Admin user;
        public Admin_menu(Admin user): base(user)
        {
            this.user = user;
            InitializeComponent();

            Button btn_add_Admin = new Button();
            btn_add_Admin.Text = "Add Admin";
            btn_add_Admin.Size = new System.Drawing.Size(144, 23);
            btn_add_Admin.Click += new EventHandler(btn_add_Admin_Click);
            flp_citizenMenu.Controls.Add(btn_add_Admin);

            Button btn_rmv_Contender = new Button();
            btn_rmv_Contender.Text = "Remove Contender";
            btn_rmv_Contender.Size = new System.Drawing.Size(144, 23);
            btn_rmv_Contender.Click += new EventHandler(btn_rmv_Contender_Click);
            flp_citizenMenu.Controls.Add(btn_rmv_Contender);

            Button btn_rmv_Citizen = new Button();
            btn_rmv_Citizen.Text = "Remove Citizen";
            btn_rmv_Citizen.Size = new System.Drawing.Size(144, 23);
            btn_rmv_Citizen.Click += new EventHandler(btn_rmv_Citizen_Click);
            flp_citizenMenu.Controls.Add(btn_rmv_Citizen);

            Button btn_rmv_Admin = new Button();
            btn_rmv_Admin.Text = "Remove Admin";
            btn_rmv_Admin.Size = new System.Drawing.Size(144, 23);
            btn_rmv_Admin.Click += new EventHandler(btn_rmv_Admin_Click);
            flp_citizenMenu.Controls.Add(btn_rmv_Admin);

            Button btn_rmv_Press = new Button();
            btn_rmv_Press.Text = "Remove Press";
            btn_rmv_Press.Size = new System.Drawing.Size(144, 23);
            btn_rmv_Press.Click += new EventHandler(btn_rmv_Press_Click);
            flp_citizenMenu.Controls.Add(btn_rmv_Press);

            Button btn_add_contender = new Button();
            btn_add_contender.Text = "Add contender";
            btn_add_contender.Size = new System.Drawing.Size(144, 23);
            btn_add_contender.Click += new EventHandler(btn_add_contender_Click);
            flp_citizenMenu.Controls.Add(btn_add_contender);


            Button btn_add_Party = new Button();
            btn_add_Party.Text = "Add party";
            btn_add_Party.Size = new System.Drawing.Size(144, 23);
            btn_add_Party.Click += new EventHandler(btn_add_Party_Click);
            flp_citizenMenu.Controls.Add(btn_add_Party);

            Button btn_add_Press = new Button();
            btn_add_Press.Text = "Add Press";
            btn_add_Press.Size = new System.Drawing.Size(144, 23);
            btn_add_Press.Click += new EventHandler(btn_add_Press_Click);
            flp_citizenMenu.Controls.Add(btn_add_Press);

            Button btn_remove_press = new Button();
            btn_remove_press.Text = "Remove Press";
            btn_remove_press.Size = new System.Drawing.Size(144, 23);
            btn_remove_press.Click += new EventHandler(btn_remove_press_Click);
            flp_citizenMenu.Controls.Add(btn_remove_press);

            Button btn_SAV = new Button();
            btn_SAV.Text = "Show / Save Vote";
            btn_SAV.Size = new System.Drawing.Size(144, 23);
            btn_SAV.Click += new EventHandler(btn_SAV_Click);
            flp_citizenMenu.Controls.Add(btn_SAV);

            Button btn_CES = new Button();
            btn_CES.Text = "Change Election Status";
            btn_CES.Size = new System.Drawing.Size(144, 23);
            btn_CES.Click += new EventHandler(btn_CES_Click);
            flp_citizenMenu.Controls.Add(btn_CES);

            Button btn_delete_votes = new Button();
            btn_delete_votes.Text = "Delete all votes";
            btn_delete_votes.Size = new System.Drawing.Size(144, 23);
            btn_delete_votes.Click += new EventHandler(btn_delete_votes_Click);
            flp_citizenMenu.Controls.Add(btn_delete_votes);
          
        }

        private void btn_SAV_Click(object sender, EventArgs e)
        {
            AdminAdapter A = new AdminAdapter(user);
            if (A.ElectionStatus() == false)
            {
                SaveAllVote a = new SaveAllVote();
                a.Owner = this;
                a.Show();
                this.Hide();
            }
        }

        private void btn_remove_press_Click(object sender, EventArgs e)
        {
            DeletePress a = new DeletePress();
            a.Owner = this;
            a.Show();
            this.Hide();
        }

        private void btn_add_Press_Click(object sender, EventArgs e)
        {
            AddPress a = new AddPress();
            a.Owner = this;
            a.Show();
            this.Hide();
        }

        private void btn_add_Admin_Click(object sender, EventArgs e)
        {
            AddAdmin a = new AddAdmin();
            a.Owner = this;
            a.Show();
            this.Hide();
        }

        private void btn_add_Party_Click(object sender, EventArgs e)
        {   AdminAdapter A = new AdminAdapter(user);
        if (A.ElectionStatus() == false)
        {
            AddParty p = new AddParty();
            p.Owner = this;
            p.Show();
            this.Hide();
        }
        }

   
        private void LoadForm(object sender, System.EventArgs e)
        {



        }

        private void btn_add_contender_Click(object sender, EventArgs e)
        {
            AdminAdapter A = new AdminAdapter(user);
            if (A.ElectionStatus() == false)
            {
                AddContender a = new AddContender();
                a.Owner = this;
                a.Show();
                this.Hide();
            }
        }

        private void btn_rmv_Press_Click(object sender, EventArgs e)
        {
            DeletePress d = new DeletePress();
            d.Owner = this;
            d.Show();
            this.Hide();
        }

        private void btn_rmv_Admin_Click(object sender, EventArgs e)
        {
            DeleteAdmin d = new DeleteAdmin(user);
            d.Owner = this;
            d.Show();
            this.Hide();
        }

        private void btn_rmv_Citizen_Click(object sender, EventArgs e)
        {
            DeleteCitizen d = new DeleteCitizen();
            d.Owner = this;
            d.Show();
            this.Hide();
        }

        private void btn_rmv_Contender_Click(object sender, EventArgs e)
        {   AdminAdapter A = new AdminAdapter(user);
        if (A.ElectionStatus() == false)
        {
            DeleteContender d = new DeleteContender();
            d.Owner = this;
            d.Show();
            this.Hide();
        }
        }

        private void btn_CES_Click(object sender, EventArgs e)
        {
            Database db = Database.Instance;
            db.OpenConn();
            if (db.ElectionStatus() == true)
            {
                if (MessageBox.Show("Are you sure you want to close election ?" , "Close Election", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                {
                    db.ChangeElectionStatus();
                }
            }
            else{

                if (MessageBox.Show("Are you sure you want to open election ?", "Open Election", MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Information) == DialogResult.OK)
                {
                    db.ChangeElectionStatus();
                }
            
            
            }
            db.CloseConn(true);
          
        }

        private void btn_delete_votes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete all votes?", "add", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
            {
                Database db = Database.Instance;
                db.OpenConn();
                if (db.deleteVote())
                {
                    MessageBox.Show("successfully deleted");
                }

                else
                {
                    MessageBox.Show("something went wrong");
                }

                db.CloseConn(true);

            }
        }
        
    }
}
