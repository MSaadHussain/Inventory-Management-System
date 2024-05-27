using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class Users : sample2
    {
        int edit = 0; //  0 - indication to save operation  , 1 - indication to update
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

        }

        public override void SaveButton_Click(object sender, EventArgs e)
        {
            if(nametxtbox.Text == "") { name_error_label.Visible = true; } else { name_error_label.Visible = false; }
            if(usernametxtbox.Text == "") { username_error_label.Visible = true;  } else {  username_error_label.Visible = false; }
            if (passwordtxtbox.Text == "") { password_error_label.Visible = true; } else { password_error_label.Visible = false; }
            if (phonetxtbox.Text == "") { phone_error_label.Visible = true; } else { phone_error_label.Visible = false; }
            if (emailtxtbox.Text == "") { Emailerror_label.Visible = true; } else {  Emailerror_label.Visible = false; }

            if ( name_error_label.Visible || phone_error_label.Visible || username_error_label.Visible || Emailerror_label.Visible || password_error_label.Visible)
            {
                MainClass.showMsg("Fields with * are mandatory!","Error","Error");
            }
            else
            {
                if (edit == 0) //save operation
                {

                }
                else if(edit == 1) // code for updating !
                {

                }
            }

        }

        public override void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        public override void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
