using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Gotal_manager
{
    public partial class ProductUserControl : UserControl
    {
        public int id { get; set; } 
        public int productNum{ get; set; }
        public double ulaz { get; set; }
        double dobit;
        public double izlaz{ get; set; }
        double profit;
        public string naziv { get; set; }
        public double tax { get; set; }

        int init_productNum;
        double init_ulaz, init_izlaz, init_tax;
        string init_naziv;

        public bool modified { get; set; }


        public ProductUserControl(int _id=0,int _productNum=0, string _naziv = "", double _ulaz = 0, double _izlaz = 0,double _tax=0)
        {
            InitializeComponent();
            modified = false;
            this.id = _id;
            this.productNum = _productNum;
            this.ulaz = _ulaz;
            this.izlaz = _izlaz;
            this.naziv = _naziv;
            this.tax = _tax;
            this.init_productNum = _productNum;
            this.init_ulaz = _ulaz;
            this.init_izlaz = _izlaz;
            this.init_naziv = _naziv;
            this.init_tax = _tax;
            this.Name = "PUC_" + _id;
            TextBoxProductNumber.Text = productNum.ToString();
            TextBoxNaziv.Text = naziv;
            TextBoxPorez.Text = tax.ToString();
            TextBoxProductNumber.TextChanged += new System.EventHandler(TextBox_isModified);
            TextBoxNaziv.TextChanged += new System.EventHandler(TextBox_isModified);
            TextBoxDobit.TextChanged += new System.EventHandler(TextBox_isModified);
            TextBoxIzlazna.TextChanged += new System.EventHandler(TextBox_isModified);
            TextBoxProfit.TextChanged += new System.EventHandler(TextBox_isModified);
            TextBoxUlazna.TextChanged += new System.EventHandler(TextBox_isModified);
            TextBoxPorez.TextChanged += new System.EventHandler(TextBox_isModified);
        }

        private void TextBox_isModified(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxProductNumber.Text==init_productNum.ToString() && TextBoxNaziv.Text == init_naziv && double.Parse(TextBoxUlazna.Text) == init_ulaz && double.Parse(TextBoxIzlazna.Text) == init_izlaz && init_tax == double.Parse(TextBoxPorez.Text))
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


        public RadioButton rbUlazna { set; get; }
        public RadioButton rbDobit { set; get; }
        public RadioButton rbIzlazna { set; get; }
        public RadioButton rbProfit { set; get; }
        private void updateNums(TextBox sender = null)
        {
            if (sender != TextBoxUlazna) TextBoxUlazna.Text = Math.Round(ulaz, 4).ToString();
            if (sender != TextBoxIzlazna) TextBoxIzlazna.Text = Math.Round(izlaz, 4).ToString();
            if (sender != TextBoxDobit) TextBoxDobit.Text = Math.Round(dobit * 100, 4).ToString();
            if (sender != TextBoxProfit) TextBoxProfit.Text = Math.Round(profit, 4).ToString();
        }

        public void InitPrice()
        {
            try
            {
                dobit = (izlaz - ulaz) / ulaz;
                profit = izlaz - ulaz;
                updateNums();
            }
            catch (Exception ex)
            {

                MessageBox.Show(TextBoxNaziv.Text + "\n" + ex.Message, "ERROR-DEV", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void TextBoxUlazna_TextChanged(object sender, EventArgs e)
        {
            if (ParentForm == null) return;
            Label err = (Label)ParentForm.Controls.Find("SmallErrorLabel", true)[0];
            if (err.Text == "Initializing") return;
            try
            {
                ulaz = double.Parse(TextBoxUlazna.Text);
            }
            catch (Exception ex)
            {

                err.Text = "Krivi zapis: " + TextBoxUlazna.Text;
                return;
            }
            err.Text = "";
            if (!Properties.Settings.Default.ProductsForm_AutoCaclulate) return;

            if (((RadioButton)ParentForm.Controls.Find("DobitLock", true)[0]).Checked)
            {
                izlaz = ulaz * (dobit + 1);
                profit = izlaz - ulaz;
            }
            if (((RadioButton)ParentForm.Controls.Find("IzlazLock", true)[0]).Checked)
            {
                dobit = (izlaz - ulaz) / ulaz;
                profit = izlaz - ulaz;
            }
            if (((RadioButton)ParentForm.Controls.Find("ProfitLock", true)[0]).Checked)
            {
                dobit = (izlaz - ulaz) / ulaz;
                izlaz = ulaz + profit;

            }
            updateNums(TextBoxUlazna);
        }
        Dictionary<string, bool> textboxDict = new Dictionary<string, bool>();

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ProductsForm_ShowAlerts)
            {
                DialogResult result = MessageBox.Show("Jesi li siguran da želiš obrisati ovaj redak?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string query = "UPDATE products SET Arhivirano=1 WHERE ProizvodID = @Id ";
                    using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        command.ExecuteNonQuery();
                    }

                    this.Dispose();
                }
            }
            else
            {
                string query = "UPDATE products SET Arhivirano=1 WHERE ProizvodID = @Id";
                using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
                this.Dispose();
            }

        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            string name = ((TextBox)sender).Name;

            textboxDict[name] = true;
        }


        private void TextBoxDobit_TextChanged(object sender, EventArgs e)
        {
            if (ParentForm == null) return;
            Label err = (Label)ParentForm.Controls.Find("SmallErrorLabel", true)[0];
            if (err.Text == "Initializing") return;
            try
            {
                dobit = double.Parse(TextBoxDobit.Text) / 100;
            }
            catch (Exception ex)
            {

                err.Text = "Krivi zapis: " + TextBoxDobit.Text;
                return;
            }
            err.Text = "";
            if (!Properties.Settings.Default.ProductsForm_AutoCaclulate) return;
            izlaz = ulaz * (dobit + 1);
            profit = izlaz - ulaz;

            updateNums(TextBoxDobit);

        }

        private void TextBoxIzlazna_TextChanged(object sender, EventArgs e)
        {
            if (ParentForm == null) return;
            Label err = (Label)ParentForm.Controls.Find("SmallErrorLabel", true)[0];
            if (err.Text == "Initializing") return;
            try
            {
                izlaz = double.Parse(TextBoxIzlazna.Text);
            }
            catch (Exception ex)
            {

                err.Text = "Krivi zapis: " + TextBoxIzlazna.Text;
                return;
            }
            err.Text = "";
            if (!Properties.Settings.Default.ProductsForm_AutoCaclulate) return;
            dobit = (izlaz - ulaz) / ulaz;
            profit = izlaz - ulaz;

            updateNums(TextBoxIzlazna);
        }

        private void TextBoxNaziv_TextChanged(object sender, EventArgs e)
        {
            naziv = TextBoxNaziv.Text;
        }

        private void TextBoxProductNumber_TextChanged(object sender, EventArgs e)
        {
            productNum = int.Parse( TextBoxProductNumber.Text);
        }

        private void TextBoxProfit_TextChanged(object sender, EventArgs e)
        {
            if (ParentForm == null) return;
            Label err = (Label)ParentForm.Controls.Find("SmallErrorLabel", true)[0];
            if (err.Text == "Initializing") return;
            try
            {
                profit = double.Parse(TextBoxProfit.Text);
            }
            catch (Exception ex)
            {

                err.Text = "Krivi zapis: " + TextBoxProfit.Text;
                return;
            }
            err.Text = "";
            if (!Properties.Settings.Default.ProductsForm_AutoCaclulate) return;
            izlaz = ulaz + profit;
            dobit = (izlaz - ulaz) / ulaz;


            updateNums(TextBoxProfit);
        }

        private void TextBoxPorez_TextChanged(object sender, EventArgs e)
        {
            if (ParentForm == null) return;
            Label err = (Label)ParentForm.Controls.Find("SmallErrorLabel", true)[0];
            if (err.Text == "Initializing") return;
            try
            {
                tax = double.Parse(TextBoxPorez.Text);
            }
            catch (Exception ex)
            {

                err.Text = "Krivi zapis: " + TextBoxPorez.Text;
                return;
            }
            err.Text = "";
        }

        public void afterSave()
        {
            init_izlaz = izlaz;
            init_naziv = naziv;
            init_productNum = productNum;
            init_ulaz = ulaz;
            init_tax = tax;
            BackColor = SystemColors.Control;
            modified = false;

        }
    }
}
