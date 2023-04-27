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
    public partial class ClientForm : Form
    {
        List<ClientUserControl> clientUserControls = new List<ClientUserControl>();
        public ClientForm()
        {
            InitializeComponent();



            string sql = "SELECT * FROM clients WHERE Arhivirano=0 ORDER BY ClientID ASC;";
            MySqlCommand command = new MySqlCommand(sql, DatabaseManager.Connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("ClientID");
                string naziv = reader.GetString("Naziv");
                string adresa = reader.GetString("Adresa");
                string telefon = reader.GetString("Telefon");
                string email = reader.GetString("E-mail");
                string VAT = reader.GetString("VAT");
                ClientUserControl userControl = new ClientUserControl(id, naziv, adresa, telefon, email, VAT);

                MainFlowPanel.Controls.Add(userControl);
                clientUserControls.Add(userControl);

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
            foreach (ClientUserControl puc in clientUserControls)
            {
                if (!puc.modified) continue;
                string query = "UPDATE clients SET Naziv = @Naziv, Adresa = @Adresa, Telefon = @Telefon, `E-mail` = @Email, VAT = @VAT WHERE ClientID = @id";


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
            string query = "INSERT INTO clients (Naziv) VALUES (@Naziv)";

            using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
            {
                command.Parameters.AddWithValue("@Naziv", "");

                command.ExecuteNonQuery();
            }



            string sql = "SELECT * FROM clients WHERE Arhivirano=0 ORDER BY ClientID DESC LIMIT 1;";
            MySqlCommand command1 = new MySqlCommand(sql, DatabaseManager.Connection);
            MySqlDataReader reader = command1.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("ClientID");
                    string naziv = reader.GetString("Naziv");
                    string adresa = reader.GetString("Adresa");
                    string telefon = reader.GetString("Telefon");
                    string email = reader.GetString("E-mail");
                    string VAT = reader.GetString("VAT");
                    ClientUserControl userControl = new ClientUserControl(id, naziv, adresa, telefon, email, VAT);

                    MainFlowPanel.Controls.Add(userControl);
                    clientUserControls.Add(userControl);

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
            foreach (ClientUserControl duc in clientUserControls)
            {
                if (duc.naziv.ToLower().Contains(textBoxNazivSearch.Text.ToLower()) || textBoxNazivSearch.Text == "")
                    duc.Visible = true;
                else duc.Visible = false;

            }
        }

        private void DobavljaciForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool unsavedChanges = false;
            foreach (ClientUserControl puc in clientUserControls)
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
