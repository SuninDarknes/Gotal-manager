using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotal_manager
{
    public partial class SelectProductUserControl : UserControl
    {
        int id;
        public SelectProductUserControl()
        {
            InitializeComponent();
        }
        public SelectProductUserControl(int id, int broj, string naziv, double cijena)
        {
            InitializeComponent();
            this.id = id;
            labelBroj.Text= broj.ToString();
            labelNaziv.Text = naziv;
            labelCijena.Text = cijena.ToString();


        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            try {
                SelectProductForm currForm = Form.ActiveForm as SelectProductForm;
                currForm.selected_product_id = id;
                currForm.Close();
                }
            catch
            {

            }
        }
    }
}
