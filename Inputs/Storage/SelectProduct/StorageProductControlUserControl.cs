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
    public partial class StorageProductControlUserControl : UserControl
    {

        public int id { get; set; }
        public int proizvodID { get; set; }
        public double popust { get; set; }
        public double porez { get; set; }
        public int kolicina { get; set; }

        public double sveukupnaCijena { get; set; }

        int broj;
        public string? naziv { get; set; }
        public double cijena { get; set; }


        public StorageProductControlUserControl()
        {
            InitializeComponent();
        }

        public StorageProductControlUserControl(int id, int proizvodID, int broj, string naziv, double cijena, double porez)
        {
            InitializeComponent();
            this.id = id;
            this.proizvodID = proizvodID;
            this.broj = broj;
            this.naziv = naziv;
            this.cijena = cijena;
            this.porez = porez;
            this.kolicina = 1;

            labelID.Text = id.ToString();
            labelBroj.Text = broj.ToString();
            labelNaziv.Text = naziv;
            textBoxCijena.Text = cijena.ToString();
            textBoxPDV.Text = (porez * 100).ToString();

            updateUkupniIznos();
        }

        private void textBoxPopust_TextChanged(object sender, EventArgs e)
        {
            PrimkaForm primkaForm = this.ParentForm as PrimkaForm;
            if (primkaForm != null)
            {
                try
                {
                    double temp_popust = double.Parse(textBoxPopust.Text) / 100;
                    if (temp_popust > 1 || temp_popust < 0) throw new Exception();
                    popust = temp_popust;
                }
                catch
                {
                    primkaForm.SmallErrorLabel.Text = "Nevaljana vrijednost u popustu: " + textBoxPopust.Text;
                }

                primkaForm.SmallErrorLabel.Text = "";
                updateUkupniIznos();
            }

        }

        private void textBoxPDV_TextChanged(object sender, EventArgs e)
        {
            PrimkaForm primkaForm = this.ParentForm as PrimkaForm;
            if (primkaForm != null)
            {
                try
                {
                    double temp_porez = double.Parse(textBoxPDV.Text) / 100;
                    if (temp_porez > 1 || temp_porez < 0) throw new Exception();
                    porez = temp_porez;
                }
                catch
                {
                    primkaForm.SmallErrorLabel.Text = "Nevaljana vrijednost u PDV-u: " + textBoxPDV.Text;
                }

                primkaForm.SmallErrorLabel.Text = "";
                updateUkupniIznos();
            }
        }
        private void textBoxKolicina_TextChanged(object sender, EventArgs e)
        {
            PrimkaForm primkaForm = this.ParentForm as PrimkaForm;
            if (primkaForm != null)
            {
                try
                {
                    int temp_kolicina = int.Parse(textBoxKolicina.Text);
                    if (temp_kolicina < 0) throw new Exception();
                    kolicina = temp_kolicina;
                }
                catch (Exception ex)
                {
                    primkaForm.SmallErrorLabel.Text = "Nevaljana vrijednost u količini: " + textBoxKolicina.Text;
                }

                primkaForm.SmallErrorLabel.Text = "";
                updateUkupniIznos();
            }
        }
        void updateUkupniIznos()
        {
            sveukupnaCijena = Racunaj.izlaznaCijenaIzUlazne(cijena,popust,porez,kolicina);
            labelIznos.Text = sveukupnaCijena.ToString();
        }
        public void updateIDTo(int id)
        {
            this.id = id;
            labelID.Text = id.ToString();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            PrimkaForm primkaForm = this.ParentForm as PrimkaForm;
            if (primkaForm != null)
            {
                primkaForm.removeUserControlByID(id);
            }
        }

        private void textBoxCijena_TextChanged(object sender, EventArgs e)
        {
            cijena = Double.Parse(textBoxCijena.Text);
            updateUkupniIznos();
        }
    }
}
