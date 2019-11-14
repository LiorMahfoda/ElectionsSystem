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
    public partial class DeleteParty : Form
    {
        public DeleteParty()
        {
            InitializeComponent();
        }

        private void DeleteParty_FormClosing(object sender, FormClosingEventArgs e)
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

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void DeleteParty_Load(object sender, EventArgs e)
        {
            Database db = Database.Instance;
            db.OpenConn();
            List<string> parties = db.getParties();
            db.CloseConn(true);

            foreach (string party in parties) 
            {
                RadioButton r = new RadioButton();
                r.Text = party;
                flp_parties.Controls.Add(r);
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Database db = Database.Instance;
            db.OpenConn();
            foreach (Control c in flp_parties.Controls)
            {
                if ((c as RadioButton).Checked)
                    db.deleteParty(c.Text);
            }
                db.CloseConn(true);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }
    }
}
