namespace IMS
{
    partial class Sample
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
            LeftPanel = new Panel();
            LeftTopPanel = new Panel();
            label1 = new Label();
            RightPanel = new Panel();
            RightTopPanel = new Panel();
            label2 = new Label();
            LeftPanel.SuspendLayout();
            LeftTopPanel.SuspendLayout();
            RightPanel.SuspendLayout();
            RightTopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.SteelBlue;
            LeftPanel.Controls.Add(LeftTopPanel);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.ForeColor = Color.White;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(200, 622);
            LeftPanel.TabIndex = 0;
            // 
            // LeftTopPanel
            // 
            LeftTopPanel.Controls.Add(label1);
            LeftTopPanel.Dock = DockStyle.Top;
            LeftTopPanel.Location = new Point(0, 0);
            LeftTopPanel.Name = "LeftTopPanel";
            LeftTopPanel.Size = new Size(200, 78);
            LeftTopPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 78);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // RightPanel
            // 
            RightPanel.BackColor = Color.FromArgb(237, 237, 237);
            RightPanel.Controls.Add(RightTopPanel);
            RightPanel.Dock = DockStyle.Fill;
            RightPanel.Font = new Font("Microsoft Sans Serif", 8.25F);
            RightPanel.Location = new Point(200, 0);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(924, 622);
            RightPanel.TabIndex = 1;
            // 
            // RightTopPanel
            // 
            RightTopPanel.Controls.Add(label2);
            RightTopPanel.Dock = DockStyle.Top;
            RightTopPanel.Location = new Point(0, 0);
            RightTopPanel.Name = "RightTopPanel";
            RightTopPanel.Size = new Size(924, 78);
            RightTopPanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 78);
            label2.TabIndex = 1;
            label2.Text = "USER";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Sample
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 622);
            ControlBox = false;
            Controls.Add(RightPanel);
            Controls.Add(LeftPanel);
            Name = "Sample";
            LeftPanel.ResumeLayout(false);
            LeftTopPanel.ResumeLayout(false);
            RightPanel.ResumeLayout(false);
            RightTopPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        protected Panel LeftPanel;
        private Panel LeftTopPanel;
        private Panel RightPanel;
        private Panel RightTopPanel;
        private Label label1;
        private Label label2;
    }
}