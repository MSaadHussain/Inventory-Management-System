namespace IMS
{
    partial class settings
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
            label3 = new Label();
            server_text = new TextBox();
            db_text = new TextBox();
            database_label = new Label();
            password_textbox_db = new TextBox();
            password_text = new Label();
            username_textbox_db = new TextBox();
            user_text = new Label();
            security_checkBox = new CheckBox();
            Database_Save_button = new Button();
            LeftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.Controls.Add(Database_Save_button);
            LeftPanel.Controls.Add(security_checkBox);
            LeftPanel.Controls.Add(password_textbox_db);
            LeftPanel.Controls.Add(password_text);
            LeftPanel.Controls.Add(username_textbox_db);
            LeftPanel.Controls.Add(user_text);
            LeftPanel.Controls.Add(db_text);
            LeftPanel.Controls.Add(database_label);
            LeftPanel.Controls.Add(server_text);
            LeftPanel.Controls.Add(label3);
            LeftPanel.Size = new Size(200, 474);
            LeftPanel.Paint += LeftPanel_Paint;
            LeftPanel.Controls.SetChildIndex(label3, 0);
            LeftPanel.Controls.SetChildIndex(server_text, 0);
            LeftPanel.Controls.SetChildIndex(database_label, 0);
            LeftPanel.Controls.SetChildIndex(db_text, 0);
            LeftPanel.Controls.SetChildIndex(user_text, 0);
            LeftPanel.Controls.SetChildIndex(username_textbox_db, 0);
            LeftPanel.Controls.SetChildIndex(password_text, 0);
            LeftPanel.Controls.SetChildIndex(password_textbox_db, 0);
            LeftPanel.Controls.SetChildIndex(security_checkBox, 0);
            LeftPanel.Controls.SetChildIndex(Database_Save_button, 0);
            // 
            // RightPanel
            // 
            RightPanel.Size = new Size(655, 474);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 116);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 1;
            label3.Text = "Server";
            // 
            // server_text
            // 
            server_text.Location = new Point(14, 134);
            server_text.MaxLength = 50;
            server_text.Name = "server_text";
            server_text.Size = new Size(167, 23);
            server_text.TabIndex = 2;
            server_text.TextChanged += server_text_TextChanged;
            // 
            // db_text
            // 
            db_text.Location = new Point(14, 178);
            db_text.MaxLength = 50;
            db_text.Name = "db_text";
            db_text.Size = new Size(167, 23);
            db_text.TabIndex = 4;
            // 
            // database_label
            // 
            database_label.AutoSize = true;
            database_label.Location = new Point(14, 160);
            database_label.Name = "database_label";
            database_label.Size = new Size(55, 15);
            database_label.TabIndex = 3;
            database_label.Text = "Database";
            // 
            // password_textbox_db
            // 
            password_textbox_db.Location = new Point(14, 271);
            password_textbox_db.MaxLength = 50;
            password_textbox_db.Name = "password_textbox_db";
            password_textbox_db.Size = new Size(167, 23);
            password_textbox_db.TabIndex = 8;
            password_textbox_db.UseSystemPasswordChar = true;
            // 
            // password_text
            // 
            password_text.AutoSize = true;
            password_text.Location = new Point(14, 253);
            password_text.Name = "password_text";
            password_text.Size = new Size(57, 15);
            password_text.TabIndex = 7;
            password_text.Text = "Password";
            // 
            // username_textbox_db
            // 
            username_textbox_db.Location = new Point(14, 227);
            username_textbox_db.MaxLength = 50;
            username_textbox_db.Name = "username_textbox_db";
            username_textbox_db.Size = new Size(167, 23);
            username_textbox_db.TabIndex = 6;
            // 
            // user_text
            // 
            user_text.AutoSize = true;
            user_text.Location = new Point(14, 209);
            user_text.Name = "user_text";
            user_text.Size = new Size(60, 15);
            user_text.TabIndex = 5;
            user_text.Text = "Username";
            // 
            // security_checkBox
            // 
            security_checkBox.AutoSize = true;
            security_checkBox.Location = new Point(18, 305);
            security_checkBox.Name = "security_checkBox";
            security_checkBox.Size = new Size(120, 19);
            security_checkBox.TabIndex = 9;
            security_checkBox.Text = "Windows Security";
            security_checkBox.UseVisualStyleBackColor = true;
            security_checkBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Database_Save_button
            // 
            Database_Save_button.FlatStyle = FlatStyle.Flat;
            Database_Save_button.Location = new Point(14, 330);
            Database_Save_button.Name = "Database_Save_button";
            Database_Save_button.Size = new Size(167, 30);
            Database_Save_button.TabIndex = 10;
            Database_Save_button.Text = "Save";
            Database_Save_button.UseVisualStyleBackColor = true;
            Database_Save_button.Click += Database_Save_button_Click;
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 474);
            Name = "settings";
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Database_Save_button;
        private CheckBox security_checkBox;
        private TextBox password_textbox_db;
        private Label password_text;
        private TextBox username_textbox_db;
        private Label user_text;
        private TextBox db_text;
        private Label database_label;
        private TextBox server_text;
        private Label label3;
    }
}