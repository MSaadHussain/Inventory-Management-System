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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            username_label = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            LeftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.Controls.Add(label7);
            LeftPanel.Controls.Add(label6);
            LeftPanel.Controls.Add(label5);
            LeftPanel.Controls.Add(label4);
            LeftPanel.Controls.Add(label3);
            LeftPanel.Controls.Add(username_label);
            LeftPanel.Controls.Add(textBox6);
            LeftPanel.Controls.Add(textBox5);
            LeftPanel.Controls.Add(textBox4);
            LeftPanel.Controls.Add(textBox3);
            LeftPanel.Controls.Add(textBox2);
            LeftPanel.Size = new Size(200, 566);
            LeftPanel.Controls.SetChildIndex(textBox2, 0);
            LeftPanel.Controls.SetChildIndex(textBox3, 0);
            LeftPanel.Controls.SetChildIndex(textBox4, 0);
            LeftPanel.Controls.SetChildIndex(textBox5, 0);
            LeftPanel.Controls.SetChildIndex(textBox6, 0);
            LeftPanel.Controls.SetChildIndex(username_label, 0);
            LeftPanel.Controls.SetChildIndex(label3, 0);
            LeftPanel.Controls.SetChildIndex(label4, 0);
            LeftPanel.Controls.SetChildIndex(label5, 0);
            LeftPanel.Controls.SetChildIndex(label6, 0);
            LeftPanel.Controls.SetChildIndex(label7, 0);
            // 
            // RightPanel
            // 
            RightPanel.Size = new Size(739, 566);
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(12, 179);
            textBox2.MaxLength = 20;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(12, 319);
            textBox3.MaxLength = 20;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(12, 365);
            textBox4.MaxLength = 20;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(12, 273);
            textBox5.MaxLength = 20;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(172, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(12, 227);
            textBox6.MaxLength = 20;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(172, 23);
            textBox6.TabIndex = 6;
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

        private TextBox textBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label username_label;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
    }
}