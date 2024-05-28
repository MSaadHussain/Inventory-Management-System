namespace IMS
{
    partial class sample2
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
            tableLayoutPanel1 = new TableLayoutPanel();
            DeleteButton = new Button();
            SaveButton = new Button();
            EditButton = new Button();
            AddButton = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            ViewBTN = new Button();
            LeftPanel.SuspendLayout();
            RightPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.Controls.Add(button1);
            LeftPanel.Controls.Add(panel1);
            LeftPanel.Size = new Size(200, 569);
            LeftPanel.Controls.SetChildIndex(panel1, 0);
            LeftPanel.Controls.SetChildIndex(button1, 0);
            // 
            // RightPanel
            // 
            RightPanel.Controls.Add(tableLayoutPanel1);
            RightPanel.Size = new Size(803, 569);
            RightPanel.Controls.SetChildIndex(tableLayoutPanel1, 0);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.1523514F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.1523476F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.1523476F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.1523476F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.3906116F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
            tableLayoutPanel1.Controls.Add(DeleteButton, 3, 0);
            tableLayoutPanel1.Controls.Add(SaveButton, 2, 0);
            tableLayoutPanel1.Controls.Add(EditButton, 1, 0);
            tableLayoutPanel1.Controls.Add(AddButton, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 5, 0);
            tableLayoutPanel1.Controls.Add(ViewBTN, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 78);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(803, 46);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // DeleteButton
            // 
            DeleteButton.Cursor = Cursors.Hand;
            DeleteButton.Dock = DockStyle.Fill;
            DeleteButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.Location = new Point(405, 3);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(128, 40);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.Dock = DockStyle.Fill;
            SaveButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(271, 3);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(128, 40);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // EditButton
            // 
            EditButton.Cursor = Cursors.Hand;
            EditButton.Dock = DockStyle.Fill;
            EditButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditButton.Location = new Point(137, 3);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(128, 40);
            EditButton.TabIndex = 1;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            AddButton.Cursor = Cursors.Hand;
            AddButton.Dock = DockStyle.Fill;
            AddButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(128, 40);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(668, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(132, 40);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 20);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 46);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 530);
            button1.Name = "button1";
            button1.Size = new Size(119, 27);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ViewBTN
            // 
            ViewBTN.Cursor = Cursors.Hand;
            ViewBTN.Dock = DockStyle.Fill;
            ViewBTN.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewBTN.Location = new Point(539, 3);
            ViewBTN.Name = "ViewBTN";
            ViewBTN.Size = new Size(123, 40);
            ViewBTN.TabIndex = 6;
            ViewBTN.Text = "View";
            ViewBTN.UseVisualStyleBackColor = true;
            ViewBTN.Click += ViewBTN_Click;
            // 
            // sample2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 569);
            Name = "sample2";
            LeftPanel.ResumeLayout(false);
            RightPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button AddButton;
        private Button DeleteButton;
        private Button SaveButton;
        private Button EditButton;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Panel panel1;
        private Button button1;
        private Button ViewBTN;
    }
}