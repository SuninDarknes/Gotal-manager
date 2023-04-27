namespace Gotal_manager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonStartCijenik_Click(object sender, EventArgs e)
        {
            ProductsForm pf = new ProductsForm();
            pf.ShowDialog();
        }

        private void buttonStartSkladiste_Click(object sender, EventArgs e)
        {
            StorageForm sf = new StorageForm();
            sf.ShowDialog();
        }

        private void buttonStartDobavljaci_Click(object sender, EventArgs e)
        {
            DobavljaciForm df=new DobavljaciForm();
            df.ShowDialog();
        }

        private void buttonStartKupci_Click(object sender, EventArgs e)
        {
            ClientForm cf = new ClientForm();
            cf.ShowDialog();
        }
    }
}