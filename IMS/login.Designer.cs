namespace IMS
{
    partial class login
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
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            LeftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.Controls.Add(button1);
            LeftPanel.Controls.Add(textBox2);
            LeftPanel.Controls.Add(label4);
            LeftPanel.Controls.Add(textBox1);
            LeftPanel.Controls.Add(label3);
            LeftPanel.Size = new Size(200, 450);
            LeftPanel.Controls.SetChildIndex(label3, 0);
            LeftPanel.Controls.SetChildIndex(textBox1, 0);
            LeftPanel.Controls.SetChildIndex(label4, 0);
            LeftPanel.Controls.SetChildIndex(textBox2, 0);
            LeftPanel.Controls.SetChildIndex(button1, 0);
            // 
            // RightPanel
            // 
            RightPanel.Size = new Size(600, 450);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 79);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 1;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 97);
            textBox1.MaxLength = 30;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 127);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 146);
            textBox2.MaxLength = 30;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 23);
            textBox2.TabIndex = 4;
            textBox2.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(16, 190);
            button1.Name = "button1";
            button1.Size = new Size(166, 27);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "login";
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
    }
}