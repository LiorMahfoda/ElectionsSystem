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
    public partial class Showcontenderplatform : Form
    {
        public Showcontenderplatform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbx_party_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }




        private void Showcontenderplatform_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Showcontenderplatform_Load(object sender, EventArgs e)
        {

        }

        private void cbx_con_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database db = Database.Instance;
            db.OpenConn();

            tbx.Text = db.getContenderplat(cbx_con.Text);
            db.CloseConn(true);
        }

        private void Showcontenderplatform_Load_1(object sender, EventArgs e)
        {
            cbx_con.SelectedIndexChanged -= cbx_con_SelectedIndexChanged;
            Database db = Database.Instance;
            db.OpenConn();

            cbx_con.DataSource = db.getTableContenders().DefaultView;
            db.CloseConn(true);
            cbx_con.DisplayMember = "Name";
            cbx_con.ValueMember = "Name";
            cbx_con.SelectedIndexChanged += cbx_con_SelectedIndexChanged;
            
        }



    }
}
