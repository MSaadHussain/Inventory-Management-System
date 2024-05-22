using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.Logging;

namespace IMS
{
    public partial class settings : Sample
    {

        public settings()
        {
            InitializeComponent();
        }

        private void LeftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (security_checkBox.Checked)
                {
                username_textbox_db.Enabled = false;
                password_textbox_db.Enabled = false;
                username_textbox_db.Text = "";
                password_textbox_db.Text = "";
                }
            else
            {
                username_textbox_db.Enabled = true;
                password_textbox_db.Enabled = true;
            }
        }

        private void server_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Database_Save_button_Click(object sender, EventArgs e)
        {
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (security_checkBox.Checked)
            {
                if(server_text.Text != "" && db_text.Text != "")
                {
                    s = "Data Source=" + server_text.Text + ";Ïnitial Catalog=" + db_text.Text + ";Integrated Security=True;";
                    File.WriteAllText(path+"\\connect", s);
                }
                else
                {
                    MessageBox.Show("Please Fill Required Data","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                if(server_text.Text !="" && db_text.Text != "" && username_textbox_db.Text != "" && password_textbox_db.Text != "")
                {
                    s = "Data Source=" + server_text.Text + ";Ïnitial Catalog=" + db_text.Text + ";User ID="+username_textbox_db.Text+";Password="+password_textbox_db.Text+";";
                    File.WriteAllText(path + "\\connect", s);
                    

                }
                else
                {
                    MessageBox.Show("Please Fill Required Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            DialogResult dr = MessageBox.Show("Database Settings Saved!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if(dr == DialogResult.OK)
            {
                login log = new login();
                MainClass.ShowWindow(log,this,MDI.ActiveForm);
            }
        }

    }
}
