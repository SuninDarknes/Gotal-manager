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
    public partial class DobavljacUserControl : UserControl
    {

        public int id { get; set; }
        public string? naziv { get; set; }
        public string? adresa { get; set; }
        public string? telefon { get; set; }
        public string? email { get; set; }
        public string? VAT { get; set; }

        string? init_naziv, init_adresa, init_telefon, init_email, init_VAT;

        public bool modified { get; set; }

        private void TextBoxNaziv_TextChanged(object sender, EventArgs e)
        {
            naziv = TextBoxNaziv.Text;
        }


        private void TextBoxAdresa_TextChanged(object sender, EventArgs e)
        {
            adresa = TextBoxAdresa.Text;
        }

        private void TextBoxTelefon_TextChanged(object sender, EventArgs e)
        {
            telefon = TextBoxTelefon.Text;
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            email = TextBoxEmail.Text;
        }

        private void TextBoxVAT_TextChanged(object sender, EventArgs e)
        {
            VAT = TextBoxVAT.Text;
        }

        public DobavljacUserControl()
        {
            InitializeComponent();
        }
        public DobavljacUserControl(int _id = 0, string _naziv = null, string _adresa = null, string _telefon = null, string _email = null, string _VAT = null)
        {
            InitializeComponent();
            modified = false;
            this.id = _id;
            this.naziv = _naziv;
            this.adresa = _adresa;
            this.telefon = _telefon;
            this.email = _email;
            this.VAT = _VAT;

            init_naziv = _naziv;
            init_adresa = _adresa;
            init_telefon = _telefon;
            init_email = _email;
            init_VAT = _VAT;

            TextBoxNaziv.Text = _naziv;
            TextBoxAdresa.Text = _adresa;
            TextBoxTelefon.Text = _telefon;
            TextBoxEmail.Text = _email;
            TextBoxVAT.Text = _VAT;

            TextBoxNaziv.TextChanged += new System.EventHandler(TextBox_isModified);
            TextBoxAdresa.TextChanged += new System.EventHandler(TextBox_isModified);
            TextBoxTelefon.TextChanged += new System.EventHandler(TextBox_isModified);
            TextBoxEmail.TextChanged += new System.EventHandler(TextBox_isModified);
            TextBoxVAT.TextChanged += new System.EventHandler(TextBox_isModified);
        }

        private void TextBox_isModified(object sender, EventArgs e)
        {
            try
            {
                if (init_naziv == naziv && init_adresa == adresa && init_telefon == telefon && init_email == email && init_VAT == VAT)
                {
                    BackColor = SystemColors.Control;
                    modified = false;
                }
                else
                {
                    BackColor = Color.LawnGreen;
                    modified = true;
                }
            }
            catch (Exception ex)
            {

            }


        }



        private void RemoveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jesi li siguran da želiš obrisati ovog dobavljača?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string query = "UPDATE dobavljaci SET Arhivirano=1 WHERE DobavljacID = @Id ";
                using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }

                this.Dispose();
            }

        }




        public void afterSave()
        {
            init_naziv = naziv;
            init_adresa = adresa;
            init_telefon = telefon;
            init_email = email;
            init_VAT = VAT;

            BackColor = SystemColors.Control;
            modified = false;

        }
    }
}

