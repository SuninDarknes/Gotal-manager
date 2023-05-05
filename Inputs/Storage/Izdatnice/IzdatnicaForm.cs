using Gotal_manager.Inputs.Storage.SelectStorageProizvod;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotal_manager.Inputs.Storage.Izdatnice
{
    public partial class IzdatnicaForm : Form
    {
        List<string> autoWords = new List<string>();
        List<int> autoWordsIDs = new List<int>();
        List<StorageProductControlUserControl> productUserControls = new List<StorageProductControlUserControl>();

        Dictionary<StorageData, int> storageDatas;

        public IzdatnicaForm()
        {
            InitializeComponent();
        }
        public IzdatnicaForm(Dictionary<StorageData, int> storageDatas)
        {
            InitializeComponent();
            this.storageDatas = storageDatas;
        }



        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            int ProductID = 0;

            using (SelectStorageProizvodForm selectProizvodForm = new SelectStorageProizvodForm())
            {
                DialogResult result = selectProizvodForm.ShowDialog();

                ProductID = selectProizvodForm.selected_product_index;

            }
            try
            {
                string query = "SELECT * FROM proizvodi WHERE ProizvodID = @id";
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
            int clientID = -1;
            try
            {
                string queryind = "SELECT * FROM kupci WHERE LOWER(Naziv)=LOWER(@Naziv)";
                using (MySqlCommand command = new MySqlCommand(queryind, DatabaseManager.Connection))
                {
                    command.Parameters.AddWithValue("@Naziv", textBoxKupac.Text);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            clientID = reader.GetInt32("KupacID");
                        }
                    }
                }
                if (clientID == -1) throw new Exception();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Provijeri ime kupca!", "Krivo ime kupca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO izdatnice (KupacID, Datum) VALUES (@KupacID, @Datum)";

            using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
            {
                command.Parameters.AddWithValue("@KupacID", clientID);
                DateTime date = DateTime.ParseExact(dateTimePicker1.Text, "dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);
                command.Parameters.AddWithValue("@Datum", date.ToString("yyyy-MM-dd HH:mm:ss"));
                command.ExecuteNonQuery();
            }
            int IzdatnicaID = -1;
            query = "SELECT * FROM primke ORDER BY IzdatnicaID DESC LIMIT 1";
            using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        IzdatnicaID = reader.GetInt32("IzdatnicaID");
                    }
                }
            }

            foreach (StorageProductControlUserControl control in productUserControls)
            {
                string query1 = "INSERT INTO `primke-stavke` (RedniBroj, IzdatnicaID, ProizvodID, Cijena, Popust, Porez, Kolicina) VALUES (@RedniBroj,@IzdatnicaID, @ProizvodID, @Cijena, @Popust, @Porez, @Kolicina)";

                using (MySqlCommand command = new MySqlCommand(query1, DatabaseManager.Connection))
                {
                    command.Parameters.AddWithValue("@RedniBroj", control.id);
                    command.Parameters.AddWithValue("@IzdatnicaID", IzdatnicaID);
                    command.Parameters.AddWithValue("@ProizvodID", control.proizvodID);
                    command.Parameters.AddWithValue("@Cijena", control.cijena);
                    command.Parameters.AddWithValue("@Popust", control.popust * 100);
                    command.Parameters.AddWithValue("@Porez", control.porez * 100);
                    command.Parameters.AddWithValue("@Kolicina", control.kolicina);
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Uspješno dodana izdatnica!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form.ActiveForm.Close();
        }


        private void dopuniKupcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IzdatnicaForm_KupacAuto = !Properties.Settings.Default.IzdatnicaForm_KupacAuto;
            dopuniKupcaToolStripMenuItem.Checked = Properties.Settings.Default.IzdatnicaForm_KupacAuto;
            Properties.Settings.Default.Save();
        }

        private void textBoxKupac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Properties.Settings.Default.IzdatnicaForm_KupacAuto)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != ' '))
                {
                    e.Handled = true;
                    return;
                }
                string currentText = textBoxKupac.Text;

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

        private void IzdatnicaForm_SizeChanged(object sender, EventArgs e)
        {
            MainFlowPanel.Size = new Size(730, Form.ActiveForm.Size.Height - 202);
        }

        private void IzdatnicaForm_Load(object sender, EventArgs e)
        {
            dopuniKupcaToolStripMenuItem.Checked = Properties.Settings.Default.IzdatnicaForm_KupacAuto;

            dateTimePicker1.Value = DateTime.Now;
            try
            {
                string sql = "SELECT * FROM kupci WHERE Arhivirano=0 ORDER BY KupacID ASC;";
                MySqlCommand command = new MySqlCommand(sql, DatabaseManager.Connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    autoWordsIDs.Add(reader.GetInt32("KupacID"));
                    autoWords.Add(reader.GetString("Naziv"));

                }
                reader.Close();

                AutoCompleteStringCollection acs = new AutoCompleteStringCollection();
                acs.AddRange(autoWords.ToArray());
                textBoxKupac.AutoCompleteCustomSource = acs;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška kod učitavanja kupca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SmallErrorLabel.Text = "";
        }
    }
}
