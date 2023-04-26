using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gotal_manager
{
    public partial class ProductsForm : Form
    {
        int length_rows = 0;
        List<ProductUserControl> productUserControls = new List<ProductUserControl>();
        public ProductsForm()
        {
            InitializeComponent();
            DobitLock.Appearance = Appearance.Button;
            DobitLock.Image = Properties.Resources.unlocked;
            IzlazLock.Appearance = Appearance.Button;
            IzlazLock.Image = Properties.Resources.locked;
            ProfitLock.Appearance = Appearance.Button;
            ProfitLock.Image = Properties.Resources.unlocked;

            automatskoRačunanjeToolStripMenuItem.Checked = Properties.Settings.Default.ProductsForm_AutoCaclulate;
            prikazujUpozorenjaToolStripMenuItem.Checked = Properties.Settings.Default.ProductsForm_ShowAlerts;



            string sql = "SELECT * FROM products ORDER BY ProductNum ASC;";
            MySqlCommand command = new MySqlCommand(sql, DatabaseManager.Connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("ProductID");
                int productNumber = reader.GetInt32("ProductNum");
                string name = reader.GetString("Name");
                double enterPrice = reader.GetDouble("EnterPrice");
                double sellPrice = reader.GetDouble("SellPrice");
                ProductUserControl userControl = new ProductUserControl(id, productNumber, name, enterPrice, sellPrice);
                userControl.rbDobit = DobitLock;
                userControl.rbIzlazna = IzlazLock;
                userControl.rbProfit = ProfitLock;
                MainFlowPanel.Controls.Add(userControl);
                userControl.InitPrice();
                productUserControls.Add(userControl);
                length_rows++;

            }

            reader.Close();






            SmallErrorLabel.Text = "";
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                rb.Image = Properties.Resources.locked;
            }
            else
            {
                rb.Image = Properties.Resources.unlocked;
            }
        }

        private void ProductsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool unsavedChanges=false;
            foreach (ProductUserControl puc in productUserControls)
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
                    SaveChanges();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void SaveChanges()
        {
            foreach(ProductUserControl puc in productUserControls)
            {
                if (!puc.modified) continue;
                string query = "UPDATE `products` SET `ProductNum` = @ProductNum, `Name` = @Name, `EnterPrice` = @EnterPrice, `SellPrice` = @SellPrice WHERE `ProductID` = @id";
                
                    using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
                    {
                        command.Parameters.AddWithValue("@ProductNum", puc.productNum);
                        command.Parameters.AddWithValue("@Name", puc.naziv);
                    command.Parameters.AddWithValue("@EnterPrice", puc.ulaz);
                    command.Parameters.AddWithValue("@SellPrice", puc.izlaz);
                    command.Parameters.AddWithValue("@id", puc.id); 

                        int rowsAffected = command.ExecuteNonQuery();
                    puc.afterSave();
                   
                    }
                
            }
        }

        private void automatskoRačunanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ProductsForm_AutoCaclulate = !automatskoRačunanjeToolStripMenuItem.Checked;
            automatskoRačunanjeToolStripMenuItem.Checked = !automatskoRačunanjeToolStripMenuItem.Checked;
        }

        private void prikazujUpozorenjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ProductsForm_ShowAlerts = !prikazujUpozorenjaToolStripMenuItem.Checked;
            prikazujUpozorenjaToolStripMenuItem.Checked = !prikazujUpozorenjaToolStripMenuItem.Checked;
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO `products` (`ProductNum`,`Name`, `EnterPrice`, `SellPrice`) VALUES (@ProductNum, @Name, @EnterPrice, @SellPrice)";

            using (MySqlCommand command = new MySqlCommand(query, DatabaseManager.Connection))
            {
                command.Parameters.AddWithValue("@ProductNum", productUserControls.Count);
                command.Parameters.AddWithValue("@Name", "");
                command.Parameters.AddWithValue("@EnterPrice", 0);
                command.Parameters.AddWithValue("@SellPrice", 0);

                int rowsAffected = command.ExecuteNonQuery();
            }



            string sql = "SELECT * FROM products ORDER BY ProductID DESC LIMIT 1;";
            MySqlCommand command1 = new MySqlCommand(sql, DatabaseManager.Connection);
            MySqlDataReader reader = command1.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("ProductID");
                    int productNumber = reader.GetInt32("ProductNum");
                    string name = reader.GetString("Name");
                    double enterPrice = reader.GetDouble("EnterPrice");
                    double sellPrice = reader.GetDouble("SellPrice");
                    ProductUserControl userControl = new ProductUserControl(id, productNumber, name, enterPrice, sellPrice);
                    userControl.rbDobit = DobitLock;
                    userControl.rbIzlazna = IzlazLock;
                    userControl.rbProfit = ProfitLock;
                    MainFlowPanel.Controls.Add(userControl);
                    userControl.InitPrice();
                    productUserControls.Add(userControl);

                }
            }catch(Exception ex) { 
            }
            reader.Close();
            
        }

        private void NazivSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (ProductUserControl puc in productUserControls)
            {
                if ((puc.productNum +puc.naziv.ToLower()).Contains(NazivSearchTextBox.Text.ToLower()) || NazivSearchTextBox.Text == "")
                    puc.Visible= true;
                
                else puc.Visible = false;
                
            }

        }

        private void ProductsForm_SizeChanged(object sender, EventArgs e)
        {
            MainFlowPanel.Size = new System.Drawing.Size(893, ActiveForm.Size.Height - 133);
        }

        private void spremiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }
    }
}
