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
    public partial class Inbox : Form
    
    {

        Citizen user;
        DataSet ds=new DataSet();
       
        public Inbox(Citizen user)
        {
            Database db = Database.Instance;
            db.OpenConn();
          //  DataSet ds = new DataSet();
            DataTable citizens = db.getCitizensNames_Ids();
            citizens.TableName = "citizens";
            citizens.DataSet.Tables.Remove(citizens.TableName);
            ds.Tables.Add(citizens);

            DataTable admins = db.getAdminsName_Id();
            admins.TableName = "admins";
            admins.DataSet.Tables.Remove(admins.TableName);
            ds.Tables.Add(admins);

            DataTable contenders = db.getContendersName_Ids();
            contenders.TableName = "contenders";
            contenders.DataSet.Tables.Remove(contenders.TableName);
            ds.Tables.Add(contenders);

            DataTable press = db.getPressName_Ids();
            press.TableName = "press";
            press.DataSet.Tables.Remove(press.TableName);
            ds.Tables.Add(press);
         
            
            //  ds.Tables.Add(db.getAdminsName_Id());
          //  ds.Tables.Add(db.getContendersName_Ids());
          //  ds.Tables.Add(db.getPressName_Ids());
            db.CloseConn(true);
            this.user = user; ;
            InitializeComponent();
            refreshMail();
            CenterToScreen();
        }

        private void refreshMail() {

            dgv_Inbox.Rows.Clear();
            dgv_Outbox.Rows.Clear();
            Database db = Database.Instance;
            db.OpenConn();
            DataTable inbox = db.getMessagesTo(user.id);
            DataTable outbox = db.getMessagesFrom(user.id);
            db.CloseConn(true);
            foreach (DataRow row in inbox.Rows)
            {

                DataGridViewRow r = new DataGridViewRow();
                string from, subject, message, serialNo;
                from = row[1].ToString();
                subject = row[3].ToString();
                message = row[4].ToString();
                serialNo = row[0].ToString();
                r.CreateCells(dgv_Inbox, from, subject, message, serialNo);
                if (row[5].ToString().Trim() == "True")
                    r.DefaultCellStyle.BackColor = Color.Aqua;
                dgv_Inbox.Rows.Add(r);
            }
            foreach (DataRow row in outbox.Rows)
            {

                DataGridViewRow r = new DataGridViewRow();

                string to, subject, message, serialNo;
                to = row[2].ToString();
                subject = row[3].ToString();
                message = row[4].ToString();
                serialNo = row[0].ToString();
                r.CreateCells(dgv_Inbox, to, subject, message, serialNo);
                dgv_Outbox.Rows.Add(r);
            }

            db.CloseConn(true);
        }

        private void dgv_Inbox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv.CurrentCell.ColumnIndex == 1)
            {
                MessageBox.Show(dgv.CurrentCell.OwningRow.Cells[2].Value.ToString());
                dgv.CurrentCell.OwningRow.DefaultCellStyle.BackColor = Color.Aqua;
                Database db = Database.Instance;
                db.OpenConn();
                db.markAsRead(dgv[3,dgv.CurrentCell.RowIndex].Value.ToString());
                db.CloseConn(true);
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            Database db = Database.Instance;
            db.OpenConn();
            if (db.createMessage(user.id, ds.Tables[cbx_type.SelectedIndex].Rows[cbx_to.SelectedIndex][0].ToString(), tbx_subject.Text, tbx_message.Text, "False"))
                MessageBox.Show("Message was sent");
            else
                MessageBox.Show("Failed!");
            db.CloseConn(true);
        }

        private void Inbox_Load(object sender, EventArgs e)
        {
            cbx_type.SelectedIndexChanged -= cbx_type_SelectedIndexChanged;
            cbx_type.Items.Add("Citizen");
            cbx_type.Items.Add("Admin");
            cbx_type.Items.Add("Contender");
            cbx_type.Items.Add("Press");
            cbx_type.DisplayMember = "Name";
            cbx_type.ValueMember = "Name";
            cbx_type.SelectedIndexChanged += cbx_type_SelectedIndexChanged; ;
            
        }


        private void cbx_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_to.Items.Clear();
            cbx_to.Text = "";

            foreach (DataRow row in ds.Tables[cbx_type.SelectedIndex].Rows) 
            {
                cbx_to.Items.Add(row[1].ToString());    
            }
       
        }
    

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refreshMail();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void Inbox_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgv_Inbox_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Inbox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv.CurrentCell.ColumnIndex == 1)
            {
                MessageBox.Show(dgv.CurrentCell.OwningRow.Cells[2].Value.ToString());
                dgv.CurrentCell.OwningRow.DefaultCellStyle.BackColor = Color.Aqua;
                Database db = Database.Instance;
                db.OpenConn();
                db.markAsRead(dgv[3, dgv.CurrentCell.RowIndex].Value.ToString());
                db.CloseConn(true);
            }
        }

        private void dgv_Outbox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Outbox.CurrentCell.ColumnIndex == 1)
            {
                MessageBox.Show(dgv_Outbox.CurrentCell.OwningRow.Cells[2].Value.ToString());
            }
        }
    }
}
