using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotal_manager.Inputs.Storage.SelectStorageProizvod
{
    public partial class SelectStorageProizvodForm : Form
    {


        public int selected_product_index { get; set; }
        public SelectStorageProizvodForm()
        {
            InitializeComponent();
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
            string sql = "SELECT * FROM primke-stavke WHERE Arhivirano=0 ORDER BY BrojProizvoda ASC;";
            MySqlCommand command = new MySqlCommand(sql, DatabaseManager.Connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("ProizvodID");
                int productNumber = reader.GetInt32("BrojProizvoda");
                string name = reader.GetString("Naziv");
                double enterPrice = reader.GetDouble("UlaznaCijena");
                double tax = reader.GetDouble("Porez");
                SelectProductUserControl userControl = new SelectProductUserControl(id, productNumber, name, enterPrice);
                flowLayoutPanel1.Controls.Add(userControl);
            }
            reader.Close();

        }

        private void SelectStorageProizvodForm_SizeChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Size = new System.Drawing.Size(541, Size.Height - 86);
        }
    }

}
