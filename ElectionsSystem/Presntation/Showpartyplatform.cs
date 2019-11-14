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
    public partial class Showpartyplatform : Form
    {



        public Showpartyplatform()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbx_party_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database db = Database.Instance;
            db.OpenConn();

            tbx.Text = db.getplat(cbx_party.Text);
            db.CloseConn(true);
        }

        private void Showpartyplatform_Load(object sender, EventArgs e)
        {
            cbx_party.SelectedIndexChanged -= cbx_party_SelectedIndexChanged;
            Database db = Database.Instance;
            db.OpenConn();

            cbx_party.DataSource = db.getTableParties().DefaultView;
            //cbx_party.Items.Clear();
            db.CloseConn(true);
            cbx_party.DisplayMember = "Name";
            cbx_party.ValueMember = "Name";
            cbx_party.SelectedIndexChanged += cbx_party_SelectedIndexChanged;
            






        }

        private void dgv_printAllContenders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Showpartyplatform_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbx_TextChanged(object sender, EventArgs e)
        {

        }
    }




}
