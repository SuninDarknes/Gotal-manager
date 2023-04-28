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

        int broj;
        string? naziv;
        double cijena;


        public StorageProductControlUserControl()
        {
            InitializeComponent();
        }

        public StorageProductControlUserControl(int id, int proizvodID, int broj, string naziv, double cijena, double porez)
        {
            InitializeComponent();
            this.id = id;
            this.proizvodID= proizvodID;
            this.broj= broj;
            this.naziv= naziv;
            this.cijena= cijena;
            this.porez= porez;
            this.kolicina = 1;

            labelID.Text = id.ToString();
            labelBroj.Text = broj.ToString();
            labelNaziv.Text = naziv;
            labelCijena.Text = cijena.ToString();
            textBoxPDV.Text = porez.ToString();

            updateUkupniIznos();
        }

        private void textBoxPopust_TextChanged(object sender, EventArgs e)
        {
            PrimkaForm primkaForm = this.ParentForm as PrimkaForm;
            if (primkaForm != null)
            {
                try
                {
                    double temp_popust = double.Parse(textBoxPopust.Text)/100;
                    if (temp_popust > 1 || temp_popust < 0) throw new Exception();
                    popust= temp_popust;
                }
                catch { 
                primkaForm.SmallErrorLabel.Text = "Nevaljana vrijednost u popustu: "+ textBoxPopust.Text;
                }
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
                    double temp_porez = double.Parse(textBoxPDV.Text)/100;
                    if(temp_porez > 1 || temp_porez < 0) throw new Exception(); 
                    porez= temp_porez;
                }
                catch
                {
                    primkaForm.SmallErrorLabel.Text = "Nevaljana vrijednost u PDV-u: " + textBoxPDV.Text;
                }
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
                    int temp_kolicina = int.Parse(textBoxKolicina.Text) ;
                    if (temp_kolicina < 0) throw new Exception();
                    kolicina = temp_kolicina;
                }
                catch(Exception ex)
                {
                    primkaForm.SmallErrorLabel.Text = "Nevaljana vrijednost u količini: " + textBoxKolicina.Text;
                }
                updateUkupniIznos();
            }
        }
        void updateUkupniIznos()
        {
            double cijena_s_popustom = cijena - (cijena * popust);
            double porez_na_cijenu = cijena_s_popustom * (porez / (1 - porez));
            double cijena_s_porezom = (cijena_s_popustom + porez_na_cijenu) * kolicina;
            labelIznos.Text = (Math.Round( cijena_s_porezom,4)).ToString();
        }
        public void updateIDTo(int id)
        {
            this.id = id;
            labelID.Text= id.ToString();
        }


    }
}
