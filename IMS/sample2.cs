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
    public partial class sample2 : Sample
    {
        public sample2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            homescreen obj = new homescreen();
            MainClass.ShowWindow(obj, this, MDI.ActiveForm);

        }

        public virtual void AddButton_Click(object sender, EventArgs e)
        {

        }

        public virtual void EditButton_Click(object sender, EventArgs e)
        {

        }

        public virtual void SaveButton_Click(object sender, EventArgs e)
        {

        }

        public virtual void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        public virtual void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public virtual void ViewBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
