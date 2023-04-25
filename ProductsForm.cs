using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gotal_manager
{
    
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();

            string connectionString = "server=localhost;database=gotal-manager;uid=root;password=root1119;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string sql = "SELECT * FROM products;";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            int index = 0;
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString("Name");
                string enterPrice = reader.GetString("EnterPrice");
                string sellPrice = reader.GetString("SellPrice");
                ProductUserControl userControl= new ProductUserControl();
                userControl.Name = "puc"+id.ToString();
                userControl.ProductName= name;
                userControl.EnterPrice = enterPrice;
                userControl.SellPrice = sellPrice;
                userControl.Location = new Point(3,3+(29*index));
                
                userControl.rbDobit =DobitLock; 
                userControl.rbIzlazna= IzlazLock; 
                userControl.rbProfit =  ProfitLock;
                panel1.Controls.Add(userControl);
                userControl.InitPrice();

                index++;
            }

            reader.Close();
            connection.Close();
            DobitLock.Appearance = Appearance.Button;
            DobitLock.Image = Properties.Resources.unlocked;
            IzlazLock.Appearance= Appearance.Button;
            IzlazLock.Image= Properties.Resources.locked;
            ProfitLock.Appearance= Appearance.Button;
            ProfitLock.Image= Properties.Resources.unlocked;

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

        private void ProductsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
