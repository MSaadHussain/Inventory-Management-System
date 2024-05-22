using System.IO;


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
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if(File.Exists(Path+"\\connect"))
            {
            login log = new login();
            MainClass.ShowWindow(log,this);
            }
            settings set = new settings();
            MainClass.ShowWindow(set,this);

        }
    }
}
