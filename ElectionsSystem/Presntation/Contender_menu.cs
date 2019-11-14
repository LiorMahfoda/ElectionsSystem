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
    public partial class Contender_menu : Citizen_menu
    {
        Contender user;
        public Contender_menu(Contender user)
            : base(user)
        {
            this.user = user;
            InitializeComponent();
            CenterToScreen();

            Button btn_change_plat = new Button();
            btn_change_plat.Text = "Change platform";
            btn_change_plat.Size = new System.Drawing.Size(144, 23);
            btn_change_plat.Click += new EventHandler(btn_change_plat_Click);
            flp_citizenMenu.Controls.Add(btn_change_plat);
        }

        private void btn_change_plat_Click(object sender, EventArgs e)
        {
            ChangePlatform c = new ChangePlatform(user);
            c.Owner = this;
            c.Show();
            this.Hide();
        }
        

     
    }
}
