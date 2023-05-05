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

namespace Gotal_manager
{
    public partial class DobavljaciForm : Form
    {
        List<DobavljacUserControl> dobavljacUserControls= new List<DobavljacUserControl>();
        public DobavljaciForm()
        {
            InitializeComponent();



            string sql = "SELECT * FROM dobavljaci WHERE Arhivirano=0 ORDER BY DobavljacID ASC;";
            MySqlCommand command = new MySqlCommand(sql, DatabaseManager.Connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("DobavljacID");
                string naziv = reader.GetString("Naziv");
                string adresa = reader.GetString("Adresa");
                string telefon = reader.GetString("Telefon");
                string email = reader.GetString("E-mail");
                string VAT = reader.GetString("VAT");
                DobavljacUserControl userControl = new DobavljacUserControl(id, naziv,adresa,telefon,email,VAT);

                MainFlowPanel.Controls.Add(userControl);
                dobavljacUserControls.Add(userControl);

            }

            reader.Close();

        }


        private void spremiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private bool SaveChanges()
        {/*
            try
            {*/
                foreach (DobavljacUserControl puc in dobavljacUserControls)
                {
                    if (!puc.modified) continue;
                string query = "UPDATE dobavljaci SET Naziv = @Naziv, Adresa = @Adresa, Telefon = @Telefon, `E-mail` = @Email, VAT = @VAT WHERE DobavljacID = @id";


                using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
                    {
                        command.Parameters.AddWithValue("@Naziv", puc.naziv);
                        command.Parameters.AddWithValue("@Adresa", puc.adresa);
                        command.Parameters.AddWithValue("@Telefon", puc.telefon);
                        command.Parameters.AddWithValue("@Email", puc.email);
                        command.Parameters.AddWithValue("@VAT", puc.VAT);
                        command.Parameters.AddWithValue("@id", puc.id);

                        command.ExecuteNonQuery();
                        puc.afterSave();

                    }

                }
                return true;
            /*}
            
            catch
            {
                DialogResult result = MessageBox.Show("Greša pri spremanju! Provjeri valjanost svih zelenih redaka!", "Nespremljene Promjene", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }*/
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO dobavljaci (Naziv) VALUES (@Naziv)";

            using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
            {
                command.Parameters.AddWithValue("@Naziv", "");

                command.ExecuteNonQuery();
            }



            string sql = "SELECT * FROM dobavljaci WHERE Arhivirano=0 ORDER BY DobavljacID DESC LIMIT 1;";
            MySqlCommand command1 = new MySqlCommand(sql, DatabaseManager.Connection);
            MySqlDataReader reader = command1.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("DobavljacID");
                    string naziv = reader.GetString("Naziv");
                    string adresa = reader.GetString("Adresa");
                    string telefon = reader.GetString("Telefon");
                    string email = reader.GetString("E-mail");
                    string VAT = reader.GetString("VAT");
                    DobavljacUserControl userControl = new DobavljacUserControl(id, naziv, adresa, telefon, email, VAT);

                    MainFlowPanel.Controls.Add(userControl);
                    dobavljacUserControls.Add(userControl);

                }
            }
            catch (Exception ex)
            {
            }
            reader.Close();
        }

        private void DobavljaciForm_SizeChanged(object sender, EventArgs e)
        {
            MainFlowPanel.Size = new System.Drawing.Size(735, ActiveForm.Size.Height - 107);
        }



        private void textBoxNazivSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (DobavljacUserControl duc in dobavljacUserControls)
            {
                if ( duc.naziv.ToLower().Contains(textBoxNazivSearch.Text.ToLower()) || textBoxNazivSearch.Text == "")
                    duc.Visible = true;
                else duc.Visible = false;

            }
        }

        private void DobavljaciForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool unsavedChanges = false;
            foreach (DobavljacUserControl puc in dobavljacUserControls)
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
                    if (!SaveChanges()) e.Cancel = true;

                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
