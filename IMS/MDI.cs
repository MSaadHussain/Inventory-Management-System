namespace IMS
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string path = "C:\\Users\\muham\\Documents\\connect.cfg";
            if (File.Exists(path))
            {
                login log = new login();
                MainClass.ShowWindow(log, this);
            }
            else
            {
                settings set = new settings();
                MainClass.ShowWindow(set, this);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings set = new settings();
            MainClass.ShowWindow(set, this);
        }
    }
}
