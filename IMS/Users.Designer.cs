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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            dataGridView1 = new DataGridView();
            userID_GV = new DataGridViewTextBoxColumn();
            Name_GV = new DataGridViewTextBoxColumn();
            username_GV = new DataGridViewTextBoxColumn();
            PasswordGV = new DataGridViewTextBoxColumn();
            Email_GV = new DataGridViewTextBoxColumn();
            Phone_GV = new DataGridViewTextBoxColumn();
            Status_GV = new DataGridViewTextBoxColumn();
            label8 = new Label();
            status_dropdown = new ComboBox();
            statusError_label = new Label();
            LeftPanel.SuspendLayout();
            RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.Controls.Add(statusError_label);
            LeftPanel.Controls.Add(status_dropdown);
            LeftPanel.Controls.Add(label8);
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
            LeftPanel.Controls.SetChildIndex(label8, 0);
            LeftPanel.Controls.SetChildIndex(status_dropdown, 0);
            LeftPanel.Controls.SetChildIndex(statusError_label, 0);
            // 
            // RightPanel
            // 
            RightPanel.Controls.Add(dataGridView1);
            RightPanel.Size = new Size(739, 566);
            RightPanel.Controls.SetChildIndex(dataGridView1, 0);
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
            label5.Location = new Point(12, 346);
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { userID_GV, Name_GV, username_GV, PasswordGV, Email_GV, Phone_GV, Status_GV });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(739, 442);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // userID_GV
            // 
            userID_GV.HeaderText = "User ID";
            userID_GV.Name = "userID_GV";
            userID_GV.ReadOnly = true;
            userID_GV.Visible = false;
            // 
            // Name_GV
            // 
            Name_GV.HeaderText = "Name";
            Name_GV.Name = "Name_GV";
            Name_GV.ReadOnly = true;
            // 
            // username_GV
            // 
            username_GV.HeaderText = "Username";
            username_GV.Name = "username_GV";
            username_GV.ReadOnly = true;
            // 
            // PasswordGV
            // 
            PasswordGV.HeaderText = "Password";
            PasswordGV.Name = "PasswordGV";
            PasswordGV.ReadOnly = true;
            PasswordGV.Visible = false;
            // 
            // Email_GV
            // 
            Email_GV.HeaderText = "Email";
            Email_GV.Name = "Email_GV";
            Email_GV.ReadOnly = true;
            // 
            // Phone_GV
            // 
            Phone_GV.HeaderText = "Phone No.";
            Phone_GV.Name = "Phone_GV";
            Phone_GV.ReadOnly = true;
            // 
            // Status_GV
            // 
            Status_GV.HeaderText = "Status";
            Status_GV.Name = "Status_GV";
            Status_GV.ReadOnly = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 391);
            label8.Name = "label8";
            label8.Size = new Size(46, 17);
            label8.TabIndex = 18;
            label8.Text = "Status";
            label8.Click += label8_Click;
            // 
            // status_dropdown
            // 
            status_dropdown.FormattingEnabled = true;
            status_dropdown.Items.AddRange(new object[] { "Active", "In-active" });
            status_dropdown.Location = new Point(12, 411);
            status_dropdown.Name = "status_dropdown";
            status_dropdown.Size = new Size(172, 23);
            status_dropdown.TabIndex = 19;
            status_dropdown.SelectedIndexChanged += status_dropdown_SelectedIndexChanged;
            // 
            // statusError_label
            // 
            statusError_label.AutoSize = true;
            statusError_label.ForeColor = Color.Red;
            statusError_label.Location = new Point(55, 393);
            statusError_label.Name = "statusError_label";
            statusError_label.Size = new Size(12, 15);
            statusError_label.TabIndex = 20;
            statusError_label.Text = "*";
            statusError_label.Visible = false;
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
            RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn userID_GV;
        private DataGridViewTextBoxColumn Name_GV;
        private DataGridViewTextBoxColumn username_GV;
        private DataGridViewTextBoxColumn PasswordGV;
        private DataGridViewTextBoxColumn Email_GV;
        private DataGridViewTextBoxColumn Phone_GV;
        private DataGridViewTextBoxColumn Status_GV;
        private Label label8;
        private ComboBox status_dropdown;
        private Label statusError_label;
    }
}