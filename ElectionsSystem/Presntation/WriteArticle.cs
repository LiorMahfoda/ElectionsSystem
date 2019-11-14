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
    public partial class WriteArticle : Form
    {
        Press user;
        DataTable citizens = new DataTable();
        public WriteArticle(Press user)
        {
            InitializeComponent();
            CenterToScreen();
            this.user = user;
            Database db = Database.Instance;
            db.OpenConn();
            citizens = db.getCitizensNames_Ids();
            db.CloseConn(true);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            
            bool flag = true;
            if (string.IsNullOrWhiteSpace(rtbx_article.Text)||string.IsNullOrWhiteSpace(tbx_topic.Text))
            {
                
                MessageBox.Show("Please fill all the details");
                return;

            }

            if (MessageBox.Show("Are you sure you want to send article?", "add", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
            {
                Database db = Database.Instance;
                db.OpenConn();
                foreach (DataRow citizen in citizens.Rows) 
                {
                    flag = db.createMessage(user.id, citizen[0].ToString(), tbx_topic.Text, rtbx_article.Text, "False");
                    if (!flag) 
                    {
                        MessageBox.Show("Failed to send to"+citizen[1].ToString());
                    }
                }
                MessageBox.Show("successfully send");
                db.CloseConn(true);
            }
        }

        private void WriteArticle_Load(object sender, EventArgs e)
        {

        }
    }
}
