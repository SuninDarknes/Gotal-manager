using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gotal_manager
{
    public partial class ProductsForm : Form
    {
        int length_rows = 0;
        List<ProductUserControl> productUserControls = new List<ProductUserControl>();
        public ProductsForm()
        {
            InitializeComponent();
            DobitLock.Appearance = Appearance.Button;
            DobitLock.Image = Properties.Resources.unlocked;
            IzlazLock.Appearance = Appearance.Button;
            IzlazLock.Image = Properties.Resources.locked;
            ProfitLock.Appearance = Appearance.Button;
            ProfitLock.Image = Properties.Resources.unlocked;

            automatskoRačunanjeToolStripMenuItem.Checked = Properties.Settings.Default.ProductsForm_AutoCaclulate;
            prikazujUpozorenjaToolStripMenuItem.Checked = Properties.Settings.Default.ProductsForm_ShowAlerts;


            string sql = "SELECT * FROM products WHERE Arhivirano=0 ORDER BY BrojProizvoda ASC;";
            MySqlCommand command = new MySqlCommand(sql, DatabaseManager.Connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("ProizvodID");
                int productNumber = reader.GetInt32("BrojProizvoda");
                string name = reader.GetString("Naziv");
                double enterPrice = reader.GetDouble("UlaznaCijena");
                double sellPrice = reader.GetDouble("IzlaznaCijena");
                double tax = reader.GetDouble("Porez");

                ProductUserControl userControl = new ProductUserControl(id, productNumber, name, enterPrice, sellPrice, tax);
                userControl.rbDobit = DobitLock;
                userControl.rbIzlazna = IzlazLock;
                userControl.rbProfit = ProfitLock;
                MainFlowPanel.Controls.Add(userControl);
                userControl.InitPrice();
                productUserControls.Add(userControl);
                length_rows++;

            }

            reader.Close();






            SmallErrorLabel.Text = "";
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                rb.Image = Properties.Resources.locked;
            }
            else
            {
                rb.Image = Properties.Resources.unlocked;
            }
        }

        private void ProductsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool unsavedChanges = false;
            foreach (ProductUserControl puc in productUserControls)
                if (puc.modified)
                {
                    unsavedChanges = true;
                    break;
                }
            if (unsavedChanges)
            {
                DialogResult result = MessageBox.Show("Spremi prije odlaska?", "Nespremljene Promjene", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if(!SaveChanges()) e.Cancel = true;

                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private bool SaveChanges()
        {
            try
            {
                foreach (ProductUserControl puc in productUserControls)
                {
                    if (!puc.modified) continue;
                    string query = "UPDATE products SET BrojProizvoda = @BrojProizvoda, Naziv = @Naziv, UlaznaCijena = @UlaznaCijena, IzlaznaCijena = @IzlaznaCijena, Porez = @Porez WHERE ProizvodID = @id";

                    using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
                    {
                        command.Parameters.AddWithValue("@BrojProizvoda", puc.productNum);
                        command.Parameters.AddWithValue("@Naziv", puc.naziv);
                        command.Parameters.AddWithValue("@UlaznaCijena", puc.ulaz);
                        command.Parameters.AddWithValue("@IzlaznaCijena", puc.izlaz);
                        command.Parameters.AddWithValue("@Porez", puc.tax);
                        command.Parameters.AddWithValue("@id", puc.id);

                        command.ExecuteNonQuery();
                        puc.afterSave();

                    }

                }
                return true;
            }
            catch {
                DialogResult result = MessageBox.Show("Greša pri spremanju! Provjeri valjanost svih zelenih redaka!", "Nespremljene Promjene", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        private void automatskoRačunanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ProductsForm_AutoCaclulate = !automatskoRačunanjeToolStripMenuItem.Checked;
            automatskoRačunanjeToolStripMenuItem.Checked = !automatskoRačunanjeToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();
        }

        private void prikazujUpozorenjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ProductsForm_ShowAlerts = !prikazujUpozorenjaToolStripMenuItem.Checked;
            prikazujUpozorenjaToolStripMenuItem.Checked = !prikazujUpozorenjaToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO products (BrojProizvoda,Naziv) VALUES (@BrojProizvoda, @Naziv)";

            using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
            {
                command.Parameters.AddWithValue("@BrojProizvoda", productUserControls.Count);
                command.Parameters.AddWithValue("@Naziv", "");

                command.ExecuteNonQuery();
            }



            string sql = "SELECT * FROM products WHERE Arhivirano=0 ORDER BY ProizvodID DESC LIMIT 1;";
            MySqlCommand command1 = new MySqlCommand(sql, DatabaseManager.Connection);
            MySqlDataReader reader = command1.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("ProizvodID");
                    int productNumber = reader.GetInt32("BrojProizvoda");
                    string name = reader.GetString("Naziv");
                    double enterPrice = reader.GetDouble("UlaznaCijena");
                    double sellPrice = reader.GetDouble("IzlaznaCijena");
                    double tax = reader.GetDouble("Porez");
                    ProductUserControl userControl = new ProductUserControl(id, productNumber, name, enterPrice, sellPrice, tax);
                    userControl.rbDobit = DobitLock;
                    userControl.rbIzlazna = IzlazLock;
                    userControl.rbProfit = ProfitLock;
                    MainFlowPanel.Controls.Add(userControl);
                    userControl.InitPrice();
                    productUserControls.Add(userControl);

                }
            }
            catch (Exception ex)
            {
            }
            reader.Close();

        }

        private void NazivSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (ProductUserControl puc in productUserControls)
            {
                if ((puc.productNum + puc.naziv.ToLower()).Contains(NazivSearchTextBox.Text.ToLower()) || NazivSearchTextBox.Text == "")
                    puc.Visible = true;

                else puc.Visible = false;

            }

        }

        private void ProductsForm_SizeChanged(object sender, EventArgs e)
        {
            MainFlowPanel.Size = new System.Drawing.Size(936, ActiveForm.Size.Height - 133);
        }

        private void spremiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

    }
}
