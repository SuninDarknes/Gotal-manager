using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotal_manager.Inputs.Storage.SelectStorageProizvod
{
    public partial class SelectStorageProizvodForm : Form
    {


        public int selected_control_id { get; set; }
        Dictionary<StorageData, int>? storageDatas;
        public SelectStorageProizvodForm()
        {
            InitializeComponent();
        }
        public SelectStorageProizvodForm(Dictionary<StorageData, int> storageDatas)
        {
            InitializeComponent();
            this.storageDatas = storageDatas;
        }

        private void SelectProductForm_SizeChanged(object sender, EventArgs e)
        {
            
        }


        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (SelectProductUserControl spuc in flowLayoutPanel1.Controls)
            {
                if (spuc.naziv.ToLower().Contains(textBoxSearch.Text.ToLower()) || textBoxSearch.Text == "")
                    spuc.Visible = true;
                else spuc.Visible = false;

            }
        }

        private void SelectStorageProizvodForm_Load(object sender, EventArgs e)
        {
            if (storageDatas == null) return;
            foreach(KeyValuePair<StorageData, int> entry in storageDatas)
            {
                int id = entry.Key.ID;
                int productNumber = entry.Key.ID;
                string name = entry.Key.naziv;
                double enterPrice = entry.Key.cijena;
                SelectProductUserControl userControl = new SelectProductUserControl(id, productNumber, name, enterPrice);
                flowLayoutPanel1.Controls.Add(userControl);
            }

        }

        private void SelectStorageProizvodForm_SizeChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Size = new System.Drawing.Size(541, Size.Height - 86);
        }
    }

}
