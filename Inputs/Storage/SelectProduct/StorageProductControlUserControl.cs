using Gotal_manager.Inputs.Storage.Izdatnice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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


        public StorageData? storageData { get; set; }

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
        public StorageProductControlUserControl(int id, StorageData data)
        {
            InitializeComponent();
            this.id = id;
            this.storageData = data;
            this.cijena = data.prodajnaCijena;
            this.porez = data.porez;
            this.kolicina = 1;

            labelID.Text = id.ToString();
            labelBroj.Text = data.brojProizvoda.ToString();
            labelNaziv.Text = data.naziv;
            textBoxCijena.Text = cijena.ToString();
            textBoxPDV.Text = porez.ToString();
            updateUkupniIznos();
        }

        private void textBoxPopust_TextChanged(object sender, EventArgs e)
        {
            PrimkaForm primkaForm = this.ParentForm as PrimkaForm;
            IzdatnicaForm izdatnicaForm = this.ParentForm as IzdatnicaForm;
            if (primkaForm != null)
                primkaForm.SmallErrorLabel.Text = "";
            if (izdatnicaForm != null)
                izdatnicaForm.SmallErrorLabel.Text = "";
            try
            {
                double temp_popust = double.Parse(textBoxPopust.Text) / 100;
                if (temp_popust > 1 || temp_popust < 0) throw new Exception();
                popust = temp_popust;
            }
            catch
            {
                if (primkaForm != null)
                    primkaForm.SmallErrorLabel.Text = "Nevaljana vrijednost u popustu: " + textBoxPopust.Text;

                if (izdatnicaForm != null)
                    izdatnicaForm.SmallErrorLabel.Text = "Nevaljana vrijednost u popustu: " + textBoxPopust.Text;
            }


            updateUkupniIznos();


        }

        private void textBoxPDV_TextChanged(object sender, EventArgs e)
        {
            PrimkaForm primkaForm = this.ParentForm as PrimkaForm;
            IzdatnicaForm izdatnicaForm = this.ParentForm as IzdatnicaForm;
            if (primkaForm != null)
                primkaForm.SmallErrorLabel.Text = "";
            if (izdatnicaForm != null)
                izdatnicaForm.SmallErrorLabel.Text = "";
            try
            {
                double temp_porez = double.Parse(textBoxPDV.Text) / 100;
                if (temp_porez > 1 || temp_porez < 0) throw new Exception();
                porez = temp_porez;
            }
            catch
            {
                if (primkaForm != null)
                    primkaForm.SmallErrorLabel.Text = "Nevaljana vrijednost u PDV-u: " + textBoxPDV.Text;
                if (izdatnicaForm != null)
                    izdatnicaForm.SmallErrorLabel.Text = "Nevaljana vrijednost u PDV-u: " + textBoxPDV.Text;
            }


            updateUkupniIznos();

        }
        private void textBoxKolicina_TextChanged(object sender, EventArgs e)
        {
            PrimkaForm primkaForm = this.ParentForm as PrimkaForm;
            IzdatnicaForm izdatnicaForm = this.ParentForm as IzdatnicaForm;
            if (primkaForm != null)
                primkaForm.SmallErrorLabel.Text = "";
            if (izdatnicaForm != null)
                izdatnicaForm.SmallErrorLabel.Text = "";
            int temp_kolicina = 0;
            try
            {
                temp_kolicina = int.Parse(textBoxKolicina.Text);
                if (temp_kolicina < 0) throw new Exception();
                if (izdatnicaForm != null)
                {
                    try
                    {


                        if (temp_kolicina > storageData.kolicina - storageData.razduzena_kolicina) throw new Exception();
                    }
                    catch
                    {
                        izdatnicaForm.SmallErrorLabel.Text = "U skladištu ima samo " + (storageData.kolicina - storageData.razduzena_kolicina) + " proizvoda.";
                    }

                    if (temp_kolicina > storageData.kolicina - storageData.razduzena_kolicina) throw new Exception();
                }
                kolicina = temp_kolicina;
            }
            catch
            {
                if (primkaForm != null)
                    primkaForm.SmallErrorLabel.Text = "Nevaljana vrijednost u količini: " + textBoxKolicina.Text;
                if (izdatnicaForm != null && !(temp_kolicina > storageData.kolicina - storageData.razduzena_kolicina))
                    izdatnicaForm.SmallErrorLabel.Text = "Nevaljana vrijednost u količini: " + textBoxKolicina.Text;
            }

            updateUkupniIznos();

        }
        void updateUkupniIznos()
        {
            sveukupnaCijena = Math.Round((cijena - cijena * popust) * kolicina, 2);
            labelIznos.Text = sveukupnaCijena + " €";
        }
        public void updateIDTo(int id)
        {
            this.id = id;
            labelID.Text = id.ToString();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            PrimkaForm primkaForm = this.ParentForm as PrimkaForm;
            IzdatnicaForm izdatnicaForm = this.ParentForm as IzdatnicaForm;
            if (primkaForm != null)
                primkaForm.removeUserControlByID(id);
            if (izdatnicaForm != null)
                izdatnicaForm.removeUserControlByID(id);
        }

        private void textBoxCijena_TextChanged(object sender, EventArgs e)
        {
            PrimkaForm primkaForm = this.ParentForm as PrimkaForm;
            IzdatnicaForm izdatnicaForm = this.ParentForm as IzdatnicaForm;
            if (primkaForm != null)
                primkaForm.SmallErrorLabel.Text = "";
            if (izdatnicaForm != null)
                izdatnicaForm.SmallErrorLabel.Text = "";

            try
            {
                cijena = Double.Parse(textBoxCijena.Text);
            }
            catch
            {
                if (primkaForm != null)
                    primkaForm.SmallErrorLabel.Text = "Kriva cijena!";
                if (izdatnicaForm != null)
                    izdatnicaForm.SmallErrorLabel.Text = "Kriva cijena!";

            }

            updateUkupniIznos();
        }
    }
}
