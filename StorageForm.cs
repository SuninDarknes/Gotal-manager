using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotal_manager
{
    public partial class StorageForm : Form
    {
        List<StorageUserControl> storageUsers = new List<StorageUserControl>();
        public StorageForm()
        {
            InitializeComponent();
        }


        private void StorageForm_Load(object sender, EventArgs e)
        {

            string sql = "SELECT * FROM products WHERE Arhivirano=0 ORDER BY BrojProizvoda ASC;";
            MySqlCommand command = new MySqlCommand(sql, DatabaseManager.Connection);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {

                    int id = reader.GetInt32("ProizvodID");
                    int sveukupnaKolicina = reader.GetInt32("SveukupnaKolicina");

                    int razduzenaKolicina = reader.GetInt32("RazduzenaKolicina");
                    double popust = reader.GetDouble("Popust");

                    StorageUserControl userControl = new StorageUserControl(id, sveukupnaKolicina, razduzenaKolicina, popust);

                    MainFlowPanel.Controls.Add(userControl);
                    storageUsers.Add(userControl);

                }
            }
            catch (Exception)
            {
                reader.Close();
                return;
            }







            SmallErrorLabel.Text = "";
        }

        private void buttonPrimka_Click(object sender, EventArgs e)
        {
            PrimkaForm ps = new PrimkaForm();
            ps.ShowDialog();
        }
    }
}
