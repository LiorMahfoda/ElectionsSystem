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
    public partial class Press_menu : Citizen_menu
    {
        Press user;
        
        public Press_menu(Press user)
            : base(user)
        {
            this.user = user;
            InitializeComponent();
            Button btn_WA = new Button();
            btn_WA.Text = "Write Article";
            btn_WA.Size = new System.Drawing.Size(144, 23);
            btn_WA.Click += new EventHandler(btn_WA_Click);
            flp_citizenMenu.Controls.Add(btn_WA);


            PressElectionDay User2 = new PressElectionDay(user);

            if (User2.ElectionStatus() == true)
            {
                Button btn_Report_CE = new Button();
                btn_Report_CE.Text = "Report Contender Elecion";
                btn_Report_CE.Size = new System.Drawing.Size(144, 23);
                btn_Report_CE.Click += new EventHandler(btn_Report_CE_Click);
                flp_citizenMenu.Controls.Add(btn_Report_CE);

                Button btn_Report_PE = new Button();
                btn_Report_PE.Text = "Report Party Election";
                btn_Report_PE.Size = new System.Drawing.Size(144, 23);
                btn_Report_PE.Click += new EventHandler(btn_Report_PE_Click);
                flp_citizenMenu.Controls.Add(btn_Report_PE);

                Button btn_Report_PG = new Button();
                btn_Report_PG.Text = "Report Party Gender";
                btn_Report_PG.Size = new System.Drawing.Size(144, 23);
                btn_Report_PG.Click += new EventHandler(btn_Report_PG_Click);
                flp_citizenMenu.Controls.Add(btn_Report_PG);

                Button btn_Report_PN = new Button();
                btn_Report_PN.Text = "Report Party N";
                btn_Report_PN.Size = new System.Drawing.Size(144, 23);
                btn_Report_PN.Click += new EventHandler(btn_Report_PN_Click);
                flp_citizenMenu.Controls.Add(btn_Report_PN);

                Button btn_Report_CG = new Button();
                btn_Report_CG.Text = "Report Contender Gender";
                btn_Report_CG.Size = new System.Drawing.Size(144, 23);
                btn_Report_CG.Click += new EventHandler(btn_Report_CG_Click);
                flp_citizenMenu.Controls.Add(btn_Report_CG);

                Button btn_Report_CN = new Button();
                btn_Report_CN.Text = "Report Contender N";
                btn_Report_CN.Size = new System.Drawing.Size(144, 23);
                btn_Report_CN.Click += new EventHandler(btn_Report_CN_Click);
                flp_citizenMenu.Controls.Add(btn_Report_CN);

                Button btn_AgeParty = new Button();
                btn_AgeParty.Text = "Report Age Party";
                btn_AgeParty.Size = new System.Drawing.Size(144, 23);
                btn_AgeParty.Click += new EventHandler(btn_AgeParty_Click);
                flp_citizenMenu.Controls.Add(btn_AgeParty);

                Button btn_AgeContender = new Button();
                btn_AgeContender.Text = "Report Age Contender";
                btn_AgeContender.Size = new System.Drawing.Size(144, 23);
                btn_AgeContender.Click += new EventHandler(btn_AgeContender_Click);
                flp_citizenMenu.Controls.Add(btn_AgeContender);

            }

            else
            {

                Button btn_final_RP = new Button();
                btn_final_RP.Text = "Show Parties Result";
                btn_final_RP.Size = new System.Drawing.Size(144, 23);
                btn_final_RP.Click += new EventHandler(btn_final_RP_Click);
                flp_citizenMenu.Controls.Add(btn_final_RP);

                Button btn_final_RC = new Button();
                btn_final_RC.Text = "Show Contenders Result";
                btn_final_RC.Size = new System.Drawing.Size(144, 23);
                btn_final_RC.Click += new EventHandler(btn_final_RC_Click);
                flp_citizenMenu.Controls.Add(btn_final_RC);

           
            }

            

        }

        private void btn_AgeContender_Click(object sender, EventArgs e)
        {
            ReportAgeContender c = new ReportAgeContender();
            c.Owner = this;
            c.Show();
            this.Hide();
        }

        private void btn_AgeParty_Click(object sender, EventArgs e)
        {
            ReportAgeParty c = new ReportAgeParty();
            c.Owner = this;
            c.Show();
            this.Hide();

        }

        private void btn_WA_Click(object sender, EventArgs e)
        {

            WriteArticle c = new WriteArticle(user);
            c.Owner = this;
            c.Show();
            this.Hide();

        }

        private void btn_Report_CG_Click(object sender, EventArgs e)
        {
            ReportContenderGender c = new ReportContenderGender();
            c.Owner = this;
            c.Show();
            this.Hide();
        }
        private void btn_Report_PG_Click(object sender, EventArgs e)
        {
            ReportGender c = new ReportGender();
            c.Owner = this;
            c.Show();
            this.Hide();
        }

        private void btn_Report_PN_Click(object sender, EventArgs e)
        {
            ReportPerNeighborhood c = new ReportPerNeighborhood();
            c.Owner = this;
            c.Show();
            this.Hide();
        }

        private void btn_Report_PE_Click(object sender, EventArgs e)
        {
            ReportPartyElection c = new ReportPartyElection();
            c.Owner = this;
            c.Show();
            this.Hide();
        }

        private void btn_Report_CN_Click(object sender, EventArgs e)
        {
            ReportContenderNeighberhood c = new ReportContenderNeighberhood();
            c.Owner = this;
            c.Show();
            this.Hide();
        }


        private void btn_final_RP_Click(object sender, EventArgs e)
        {
            FinalResParty c = new FinalResParty();
            c.Owner = this;
            c.Show();
            this.Hide();
        }

        private void btn_final_RC_Click(object sender, EventArgs e)
        {
            FinalResContender c = new FinalResContender();
            c.Owner = this;
            c.Show();
            this.Hide();
        }
        private void btn_Report_CE_Click(object sender, EventArgs e)
        {
            ReportContenderElecion c = new ReportContenderElecion();
            c.Owner = this;
            c.Show();
            this.Hide();
        }
       

        public void LoadForm(Object sender, EventArgs e)
        {
        }

        private void Press_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
