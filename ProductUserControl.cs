using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Gotal_manager
{
    public partial class ProductUserControl : UserControl
    {

        public ProductUserControl()
        {
            InitializeComponent();
        }
        double ulaz, dobit, izlaz, profit;
        public string ProductName
        {
            get { return TextBoxNaziv.Text; }
            set { TextBoxNaziv.Text = value; }
        }

        public string EnterPrice
        {
            get { return TextBoxUlazna.Text; }
            set { TextBoxUlazna.Text = value; ulaz = double.Parse(value); }
        }
        public string SellPrice
        {
            get { return TextBoxIzlazna.Text; }
            set { TextBoxIzlazna.Text = value; izlaz = double.Parse(value); }
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

        private void TextBox_Enter(object sender, EventArgs e)
        {
            string name = ((TextBox)sender).Name;

            textboxDict[name] = true;
        }

        private void ProductUserControl_Load(object sender, EventArgs e)
        {

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
    }
}
