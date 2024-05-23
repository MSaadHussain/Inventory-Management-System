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
            MainClass.ShowWindow(obj,this,MDI.ActiveForm);

        }
    }
}
