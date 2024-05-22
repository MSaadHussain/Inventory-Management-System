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
            textBox2 = new TextBox();
            database_text = new Label();
            textBox3 = new TextBox();
            password_text = new Label();
            textBox4 = new TextBox();
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
            LeftPanel.Controls.Add(textBox3);
            LeftPanel.Controls.Add(password_text);
            LeftPanel.Controls.Add(textBox4);
            LeftPanel.Controls.Add(user_text);
            LeftPanel.Controls.Add(textBox2);
            LeftPanel.Controls.Add(database_text);
            LeftPanel.Controls.Add(server_text);
            LeftPanel.Controls.Add(label3);
            LeftPanel.Size = new Size(200, 450);
            LeftPanel.Paint += LeftPanel_Paint;
            LeftPanel.Controls.SetChildIndex(label3, 0);
            LeftPanel.Controls.SetChildIndex(server_text, 0);
            LeftPanel.Controls.SetChildIndex(database_text, 0);
            LeftPanel.Controls.SetChildIndex(textBox2, 0);
            LeftPanel.Controls.SetChildIndex(user_text, 0);
            LeftPanel.Controls.SetChildIndex(textBox4, 0);
            LeftPanel.Controls.SetChildIndex(password_text, 0);
            LeftPanel.Controls.SetChildIndex(textBox3, 0);
            LeftPanel.Controls.SetChildIndex(security_checkBox, 0);
            LeftPanel.Controls.SetChildIndex(Database_Save_button, 0);
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
            // textBox2
            // 
            textBox2.Location = new Point(14, 178);
            textBox2.MaxLength = 50;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 23);
            textBox2.TabIndex = 4;
            // 
            // database_text
            // 
            database_text.AutoSize = true;
            database_text.Location = new Point(14, 160);
            database_text.Name = "database_text";
            database_text.Size = new Size(55, 15);
            database_text.TabIndex = 3;
            database_text.Text = "Database";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(14, 271);
            textBox3.MaxLength = 50;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(167, 23);
            textBox3.TabIndex = 8;
            textBox3.UseSystemPasswordChar = true;
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
            // textBox4
            // 
            textBox4.Location = new Point(14, 227);
            textBox4.MaxLength = 50;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(167, 23);
            textBox4.TabIndex = 6;
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
            security_checkBox.Size = new Size(61, 19);
            security_checkBox.TabIndex = 9;
            security_checkBox.Text = "Secure";
            security_checkBox.UseVisualStyleBackColor = true;
            security_checkBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Database_Save_button
            // 
            Database_Save_button.FlatStyle = FlatStyle.Flat;
            Database_Save_button.Location = new Point(14, 330);
            Database_Save_button.Name = "Database_Save_button";
            Database_Save_button.Size = new Size(167, 23);
            Database_Save_button.TabIndex = 10;
            Database_Save_button.Text = "Save";
            Database_Save_button.UseVisualStyleBackColor = true;
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "settings";
            Text = "settings";
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Database_Save_button;
        private CheckBox security_checkBox;
        private TextBox textBox3;
        private Label password_text;
        private TextBox textBox4;
        private Label user_text;
        private TextBox textBox2;
        private Label database_text;
        private TextBox server_text;
        private Label label3;
    }
}