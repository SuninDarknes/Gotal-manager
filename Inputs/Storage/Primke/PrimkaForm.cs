using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            SmallErrorLabel.Text = "";
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
                            double porez = reader.GetDouble("Porez") / 100;
                            StorageProductControlUserControl userControl =
                                new StorageProductControlUserControl(productUserControls.Count, ProductID, broj, naziv, cijena, porez);
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

        public void removeUserControlByID(int id)
        {
            productUserControls[id].Dispose();
            productUserControls.RemoveAt(id);
            for (int i = 0; i < productUserControls.Count; i++)
            {
                productUserControls[i].updateIDTo(i);

            }
        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            int dobavljacID = -1;
            try
            {
                string queryind = "SELECT * FROM deliverer WHERE LOWER(Naziv)=LOWER(@Naziv)";
                using (MySqlCommand command = new MySqlCommand(queryind, DatabaseManager.Connection))
                {
                    command.Parameters.AddWithValue("@Naziv", textBoxDobavljac.Text);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dobavljacID = reader.GetInt32("DobavljacID");
                        }
                    }
                }
                if (dobavljacID == -1) throw new Exception();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Provijeri ime dobavljača!", "Krivo ime dobavljača", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO primke (DobavljacID, Datum) VALUES (@DobavljacID, @Datum)";

            using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
            {
                command.Parameters.AddWithValue("@DobavljacID", dobavljacID);
                DateTime date = DateTime.ParseExact(dateTimePicker1.Text, "dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);
                command.Parameters.AddWithValue("@Datum", date.ToString("yyyy-MM-dd HH:mm:ss"));
                command.ExecuteNonQuery();
            }
            int PrimkaID = -1;
            query = "SELECT * FROM primke ORDER BY PrimkaID DESC LIMIT 1";
            using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        PrimkaID = reader.GetInt32("PrimkaID");
                    }
                }
            }

            foreach (StorageProductControlUserControl control in productUserControls)
            {
                string query1 = "INSERT INTO `primke-stavke` (RedniBroj, PrimkaID, ProizvodID, Popust, Porez, Kolicina) VALUES (@RedniBroj,@PrimkaID, @ProizvodID, @Popust, @Porez, @Kolicina)";

                using (MySqlCommand command = new MySqlCommand(query1, DatabaseManager.Connection))
                {
                    command.Parameters.AddWithValue("@RedniBroj", control.id);
                    command.Parameters.AddWithValue("@PrimkaID", PrimkaID);
                    command.Parameters.AddWithValue("@ProizvodID", control.proizvodID);
                    command.Parameters.AddWithValue("@Popust", control.popust * 100);
                    command.Parameters.AddWithValue("@Porez", control.porez * 100);
                    command.Parameters.AddWithValue("@Kolicina", control.kolicina);
                    command.ExecuteNonQuery();
                }
            }

            foreach (StorageProductControlUserControl control in productUserControls)
            {
                int kolicinaNaSkladistu = -1;

                query = "SELECT * FROM storage WHERE ProizvodID=@ProizvodID";
                using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
                {
                    command.Parameters.AddWithValue("@ProizvodID", control.proizvodID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            kolicinaNaSkladistu = reader.GetInt32("SveukupnaKolicina");
                        }
                    }
                }

                if (kolicinaNaSkladistu == -1)
                {
                    query = "INSERT INTO storage (ProizvodID, Popust, SveukupnaKolicina) VALUES (@ProizvodID, @Popust, @SveukupnaKolicina)";
                    kolicinaNaSkladistu = 0;
                }

                else
                    query = "UPDATE storage SET SveukupnaKolicina = @SveukupnaKolicina, Popust = @Popust WHERE ProizvodID = @ProizvodID";

                using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
                {
                    command.Parameters.AddWithValue("@ProizvodID", control.proizvodID);
                    command.Parameters.AddWithValue("@Popust", control.popust * 100);
                    command.Parameters.AddWithValue("@SveukupnaKolicina", kolicinaNaSkladistu+control.kolicina);
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Uspješno dodana primka!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form.ActiveForm.Close();
        }

        private void PrimkaForm_SizeChanged(object sender, EventArgs e)
        {
            MainFlowPanel.Size = new Size(730, Form.ActiveForm.Size.Height - 202);
        }
    }
}
