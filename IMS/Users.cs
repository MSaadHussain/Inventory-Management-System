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
            MainClass.enable_reset(LeftPanel);
        }

        public override void EditButton_Click(object sender, EventArgs e)
        {

        }

        public override void SaveButton_Click(object sender, EventArgs e)
        {

        }

        public override void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        public override void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
