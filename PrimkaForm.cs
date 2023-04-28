using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gotal_manager
{
    public partial class PrimkaForm : Form
    {
        List<string> autoWords = new List<string>();
        List<int> autoWordsIDs = new List<int>();
        List<StorageProductControlUserControl> productUserControls = new List<StorageProductControlUserControl>();
        public PrimkaForm()
        {
            InitializeComponent();
        }

        private void PrimkaForm_Load(object sender, EventArgs e)
        {
            dopuniDobavljačaToolStripMenuItem.Checked = Properties.Settings.Default.PrimkaForm_DobavljacAuto;

            try
            {
                string sql = "SELECT * FROM deliverer WHERE Arhivirano=0 ORDER BY DobavljacID ASC;";
                MySqlCommand command = new MySqlCommand(sql, DatabaseManager.Connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    autoWordsIDs.Add(reader.GetInt32("DobavljacID"));
                    autoWords.Add(reader.GetString("Naziv"));

                }
                reader.Close();

                AutoCompleteStringCollection acs = new AutoCompleteStringCollection();
                acs.AddRange(autoWords.ToArray());
                textBoxDobavljac.AutoCompleteCustomSource = acs;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška kod učitavanja dobavljača", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBoxDobavljac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Properties.Settings.Default.PrimkaForm_DobavljacAuto)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != ' '))
                {
                    e.Handled = true;
                    return;
                }
                string currentText = textBoxDobavljac.Text;

                if (!char.IsControl(e.KeyChar))
                {
                    currentText += e.KeyChar;
                }

                bool foundMatch = false;
                foreach (string value in autoWords)
                {
                    if (value.StartsWith(currentText, StringComparison.OrdinalIgnoreCase))
                    {
                        foundMatch = true;
                        break;
                    }
                }

                if (!foundMatch)
                {
                    e.Handled = true;
                }
            }
        }

        private void dopuniDobavljačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PrimkaForm_DobavljacAuto = !Properties.Settings.Default.PrimkaForm_DobavljacAuto;
            dopuniDobavljačaToolStripMenuItem.Checked = Properties.Settings.Default.PrimkaForm_DobavljacAuto;
            Properties.Settings.Default.Save();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            int ProductID = 0;

            using (SelectProductForm selectProductForm = new SelectProductForm())
            {
                DialogResult result = selectProductForm.ShowDialog();

                    ProductID = selectProductForm.selected_product_id;
                
            }
            try
            {
                string query = "SELECT * FROM products WHERE ProizvodID = @id";
                using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
                {
                    command.Parameters.AddWithValue("@id", ProductID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int broj = reader.GetInt32("BrojProizvoda");
                            string naziv = reader.GetString("Naziv");
                            double cijena = reader.GetDouble("UlaznaCijena");
                            double porez = reader.GetDouble("Porez");
                            StorageProductControlUserControl userControl =
                                new StorageProductControlUserControl(productUserControls.Count, ProductID, broj, naziv, cijena, porez );
                            MainFlowPanel.Controls.Add(userControl);
                            productUserControls.Add(userControl);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška kod učitavanja proizvoda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

    }
}
