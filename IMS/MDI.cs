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
            login log = new login();
            MainClass.ShowWindow(log,this);
        }
    }
}
