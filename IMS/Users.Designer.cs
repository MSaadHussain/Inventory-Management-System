namespace IMS
{
    partial class Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nametxtbox = new TextBox();
            phonetxtbox = new TextBox();
            emailtxtbox = new TextBox();
            passwordtxtbox = new TextBox();
            usernametxtbox = new TextBox();
            username_label = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            name_error_label = new Label();
            phone_error_label = new Label();
            password_error_label = new Label();
            username_error_label = new Label();
            Emailerror_label = new Label();
            LeftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.Controls.Add(Emailerror_label);
            LeftPanel.Controls.Add(username_error_label);
            LeftPanel.Controls.Add(password_error_label);
            LeftPanel.Controls.Add(phone_error_label);
            LeftPanel.Controls.Add(name_error_label);
            LeftPanel.Controls.Add(panel2);
            LeftPanel.Controls.Add(label7);
            LeftPanel.Controls.Add(label6);
            LeftPanel.Controls.Add(label5);
            LeftPanel.Controls.Add(label4);
            LeftPanel.Controls.Add(label3);
            LeftPanel.Controls.Add(username_label);
            LeftPanel.Controls.Add(usernametxtbox);
            LeftPanel.Controls.Add(passwordtxtbox);
            LeftPanel.Controls.Add(emailtxtbox);
            LeftPanel.Controls.Add(phonetxtbox);
            LeftPanel.Controls.Add(nametxtbox);
            LeftPanel.Size = new Size(200, 566);
            LeftPanel.Controls.SetChildIndex(nametxtbox, 0);
            LeftPanel.Controls.SetChildIndex(phonetxtbox, 0);
            LeftPanel.Controls.SetChildIndex(emailtxtbox, 0);
            LeftPanel.Controls.SetChildIndex(passwordtxtbox, 0);
            LeftPanel.Controls.SetChildIndex(usernametxtbox, 0);
            LeftPanel.Controls.SetChildIndex(username_label, 0);
            LeftPanel.Controls.SetChildIndex(label3, 0);
            LeftPanel.Controls.SetChildIndex(label4, 0);
            LeftPanel.Controls.SetChildIndex(label5, 0);
            LeftPanel.Controls.SetChildIndex(label6, 0);
            LeftPanel.Controls.SetChildIndex(label7, 0);
            LeftPanel.Controls.SetChildIndex(panel2, 0);
            LeftPanel.Controls.SetChildIndex(name_error_label, 0);
            LeftPanel.Controls.SetChildIndex(phone_error_label, 0);
            LeftPanel.Controls.SetChildIndex(password_error_label, 0);
            LeftPanel.Controls.SetChildIndex(username_error_label, 0);
            LeftPanel.Controls.SetChildIndex(Emailerror_label, 0);
            // 
            // RightPanel
            // 
            RightPanel.Size = new Size(739, 566);
            // 
            // nametxtbox
            // 
            nametxtbox.BorderStyle = BorderStyle.FixedSingle;
            nametxtbox.Location = new Point(12, 179);
            nametxtbox.MaxLength = 20;
            nametxtbox.Name = "nametxtbox";
            nametxtbox.Size = new Size(172, 23);
            nametxtbox.TabIndex = 2;
            nametxtbox.TextChanged += textBox2_TextChanged;
            // 
            // phonetxtbox
            // 
            phonetxtbox.BorderStyle = BorderStyle.FixedSingle;
            phonetxtbox.Location = new Point(12, 319);
            phonetxtbox.MaxLength = 20;
            phonetxtbox.Name = "phonetxtbox";
            phonetxtbox.Size = new Size(172, 23);
            phonetxtbox.TabIndex = 3;
            // 
            // emailtxtbox
            // 
            emailtxtbox.BorderStyle = BorderStyle.FixedSingle;
            emailtxtbox.Location = new Point(12, 365);
            emailtxtbox.MaxLength = 20;
            emailtxtbox.Name = "emailtxtbox";
            emailtxtbox.Size = new Size(172, 23);
            emailtxtbox.TabIndex = 4;
            // 
            // passwordtxtbox
            // 
            passwordtxtbox.BorderStyle = BorderStyle.FixedSingle;
            passwordtxtbox.Location = new Point(12, 273);
            passwordtxtbox.MaxLength = 20;
            passwordtxtbox.Name = "passwordtxtbox";
            passwordtxtbox.Size = new Size(172, 23);
            passwordtxtbox.TabIndex = 5;
            passwordtxtbox.UseSystemPasswordChar = true;
            // 
            // usernametxtbox
            // 
            usernametxtbox.BorderStyle = BorderStyle.FixedSingle;
            usernametxtbox.Location = new Point(12, 227);
            usernametxtbox.MaxLength = 20;
            usernametxtbox.Name = "usernametxtbox";
            usernametxtbox.Size = new Size(172, 23);
            usernametxtbox.TabIndex = 6;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username_label.Location = new Point(12, 159);
            username_label.Name = "username_label";
            username_label.Size = new Size(44, 17);
            username_label.TabIndex = 7;
            username_label.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 253);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 205);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 9;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 345);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 10;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 299);
            label6.Name = "label6";
            label6.Size = new Size(73, 17);
            label6.TabIndex = 11;
            label6.Text = "Phone No.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 253);
            label7.Name = "label7";
            label7.Size = new Size(66, 17);
            label7.TabIndex = 12;
            label7.Text = "Password";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 23);
            panel2.TabIndex = 2;
            // 
            // name_error_label
            // 
            name_error_label.AutoSize = true;
            name_error_label.ForeColor = Color.Red;
            name_error_label.Location = new Point(61, 161);
            name_error_label.Name = "name_error_label";
            name_error_label.Size = new Size(12, 15);
            name_error_label.TabIndex = 13;
            name_error_label.Text = "*";
            name_error_label.Visible = false;
            // 
            // phone_error_label
            // 
            phone_error_label.AutoSize = true;
            phone_error_label.ForeColor = Color.Red;
            phone_error_label.Location = new Point(81, 298);
            phone_error_label.Name = "phone_error_label";
            phone_error_label.Size = new Size(12, 15);
            phone_error_label.TabIndex = 14;
            phone_error_label.Text = "*";
            phone_error_label.Visible = false;
            // 
            // password_error_label
            // 
            password_error_label.AutoSize = true;
            password_error_label.ForeColor = Color.Red;
            password_error_label.Location = new Point(83, 253);
            password_error_label.Name = "password_error_label";
            password_error_label.Size = new Size(12, 15);
            password_error_label.TabIndex = 15;
            password_error_label.Text = "*";
            password_error_label.Visible = false;
            // 
            // username_error_label
            // 
            username_error_label.AutoSize = true;
            username_error_label.ForeColor = Color.Red;
            username_error_label.Location = new Point(83, 209);
            username_error_label.Name = "username_error_label";
            username_error_label.Size = new Size(12, 15);
            username_error_label.TabIndex = 16;
            username_error_label.Text = "*";
            username_error_label.Visible = false;
            // 
            // Emailerror_label
            // 
            Emailerror_label.AutoSize = true;
            Emailerror_label.ForeColor = Color.Red;
            Emailerror_label.Location = new Point(49, 346);
            Emailerror_label.Name = "Emailerror_label";
            Emailerror_label.Size = new Size(12, 15);
            Emailerror_label.TabIndex = 17;
            Emailerror_label.Text = "*";
            Emailerror_label.Visible = false;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 566);
            Name = "Users";
            Load += Users_Load;
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox nametxtbox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label username_label;
        private TextBox usernametxtbox;
        private TextBox passwordtxtbox;
        private TextBox emailtxtbox;
        private TextBox phonetxtbox;
        private Panel panel2;
        private Label Emailerror_label;
        private Label username_error_label;
        private Label password_error_label;
        private Label phone_error_label;
        private Label name_error_label;
    }
}