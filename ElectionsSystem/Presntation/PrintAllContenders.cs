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
    public partial class PrintAllContenders : Form
    {
        public PrintAllContenders()
        {
            InitializeComponent();
        }

        private void PrintAllContenders_Load(object sender, EventArgs e)
        {
            Database db = Database.Instance;
            db.OpenConn();
            dgv_printAllContenders.DataSource = db.getTableContender().DefaultView;     
            db.CloseConn(true);
        }

        private void PrintAllContenders_FormClosing(object sender, FormClosingEventArgs e)
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
