using Gotal_manager.Inputs.Storage.SelectStorageProizvod;
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
        public string naziv { get; set; }

        public SelectProductUserControl()
        {
            InitializeComponent();
            naziv = "";
        }
        public SelectProductUserControl(int id, int broj, string naziv, double cijena)
        {
            InitializeComponent();
            this.id = id;
            this.naziv = naziv;
            labelBroj.Text = broj.ToString();
            labelNaziv.Text = naziv;
            labelCijena.Text = cijena.ToString();


        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                SelectProductForm selectProductForm = Form.ActiveForm as SelectProductForm;
                if (selectProductForm != null)
                {
                    selectProductForm.selected_control_id = id;
                    selectProductForm.Close();
                }
                SelectStorageProizvodForm selectStorageProizvodForm = Form.ActiveForm as SelectStorageProizvodForm;
                if (selectStorageProizvodForm != null)
                {
                    selectStorageProizvodForm.selected_control_id =  id;
                    selectStorageProizvodForm.Close();
                }
            }
            catch
            {

            }
        }
    }
}
