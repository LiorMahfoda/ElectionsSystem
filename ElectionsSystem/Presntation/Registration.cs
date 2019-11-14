using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectionsSystem
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void tbx_id_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (tbx_pass.Text != tbx_rePass.Text)
                MessageBox.Show("Password doesn't match");
            else
            {
                Database db = Database.Instance;
                db.OpenConn(); 
                if (db.isCitizenExist(tbx_id.Text))
                    MessageBox.Show("Citizen already exist!");

                else if (db.AddNewCitizen(tbx_id.Text, tbx_name.Text, dtp_birthdate.Value.ToString("yyyy-MM-dd"), tbx_street.Text, int.Parse(tbx_house.Text), cbx_gender.SelectedItem.ToString(), tbx_pass.Text, tbx_neighborhood.Text, DateTime.Today.ToString("yyyy-MM-dd"), "valid"))
                {

                    DialogResult res = MessageBox.Show("Regitered successfully!");
                    if (res == DialogResult.OK)
                    {
                        db.CloseConn(true);
                        LogIn s = new LogIn();
                        
                        s.Show();
                        this.Hide();
                    }
                    
                }
                else
                    MessageBox.Show("Registration failed! Try again");
                db.CloseConn(true);
            }
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }
    }
}
