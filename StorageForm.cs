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

        class StorageData
        {
            public int id, sveukupnaKolicina, razduzenaKolicina;
            public double popust;
            public StorageData(int id, int sveukupnaKolicina, int razduzenaKolicina, double popust)
            {
                this.id = id;
                this.sveukupnaKolicina = sveukupnaKolicina;
                this.razduzenaKolicina = razduzenaKolicina;
                this.popust = popust;
            }



        };


        private void StorageForm_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void refreshData()
        {
            MainFlowPanel.Controls.Clear();
            storageUsers.Clear();


            string sql = "SELECT * FROM storage;";
            MySqlCommand command = new MySqlCommand(sql, DatabaseManager.Connection);
            MySqlDataReader reader = command.ExecuteReader();



            List<StorageData> storageData = new List<StorageData>();
            while (reader.Read())
            {

                int id = reader.GetInt32("ProizvodID");
                int sveukupnaKolicina = reader.GetInt32("SveukupnaKolicina");


                int razduzenaKolicina = reader.GetInt32("RazduzenaKolicina");
                double popust = reader.GetDouble("Popust");
                storageData.Add(new StorageData(id, sveukupnaKolicina, razduzenaKolicina, popust));
            }
            reader.Close();
            foreach (StorageData sd in storageData)
            {
                StorageUserControl userControl = new StorageUserControl(sd.id, sd.sveukupnaKolicina, sd.razduzenaKolicina, sd.popust);

                MainFlowPanel.Controls.Add(userControl);
                storageUsers.Add(userControl);
            }
        }



        private void buttonPrimka_Click(object sender, EventArgs e)
        {
            PrimkaForm ps = new PrimkaForm();
            ps.ShowDialog();
            refreshData();
        }
    }
}
