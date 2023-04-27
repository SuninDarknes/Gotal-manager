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
    }
}