using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class Users : sample2
    {
        retrieval r = new retrieval();
        int edit = 0; //  0 - indication to save operation  , 1 - indication to update
        int userID;
        short status;
        public Users()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {
            MainClass.disable(LeftPanel);

        }
        public override void AddButton_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.enable_reset(LeftPanel);
        }

        public override void EditButton_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(LeftPanel);

        }

        public override void SaveButton_Click(object sender, EventArgs e)
        {
            if (nametxtbox.Text == "") { name_error_label.Visible = true; } else { name_error_label.Visible = false; }
            if (usernametxtbox.Text == "") { username_error_label.Visible = true; } else { username_error_label.Visible = false; }
            if (passwordtxtbox.Text == "") { password_error_label.Visible = true; } else { password_error_label.Visible = false; }
            if (phonetxtbox.Text == "") { phone_error_label.Visible = true; } else { phone_error_label.Visible = false; }
            if (emailtxtbox.Text == "") { Emailerror_label.Visible = true; } else { Emailerror_label.Visible = false; }
            if (status_dropdown.SelectedIndex == -1) { statusError_label.Visible = true; } else { statusError_label.Visible = false; }

            if (name_error_label.Visible || phone_error_label.Visible || username_error_label.Visible || Emailerror_label.Visible || password_error_label.Visible || statusError_label.Visible)
            {
                MainClass.showMsg("Fields with * are mandatory!", "Error", "Error");
            }
            else
            {   

                if (status_dropdown.SelectedIndex == 0)
                {
                    status = 1;
                }
                else if (status_dropdown.SelectedIndex == 1)
                {
                    status = 0;
                }

                if (edit == 0) //save operation
                {
                    insertion i = new insertion();

                    i.insertuser(nametxtbox.Text, usernametxtbox.Text, passwordtxtbox.Text, emailtxtbox.Text, phonetxtbox.Text, status);
                    r.showuser(dataGridView1, userID_GV, Name_GV, username_GV, PasswordGV, Email_GV, Phone_GV, Status_GV);
                }
                else if (edit == 1) // code for updating !
                {
                    updation u = new updation();
                    u.updateuser(userID, nametxtbox.Text, usernametxtbox.Text, passwordtxtbox.Text, emailtxtbox.Text, phonetxtbox.Text,status);
                    r.showuser(dataGridView1, userID_GV, Name_GV, username_GV, PasswordGV, Email_GV, Phone_GV, Status_GV);

                }
            }

        }

        public override void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        public override void ViewBTN_Click(object sender, EventArgs e)
        {
            r.showuser(dataGridView1, userID_GV, Name_GV, username_GV, PasswordGV, Email_GV, Phone_GV, Status_GV);

        }

        public override void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void status_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != 1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userID = Convert.ToInt32(row.Cells["userID_GV"].Value.ToString());
                nametxtbox.Text = row.Cells["Name_GV"].Value.ToString();
                usernametxtbox.Text = row.Cells["username_GV"].Value.ToString();
                passwordtxtbox.Text = row.Cells["PasswordGV"].Value.ToString();
                phonetxtbox.Text = row.Cells["Phone_GV"].Value.ToString();
                emailtxtbox.Text = row.Cells["Email_GV"].Value.ToString();
                status_dropdown.SelectedItem = row.Cells["Status_GV"].Value.ToString();
                MainClass.disable(LeftPanel);
            }
        }
    }
}
